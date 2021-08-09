﻿using ngx_docs_managment_application._Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ngx_docs_managment_application._Controllers
{
    class Input_Controller
    {
        Input_Service input;

        public Input_Controller()
        {
            input = new Input_Service();
        }

        public void SetSelectedItem()
        {

        }


        /// <summary>
        /// Fills the input tab listbox
        /// </summary>
        /// <param name="input_listbox">The input listbox</param>
        public void FillInputListbox(ListBox input_listbox)
        {
            try
            {
                foreach (Input_Model im in input.input_collection)
                {
                    input_listbox.Items.Add(im.Title);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
