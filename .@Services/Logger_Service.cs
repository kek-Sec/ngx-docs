using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ngx_docs_managment_application._Services
{
    class Logger_Service
    {
        public static void Add(string title, string content)
        {
            MessageBox.Show("Error occured, check logs...");
            FormattableString log_entry = $"[{title}]-[{DateTime.Now.ToString("MM-dd-HH-mm")}]----> {content}\n";
            File.AppendAllText("log.txt", log_entry.ToString());
        }
    }
}
