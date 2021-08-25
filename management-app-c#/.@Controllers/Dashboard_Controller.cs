using ngx_docs_managment_application._Forms;
using ngx_docs_managment_application._Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ngx_docs_managment_application._Controllers
{
    class Dashboard_Controller
    {
        readonly Dashboard_Service ds = new Dashboard_Service();
        readonly Settings_Service settings = new Settings_Service();

        /// <summary>
        /// Updates the label that states the status of the project folder directory
        /// </summary>
        /// <param name="status">The status label</param>
        public void UpdateProjectFolderLabel(Label status)
        {
            try
            {
                bool ok = ds.VerifyProjectFolder();
                if (ok)
                {
                    status.ForeColor = Color.LightSeaGreen;
                    status.Text = "Verified!";
                    return;
                }

                while (!ds.VerifyProjectFolder())
                {
                    MessageBox.Show("Project folder not found!");
                    settings.LoadKeysFolder();
                    status.ForeColor = Color.LightSeaGreen;
                    status.Text = "Verified!";
                }
            }
            catch (Exception e)
            {
                Logger_Service.Add("Dashboard_Controller|UpdateProjectFolderLabel", e.Message);
            }

        }

        /// <summary>
        /// Generate sample input button handler
        /// </summary>
        public void generateInputButton()
        {
            ds.GenerateSampleInput();
        }

        /// <summary>
        /// Generate sample settings button handler
        /// </summary>
        public void generateSettingsButton()
        {
            ds.GenerateSampleSettings();
        }

    }
}
