﻿using ngx_docs_managment_application._Controllers;
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

        private void Managment_Load(object sender, EventArgs e)
        {
            dc.UpdateProjectFolderLabel(dashboard_project_path_status_label);
            ic.FillInputListbox(input_listbox);
            
        }

        private void set_project_path_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sc.SelectProjectPath();
            dc.UpdateProjectFolderLabel(dashboard_project_path_status_label);
        }
    }
}
