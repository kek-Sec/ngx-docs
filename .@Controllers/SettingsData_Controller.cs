using ngx_docs_managment_application._Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ngx_docs_managment_application._Forms
{
    class SettingsData_Controller
    {
        SettingsData_Service ss = new SettingsData_Service();

        /// <summary>
        /// Update Settings data view
        /// </summary>
        /// <param name="show_picture"></param>
        /// <param name="show_title"></param>
        /// <param name="show_description"></param>
        /// <param name="show_text"></param>
        /// <param name="show_items"></param>
        /// <param name="show_url"></param>
        /// <param name="show_album"></param>
        /// <param name="show_tags"></param>
        /// <param name="description_length"></param>
        /// <param name="text_length"></param>
        /// <param name="item_length"></param>
        /// <param name="items_count"></param>
        /// <param name="column_count"></param>
        public void UpdateSettingsDataView(CheckBox show_picture, CheckBox show_title, CheckBox show_description, CheckBox show_text, CheckBox show_items, CheckBox show_url, CheckBox show_album, CheckBox show_tags, NumericUpDown description_length, NumericUpDown text_length, NumericUpDown item_length, NumericUpDown items_count, NumericUpDown column_count)
        {
            var setting = ss.settings_model[0];

            show_picture.Checked = setting.preview_show_picture;
            show_title.Checked = setting.preview_show_title;
            show_description.Checked = setting.preview_show_description;
            show_text.Checked = setting.preview_show_text;
            show_items.Checked = setting.preview_show_items;
            show_url.Checked = setting.preview_show_url;
            show_tags.Checked = setting.preview_show_tags;
            show_album.Checked = setting.preview_show_album;

            text_length.Value = setting.preview_text_length;
            item_length.Value = setting.preview_item_text_length;
            items_count.Value = setting.preview_items_count;
            description_length.Value = setting.preview_description_text_length;
            column_count.Value = setting.preview_number_of_columns;
        }


        public void SaveSettings(CheckBox show_picture, CheckBox show_title, CheckBox show_description, CheckBox show_text, CheckBox show_items, CheckBox show_url, CheckBox show_album, CheckBox show_tags, NumericUpDown description_length, NumericUpDown text_length, NumericUpDown item_length, NumericUpDown items_count, NumericUpDown column_count)
        {
            Settings_Model settings = new Settings_Model();
            settings.preview_show_picture = show_picture.Checked;
            settings.preview_show_title = show_title.Checked;
            settings.preview_show_description = show_description.Checked;
            settings.preview_show_text = show_text.Checked;
            settings.preview_show_items = show_items.Checked;
            settings.preview_show_url = show_url.Checked;
            settings.preview_show_album = show_album.Checked;
            settings.preview_show_tags = show_tags.Checked;
            settings.preview_description_text_length = (int)description_length.Value;
            settings.preview_item_text_length = (int)item_length.Value;
            settings.preview_items_count = (int)items_count.Value;
            settings.preview_text_length = (int)text_length.Value;
            settings.preview_number_of_columns = (int)column_count.Value;

            ss.Save(settings);
        }
    }
}
