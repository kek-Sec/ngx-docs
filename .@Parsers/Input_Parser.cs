using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
        public IList<Input_Model> parse(string filename)
        {
            string json = File.ReadAllText(filename);
            dynamic blogPosts = JArray.Parse(json);
            JObject o = JObject.Parse(json);
            JArray a = (JArray)o["d"];
            IList<Input_Model> ret = a.ToObject<IList<Input_Model>>();
            return ret;
        }
    }
}
