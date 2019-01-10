using System;
using Microsoft.Win32;
using System.Windows.Forms;

namespace mFileSearch
{
    public static class RegistryHandle
    {
        private static void Write(string path, string value)
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey("Software", true);

            key.CreateSubKey("AppName");
            key = key.OpenSubKey("AppName", true);


            key.CreateSubKey("AppVersion");
            key = key.OpenSubKey("AppVersion", true);

            key.SetValue("yourkey", "yourvalue");
        }
    }
}
