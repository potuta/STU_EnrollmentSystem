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
    public partial class frmGradeLevel : Form
    {
        private GradeLevelRepository _gradeLevelRepository;

        public frmGradeLevel()
        {
            InitializeComponent();
            _gradeLevelRepository = new GradeLevelRepository(ConnectionFactory.GetConnectionString());
            this.tableAdapterManager.Connection.ConnectionString = ConnectionFactory.GetConnectionString();
        }

        private void gradeLevelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gradeLevelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTU_DBDataSet);
        }

        private void frmGradeLevel_Load(object sender, EventArgs e)
        {
            this.gradeLevelTableAdapter.Fill(this.sTU_DBDataSet.GradeLevel);
            searchPanel.Visible = false;
            InitializeSearchComboBoxes();
            InitializeUserRolePrivileges();
        }

        private void InitializeUserRolePrivileges()
        {
            if (!frmLogin.Role.Equals("Administrator"))
            {
                bindingNavigatorAddNewItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
                gradeLevelBindingNavigatorSaveItem.Enabled = false;
            }
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            this.gradeLevelTableAdapter.Fill(this.sTU_DBDataSet.GradeLevel);
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
            InitializeSearchGradeLevelCB();
            InitializeSearchGradeCodeCB();
            InitializeSearchSubjectGradeCodeCB();
        }

        private void InitializeSearchSubjectGradeCodeCB()
        {
            List<string> subjectGradeCodeList = _gradeLevelRepository.GetColumnData("GradeLevel", "SubjectGradeCode");
            subjectGradeCodeList.Sort();
            subjectGradeCodeToolStripComboBox.Items.Clear();
            subjectGradeCodeToolStripComboBox.Items.AddRange(subjectGradeCodeList.ToArray());
        }

        private void InitializeSearchGradeCodeCB()
        {
            List<string> gradeCodeList = _gradeLevelRepository.GetColumnData("GradeLevel", "GradeCode");
            gradeCodeList.Sort();
            gradeCodeToolStripComboBox.Items.Clear();
            gradeCodeToolStripComboBox.Items.AddRange(gradeCodeList.ToArray());
        }

        private void InitializeSearchGradeLevelCB()
        {
            List<string> gradeLevelList = _gradeLevelRepository.GetColumnData("GradeLevel", "GradeLevel");
            gradeLevelList.Sort();
            gradeLevelToolStripComboBox.Items.Clear();
            gradeLevelToolStripComboBox.Items.AddRange(gradeLevelList.ToArray());
        }

        private void searchToolStripButton_Click(object sender, EventArgs e) => searchGradeLevel();
        private void OnSearchToolStripTextChanged(object sender, EventArgs e) => searchGradeLevel();

        private void searchGradeLevel()
        {
            try
            {
                this.gradeLevelTableAdapter.Search(this.sTU_DBDataSet.GradeLevel, gradeLevelToolStripComboBox.Text, gradeCodeToolStripComboBox.Text, subjectGradeCodeToolStripComboBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void viewSubjectButton_Click(object sender, EventArgs e)
        {
            if (subjectDataGridView.Visible == true)
            {
                subjectDataGridView.Visible = false;
                return;
            }

            subjectDataGridView.Visible = true;
            DataTable dataTable = new SubjectsRepository(ConnectionFactory.GetConnectionString()).GetSubjectsDataTableFromSubjectGradeCode(subjectGradeCodeTextBox.Text);
            subjectDataGridView.DataSource = dataTable;
        }
    }
}
