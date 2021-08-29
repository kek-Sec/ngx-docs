using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngx_docs_managment_application._Models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]

    ///Model that desrcibes the settings.json entities
    class Settings_Model
    {
        public bool preview_show_picture { get; set; }
        public bool preview_show_title { get; set; }
        public bool preview_show_description { get; set; }
        public bool preview_show_text { get; set; }

        public bool preview_show_code { get; set; }
        public bool preview_show_items { get; set; }
        public bool preview_show_url { get; set; }
        public bool preview_show_album { get; set; }
        public bool preview_show_tags { get; set; }
        public int preview_description_text_length { get; set; }
        public int preview_text_length { get; set; }

        public int preview_item_text_length { get; set; }
        public int preview_items_count { get; set; }
        public int preview_number_of_columns { get; set; }
    }
}
