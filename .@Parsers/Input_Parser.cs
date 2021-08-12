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
            try
            {
                string json = File.ReadAllText(filename);
                JArray input_arr = JArray.Parse(json);

                IList<Input_Model> ret = input_arr.ToObject<IList<Input_Model>>();

                return ret;
            }catch(Exception e)
            {
                return null;
            }

        }
    }
}
