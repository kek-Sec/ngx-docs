using Newtonsoft.Json;
using System.Collections.Generic;

namespace ngx_docs_managment_application._Models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]

    //Model that describes input.json entities
    class Input_Model
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string text { get; set; }
        public string image { get; set; }
        public IList<string> code { get; set; }
        public IList<string> items { get; set; }
        public IList<string> tags { get; set; }
        public string url { get; set; }
        public IList<string> album { get; set; }

        public Input_Model()
        {
        }
    }
}
