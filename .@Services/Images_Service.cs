using ngx_docs_managment_application._Forms;
using System;
using System.IO;
using System.Windows.Forms;

namespace ngx_docs_managment_application._Services
{
    class Images_Service
    {
        Settings_Service settings = new Settings_Service();
        public string favicon_path;
        public string images_path;

        public Images_Service()
        {
            favicon_path = settings.getSetting("project_path") + "\\src\\favicon.ico";
            images_path = settings.getSetting("project_path") + "\\src\\assets\\images\\";
        }

        /// <summary>
        /// Function to open folder dialog to choose images folder
        /// </summary>
        public void Set_Images_Folder()
        {
            try
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        DirectoryCopy(fbd.SelectedPath, images_path, true);
                        MessageBox.Show("Successfully saved", "Images directory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception e)
            {
                Logger_Service.Add("IMAGE_SERVICE|Set_Images_Folder", e.Message);
            }
        }

        /// <summary>
        /// Function to open a file dialog to choose favicon
        /// </summary>
        public void Set_Favicon()
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog
                {
                    //InitialDirectory = @"C:\",
                    Title = "Browse favicon",

                    CheckFileExists = true,
                    CheckPathExists = true,

                    DefaultExt = "ico",
                    Filter = "ico files (*.ico)|*.ico",
                    FilterIndex = 2,
                    RestoreDirectory = true,

                    ReadOnlyChecked = true,
                    ShowReadOnly = true
                };

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(openFileDialog1.FileName, favicon_path);

                    MessageBox.Show("Successfully saved", "Favicon file", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception e)
            {
                Logger_Service.Add("IMAGE_SERVICE|Set_Favicon", e.Message);
            }
        }


        /// <summary>
        /// Helper utility for copying directories 
        /// </summary>
        /// <param name="sourceDirName">Source directory</param>
        /// <param name="destDirName">Destination directory</param>
        /// <param name="copySubDirs">boolean whether to copy sub directories</param>
        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();

            // If the destination directory doesn't exist, create it.       
            Directory.CreateDirectory(destDirName);

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destDirName, file.Name);
                file.CopyTo(tempPath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string tempPath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, tempPath, copySubDirs);
                }
            }
        }
    }
}
