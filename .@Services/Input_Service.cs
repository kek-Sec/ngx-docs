using ngx_docs_managment_application._Forms;
using ngx_docs_managment_application._Models;
using ngx_docs_managment_application._Serializers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngx_docs_managment_application._Controllers
{
    class Input_Service
    {
        readonly Input_Parser parser = new Input_Parser();
        readonly Input_Serializer serializer = new Input_Serializer();
        readonly Settings_Service settings = new Settings_Service();

        public IList<Input_Model> input_collection;

        public Input_Service()
        {
            LoadData();
        }


        public void AddEntry(Input_Model input)
        {
            input_collection.Add(input);
            var filepath = settings.getSetting("project_path") + "\\src\\input2.json";
            var json = serializer.Serialize(input_collection);
            File.WriteAllText(filepath, json);

        }

        /// <summary>
        /// Read and parse JSON
        /// </summary>
        public void LoadData()
        {
            try
            {
                var filepath = settings.getSetting("project_path") + "\\src\\input.json";
                input_collection = parser.parse(filepath);
            }
            catch (Exception e)
            {
                Console.Write("error -> " + e.Message.ToString());
            }
        }
    }
}
