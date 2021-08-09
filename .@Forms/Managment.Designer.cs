
namespace ngx_docs_managment_application
{
    partial class Managment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.input_tabPage = new System.Windows.Forms.TabPage();
            this.settings_tabPage = new System.Windows.Forms.TabPage();
            this.theming_tabPage = new System.Windows.Forms.TabPage();
            this.dashboard_tabPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.dashboard_tabPage);
            this.tabControl1.Controls.Add(this.input_tabPage);
            this.tabControl1.Controls.Add(this.settings_tabPage);
            this.tabControl1.Controls.Add(this.theming_tabPage);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(840, 541);
            this.tabControl1.TabIndex = 0;
            // 
            // input_tabPage
            // 
            this.input_tabPage.Location = new System.Drawing.Point(4, 29);
            this.input_tabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_tabPage.Name = "input_tabPage";
            this.input_tabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input_tabPage.Size = new System.Drawing.Size(832, 508);
            this.input_tabPage.TabIndex = 0;
            this.input_tabPage.Text = "Input data";
            this.input_tabPage.UseVisualStyleBackColor = true;
            // 
            // settings_tabPage
            // 
            this.settings_tabPage.Location = new System.Drawing.Point(4, 29);
            this.settings_tabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.settings_tabPage.Name = "settings_tabPage";
            this.settings_tabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.settings_tabPage.Size = new System.Drawing.Size(832, 508);
            this.settings_tabPage.TabIndex = 1;
            this.settings_tabPage.Text = "Settings data";
            this.settings_tabPage.UseVisualStyleBackColor = true;
            // 
            // theming_tabPage
            // 
            this.theming_tabPage.Location = new System.Drawing.Point(4, 29);
            this.theming_tabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.theming_tabPage.Name = "theming_tabPage";
            this.theming_tabPage.Size = new System.Drawing.Size(832, 508);
            this.theming_tabPage.TabIndex = 2;
            this.theming_tabPage.Text = "Theming";
            this.theming_tabPage.UseVisualStyleBackColor = true;
            // 
            // dashboard_tabPage
            // 
            this.dashboard_tabPage.Location = new System.Drawing.Point(4, 29);
            this.dashboard_tabPage.Name = "dashboard_tabPage";
            this.dashboard_tabPage.Size = new System.Drawing.Size(832, 508);
            this.dashboard_tabPage.TabIndex = 3;
            this.dashboard_tabPage.Text = "Dashboard";
            this.dashboard_tabPage.UseVisualStyleBackColor = true;
            // 
            // Managment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 542);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Managment";
            this.Text = "Managment";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage dashboard_tabPage;
        private System.Windows.Forms.TabPage input_tabPage;
        private System.Windows.Forms.TabPage settings_tabPage;
        private System.Windows.Forms.TabPage theming_tabPage;
    }
}