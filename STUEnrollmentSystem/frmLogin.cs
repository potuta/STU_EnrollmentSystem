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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace STUEnrollmentSystem
{
    public partial class frmLogin : Form
    {
        public static string UserID {  get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string Email { get; set; }
        public static string Role { get; set; }
        private string Code {  get; set; }
        private UsersRepository _usersRepository;

        public frmLogin()
        {
            InitializeComponent();
            _usersRepository = new UsersRepository(Properties.Settings.Default.STU_DBConnectionString);
            this.AcceptButton = loginButton;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = loginButton;
        }

        private void confirmUserLogin(string userID, string username, string password)
        {
            try
            {
                bool isUserVerified = _usersRepository.VerifyUserLogin(userID, username, password);
                if (isUserVerified == true)
                {
                    InitializeUserLoginInfo(userID, username, password);
                    frmSTU_Dashboard STU = new frmSTU_Dashboard();
                    STU.FormClosed += STU_FormClosed;
                    STU.Show();
                    this.Hide();
                    LoggingService.LogInformation($"Successful login verification in VerifyUserLogin: UserID: {userID} Username: {username}");
                }
                else
                {
                    MessageBox.Show("User account not found");
                    return;
                }
            }
            catch (FormatException fe)
            {
                _usersRepository.CloseConnection();
                MessageBox.Show("User account not found");
                return;
            }
            catch (NullReferenceException nre)
            {
                _usersRepository.CloseConnection();
                MessageBox.Show("User account not found");
                return;
            }
        }

        private void STU_FormClosed(object sender, FormClosedEventArgs e)
        {
            userIDTextBox.Clear();
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            confirmUserIDTextBox.Clear();
            codeTextBox.Clear();
            this.Show();
        }

        private void InitializeUserLoginInfo(string userID, string username, string password)
        {
            List<string> userLoginInfo = _usersRepository.GetUserLoginInfo(userID, username, password);
            UserID = userLoginInfo[0];
            Username = userLoginInfo[1];
            Password = userLoginInfo[2];
            Email = userLoginInfo[3];
            Role = userLoginInfo[4]; 
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!userIDTextBox.Text.Equals(string.Empty) && !usernameTextBox.Text.Equals(string.Empty) && !passwordTextBox.Text.Equals(string.Empty))
            {
                confirmUserLogin(userIDTextBox.Text, usernameTextBox.Text, passwordTextBox.Text);
            }
            else
            {
                return;
            }
        }

        private void forgotPasswordButton_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
                codeTextBox.Focus();
            }
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

        private void confirmUserIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!confirmUserIDTextBox.Text.Equals(string.Empty))
            {
                sendCodeButton.Enabled = true;
            }
            else
            {
                sendCodeButton.Enabled = false;
            }
        }

        private void codeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!codeTextBox.Text.Equals(string.Empty))
            {
                confirmButton.Enabled = true;
            }
            else
            {
                confirmButton.Enabled = false;
            }
        }

        private void sendCodeButton_Click(object sender, EventArgs e)
        {
            UserID = confirmUserIDTextBox.Text;
            string email = _usersRepository.GetEmail(confirmUserIDTextBox.Text);
            textBox1.Visible = true;
            emailTextBox.Visible = true;
            emailTextBox.Text = email;

            Code = GenerateRandomNumericCode(5);
            string subject = "STU Verification Code";
            string body = $"Your code is: {Code}";

            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail(email, subject, body);

            MessageBox.Show($"Code has been sent! Please check your email inbox.");
        }

        public string GenerateRandomNumericCode(int length)
        {
            Random random = new Random();
            string code = "";
            for (int i = 0; i < length; i++)
            {
                code += random.Next(0, 10); // Generate a random digit (0-9)
            }
            return code;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (codeTextBox.Text != Code)
            {
                MessageBox.Show("Wrong code entered, please try again.", "Error", MessageBoxButtons.OK);
                return;
            }

            MessageBox.Show("Confirmation success! You can now change your password.", "Success", MessageBoxButtons.OK);
            changePasswordPanel.Visible = true;
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm changes?", "Change Password", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            if (newPasswordTextBox.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter new password");
                return;
            }
            
            _usersRepository.UpdateUserPassword(UserID, newPasswordTextBox.Text);
            MessageBox.Show($"Password has been successfully changed!", "Success", MessageBoxButtons.OK);

            forgotPasswordButton.PerformClick();
            confirmUserIDTextBox.Clear();
            codeTextBox.Clear();
            changePasswordPanel.Visible = false;
            textBox1.Visible = false;
            emailTextBox.Visible = false;
        }

    }
}
