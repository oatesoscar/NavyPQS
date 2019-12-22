using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Forms;

namespace NavyPQS
{
    class FileIO
    {
        public string TxtPath { get; set; }
        public string JsonQuestions { get; set; } = @"C:\Users\HomicidalMAdMan\Documents\GitHub\NavyPQS\Questions.json";
        public string UserFileJson { get; set; } = @"C:\Users\HomicidalMAdMan\Documents\GitHub\NavyPQS\Users.json";
        public string DefaultUserJson { get; set; } = @"C:\Users\HomicidalMAdMan\Documents\GitHub\NavyPQS\Default.json";

        public void GetTextFile()
        {
            // Bring up a dialog to chose a folder path in which to open a text file.
            OpenFileDialog openFile = new OpenFileDialog
            {
                Title = "Open Text File",
                Filter = "Text files(*.txt) | *.txt"
            };

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TxtPath = openFile.FileName;
            }
        }

        public void SetTextFilePath()
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TxtPath = folderBrowser.SelectedPath;
            }
        }

        public void GetJsonFile()
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                Title = "Open Json File",
                Filter = "Json files(*.json) | *.json"
            };

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                JsonQuestions = openFile.FileName;
            }
        }

        public void SetJsonFilePath()
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                JsonQuestions = folderBrowser.SelectedPath;
                //GrantAccess(JsonFilePath);
            }
        }

        /*private void GrantAccess(string fullPath)
        {
            DirectoryInfo dInfo = new DirectoryInfo(fullPath);
            DirectorySecurity dSecurity = dInfo.GetAccessControl();
            dSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
            dInfo.SetAccessControl(dSecurity);
        }
        */
    }
}
