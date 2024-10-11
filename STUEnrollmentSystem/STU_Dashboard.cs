using System;
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
    public partial class STU_Dashboard : Form
    {
        public STU_Dashboard()
        {
            InitializeComponent();
        }

        private void STU_Dashboard_Load(object sender, EventArgs e)
        {
            studentSubPanel.Visible = false;
            cashierSubPanel.Visible = false;
            adminSubPanel.Visible = false;
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
    }
}
