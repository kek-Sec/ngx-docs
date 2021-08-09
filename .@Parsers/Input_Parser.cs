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
    class Input_Parser
    {

        /// <summary>
        /// Parse given json and map it to an input model
        /// </summary>
        /// <param name="filename">The file to parse</param>
        /// <returns>Input model object</returns>
        public Input_Model parse(string filename)
        {
            string json = File.ReadAllText(filename);
            return JsonConvert.DeserializeObject<Input_Model>(json);
        }
    }
}
