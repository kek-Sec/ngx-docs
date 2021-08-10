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
        public void UpdateSettingsDataView(RadioButton show_picture,RadioButton show_title,RadioButton show_description,RadioButton show_text,RadioButton show_items,RadioButton show_url,RadioButton show_album,RadioButton show_tags,NumericUpDown description_length,NumericUpDown text_length,NumericUpDown item_length,NumericUpDown items_count,NumericUpDown column_count)
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


        public void SaveSettings(RadioButton show_picture, RadioButton show_title, RadioButton show_description, RadioButton show_text, RadioButton show_items, RadioButton show_url, RadioButton show_album, RadioButton show_tags, NumericUpDown description_length, NumericUpDown text_length, NumericUpDown item_length, NumericUpDown items_count, NumericUpDown column_count)
        {

        }
    }
}
