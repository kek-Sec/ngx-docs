using Newtonsoft.Json;
using ngx_docs_managment_application._Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngx_docs_managment_application._Forms
{
    class Settings_Parser
    {
        public Settings_Model parse(string filename)
        {
            string json = File.ReadAllText(filename);
            Settings_Model ret = JsonConvert.DeserializeObject<Settings_Model>(json);
            return ret;
        }
    }
}
