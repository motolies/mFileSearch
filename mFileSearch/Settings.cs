using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace mFileSearch
{
    [XmlRoot("Settings", Namespace = "http://www.motolies.com")]
    public class Settings
    {
        [XmlIgnore]
        public static string path = Environment.CurrentDirectory + "//settings.xml";

        [XmlArray("WithoutExtensionList"), XmlArrayItem(typeof(String), ElementName = "WithoutExtension")]
        public List<string> woExtensionList = new List<string>();

        [XmlArray("FilterExtensionList"), XmlArrayItem(typeof(String), ElementName = "FilterExtension")]
        public List<string> schExtensionList = new List<string>();

        [XmlElement("Notepad_PP_Path")]
        public string NotepadPlusPath { get; set; }

        public Settings() { }
        public Settings(bool isNew)
        {
            woExtensionList = new List<string>
        {
            ".dll", ".exe", ".db", ".svn-base", ".pdb"
        };

            schExtensionList = new List<string>
        {
            "*.*"
            ,"*.txt"
            ,"*.c;*.cpp;*.h;*.cs;*.sql;*.html;*.aspx;*.css;*.js;*.py;*.xml"
        };
        }
    }



}
