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
    public partial class STU_Dashboard : Form
    {
        private SqlConnection STU_DB_Connection;
        private SqlCommand STU_Command;
        private List<string> userLoginInfo;

        public STU_Dashboard()
        {
            InitializeComponent();
        }

        public STU_Dashboard(string userID, string username, string password)
        {
            InitializeComponent();
            STU_DB_Connection = new SqlConnection(Properties.Settings.Default.STU_DBConnectionString);
            userLoginInfo = new List<string>();
            getUserLogin(userID, username, password);
            InitializeUserRole(userLoginInfo[4]);
            userLabel.Text = "User: " + userLoginInfo[1];
            roleLabel.Text = "Role: " + userLoginInfo[4];
            MessageBox.Show("Welcome " + userLoginInfo[4] + ": " + userLoginInfo[1]);
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

        private void getUserLogin(string userID, string username, string password)
        {
            STU_Command = new SqlCommand("SELECT * FROM Users WHERE UserID = @UserID AND Username = @Username AND Password = @Password", STU_DB_Connection);
            STU_Command.Parameters.AddWithValue("@UserID", userID);
            STU_Command.Parameters.AddWithValue("@Username", username);
            STU_Command.Parameters.AddWithValue("@Password", password);

            STU_DB_Connection.Open();
            using(SqlDataReader reader = STU_Command.ExecuteReader())
            {
                while (reader.Read())
                {
                    for (int column = 0; column < reader.FieldCount; column++)
                    {
                        userLoginInfo.Add(reader.GetString(column));
                    }
                }
            }
            STU_DB_Connection.Close();
        }

        private void InitializeUserRole(string role)
        {
            if (role.Equals("Admin"))
            {
                userLoginInfo[4] = "Admin";
                studentButton.Enabled = true;
                cashierButton.Enabled = true;
                adminButton.Enabled = true;
            }
            else if (role.Equals("A"))
            {
                userLoginInfo[4] = "Admission";
                studentButton.Enabled = true;
                cashierButton.Enabled = false;
                adminButton.Enabled = false;
            }
            else if (role.Equals("C"))
            {
                userLoginInfo[4] = "Cashier";
                studentButton.Enabled = false;
                cashierButton.Enabled = true;
                adminButton.Enabled = false;
            }
            else if (role.Equals("R")) 
            {
                userLoginInfo[4] = "Registrar";
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

    }
}
