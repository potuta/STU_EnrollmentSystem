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
    public partial class frmUserProfile : Form
    {
        private UsersRepository _usersRepository;

        public frmUserProfile()
        {
            InitializeComponent();
            _usersRepository = new UsersRepository(ConnectionFactory.GetConnectionString());
        }

        private void frmUserProfile_Load(object sender, EventArgs e)
        {
            InitializeUserInformation();
        }

        private void InitializeUserInformation()
        {
            userIDTextBox.Text = frmLogin.UserID;
            usernameTextBox.Text = frmLogin.Username;
            passwordTextBox.Text = frmLogin.Password;
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to change your password?", "Change Password", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            
            changePasswordPanel.Visible = true;
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to save changes?", "Change Password", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            if (frmLogin.HashPassword(currentPasswordTextBox.Text) != passwordTextBox.Text && currentPasswordTextBox.Text != passwordTextBox.Text)
            {
                MessageBox.Show("The current password you entered is wrong.");
                currentPasswordTextBox.Clear();
                return;
            }

            string hashedPassword = frmLogin.HashPassword(newPasswordTextBox.Text);
            _usersRepository.UpdateUserPassword(userIDTextBox.Text, hashedPassword);
            MessageBox.Show($"Password has been successfully changed!", "Success", MessageBoxButtons.OK);
            frmLogin.Password = hashedPassword;
            InitializeUserInformation();
            changePasswordPanel.Visible = false;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (newPasswordTextBox.UseSystemPasswordChar == true)
            {
                newPasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                newPasswordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
