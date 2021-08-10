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
        }
    }
}
