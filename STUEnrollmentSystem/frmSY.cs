using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUEnrollmentSystem
{
    public partial class frmSY : Form
    {
        private DatabaseManager _databaseManager;
        private Dictionary<string, RadioButton> schoolYearRadioButtonsList;

        public frmSY()
        {
            InitializeComponent();
            _databaseManager = new DatabaseManager(ConnectionFactory.GetConnectionString());
            schoolYearRadioButtonsList = new Dictionary<string, RadioButton>();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            updateDatabaseListFromPanel();
        }

        private void updateDatabaseListFromPanel()
        {
            Dictionary<string, string> databases = _databaseManager.GetDatabaseConnectionStrings();
            flowLayoutPanel1.Controls.Clear();
            schoolYearRadioButtonsList.Clear();
            foreach (string name in databases.Keys)
            {
                flowLayoutPanel1.Controls.Add(cloneButton(currentYearRadioButton, getButtonText(name), name));
            }
        }

        private string getButtonText(string name)
        {
            string buttonName = string.Empty;
            if (name == "STU_DB")
            {
                buttonName = "Current year";
            }
            else
            {
                string[] nameParts = name.Split('_');
                string[] years = { nameParts[2], nameParts[3] };
                buttonName = string.Join("-", years);
            }
            return buttonName;
        }

        private RadioButton cloneButton(RadioButton originalButton, string text, string name)
        {
            RadioButton newButton = new RadioButton();

            newButton.Text = text;
            newButton.Name = name;
            newButton.Size = originalButton.Size;
            newButton.BackColor = originalButton.BackColor;
            newButton.ForeColor = originalButton.ForeColor;
            newButton.Font = originalButton.Font;
            newButton.Enabled = originalButton.Enabled;
            newButton.Visible = originalButton.Visible;
            newButton.FlatStyle = originalButton.FlatStyle;
            newButton.TextAlign = originalButton.TextAlign;
            newButton.Visible = true;
            newButton.AutoCheck = false;
            newButton.Click += SYButton_Click_EventHandler;
            newButton.CheckedChanged += SYButton_CheckedChanged_EventHandler;

            schoolYearRadioButtonsList[newButton.Name] = newButton;
            return schoolYearRadioButtonsList[newButton.Name];
        }

        private void SYButton_CheckedChanged_EventHandler(object sender, EventArgs e)
        {
            RadioButton button = sender as RadioButton;
            if (button.Checked == true)
            {
                if (button.Name == "STU_DB")
                {
                    schoolYearLabel.Text = $"{button.Text} ({button.Name}: {frmSTU_Dashboard.Instance.SchoolYearLabel.Text})";
                }
                else
                {
                    schoolYearLabel.Text = $"{button.Text} ({button.Name})";
                }
            }
            else
            {
                schoolYearLabel.Text = "---------------";
            }
        }

        private void SYButton_Click_EventHandler(object sender, EventArgs e)
        {
            RadioButton button = sender as RadioButton;

            if (button.Checked == true)
            {
                button.Checked = false;
            }
            else
            {
                button.Checked = true;
            }
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            if (sender == addSchoolYearButton)
            {
                addSchoolYear();
            }
            else if (sender == deleteSchoolYearButton)
            {
                deleteSchoolYear();
            }
            else if (sender == selectSchoolYearButton)
            {
                selectSchoolYear();
            }
        }

        private void selectSchoolYear()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to select this school year database?", "Select school year", MessageBoxButtons.YesNo);

            if (dialogResult != DialogResult.Yes)
            {
                return;
            }

            foreach (string name in schoolYearRadioButtonsList.Keys)
            {
                if (schoolYearRadioButtonsList[name].Checked == true)
                {
                    if (ConnectionFactory.GetConnectionString() != ConnectionFactory.GetNewDestinationString(name))
                    {
                        LoggingService.LogInformation($"Database selection attempt in selectSchoolYear: DBName: {name}");
                        Dictionary<string, string> databases = _databaseManager.GetDatabaseConnectionStrings();
                        ConnectionFactory.SetConnectionString(databases[name]);
                        this.Enabled = false;
                        MessageBox.Show($"Successfully selected school year database '{name} ({schoolYearRadioButtonsList[name].Text})'", "Success", MessageBoxButtons.OK);
                        LoggingService.LogInformation($"Database selection successful in selectSchoolYear: DBName: {name}");
                        this.Enabled = true;
                        break;
                    }
                    MessageBox.Show($"School year database '{name} ({schoolYearRadioButtonsList[name].Text})' is already selected", "Notice", MessageBoxButtons.OK);
                }
            }

            frmSTU_Dashboard.Instance.InitializeSelectedSchoolYear();
        }

        private void deleteSchoolYear()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this school year database?", "Delete school year", MessageBoxButtons.YesNo);

            if (dialogResult != DialogResult.Yes)
            {
                return;
            }

            foreach (string name in schoolYearRadioButtonsList.Keys)
            {
                if (schoolYearRadioButtonsList[name].Checked == true)
                {
                    if (ConnectionFactory.GetConnectionString() == ConnectionFactory.GetNewDestinationString(name))
                    {
                        MessageBox.Show($"Cannot delete the school year database you're currently using '{name} ({schoolYearRadioButtonsList[name].Text})'", "Error", MessageBoxButtons.OK);
                        return;
                    }

                    if (schoolYearRadioButtonsList[name].Name == "STU_DB")
                    {
                        MessageBox.Show($"You're not allowed to delete the current school year database '{name} ({schoolYearRadioButtonsList[name].Text})'. Please make sure it is unselected.", "Error", MessageBoxButtons.OK);
                        return;
                    }

                    _databaseManager.DeleteDatabase(name);
                    MessageBox.Show($"Successfully deleted school year database: '{name} ({schoolYearRadioButtonsList[name].Text})'");
                }
            }

            updateDatabaseListFromPanel();
        }

        private void addSchoolYear()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to add a new school year database?", "Add school year", MessageBoxButtons.YesNo);

            if (dialogResult != DialogResult.Yes)
            {
                return;
            }

            if (!ConnectionFactory.GetSelectedDatabaseInConnectionString(ConnectionFactory.GetConnectionString()).Equals("STU_DB"))
            {
                MessageBox.Show($"Please use the Current School Year to add new databases.", "Error", MessageBoxButtons.OK);
                return;
            }

            string originalDbName = "STU_DB";
            string newDbName = generateNewDatabaseName(originalDbName);

            //Dictionary<string, string> databases = _databaseManager.GetDatabaseConnectionStrings();
            //foreach (string name in databases.Keys)
            //{
            //    if (name == newDbName)
            //    {
            //        MessageBox.Show($"Database {newDbName} has already been created.", "Error", MessageBoxButtons.OK);
            //        return;
            //    }
            //}

            _databaseManager.DuplicateDatabase(originalDbName, newDbName);
            _databaseManager.UpdateDatabaseDataForSY(ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
            updateDatabaseListFromPanel();
            MessageBox.Show($"Successfully created database school year: '{newDbName}'");
        }

        private string generateNewDatabaseName(string originalDbName)
        {
            Dictionary<string, string> databases = _databaseManager.GetDatabaseConnectionStrings();
            List<int> dbPreviousYearList = new List<int>();
            List<int> dbNextYearList = new List<int>();
            string newYear = string.Empty;

            foreach (string name in databases.Keys)
            {
                if (name.Contains("2"))
                {
                    string[] nameParts = name.Split('_');
                    dbPreviousYearList.Add(Convert.ToInt32(nameParts[2]));
                    dbNextYearList.Add(Convert.ToInt32(nameParts[3]));
                }
                else
                {
                    dbPreviousYearList.Add(DateTime.Now.Year - 1);
                    dbNextYearList.Add(DateTime.Now.Year);
                }
            }

            if (databases.Count == 1)
            {
                newYear = $"{dbPreviousYearList.Max()}_{dbNextYearList.Max()}";
            }
            else
            {
                newYear = $"{dbPreviousYearList.Max() + 1}_{dbNextYearList.Max() + 1}";
            }

            string newDbName = $"{originalDbName}_{newYear}";
            return newDbName;
        }
    }
}
