using ngx_docs_managment_application._Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngx_docs_managment_application._Controllers
{
    class Settings_Controller
    {
        readonly Settings_Service settings = new Settings_Service();

        /// <summary>
        /// Middleware function to start the folder selection routine
        /// </summary>
        public void SelectProjectPath()
        {
            settings.LoadKeysFolder();
        }
    }
}
