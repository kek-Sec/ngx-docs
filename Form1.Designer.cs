
namespace ngx_docs_managment_application
{
    partial class Main_form
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
            this.manage_project_button = new System.Windows.Forms.Button();
            this.setup_wizard_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manage_project_button
            // 
            this.manage_project_button.BackColor = System.Drawing.SystemColors.Control;
            this.manage_project_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manage_project_button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.manage_project_button.Location = new System.Drawing.Point(12, 13);
            this.manage_project_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.manage_project_button.Name = "manage_project_button";
            this.manage_project_button.Size = new System.Drawing.Size(306, 272);
            this.manage_project_button.TabIndex = 0;
            this.manage_project_button.Text = "Manage existing project";
            this.manage_project_button.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.manage_project_button.UseVisualStyleBackColor = false;
            // 
            // setup_wizard_button
            // 
            this.setup_wizard_button.BackColor = System.Drawing.SystemColors.Control;
            this.setup_wizard_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setup_wizard_button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.setup_wizard_button.Location = new System.Drawing.Point(324, 13);
            this.setup_wizard_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.setup_wizard_button.Name = "setup_wizard_button";
            this.setup_wizard_button.Size = new System.Drawing.Size(306, 272);
            this.setup_wizard_button.TabIndex = 1;
            this.setup_wizard_button.Text = "Run setup wizard";
            this.setup_wizard_button.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.setup_wizard_button.UseVisualStyleBackColor = false;
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 298);
            this.Controls.Add(this.setup_wizard_button);
            this.Controls.Add(this.manage_project_button);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main_form";
            this.Text = "ngx-docs manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manage_project_button;
        private System.Windows.Forms.Button setup_wizard_button;
    }
}

