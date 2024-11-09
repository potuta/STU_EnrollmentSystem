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

        public frmSettings()
        {
            InitializeComponent();
            _databaseManager = new DatabaseManager(Properties.Settings.Default.STU_DBConnectionString);
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
