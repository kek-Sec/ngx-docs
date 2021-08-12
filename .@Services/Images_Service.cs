using ngx_docs_managment_application._Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    images_path = fbd.SelectedPath;
                    MessageBox.Show("Successfully saved", "Images directory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Function to open a file dialog to choose favicon
        /// </summary>
        public void Set_Favicon()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                //InitialDirectory = @"C:\",
                Title = "Browse favicon",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "ico files (*.ico)|*.ico",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                favicon_path = openFileDialog1.FileName;
                MessageBox.Show("Successfully saved", "Favicon file", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
