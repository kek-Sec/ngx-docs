using ngx_docs_managment_application._Forms;
using ngx_docs_managment_application._Services;
using System;
using System.IO;


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
            try
            {


                string folder_path = settings.getSetting("project_path");

                if (string.IsNullOrEmpty(folder_path)) { return false; }

                if (string.IsNullOrWhiteSpace(folder_path)) { return false; }

                if (!Directory.Exists(folder_path)) { return false; }

                return true;
            }
            catch(Exception e)
            {
                Logger_Service.Add("DASHBOARD_SERVICE|VerifyProjectFolder", e.Message);
                return false;
            }
        }
    }
}
