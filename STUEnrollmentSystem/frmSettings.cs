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
    public partial class frmSettings : Form
    {
        private DatabaseManager _databaseManager;
        private Dictionary<string, RadioButton> schoolYearRadioButtonsList;

        public frmSettings()
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

            schoolYearRadioButtonsList[newButton.Name] = newButton;
            return schoolYearRadioButtonsList[newButton.Name];
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
                        Dictionary<string, string> databases = _databaseManager.GetDatabaseConnectionStrings();
                        ConnectionFactory.SetConnectionString(databases[name]);
                        this.Enabled = false;
                        MessageBox.Show($"Successfully selected school year database '{name} ({schoolYearRadioButtonsList[name].Text})'", "Success", MessageBoxButtons.OK);
                        this.Enabled = true;
                        break;
                    }
                    MessageBox.Show($"School year database '{name} ({schoolYearRadioButtonsList[name].Text})' is already selected", "Notice", MessageBoxButtons.OK);
                }
            }
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
                    if (schoolYearRadioButtonsList[name].Name == "STU_DB")
                    {
                        MessageBox.Show($"Cannot delete school year database '{name} ({schoolYearRadioButtonsList[name].Text})'. Please make sure it is unselected.", "Error", MessageBoxButtons.OK);
                        break;
                    }
                    _databaseManager.DeleteDatabase(name);
                    MessageBox.Show($"Successfully deleted school year database: '{name} ({schoolYearRadioButtonsList[name].Text})'");
                    schoolYearRadioButtonsList.Remove(name);
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

            string originalDbName = "STU_DB";
            string newDbName = generateNewDatabaseName(originalDbName);
            _databaseManager.DuplicateDatabase(originalDbName, newDbName);
            updateDatabaseListFromPanel();
            MessageBox.Show($"Successfully created database school year: '{newDbName}'");
        }

        private string generateNewDatabaseName(string originalDbName)
        {
            Dictionary<string, string> databases = _databaseManager.GetDatabaseConnectionStrings();
            List<int> dbPreviousYearList = new List<int>();
            List<int> dbNextYearList = new List<int>();

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

            string newYear = $"{dbPreviousYearList.Max() + 1}_{dbNextYearList.Max() + 1}";
            string newDbName = $"{originalDbName}_{newYear}";
            return newDbName;
        }
    }
}
