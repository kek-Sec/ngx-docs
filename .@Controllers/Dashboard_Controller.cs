using ngx_docs_managment_application._Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ngx_docs_managment_application._Controllers
{
    class Dashboard_Controller
    {
        Dashboard_Service ds = new Dashboard_Service();
        Settings_Service settings = new Settings_Service();

        /// <summary>
        /// Updates the label that states the status of the project folder directory
        /// </summary>
        /// <param name="status">The status label</param>
        public void UpdateProjectFolderLabel(Label status)
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
            }
        }

    }
}
