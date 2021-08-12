using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngx_docs_managment_application._Services
{
    class Logger_Service
    {
        public void Add(string title,string content)
        {
            FormattableString log_entry = $"[{title}]-[{DateTime.Now.ToString("MM-dd-HH-mm")}]----> {content}\n";
            File.AppendAllText("log.txt", log_entry.ToString());
        }
    }
}
