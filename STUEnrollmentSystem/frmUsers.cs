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
    public partial class frmUsers : Form
    {
        private UsersRepository _usersRepository;

        public frmUsers()
        {
            InitializeComponent();
            _usersRepository = new UsersRepository(ConnectionFactory.GetConnectionString());
            this.tableAdapterManager.Connection.ConnectionString = ConnectionFactory.GetConnectionString();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTU_DBDataSet);
            bindingNavigatorCancelItem.PerformClick();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTU_DBDataSet.Roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this.sTU_DBDataSet.Roles);
            this.usersTableAdapter.Fill(this.sTU_DBDataSet.Users);
            searchPanel.Visible = false;
            InitializeSearchComboBoxes();
            InitializeUserRolePrivileges();
        }

        private void InitializeUserRolePrivileges()
        {
            if (!frmLogin.Role.Equals("Administrator"))
            {
                bindingNavigatorDeleteItem.Enabled = false;
            }
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.sTU_DBDataSet.Users);
            InitializeSearchComboBoxes();
        }

        private void showSearchButton_Click(object sender, EventArgs e)
        {
            if (searchPanel.Visible == false)
            {
                showSearchButton.Text = "Search ▲";
                searchPanel.Visible = true;
            }
            else
            {
                showSearchButton.Text = "Search ▼";
                searchPanel.Visible = false;
            }
        }

        private void InitializeSearchComboBoxes()
        {
            InitializeSearchUserIDCB();
            InitializeSearchUsernameCB();
            InitializeSearchRoleIDCB();
        }

        private void InitializeSearchRoleIDCB()
        {
            List<string> roleIDList = _usersRepository.GetColumnData("Users", "RoleID");
            roleIDToolStripComboBox.Items.Clear();
            foreach (string items in roleIDList)
            {
                if (!roleIDToolStripComboBox.Items.Contains(items))
                {
                    roleIDToolStripComboBox.Items.Add(items);
                }
            }
        }

        private void InitializeSearchUsernameCB()
        {
            List<string> usernameList = _usersRepository.GetColumnData("Users", "Username");
            usernameToolStripComboBox.Items.Clear();
            foreach (string items in usernameList)
            {
                if (!usernameToolStripComboBox.Items.Contains(items))
                {
                    usernameToolStripComboBox.Items.Add(items);
                }
            }
        }

        private void InitializeSearchUserIDCB()
        {
            List<string> userIDList = _usersRepository.GetColumnData("Users", "UserID");
            userIDToolStripComboBox.Items.Clear();
            userIDToolStripComboBox.Items.AddRange(userIDList.ToArray());
        }

        private void searchToolStripButton_Click(object sender, EventArgs e) => searchUsers();
        private void OnSearchToolStripTextChanged(object sender, EventArgs e) => searchUsers();

        private void searchUsers()
        {
            try
            {
                this.usersTableAdapter.Search(this.sTU_DBDataSet.Users, userIDToolStripComboBox.Text, usernameToolStripComboBox.Text, roleIDToolStripComboBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void usersDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int columnToMaskIndex = 2; 
            string columnToMaskName = "Password"; 

            if (usersDataGridView.Columns[e.ColumnIndex].Index == columnToMaskIndex ||
                usersDataGridView.Columns[e.ColumnIndex].Name == columnToMaskName)
            {
                if (e.Value != null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                }
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            usersDataGridView.Enabled = false;
            bindingNavigatorCancelItem.Enabled = true;

            string userID = generateUserID();
            userIDTextBox.Text = userID;
            usernameTextBox.ReadOnly = false;
            passwordTextBox.ReadOnly = false;
            passwordTextBox.UseSystemPasswordChar = false;
            emailTextBox.ReadOnly = false;
        }

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            usersDataGridView.Enabled = true;

            usernameTextBox.ReadOnly = true;
            passwordTextBox.ReadOnly = true;
            passwordTextBox.UseSystemPasswordChar = true;
            emailTextBox.ReadOnly = true;

            bindingNavigatorCancelItem.Enabled = false;
            bindingNavigatorRefreshItem.PerformClick();
        }

        private string generateUserID()
        {
            int userCount = _usersRepository.GenerateUserCode();
            string userID = string.Empty;

            if (userCount < 10)
            {
                userID = "U000" + userCount.ToString();
            }
            else if (userCount >= 10 && userCount < 100)
            {
                userID = "U00" + userCount.ToString();
            }
            else if (userCount >= 100 && userCount < 1000)
            {
                userID = "U0" + userCount.ToString();
            }
            else if (userCount >= 1000)
            {
                userID = "U" + userCount.ToString();
            }

            return userID;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                bindingNavigatorRefreshItem.PerformClick();
                return;
            }

        }
    }
}
