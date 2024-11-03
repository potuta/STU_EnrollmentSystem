using System;
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
    public partial class frmSTU_Dashboard : Form
    {
        public frmSTU_Dashboard()
        {
            InitializeComponent();
            InitializeUserLoginRole(frmLogin.Role);
            MessageBox.Show("Welcome " + frmLogin.Role + ": " + frmLogin.Username);
        }

        private void STU_Dashboard_Load(object sender, EventArgs e)
        {
            studentSubPanel.Visible = false;
            cashierSubPanel.Visible = false;
            adminSubPanel.Visible = false;
            userLabel.Text = "User: " + frmLogin.Username;
            roleLabel.Text = "Role: " + frmLogin.Role;
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
                panel_main.Controls.Remove(activeForm);
                activeForm.Close();
                activeForm.Dispose(); 
                activeForm = null;
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(activeForm);
            panel_main.Tag = activeForm;
            activeForm.BringToFront();
            activeForm.Show();
        }

        private void InitializeUserLoginRole(string role)
        {
            if (role.Equals("Admin"))
            {
                frmLogin.Role = "Admin";
                studentButton.Enabled = true;
                cashierButton.Enabled = true;
                adminButton.Enabled = true;
            }
            else if (role.Equals("A"))
            {
                frmLogin.Role = "Admission";
                studentButton.Enabled = true;
                cashierButton.Enabled = false;
                adminButton.Enabled = false;
            }
            else if (role.Equals("C"))
            {
                frmLogin.Role = "Cashier";
                studentButton.Enabled = false;
                cashierButton.Enabled = true;
                adminButton.Enabled = false;
            }
            else if (role.Equals("R")) 
            {
                frmLogin.Role = "Registrar";
                studentButton.Enabled = true;
                cashierButton.Enabled = false;
                adminButton.Enabled = false;
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
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

        private void OnButtonClicked(object sender, EventArgs e)
        {
            if (sender == registrationButton)
            {
                openChildForm(new frmRegistration());
            }
            else if (sender == pendingButton)
            {
                openChildForm(new frmPendingStudents());
            }
            else if (sender == manageStudentButton)
            {
                openChildForm(new frmStudent());
            }
            else if (sender == pendingRequirementsButton)
            {
                openChildForm(new frmPendingRequirements());
            }
            else if (sender == managePaymentButton)
            {
                openChildForm(new frmStudentPayment());
            }
            else if (sender == sectionButton)
            {
                openChildForm(new frmSection());
            }
            else if (sender == usersButton)
            {
                openChildForm(new frmUsers());
            }
            else if (sender == teacherButton)
            {
                openChildForm(new frmTeacher());
            }
            else if (sender == pricesButton)
            {
                openChildForm(new frmPrices());
            }
            else if (sender == paymentTypeButton)
            {
                openChildForm(new frmPaymentType());
            }
        }
    }
}
