using ngx_docs_managment_application._Models;
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

        /// <summary>
        /// Updates the data view when the selected entry is changed
        /// </summary>
        /// <param name="index">The index for the input array</param>
        /// <param name="title">Title textbox</param>
        /// <param name="description">Description textbox</param>
        /// <param name="text">Text textbox</param>
        /// <param name="picture">Picture textbox</param>
        /// <param name="url">Url textbox</param>
        /// <param name="tags">Tags listbox</param>
        /// <param name="items">Items listbox</param>
        /// <param name="album">Album listbox</param>
        public void SetSelectedItem(int index,TextBox title, TextBox description, TextBox text, TextBox picture, TextBox url,ListBox tags,ListBox items,ListBox album)
        {
            Input_Model inpt = input.input_collection[index];

            title.Text = inpt.Title;
            description.Text = inpt.Description;
            text.Text = inpt.text;
            picture.Text = inpt.image;
            url.Text = inpt.url;

            foreach(string i in inpt.items) { items.Items.Clear(); items.Items.Add(i); }
            foreach (string i in inpt.tags) { tags.Items.Clear(); tags.Items.Add(i); }
            foreach (string i in inpt.album) { album.Items.Clear(); album.Items.Add(i); }


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
