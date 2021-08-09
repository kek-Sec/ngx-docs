using ngx_docs_managment_application._Forms;
using ngx_docs_managment_application._Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngx_docs_managment_application._Controllers
{
    class Input_Service
    {
        readonly Input_Parser parser = new Input_Parser();
        readonly Settings_Service settings = new Settings_Service();

        public IList<Input_Model> input_collection;

        public Input_Service()
        {
            LoadData();
        }


        public void AddEntry(Input_Model input)
        {
            input_collection.Add(input);

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
