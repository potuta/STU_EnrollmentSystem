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
    public partial class frmDashboardDisplay : Form
    {
        public frmDashboardDisplay()
        {
            InitializeComponent();
        }

        private void frmDashboardDisplay_Load(object sender, EventArgs e)
        {
            DataTable studentsDataTable = new StudentRepository(ConnectionFactory.GetConnectionString()).GetTotalEnrolledStudentsByGrade();
            studentsEnrolledListBox.Items.Clear();
            foreach (DataColumn column in studentsDataTable.Columns)
            {
                foreach (DataRow row in studentsDataTable.Rows)
                {
                    string displayText = $"{column}: {row[column]}";
                    studentsEnrolledListBox.Items.Add(displayText);
                }
            }

            DataTable teachersDataTable = new TeacherRepository(ConnectionFactory.GetConnectionString()).GetTotalTeachersAsDataTable();
            teachersListBox.Items.Clear();
            foreach (DataColumn column in teachersDataTable.Columns)
            {
                foreach (DataRow row in teachersDataTable.Rows)
                {
                    string displayText = $"{column}: {row[column]}";
                    teachersListBox.Items.Add(displayText);
                }
            }

            DataTable earningsDataTable = new BillingReportRepository(ConnectionFactory.GetConnectionString()).GetTotalEarningsAsDataTable();
            earningsListBox.Items.Clear();
            foreach (DataColumn column in earningsDataTable.Columns)
            {
                foreach (DataRow row in earningsDataTable.Rows)
                {
                    string displayText = $"{column}: {row[column]}";
                    earningsListBox.Items.Add(displayText);
                }
            }

        }
    }
}
