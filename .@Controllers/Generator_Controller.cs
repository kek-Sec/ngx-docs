using ngx_docs_managment_application._Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngx_docs_managment_application._Controllers
{
    class Generator_Controller
    {
        Settings_Service settings = new Settings_Service();
        public void doServe()
        {
            string folder_path = settings.getSetting("project_path");
            System.Diagnostics.Process.Start(folder_path+"\\serve.bat");
        }
    }
}
