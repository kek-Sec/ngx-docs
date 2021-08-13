using ngx_docs_managment_application._Models;
using ngx_docs_managment_application._Serializers;
using ngx_docs_managment_application._Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

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
                Logger_Service.Add("SETTINGSDATA_SERVICE|Constructor", e.Message);
            }
        }

        /// <summary>
        /// Used to save settings file
        /// </summary>
        /// <param name="sm">The current settings model</param>
        public void Save(Settings_Model sm)
        {
            try
            {
                settings_model[0] = sm;
                string filepath = settings.getSetting("project_path") + "\\src\\settings.json";
                var json = serializer.Serialize(settings_model);
                File.WriteAllText(filepath, json);

                MessageBox.Show("Saved settings...");
            }
            catch(Exception e)
            {
                Logger_Service.Add("SETTINGSDATA_SERVICE|Save", e.Message);
                return;
            }

        }
    }
}
