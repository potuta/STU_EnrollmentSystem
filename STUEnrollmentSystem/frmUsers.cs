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
        }

        private void Users_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.sTU_DBDataSet.Users);
            searchPanel.Visible = false;
            InitializeSearchComboBoxes();
            InitializeUserRolePrivileges();
        }

        private void InitializeUserRolePrivileges()
        {
            if (!frmLogin.Role.Equals("Admin"))
            {
                bindingNavigatorDeleteItem.Enabled = false;
            }
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.Update(sTU_DBDataSet);
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
    }
}
