using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mFileSearch
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void chkContext_CheckedChanged(object sender, EventArgs e)
        {
            //https://www.youtube.com/watch?v=tQJ1R-jafSw
            //Context Menu 등록
            //folder = 컴퓨터\HKEY_CLASSES_ROOT\Directory\shell
            //all file = 컴퓨터\HKEY_CLASSES_ROOT\*\shell

            //우선은 폴더에만 적용하도록...........

            //RegistryHandle myRegistry = new RegistryHandle();
            //myRegistry.SubKey = "SOFTWARE\\RTF_SHARP_EDIT\\RECENTFILES";
            //myRegistry.ShowError = true;
            //myRegistry.Write()


        }


        
    }
}
