using ngx_docs_managment_application._Forms;
using ngx_docs_managment_application._Models;
using ngx_docs_managment_application._Serializers;
using ngx_docs_managment_application._Services;
using System;
using System.Collections.Generic;
using System.IO;

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

        /// <summary>
        /// Update entry at given index
        /// </summary>
        /// <param name="index">The index of the entry to update</param>
        /// <param name="input">The entry model to add</param>
        public void UpdateEntry(int index, Input_Model input)
        {
            try
            {
                input_collection[index] = input;
                var filepath = settings.getSetting("project_path") + "\\src\\input.json";
                var json = serializer.Serialize(input_collection);
                File.WriteAllText(filepath, json);
            }
            catch (Exception e)
            {
                Logger_Service.Add("INPUT_SERVICE|UpdateEntry", e.Message);
            }

        }

        /// <summary>
        /// Delete entry from input.json
        /// </summary>
        /// <param name="index">The index of the entry to delete</param>
        public void DeleteEntry(int index)
        {
            try
            {
                input_collection.RemoveAt(index);
                var filepath = settings.getSetting("project_path") + "\\src\\input.json";
                var json = serializer.Serialize(input_collection);
                File.WriteAllText(filepath, json);
            }
            catch (Exception e)
            {
                Logger_Service.Add("INPUT_SERVICE|DeleteEntry", e.Message);
            }
        }

        /// <summary>
        /// Add entry to input.json
        /// </summary>
        /// <param name="input">The entry model to add</param>
        public void AddEntry(Input_Model input)
        {
            try
            {
                input_collection.Add(input);
                var filepath = settings.getSetting("project_path") + "\\src\\input.json";
                var json = serializer.Serialize(input_collection);
                File.WriteAllText(filepath, json);
            }
            catch (Exception e)
            {
                Logger_Service.Add("INPUT_SERVICE|AddEntry", e.Message);

            }
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
                Logger_Service.Add("INPUT_SERVICE|LoadData", e.Message);

            }
        }
    }
}
