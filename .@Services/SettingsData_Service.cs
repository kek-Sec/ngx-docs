using ngx_docs_managment_application._Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngx_docs_managment_application._Forms
{
    class SettingsData_Service
    {
        Settings_Service settings = new Settings_Service();
        Settings_Parser parser = new Settings_Parser();
        public IList<Settings_Model> settings_model;

        public SettingsData_Service()
        {
            try
            {
                var filepath = settings.getSetting("project_path") + "\\src\\settings.json";
                settings_model = parser.parse(filepath);
            }
            catch (Exception e)
            {
                Console.Write("error -> " + e.Message.ToString());
            }
        }

        public void Save(Settings_Model sm)
        {

        }
    }
}
