﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUEnrollmentSystem
{
    public partial class frmUsers_Roles : Form
    {
        public frmUsers_Roles()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                panelMain.Controls.Remove(activeForm);
                activeForm.Close();
                activeForm.Dispose();
                activeForm = null;
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(activeForm);
            panelMain.Tag = activeForm;
            activeForm.BringToFront();
            activeForm.Show();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            if (sender == usersButton)
            {
                openChildForm(new frmUsers());
            }
            else if (sender == rolesButton)
            {
                openChildForm(new frmRoles());
            }
        }
    }
}
