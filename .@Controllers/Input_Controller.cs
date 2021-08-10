using ngx_docs_managment_application._Models;
using ngx_docs_managment_application._Services;
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
        Validator_Service validator = new Validator_Service();
        public Input_Controller()
        {
            input = new Input_Service();
        }

        /// <summary>
        /// Middleware for updating an entry in input.json
        /// </summary>
        /// <param name="index">The index of the item</param>
        /// <param name="title">Title textbox</param>
        /// <param name="description">Description textbox</param>
        /// <param name="text">Text textbox</param>
        /// <param name="picture">Picture textbox</param>
        /// <param name="url">Url textbox</param>
        /// <param name="tags">Tags listbox</param>
        /// <param name="items">Items listbox</param>
        /// <param name="album">Album listbox</param>
        public void UpdateEntry(int index, TextBox title, TextBox description, TextBox text, TextBox picture, TextBox url, ListBox tags, ListBox items, ListBox album)
        {
            bool validate_input = items.Items.Count > 0 && validator.ValidateTextBox(title) && validator.ValidateTextBox(description) && validator.ValidateTextBox(text) && validator.ValidateTextBox(picture);
            if (!validate_input) { MessageBox.Show("Fields missing"); return; }

            Input_Model new_entry = new Input_Model();
            new_entry.Title = title.Text;
            new_entry.Description = description.Text;
            new_entry.text = text.Text;
            new_entry.image = picture.Text;

            //optional fields
            if (url.Text.Length > 0) { new_entry.url = url.Text; }
            if (tags.Items.Count > 0) { foreach (string s in tags.Items) { new_entry.tags.Add(s); } }
            if (album.Items.Count > 0) { foreach (string s in album.Items) { new_entry.album.Add(s); } }

            //call service
            input.UpdateEntry(index, new_entry);
            return;
        }

        /// <summary>
        /// Middleware function to delete an entry
        /// </summary>
        /// <param name="index">The index of the item to delete</param>
        public void DeleteEntry(int index)
        {
            if(index == -1) { return; }
            input.DeleteEntry(index);
        }

        /// <summary>
        /// Middleware function for Adding an entry to input.json
        /// </summary>
        /// <param name="title">Title textbox</param>
        /// <param name="description">Description textbox</param>
        /// <param name="text">Text textbox</param>
        /// <param name="picture">Picture textbox</param>
        /// <param name="url">Url textbox</param>
        /// <param name="tags">Tags listbox</param>
        /// <param name="items">Items listbox</param>
        /// <param name="album">Album listbox</param>
        public void AddEntry(TextBox title, TextBox description, TextBox text, TextBox picture, TextBox url, ListBox tags, ListBox items, ListBox album)
        {
            bool validate_input = items.Items.Count > 0 && validator.ValidateTextBox(title) && validator.ValidateTextBox(description) && validator.ValidateTextBox(text) && validator.ValidateTextBox(picture);
            if(!validate_input) { MessageBox.Show("Fields missing"); return; }
            Input_Model new_entry = new Input_Model();
            new_entry.Title = title.Text;
            new_entry.Description = description.Text;
            new_entry.text = text.Text;
            new_entry.image = picture.Text;

            //optional fields
            if(url.Text.Length > 0) { new_entry.url = url.Text; }
            if(tags.Items.Count > 0) { foreach(string s in tags.Items) { new_entry.tags.Add(s); } }
            if (album.Items.Count > 0) { foreach (string s in album.Items) { new_entry.album.Add(s); } }

            return;
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

            //clear listboxes
            items.Items.Clear();
            tags.Items.Clear();
            album.Items.Clear();

            foreach (string i in inpt.items) {  items.Items.Add(i); }

            if(inpt.tags is object)
            {
                foreach (string i in inpt.tags) { tags.Items.Add(i); }
            }

            if(inpt.album is object)
            {
                foreach (string i in inpt.album) { album.Items.Add(i); }
            }


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
