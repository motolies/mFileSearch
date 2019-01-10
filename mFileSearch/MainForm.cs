using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mFileSearch
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region 변수
        delegate void AddItemDelegate(string file, string lineNo, string line);
        delegate void ChangePercentDelegate(float per);

        static bool isStop = false;
        static int MatchedCount = 0;
        object syncMatchCount = new object();
        object syncLineNumber = new object();
        static ThreadWorker tw = new ThreadWorker();
        static Settings set;
        static Dictionary<string, ListViewGroup> groupList = new Dictionary<string, ListViewGroup>();
        #endregion

        #region thread 관련 함수
        private void Tw_OnCompleted(object sender, EventArgs e)
        {
            ControlState(false);
        }
        private void Tw_DoWork(object sender, EventArgs e)
        {
            SearchFile(sender);
        }
        #endregion

        private void AddItem(string file, string lineNo, string line)
        {
            if (groupList.ContainsKey(file))
            {
                ListViewGroup group = groupList[file];
                ListViewItem i = new ListViewItem(lineNo.ToString(), group);
                i.SubItems.Add(line);
                listView.Items.Add(i);
            }
            else
            {
                ListViewGroup group = new ListViewGroup(file);
                listView.Groups.Add(group);

                groupList.Add(file, group);

                ListViewItem i = new ListViewItem(lineNo.ToString(), group);
                i.SubItems.Add(line);
                listView.Items.Add(i);
            }
            txtTotalCount.Text = string.Format("총 {0}개 검색", MatchedCount.ToString("#,###"));
            Application.DoEvents();
        }
        private void AddItemDele(string file, string lineNo, string line)
        {
            if (this.listView.InvokeRequired)
                this.listView.Invoke(new AddItemDelegate(AddItem), new object[] { file, lineNo, line });
            else
                AddItem(file, lineNo, line);
        }

        private void ChangePercent(float per)
        {
            txtPercent.Text = (per * 100).ToString("#,###.00") + "%";
        }
        private void ChangePercentDele(float per)
        {
            if (statusStrip1.InvokeRequired)
            {
                statusStrip1.Invoke(new ChangePercentDelegate(ChangePercent), new object[] { per });
            }
            else
                ChangePercent(per);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered(true);
            listView.DoubleBuffered(true);

            if (File.Exists(Settings.path))
            {
                set = XMLSerializer.FromXMLFile<Settings>(Settings.path);
            }
            else
            {
                set = new Settings(true);
                XMLSerializer.ToXMLFile<Settings>(set, Settings.path);
            }

            foreach (string f in set.schExtensionList)
                cbFilter.Items.Add(f);
            if (cbFilter.Items.Count > 0)
                cbFilter.SelectedIndex = 0;

            tw.DoWork += Tw_DoWork;
            tw.OnCompleted += Tw_OnCompleted;
            tw.OnProcessChanged += Tw_OnProcessChanged;

            //chkLstFolder.Items.Add(@"D:\Source\NetClient5\branches", true);
            //chkLstFolder.Items.Add(@"D:\csharp", true);
            //cbCondition.Text = "ImageViewer";

            ControlState(false);
        }

        private void Tw_OnProcessChanged(object sender, ProgressEventArgs e)
        {
            ChangePercentDele(e.Percent);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BeforeSearch();
            tw.Run();
        }

        private void BeforeSearch()
        {
            isStop = false;
            listView.Items.Clear();
            listView.Groups.Clear();
            MatchedCount = 0;
            txtTotalCount.Text = string.Format("총 {0}개 검색", MatchedCount);
            groupList.Clear();
            ControlState(true);

            if (!cbCondition.Items.Contains(cbCondition.Text))
                cbCondition.Items.Add(cbCondition.Text);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isStop = true;
            Thread.Sleep(1000);
            tw.Stop();
            ControlState(false);
        }


        private void SearchFile(object sender)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            List<string> files = new List<string>();
            string searchTerm = readControlText(cbCondition).ToLower();
            string[] filter = readControlText(cbFilter).Trim().ToLower().Replace("*.*", string.Empty).Replace("*", string.Empty).Split(';');

            foreach (string folder in chkLstFolder.CheckedItems)
            {
                SearchOption so = chkSubFolder.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
                files.AddRange(Directory.GetFiles(folder, "*.*", so));
            }

            var withoutFiles = files.Where(ext => !ext.EndWith(set.woExtensionList));
            var fileList = withoutFiles.Where(ext => ext.ToLower().EndWith(filter));

            int totalFile = fileList.Count();
            int curFile = 0;
            Parallel.ForEach(fileList, new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount }, (file, stateFile) =>
            {
                if (isStop)
                    stateFile.Stop();

                int lineNumber = 1;

                foreach (string line in File.ReadLines(file, GetFileEncoding(file)))
                {
                    if (isStop)
                        break;

                    if ((chkRegex.Checked && Regex.IsMatch(line, searchTerm, RegexOptions.IgnoreCase)) || line.ToLower().Contains(searchTerm))
                    {
                        MatchedCount++;
                        lock (syncLineNumber)
                        {
                            //검색 중간중간에 리스트에 뿌린다
                            AddItemDele(file, lineNumber.ToString(), line);
                        }
                    }
                    lineNumber++;
                }
                curFile++;
                if (curFile % 10 == 0)
                    tw.ReportProgress((float)curFile / (float)totalFile);

            });
            tw.ReportProgress((float)1);
            sw.Stop();
            Console.WriteLine("검색종료 : " + sw.ElapsedMilliseconds);
        }


        //인코딩 확인
        public static Encoding GetFileEncoding(string srcFile)
        {
            // *** Use Default of Encoding.Default (Ansi CodePage)
            Encoding enc = Encoding.Default;
            // *** Detect byte order mark if any - otherwise assume default
            byte[] buffer = new byte[10];
            FileStream file = new FileStream(srcFile, FileMode.Open, FileAccess.Read, FileShare.Read);
            file.Read(buffer, 0, 10);
            file.Close();
            if (buffer[0] == 0xef && buffer[1] == 0xbb && buffer[2] == 0xbf)
                enc = Encoding.UTF8; //with BOM
            else if (buffer[0] == 0xfe && buffer[1] == 0xff)
                enc = Encoding.Unicode;
            else if (buffer[0] == 0 && buffer[1] == 0 && buffer[2] == 0xfe && buffer[3] == 0xff)
                enc = Encoding.UTF32;
            else if (buffer[0] == 0x2b && buffer[1] == 0x2f && buffer[2] == 0x76)
                enc = Encoding.UTF7;
            else if (buffer[0] == 0xFE && buffer[1] == 0xFF)
                // 1201 unicodeFFFE Unicode (Big-Endian)
                enc = Encoding.GetEncoding(1201);
            else if (buffer[0] == 0xFF && buffer[1] == 0xFE)
                // 1200 utf-16 Unicode
                enc = Encoding.GetEncoding(1200);
            else if (ValidateUTF8WithoutBOM(srcFile))
                enc = new UTF8Encoding(false);
            return enc;
        }
        private static bool ValidateUTF8WithoutBOM(string filePath)
        {
            //ansi로 인코딩 된 파일을 utf-8을 사용하여 읽으면 각 기본 언어마다 특수문자가 포함되는 것같다.
            //euc-kr 에서 utf-8로 읽으면 "� = (char)0xfffd)"가 생기는 것 같다. 
            using (FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read))
            using (BufferedStream bs = new BufferedStream(fs))
            using (StreamReader sr = new StreamReader(bs))
            {
                if (fs.Length < 1024 * 1000)
                {
                    if (sr.ReadToEnd().Contains((char)0xfffd))
                        return false;
                    else
                        return true;
                }

                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    if (s.Contains((char)0xfffd))
                        return false;
                }
            }
            return true;
        }





        private void ControlState(bool stat)
        {
            List<Control> cancelList = new List<Control> { btnCancel };
            List<Control> searchList = new List<Control> { btnSearch, cbCondition, cbFilter, plOption, chkLstFolder };

            var actionCancel = new Action<Control>(c => c.Enabled = stat);
            var actionSearch = new Action<Control>(c => c.Enabled = !stat);

            foreach (Control c in cancelList)
            {
                if (c.InvokeRequired)
                {
                    c.Invoke(actionCancel, c);
                }
                else
                {
                    c.Enabled = stat;
                }
            }
            foreach (Control c in searchList)
            {
                if (c.InvokeRequired)
                {
                    c.Invoke(actionSearch, c);
                }
                else
                {
                    c.Enabled = !stat;
                }
            }
        }

        public static string readControlText(Control varControl)
        {
            if (varControl.InvokeRequired)
            {
                string res = "";
                var action = new Action<Control>(c => res = c.Text);
                varControl.Invoke(action, varControl);
                return res;
            }
            else
            {
                string varText = varControl.Text;
                return varText;
            }
        }



        private void Combobox_DrawItem(object sender, DrawItemEventArgs e)
        {
            int index = e.Index >= 0 ? e.Index : 0;
            var brush = Brushes.Black;
            e.DrawBackground();

            var ctrl = sender as ComboBox;
            string itemText = string.Empty;

            if (ctrl.DataSource is DataTable)
                itemText = ((DataRowView)ctrl.Items[e.Index])[ctrl.DisplayMember].ToString();
            else
                itemText = ctrl.Items[index].ToString();

            e.Graphics.DrawString(itemText, e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }


        #region drag drop
        private void chkLstFolder_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string str in file)
                {
                    FileAttributes attr = File.GetAttributes(str);
                    string value = string.Empty;
                    if (attr.HasFlag(FileAttributes.Directory))
                        value = str;
                    else
                        value = Path.GetDirectoryName(str);

                    if (!chkLstFolder.Items.Contains(value))
                        chkLstFolder.Items.Add(value, true);
                }
            }
        }
        private void chkLstFolder_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy | DragDropEffects.Scroll;
            }
        }


        #endregion

        private void listView_Resize(object sender, EventArgs e)
        {
            listView.Columns[1].Width = -2;
        }

        private void chkLstFolder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                chkLstFolder.SelectedItems.OfType<string>().ToList().ForEach(chkLstFolder.Items.Remove);
            }
        }

        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                string file = listView.SelectedItems[0].Group.ToString();
                Process.Start(file);
            }
        }

        private void cbCondition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(this, null);
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            contextMenuStrip.Items.Cast<ToolStripMenuItem>().ToList().ForEach(o => o.Enabled = listView.SelectedItems.Count < 1 ? false : true);
        }

        private void contextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string file = listView.SelectedItems[0].Group.ToString();
            contextMenuStrip.Close();
            switch (e.ClickedItem.Name)
            {
                case "cmOpenFile":
                    listView_MouseDoubleClick(this, null);
                    break;
                case "cmOpenNotepad":
                    if (string.IsNullOrWhiteSpace(set.NotepadPlusPath))
                    {
                        MessageBox.Show("Notepad++ 실행파일을 선택해주세요.");
                        OpenFileDialog d = new OpenFileDialog();
                        d.Filter = "EXE|*.exe";
                        d.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
                        if (d.ShowDialog() == DialogResult.OK)
                        {
                            set.NotepadPlusPath = d.FileName;
                            XMLSerializer.ToXMLFile<Settings>(set, Settings.path);
                        }
                        else
                        {
                            MessageBox.Show("Notepad++ 실행파일을 선택해야 사용하실 수 있습니다.");
                            return;
                        }
                    }
                    Process.Start(set.NotepadPlusPath, string.Format("\"{0}\" -n{1}", file, listView.SelectedItems[0].Text));
                    break;
                case "cmOpenFolder":
                    Process.Start("explorer.exe", "/select, " + file);
                    break;
            }
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            SettingForm f = new SettingForm();
            f.ShowDialog();
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = Path.GetPathRoot(Environment.SystemDirectory);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                chkLstFolder.Items.Add(dialog.SelectedPath, true);
            }
        }
    }


}
