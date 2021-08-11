using Newtonsoft.Json;
using System.Collections.Generic;

namespace ngx_docs_managment_application._Models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]

    class Input_Model
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string text {get; set;}
        public string image { get; set; }
        public IList<string> items { get; set; }
        public IList<string> tags { get; set; }
        public string url { get; set; }
        public IList<string> album { get; set; }

        public Input_Model()
        {
            items = new List<string>();
            tags = new List<string>();
            album = new List<string>();
        }
    }
}
