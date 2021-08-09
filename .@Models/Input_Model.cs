﻿
using System.Collections.Generic;

namespace ngx_docs_managment_application._Models
{
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
    }
}
