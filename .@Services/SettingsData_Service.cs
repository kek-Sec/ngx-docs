using ngx_docs_managment_application._Models;
using ngx_docs_managment_application._Serializers;
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
        Settings_Serializer serializer = new Settings_Serializer();
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

        /// <summary>
        /// Used to save settings file
        /// </summary>
        /// <param name="sm">The current settings model</param>
        public void Save(Settings_Model sm)
        {
            settings_model[0] = sm;
            serializer.Serialize(settings_model);
        }
    }
}
