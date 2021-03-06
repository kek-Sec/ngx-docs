using ngx_docs_managment_application._Models;
using ngx_docs_managment_application._Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ngx_docs_managment_application._Controllers
{
    class Input_Controller
    {
        Input_Service input;
        readonly Validator_Service validator = new Validator_Service();
        public Input_Controller()
        {
            input = new Input_Service();
        }

        /// <summary>
        /// Function to update input listbox
        /// </summary>
        public void UpdateInput(ListBox input_lbx)
        {
            try
            {
                this.input = new Input_Service();
                input_lbx.Items.Clear();
                foreach (Input_Model s in input.input_collection)
                {
                    input_lbx.Items.Add(s.Title);
                }
            }
            catch (Exception e)
            {
                Logger_Service.Add("INPUT_CONTROLLER", e.Message);
                return;
            }
        }

        /// <summary>
        /// Helper function for removing data from listboxes
        /// </summary>
        /// <param name="lbx">The listbox</param>
        /// <param name="index">The item index</param>
        public void RemoveDataFromListBox(ListBox lbx, int index)
        {
            try
            {
                if (index < 0) { return; }
                lbx.Items.RemoveAt(index);
            }
            catch (Exception e)
            {
                Logger_Service.Add("INPUT_CONTROLLER|RemoveDataFromListBox", e.Message);
            }
        }

        /// <summary>
        /// Helper function for adding data to listboxes
        /// </summary>
        /// <param name="lbx">The listbox</param>
        /// <param name="inp">The input textbox</param>
        public void AddDataToListBox(ListBox lbx, TextBox inp)
        {
            try
            {
                if (inp.Text == string.Empty) { return; }
                lbx.Items.Add(inp.Text);
                inp.Clear();
            }
            catch (Exception e)
            {
                Logger_Service.Add("INPUT_CONTROLLER|AddDataToListBox", e.Message);
            }
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
        public void UpdateEntry(int index, TextBox title, TextBox description, TextBox text, TextBox picture, TextBox url,ListBox code, ListBox tags, ListBox items, ListBox album)
        {
            try
            {
                if (!ConfirmAction("Update entry")) { return; }
                bool validate_input = validator.ValidateTextBox(title);
                if (!validate_input) { MessageBox.Show("Fields missing"); return; }

                Input_Model new_entry = new Input_Model();
                new_entry.Title = title.Text;

                

                //optional fields
                if (description.Text.Length > 0) { new_entry.Description = description.Text; }
                if (text.Text.Length > 0) { new_entry.text = text.Text; }
                if (picture.Text.Length >0) { new_entry.image = picture.Text; }
                if (url.Text.Length > 0) { new_entry.url = url.Text; }
                if (code.Items.Count > 0) { new_entry.code = new List<string>(); foreach (string s in code.Items) { new_entry.code.Add(s); } }
                if (items.Items.Count > 0) { new_entry.items = new List<string>(); foreach (string s in items.Items) {  new_entry.items.Add(s); } }
                if (tags.Items.Count > 0) { new_entry.tags = new List<string>(); foreach (string s in tags.Items) { new_entry.tags.Add(s); } }
                if (album.Items.Count > 0) { new_entry.album = new List<string>(); foreach (string s in album.Items) { new_entry.album.Add(s); } }


                //call service
                input.UpdateEntry(index, new_entry);
                input.LoadData();

                return;
            }
            catch (Exception e)
            {
                Logger_Service.Add("INPUT_CONTROLLER|UpdateEntry", e.Message);
            }

        }

        /// <summary>
        /// Middleware function to delete an entry
        /// </summary>
        /// <param name="index">The index of the item to delete</param>
        public void DeleteEntry(int index)
        {
            try
            {
                if (index == -1) { return; }
                if (!ConfirmAction("Delete entry")) { return; }
                input.DeleteEntry(index);
            }
            catch (Exception e)
            {
                Logger_Service.Add("INPUT_CONTROLLER|DeleteEntry", e.Message);
            }

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
        public void AddEntry(TextBox title, TextBox description, TextBox text, TextBox picture, TextBox url,ListBox code, ListBox tags, ListBox items, ListBox album)
        {
            try
            {
                if (!ConfirmAction("Add entry")) { return; }
                bool validate_input = validator.ValidateTextBox(title);
                if (!validate_input) { MessageBox.Show("Fields missing"); return; }
                Input_Model new_entry = new Input_Model();
                new_entry.Title = title.Text;



                //optional fields
                if (description.Text.Length > 0) { new_entry.Description = description.Text; }
                if (text.Text.Length > 0) { new_entry.text = text.Text; }
                if (picture.Text.Length > 0) { new_entry.image = picture.Text; }
                if (url.Text.Length > 0) { new_entry.url = url.Text; }
                if (code.Items.Count > 0) { new_entry.code = new List<string>(); foreach(string s in code.Items) { new_entry.code.Add(s); } }
                if (items.Items.Count > 0) { new_entry.items = new List<string>(); foreach (string s in items.Items) { new_entry.items.Add(s); } }
                if (tags.Items.Count > 0) { new_entry.tags = new List<string>(); foreach (string s in tags.Items) { new_entry.tags.Add(s); } }
                if (album.Items.Count > 0) { new_entry.album = new List<string>(); foreach (string s in album.Items) { new_entry.album.Add(s); } }

                input.AddEntry(new_entry);

                //reset fields
                picture.Text = "assets/images/default.PNG";
                items.Items.Clear();
                album.Items.Clear();
                code.Items.Clear();
                tags.Items.Clear();
                text.Text = "";
                description.Text = "";
                title.Text = "";
                return;
            }
            catch (Exception e)
            {
                Logger_Service.Add("INPUT_CONTROLLER|AddEntry", e.Message);
            }
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
        public void SetSelectedItem(int index,Label id_label, TextBox title, TextBox description, TextBox text, TextBox picture, TextBox url,ListBox code, ListBox tags, ListBox items, ListBox album)
        {
            try
            {
                Input_Model inpt = input.input_collection[index];

                title.Text = inpt.Title;
                description.Text = inpt.Description;
                text.Text = inpt.text;
                picture.Text = inpt.image;
                url.Text = inpt.url;
                id_label.Text = inpt.id.ToString();

                //clear listboxes
                items.Items.Clear();
                tags.Items.Clear();
                album.Items.Clear();
                code.Items.Clear();

                if (inpt.items is object)
                {
                    foreach (string i in inpt.items) { items.Items.Add(i); }
                }

                if (inpt.code is object)
                {
                    foreach(string i in inpt.code) { code.Items.Add(i); }
                }


                if (inpt.tags is object)
                {
                    foreach (string i in inpt.tags) { tags.Items.Add(i); }
                }

                if (inpt.album is object)
                {
                    foreach (string i in inpt.album) { album.Items.Add(i); }
                }

            }
            catch (Exception e)
            {
                Logger_Service.Add("INPUT_CONTROLLER|SetSelectedItem", e.Message);
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
                if(input.input_collection is null) { return; }

                foreach (Input_Model im in input.input_collection)
                {
                    input_listbox.Items.Add(im.Title);
                }
            }
            catch (Exception e)
            {
                Logger_Service.Add("INPUT_CONTROLLER|FillInputListbox", e.Message);
            }
        }

        /// <summary>
        /// Helper function to show a confirmation message box
        /// </summary>
        /// <param name="title">The messagebox title</param>
        /// <returns></returns>
        private bool ConfirmAction(string title) => (MessageBox.Show("Confirm action", title,
   MessageBoxButtons.YesNo, MessageBoxIcon.Question,
   MessageBoxDefaultButton.Button1) == DialogResult.Yes);
    }
}
