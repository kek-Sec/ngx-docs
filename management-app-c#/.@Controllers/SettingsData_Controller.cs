using ngx_docs_managment_application._Models;
using ngx_docs_managment_application._Services;
using System;
using System.Windows.Forms;

namespace ngx_docs_managment_application._Forms
{
    class SettingsData_Controller
    {
        readonly SettingsData_Service ss = new SettingsData_Service();

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
        public void UpdateSettingsDataView(CheckBox detailed_show_code, CheckBox detailed_show_picture, CheckBox detailed_show_title, CheckBox detailed_show_description, CheckBox detailed_show_text, CheckBox detailed_show_items, CheckBox detailed_show_url, CheckBox detailed_show_album, CheckBox detailed_show_tags, CheckBox preview_show_code, CheckBox preview_show_picture, CheckBox preview_show_title, CheckBox preview_show_description, CheckBox preview_show_text, CheckBox preview_show_items, CheckBox preview_show_url, CheckBox preview_show_album, CheckBox preview_show_tags, NumericUpDown description_length, NumericUpDown text_length, NumericUpDown item_length, NumericUpDown items_count, NumericUpDown column_count)
        {
            try 
            {
                if(ss.settings_model is null) { ss.RefreshData(); return; }

                var setting = ss.settings_model[0];

                preview_show_code.Checked = setting.preview_show_code;
                preview_show_picture.Checked = setting.preview_show_picture;
                preview_show_title.Checked = setting.preview_show_title;
                preview_show_description.Checked = setting.preview_show_description;
                preview_show_text.Checked = setting.preview_show_text;
                preview_show_items.Checked = setting.preview_show_items;
                preview_show_url.Checked = setting.preview_show_url;
                preview_show_tags.Checked = setting.preview_show_tags;
                preview_show_album.Checked = setting.preview_show_album;
                text_length.Value = setting.preview_text_length;
                item_length.Value = setting.preview_item_text_length;
                items_count.Value = setting.preview_items_count;
                description_length.Value = setting.preview_description_text_length;
                column_count.Value = setting.preview_number_of_columns;

                //DETAILED
                detailed_show_code.Checked = setting.detailed_show_code;
                detailed_show_picture.Checked = setting.detailed_show_picture;
                detailed_show_title.Checked = setting.detailed_show_title;
                detailed_show_description.Checked = setting.detailed_show_description;
                detailed_show_text.Checked = setting.detailed_show_text;
                detailed_show_items.Checked = setting.detailed_show_items;
                detailed_show_url.Checked = setting.detailed_show_url;
                detailed_show_tags.Checked = setting.detailed_show_tags;
                detailed_show_album.Checked = setting.detailed_show_album;
            }
            catch (Exception e)
            {
                Logger_Service.Add("SETTINGSDATA_CONTROLLER|UpdateSettingsDataView", e.Message);
            }

        }

        /// <summary>
        /// Save settings 
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
        public void SaveSettings(CheckBox detailed_show_code, CheckBox detailed_show_picture, CheckBox detailed_show_title, CheckBox detailed_show_description, CheckBox detailed_show_text, CheckBox detailed_show_items, CheckBox detailed_show_url, CheckBox detailed_show_album, CheckBox detailed_show_tags, CheckBox preview_show_code, CheckBox preview_show_picture, CheckBox preview_show_title, CheckBox preview_show_description, CheckBox preview_show_text, CheckBox preview_show_items, CheckBox preview_show_url, CheckBox preview_show_album, CheckBox preview_show_tags, NumericUpDown description_length, NumericUpDown text_length, NumericUpDown item_length, NumericUpDown items_count, NumericUpDown column_count)
        {
            try
            {
                Settings_Model settings = new Settings_Model();
                settings.preview_show_code = preview_show_code.Checked;
                settings.preview_show_picture = preview_show_picture.Checked;
                settings.preview_show_title = preview_show_title.Checked;
                settings.preview_show_description = preview_show_description.Checked;
                settings.preview_show_text = preview_show_text.Checked;
                settings.preview_show_items = preview_show_items.Checked;
                settings.preview_show_url = preview_show_url.Checked;
                settings.preview_show_album = preview_show_album.Checked;
                settings.preview_show_tags = preview_show_tags.Checked;
                settings.preview_description_text_length = (int)description_length.Value;
                settings.preview_item_text_length = (int)item_length.Value;
                settings.preview_items_count = (int)items_count.Value;
                settings.preview_text_length = (int)text_length.Value;
                settings.preview_number_of_columns = (int)column_count.Value;

                //DETAILED
                settings.detailed_show_code = detailed_show_code.Checked;
                settings.detailed_show_picture = detailed_show_picture.Checked;
                settings.detailed_show_title = detailed_show_title.Checked;
                settings.detailed_show_description = detailed_show_description.Checked;
                settings.detailed_show_text = detailed_show_text.Checked;
                settings.detailed_show_items = detailed_show_items.Checked;
                settings.detailed_show_url = detailed_show_url.Checked;
                settings.detailed_show_album = detailed_show_album.Checked;
                settings.detailed_show_tags = detailed_show_tags.Checked;

                ss.Save(settings);
            }
            catch (Exception e)
            {
                Logger_Service.Add("SETTINGSDATA_CONTROLLER|SaveSettings", e.Message);
            }
        }
    }
}
