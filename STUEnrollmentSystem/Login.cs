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
    public partial class Login : Form
    {
        public static string UserID {  get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string Role { get; set; }
        public static List<string> userLoginInfo;
        private bool isUserVerified;
        private SqlConnection STU_DB_Connection;
        private SqlCommand STU_Command;

        public Login()
        {
            InitializeComponent();
            STU_DB_Connection = new SqlConnection(Properties.Settings.Default.STU_DBConnectionString);
            userLoginInfo = new List<string>();
        }

        private void confirmUserLogin(string userID, string username, string password)
        {
            try
            {
                verifyUserLogin(userID, username, password);
                if (isUserVerified == true)
                {
                    InitializeUserLoginInfo();
                    STU_Dashboard STU = new STU_Dashboard();
                    STU.Show();
                    this.Hide();
                }
                else
                {
                    return;
                }
            }
            catch (NullReferenceException nre)
            {
                STU_DB_Connection.Close();
                MessageBox.Show("User not found");
                return;
            }
        }

        private void verifyUserLogin(string userID, string username, string password)
        {
            STU_Command = new SqlCommand("SELECT * FROM Users WHERE UserID = @UserID AND Username = @Username AND Password = @Password", STU_DB_Connection);
            STU_Command.Parameters.AddWithValue("@UserID", userID);
            STU_Command.Parameters.AddWithValue("@Username", username);
            STU_Command.Parameters.AddWithValue("@Password", password);

            STU_DB_Connection.Open();
            isUserVerified = STU_Command.ExecuteScalar().Equals(DBNull.Value) ? false : true;
            STU_DB_Connection.Close();
        }

        private void InitializeUserLoginInfo()
        {
            STU_DB_Connection.Open();
            using (SqlDataReader reader = STU_Command.ExecuteReader())
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

            UserID = userIDTextBox.Text;
            Username = usernameTextBox.Text;
            Password = passwordTextBox.Text;
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
