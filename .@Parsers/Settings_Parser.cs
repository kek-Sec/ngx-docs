using Newtonsoft.Json.Linq;
using ngx_docs_managment_application._Models;
using ngx_docs_managment_application._Services;
using System;
using System.Collections.Generic;
using System.IO;

namespace ngx_docs_managment_application._Forms
{
    class Settings_Parser
    {
        /// <summary>
        /// Parse given json and map it to a settings model
        /// </summary>
        /// <param name="filename">The file to parse</param>
        /// <returns>Settings model object</returns>
        public IList<Settings_Model> parse(string filename)
        {
            try
            {
                string json = File.ReadAllText(filename);
                JArray input_arr = JArray.Parse(json);

                IList<Settings_Model> ret = input_arr.ToObject<IList<Settings_Model>>();

                return ret;
            }
            catch(Exception e)
            {
                Logger_Service.Add("SETTINGS_PARSER|parse", e.Message);
                return null;
            }
        }
    }
}
