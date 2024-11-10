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
    public partial class frmSettings : Form
    {
        private DatabaseManager _databaseManager;
        private List<RadioButton> schoolYearRadioButtonsList;

        public frmSettings()
        {
            InitializeComponent();
            _databaseManager = new DatabaseManager(Properties.Settings.Default.STU_DBConnectionString);
            schoolYearRadioButtonsList = new List<RadioButton>();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> databases = _databaseManager.GetDatabaseConnectionStrings();
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
            newButton.Font = originalButton.Font;
            newButton.Enabled = originalButton.Enabled;
            newButton.Visible = originalButton.Visible;
            newButton.FlatStyle = originalButton.FlatStyle;
            newButton.TextAlign = originalButton.TextAlign;
            newButton.Visible = true;

            schoolYearRadioButtonsList.Add(newButton);
            return newButton;
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
            throw new NotImplementedException();
        }

        private void deleteSchoolYear()
        {
            throw new NotImplementedException();
        }

        private void addSchoolYear()
        {
            throw new NotImplementedException();
        }

    }
}
