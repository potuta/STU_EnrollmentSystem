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

        private frmSTU_Dashboard STU;
        private void confirmUserLogin(string userID, string username, string password)
        {
            try
            {
                bool isUserVerified = _usersRepository.VerifyUserLogin(userID, username, password);
                if (isUserVerified == true)
                {
                    InitializeUserLoginInfo(userID, username, password);
                    STU = new frmSTU_Dashboard();
                    STU.FormClosed += STU_FormClosed;
                    STU.Show();
                    this.Hide();
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
            STU.Dispose();
            userIDTextBox.Clear();
            usernameTextBox.Clear();
            passwordTextBox.Clear();
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

    }
}
