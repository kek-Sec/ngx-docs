using ngx_docs_managment_application._Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngx_docs_managment_application._Controllers
{
    class Dashboard_Service
    {
        readonly Settings_Service settings = new Settings_Service();


        /// <summary>
        /// Verify that folder path is set and exists
        /// </summary>
        /// <returns>True if folder exists false if folder does not exist</returns>
        public bool VerifyProjectFolder()
        {
            string folder_path = settings.getSetting("project_path");

            if (string.IsNullOrEmpty(folder_path)) { return false; }

            if (string.IsNullOrWhiteSpace(folder_path)) { return false; }

            if (!Directory.Exists(folder_path)) { return false; }

            return true;
        }
    }
}
