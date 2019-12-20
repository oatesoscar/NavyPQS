using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Forms;

namespace NavyPQS
{
    class FileIO
    {
        public string TxtFilePath { get; set; }
        public string JsonFilePath { get; set; } = @"C:\Users\Oates Oscar\source\repos\NavyPQS\test.json";

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
                TxtFilePath = openFile.FileName;
            }
        }

        public void SetTextFilePath()
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TxtFilePath = folderBrowser.SelectedPath;
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
                JsonFilePath = openFile.FileName;
            }
        }

        public void SetJsonFilePath()
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                JsonFilePath = folderBrowser.SelectedPath;
                GrantAccess(JsonFilePath);
            }
        }


        private void GrantAccess(string fullPath)
        {
            DirectoryInfo dInfo = new DirectoryInfo(fullPath);
            DirectorySecurity dSecurity = dInfo.GetAccessControl();
            dSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
            dInfo.SetAccessControl(dSecurity);
        }
    }
}
