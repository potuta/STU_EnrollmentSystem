﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUEnrollmentSystem
{
    public partial class STU_Dashboard : Form
    {
        public STU_Dashboard()
        {
            InitializeComponent();
            InitializeUserLoginRole(Login.Role);
            MessageBox.Show("Welcome " + Login.Role + ": " + Login.Username);
        }

        private void STU_Dashboard_Load(object sender, EventArgs e)
        {
            studentSubPanel.Visible = false;
            cashierSubPanel.Visible = false;
            adminSubPanel.Visible = false;
            userLabel.Text = "User: " + Login.Username;
            roleLabel.Text = "Role: " + Login.Role;
        }

        private void hideSubpanel()
        {
            if (studentSubPanel.Visible == true)
            {
                studentSubPanel.Visible = false;
            }
            if (cashierSubPanel.Visible == true)
            {
                cashierSubPanel.Visible = false;
            }
        }

        private void showSubPanel(Panel subPanel)
        {
            if (subPanel.Visible == false)
            {
                //hideSubpanel();
                subPanel.Visible = true;
            }
            else
            {
                subPanel.Visible = false;
            }
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void InitializeUserLoginRole(string role)
        {
            if (role.Equals("Admin"))
            {
                Login.Role = "Admin";
                studentButton.Enabled = true;
                cashierButton.Enabled = true;
                adminButton.Enabled = true;
            }
            else if (role.Equals("A"))
            {
                Login.Role = "Admission";
                studentButton.Enabled = true;
                cashierButton.Enabled = false;
                adminButton.Enabled = false;
            }
            else if (role.Equals("C"))
            {
                Login.Role = "Cashier";
                studentButton.Enabled = false;
                cashierButton.Enabled = true;
                adminButton.Enabled = false;
            }
            else if (role.Equals("R")) 
            {
                Login.Role = "Registrar";
                studentButton.Enabled = true;
                cashierButton.Enabled = false;
                adminButton.Enabled = false;
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
            this.Close();
            this.Dispose();
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            showSubPanel(studentSubPanel);
        }

        private void cashierButton_Click(object sender, EventArgs e)
        {
            showSubPanel(cashierSubPanel);
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            showSubPanel(adminSubPanel);
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Registration());
        }

        private void pendingButton_Click(object sender, EventArgs e)
        {
            openChildForm(new PendingStudents());
        }

        private void manageStudentButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Student());
        }

        private void pendingRequirementsButton_Click(object sender, EventArgs e)
        {
            openChildForm(new PendingRequirements());
        }

        private void managePaymentButton_Click(object sender, EventArgs e)
        {
            openChildForm(new StudentPayment());
        }

        private void sectionButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Section());
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Users());
        }

        private void teacherButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Teacher());
        }
    }
}
