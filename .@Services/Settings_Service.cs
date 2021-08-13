using ngx_docs_managment_application._Services;
using System;
using System.Windows.Forms;

namespace ngx_docs_managment_application._Forms
{
    class Settings_Service
    {

        /// <summary>
        /// Changes the project folder directory setting
        /// </summary>
        public void LoadKeysFolder()
        {
            try
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        UpdateSetting("project_path", fbd.SelectedPath);
                        MessageBox.Show("Successfully saved", "Project directory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }catch(Exception e)
            {
                Logger_Service.Add("SETTINGS_SERVICE|LoadKeysFolder", e.Message);
            }
        }

        #region settings
        /// <summary>
        /// Updates System Properties settings
        /// </summary>
        /// <param name="setting">The setting to update.</param>
        /// <param name="value">The value to use for the setting.</param>
        public void UpdateSetting(string setting, string value)
        {
            Properties.Settings.Default[setting] = value;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Updates System Properties settings (OVERLOAD FOR BOOLEANS)
        /// </summary>
        /// <param name="setting">The setting to update.</param>
        /// <param name="value">The value to use for the setting.</param>
        public void UpdateSetting(string setting, bool value)
        {
            Properties.Settings.Default[setting] = value;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Gets System Properties setting
        /// </summary>
        /// <param name="setting">The setting to get.</param>
        public string getSetting(string setting)
        {
            return Properties.Settings.Default[setting].ToString();
        }

        /// <summary>
        /// Gets System Properties setting boolean overload
        /// </summary>
        /// <param name="setting">The setting to get.</param>
        /// <param name="get_bool">True if we want a bool</param>
        public bool getSetting(string setting, bool get_bool)
        {
            return (bool)Properties.Settings.Default[setting];
        }

        #endregion
    }
}

