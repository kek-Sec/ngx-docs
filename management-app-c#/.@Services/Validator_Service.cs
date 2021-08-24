using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ngx_docs_managment_application._Services
{
    /// <summary>
    /// Used to validate inputs
    /// </summary>
    class Validator_Service
    {
        public bool ValidateTextBox(TextBox input)
        {
            return input.Text.Length > 0;
        }
    }
}
