﻿using Newtonsoft.Json.Linq;
using ngx_docs_managment_application._Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngx_docs_managment_application._Serializers
{
    class Settings_Serializer
    {
        /// <summary>
        /// Build json file
        /// </summary>
        /// <param name="input_list">The list of settings models to build</param>
        /// <returns>The json</returns>
        public string Serialize(IList<Settings_Model> input_list)
        {
            JArray json = (JArray)JToken.FromObject(input_list);
            return json.ToString();
        }
    }
}
