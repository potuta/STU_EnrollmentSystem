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
    public partial class frmTeacher : Form
    {
        private TeacherRepository _teacherRepository;

        public frmTeacher()
        {
            InitializeComponent();
            _teacherRepository = new TeacherRepository(ConnectionFactory.GetConnectionString());
            this.tableAdapterManager.Connection.ConnectionString = ConnectionFactory.GetConnectionString();
        }

        private void teachersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teachersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTU_DBDataSet);
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            this.subjectsTableAdapter.Fill(this.sTU_DBDataSet.Subjects);
            this.teachersTableAdapter.Fill(this.sTU_DBDataSet.Teachers);
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
            this.teachersTableAdapter.Update(sTU_DBDataSet);
            this.teachersTableAdapter.Fill(sTU_DBDataSet.Teachers);
            InitializeSearchComboBoxes();
        }

        private void teachersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                InitializeSectionCB();
            }
            catch (FormatException fe)
            {
                _teacherRepository.CloseConnection();
                return;
            }
            catch (NullReferenceException nre)
            {
                _teacherRepository.CloseConnection();
                return;
            }
        }

        private void InitializeSearchComboBoxes()
        {
            InitializeSearchTeacherNameCB();
            InitializeSearchTeacherCodeCB();
            InitializeSearchSectionCodeCB();
            InitializeSearchSubjectCodeCB();
        }

        private void InitializeSearchTeacherNameCB()
        {
            List<string> teacherNumberList = _teacherRepository.GetColumnData("Teachers", "TeacherName");
            teacherNumberList.Sort();
            teacherNameToolStripComboBox.Items.Clear();
            teacherNameToolStripComboBox.Items.AddRange(teacherNumberList.ToArray());
        }

        private void InitializeSearchTeacherCodeCB()
        {
            List<string> teacherCodeList = _teacherRepository.GetColumnData("Teachers", "TeacherCode");
            teacherCodeList.Sort();
            teacherCodeToolStripComboBox.Items.Clear();
            teacherCodeToolStripComboBox.Items.AddRange(teacherCodeList.ToArray());
        }

        private void InitializeSearchSectionCodeCB()
        {
            List<string> sectionCodeList = _teacherRepository.GetColumnData("Teachers", "SectionCode");
            sectionCodeList.Sort();
            sectionCodeToolStripComboBox.Items.Clear();
            foreach(string items in sectionCodeList)
            {
                if (!sectionCodeToolStripComboBox.Items.Contains(items))
                {
                    sectionCodeToolStripComboBox.Items.Add(items);
                }
            }
        }

        private void InitializeSearchSubjectCodeCB()
        {
            List<string> subjectCodeList = _teacherRepository.GetColumnData("Teachers", "SubjectCode");
            subjectCodeList.Sort();
            subjectCodeToolStripComboBox.Items.Clear();
            foreach (string items in subjectCodeList)
            {
                if (!subjectCodeToolStripComboBox.Items.Contains(items))
                {
                    subjectCodeToolStripComboBox.Items.Add(items);
                }
            }
        }

        private void InitializeSectionCB()
        {
            List<string> sectionCodeList = new SectionRepository(ConnectionFactory.GetConnectionString()).GetColumnData("Sections", "SectionCode");
            sectionCodeList.Sort();
            sectionCodeComboBox.Items.Clear();
            sectionCodeComboBox.Items.AddRange(sectionCodeList.ToArray());
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

        private void generateTeacherCodeButton_Click(object sender, EventArgs e)
        {
            int teacherCode = _teacherRepository.GenerateTeacherCode();

            if (teacherCode < 10)
            {
                teacherCodeTextBox.Text = "T000" + teacherCode.ToString();
            }
            else if (teacherCode >= 10 && teacherCode < 100)
            {
                teacherCodeTextBox.Text = "T00" + teacherCode.ToString();
            }
            else if (teacherCode >= 100 && teacherCode < 1000)
            {
                teacherCodeTextBox.Text = "T0" + teacherCode.ToString();
            }
            else if (teacherCode >= 1000)
            {
                teacherCodeTextBox.Text = "T" + teacherCode.ToString();
            }
        }

        private void searchTeachersToolStripButton_Click(object sender, EventArgs e) => searchTeacher();
        private void OnSearchToolStripTextChanged(object sender, EventArgs e) => searchTeacher();

        private void searchTeacher()
        {
            try
            {
                this.teachersTableAdapter.SearchTeachers(this.sTU_DBDataSet.Teachers, teacherNameToolStripComboBox.Text, teacherCodeToolStripComboBox.Text, sectionCodeToolStripComboBox.Text, subjectCodeToolStripComboBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
