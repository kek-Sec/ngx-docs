using ngx_docs_managment_application._Controllers;
using ngx_docs_managment_application._Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ngx_docs_managment_application
{
    public partial class Managment : Form
    {

        //Initiate controllers
        readonly Dashboard_Controller dc = new Dashboard_Controller();
        readonly Settings_Controller sc = new Settings_Controller();
        readonly Input_Controller ic = new Input_Controller();
        readonly SettingsData_Controller sdc = new SettingsData_Controller();
        public Managment()
        {
            InitializeComponent();
        }

        void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }

        /*
         * ENTRY POINT FOR MANAGMENT FORM
        **********************************
         */
        private void Managment_Load(object sender, EventArgs e)
        {
            dc.UpdateProjectFolderLabel(dashboard_project_path_status_label);
            ic.FillInputListbox(input_listbox);
            sdc.UpdateSettingsDataView(preview_show_picture_checkBox, preview_show_title_checkBox, preview_show_description_checkBox, preview_show_text_checkBox, preview_show_items_checkBox, preview_show_url_checkBox, preview_show_album_checkBox, preview_show_tags_checkBox, preview_description_text_length_numericUpDown, preview_text_length_numericUpDown, preview_item_text_length_numericUpDown, preview_items_count_numericUpDown, preview_number_of_columns_numericUpDown);

        }

        private void set_project_path_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sc.SelectProjectPath();
            dc.UpdateProjectFolderLabel(dashboard_project_path_status_label);
        }

        private void input_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var indx = input_listbox.SelectedIndex;
            if (indx == -1)
            {
                return;
            }
            
            ic.SetSelectedItem(indx, input_title_textBox, input_description_textBox, input_text_textBox, input_thumbnail_textBox, input_url_textBox, input_tags_listbox, input_items_listbox, input_album_listbox);
        }

        private void input_item_add_button_Click(object sender, EventArgs e)
        {
            ic.AddDataToListBox(input_items_listbox, input_item_textBox);
        }

        private void input_item_remove_button_Click(object sender, EventArgs e)
        {
            ic.RemoveDataFromListBox(input_items_listbox, input_items_listbox.SelectedIndex);
        }

        private void settings_save_button_Click(object sender, EventArgs e)
        {
            sdc.SaveSettings(preview_show_picture_checkBox, preview_show_title_checkBox, preview_show_description_checkBox, preview_show_text_checkBox, preview_show_items_checkBox, preview_show_url_checkBox, preview_show_album_checkBox, preview_show_tags_checkBox, preview_description_text_length_numericUpDown, preview_text_length_numericUpDown, preview_item_text_length_numericUpDown, preview_items_count_numericUpDown, preview_number_of_columns_numericUpDown);

        }
    }
}
