namespace mFileSearch
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.plOption = new System.Windows.Forms.Panel();
            this.btnOption = new System.Windows.Forms.Button();
            this.chkSubFolder = new System.Windows.Forms.CheckBox();
            this.chkRegex = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chkLstFolder = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.cmOpenNotepad = new System.Windows.Forms.ToolStripMenuItem();
            this.cmOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cbCondition = new System.Windows.Forms.ComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtPercent = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtTotalCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.plOption.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.plOption, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(628, 399);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 24);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "필터";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbFilter);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(103, 33);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.panel2.Size = new System.Drawing.Size(422, 24);
            this.panel2.TabIndex = 1;
            // 
            // cbFilter
            // 
            this.cbFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(0, 1);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(422, 22);
            this.cbFilter.TabIndex = 0;
            this.cbFilter.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Combobox_DrawItem);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(531, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(94, 24);
            this.panel3.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(0, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 24);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "취  소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // plOption
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.plOption, 3);
            this.plOption.Controls.Add(this.btnOption);
            this.plOption.Controls.Add(this.chkSubFolder);
            this.plOption.Controls.Add(this.chkRegex);
            this.plOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plOption.Location = new System.Drawing.Point(3, 63);
            this.plOption.Name = "plOption";
            this.plOption.Size = new System.Drawing.Size(622, 44);
            this.plOption.TabIndex = 3;
            // 
            // btnOption
            // 
            this.btnOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOption.Location = new System.Drawing.Point(528, 10);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(94, 24);
            this.btnOption.TabIndex = 2;
            this.btnOption.Text = "옵  션";
            this.btnOption.UseVisualStyleBackColor = true;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // chkSubFolder
            // 
            this.chkSubFolder.AutoSize = true;
            this.chkSubFolder.Checked = true;
            this.chkSubFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSubFolder.Location = new System.Drawing.Point(13, 15);
            this.chkSubFolder.Name = "chkSubFolder";
            this.chkSubFolder.Size = new System.Drawing.Size(100, 16);
            this.chkSubFolder.TabIndex = 1;
            this.chkSubFolder.Text = "하위폴더 포함";
            this.chkSubFolder.UseVisualStyleBackColor = true;
            // 
            // chkRegex
            // 
            this.chkRegex.AutoSize = true;
            this.chkRegex.Location = new System.Drawing.Point(128, 15);
            this.chkRegex.Name = "chkRegex";
            this.chkRegex.Size = new System.Drawing.Size(88, 16);
            this.chkRegex.TabIndex = 0;
            this.chkRegex.Text = "정규식 사용";
            this.chkRegex.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel5, 3);
            this.panel5.Controls.Add(this.btnAddFolder);
            this.panel5.Controls.Add(this.chkLstFolder);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 113);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(622, 144);
            this.panel5.TabIndex = 4;
            // 
            // chkLstFolder
            // 
            this.chkLstFolder.AllowDrop = true;
            this.chkLstFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkLstFolder.FormattingEnabled = true;
            this.chkLstFolder.Location = new System.Drawing.Point(0, 24);
            this.chkLstFolder.Name = "chkLstFolder";
            this.chkLstFolder.Size = new System.Drawing.Size(622, 120);
            this.chkLstFolder.TabIndex = 2;
            this.chkLstFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.chkLstFolder_DragDrop);
            this.chkLstFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.chkLstFolder_DragEnter);
            this.chkLstFolder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkLstFolder_KeyDown);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(622, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "검색할 폴더(Drag && Drop)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel6, 3);
            this.panel6.Controls.Add(this.listView);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 263);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(622, 133);
            this.panel6.TabIndex = 5;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView.ContextMenuStrip = this.contextMenuStrip;
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.FullRowSelect = true;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(622, 133);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            this.listView.Resize += new System.EventHandler(this.listView_Resize);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Line";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Contents";
            this.columnHeader2.Width = 513;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmOpenFile,
            this.cmOpenNotepad,
            this.cmOpenFolder});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.ShowImageMargin = false;
            this.contextMenuStrip.Size = new System.Drawing.Size(152, 70);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            this.contextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip_ItemClicked);
            // 
            // cmOpenFile
            // 
            this.cmOpenFile.Name = "cmOpenFile";
            this.cmOpenFile.Size = new System.Drawing.Size(151, 22);
            this.cmOpenFile.Text = "열기";
            // 
            // cmOpenNotepad
            // 
            this.cmOpenNotepad.Name = "cmOpenNotepad";
            this.cmOpenNotepad.Size = new System.Drawing.Size(151, 22);
            this.cmOpenNotepad.Text = "Notepad++로 열기";
            // 
            // cmOpenFolder
            // 
            this.cmOpenFolder.Name = "cmOpenFolder";
            this.cmOpenFolder.Size = new System.Drawing.Size(151, 22);
            this.cmOpenFolder.Text = "폴더열기";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(94, 24);
            this.panel7.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "검색어";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cbCondition);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(103, 3);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.panel8.Size = new System.Drawing.Size(422, 24);
            this.panel8.TabIndex = 7;
            // 
            // cbCondition
            // 
            this.cbCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCondition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCondition.FormattingEnabled = true;
            this.cbCondition.Location = new System.Drawing.Point(0, 1);
            this.cbCondition.Name = "cbCondition";
            this.cbCondition.Size = new System.Drawing.Size(422, 22);
            this.cbCondition.TabIndex = 0;
            this.cbCondition.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Combobox_DrawItem);
            this.cbCondition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbCondition_KeyDown);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnSearch);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(531, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(94, 24);
            this.panel9.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Location = new System.Drawing.Point(0, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 24);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "검  색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtPercent,
            this.toolStripStatusLabel1,
            this.txtTotalCount});
            this.statusStrip1.Location = new System.Drawing.Point(5, 404);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(628, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtPercent
            // 
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(0, 17);
            this.txtPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(613, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // txtTotalCount
            // 
            this.txtTotalCount.Name = "txtTotalCount";
            this.txtTotalCount.Size = new System.Drawing.Size(0, 17);
            this.txtTotalCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFolder.Location = new System.Drawing.Point(528, 0);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(94, 24);
            this.btnAddFolder.TabIndex = 3;
            this.btnAddFolder.Text = "추  가";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 431);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mFileSearch";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.plOption.ResumeLayout(false);
            this.plOption.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel plOption;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox cbCondition;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckedListBox chkLstFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkRegex;
        private System.Windows.Forms.CheckBox chkSubFolder;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtTotalCount;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem cmOpenFile;
        private System.Windows.Forms.ToolStripMenuItem cmOpenNotepad;
        private System.Windows.Forms.ToolStripMenuItem cmOpenFolder;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.ToolStripStatusLabel txtPercent;
        private System.Windows.Forms.Button btnAddFolder;
    }
}

