using SPLib.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPLib
{
    public class FileHelper
    {
        private string _path = String.Empty;

        public FileHelper()
        {
        }
        public List<ServerInfo> OpenFile()
        {
            var listRecord = new List<ServerInfo>();
            var fileDialog = new OpenFileDialog
            {
                
            };
            fileDialog.FileName = ".xml";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {

                _path = fileDialog.FileName;
                System.IO.StreamReader file = new System.IO.StreamReader(_path);
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    listRecord.Add(new ServerInfo(words[0], int.Parse(words[1]), words[2]));
                }

                file.Close();
            }

            return listRecord;
        }

        public void Save(List<ServerInfo> list, string path = null)
        {
            var saveFileDialog = new SaveFileDialog
            {
                FileName = path == null ? _path : path
            };

            StreamWriter stream = new StreamWriter(saveFileDialog.OpenFile());
            foreach (var item in list)
            {
                stream.WriteLine(item.Adress + " " + item.Port + " " + item.Protocol);
            }
            stream.Close();
        }

        public void SaveFile(List<ServerInfo> list)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Save(list, saveFileDialog.FileName);
            }
        }

    }
}
