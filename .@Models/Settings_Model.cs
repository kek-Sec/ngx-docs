using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngx_docs_managment_application._Models
{
    class Settings_Model
    {
        public string preview_show_picture { get; set; }
        public string preview_show_title { get; set; }
        public string preview_show_description { get; set; }
        public string preview_show_text { get; set; }
        public string preview_show_items { get; set; }
        public string preview_show_url { get; set; }
        public string preview_show_album { get; set; }
        public string preview_show_tags { get; set; }
        public string preview_description_text_length { get; set; }
        public string preview_text_length { get; set; }

        public string preview_item_text_length { get; set; }
        public string preview_items_count { get; set; }
        public string preview_number_of_columns { get; set; }
    }
}
