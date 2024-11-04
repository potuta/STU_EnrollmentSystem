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
    public partial class frmSubjects : Form
    {
        private SubjectsRepository _subjectsRepository;

        public frmSubjects()
        {
            InitializeComponent();
            _subjectsRepository = new SubjectsRepository(Properties.Settings.Default.STU_DBConnectionString);
        }

        private void subjectsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.subjectsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTU_DBDataSet);
        }

        private void frmSubject_Load(object sender, EventArgs e)
        {
            this.subjectsTableAdapter.Fill(this.sTU_DBDataSet.Subjects);
            searchPanel.Visible = false;
            InitializeSearchComboBoxes();
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            this.subjectsTableAdapter.Update(sTU_DBDataSet);
            this.subjectsTableAdapter.Fill(sTU_DBDataSet.Subjects);
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
            InitializeSearchSubjectTitleCB();
            InitializeSearchSubjectCodeCB();
            InitializeSearchSubjectGradeCodeCB();
        }

        private void InitializeSearchSubjectGradeCodeCB()
        {
            List<string> subjectGradeCodeList = _subjectsRepository.GetColumnData("Subjects", "SubjectGradeCode");
            subjectGradeCodeToolStripComboBox.Items.Clear();
            foreach (string items in subjectGradeCodeList)
            {
                if (!subjectGradeCodeToolStripComboBox.Items.Contains(items))
                {
                    subjectGradeCodeToolStripComboBox.Items.Add(items);
                }
            }
        }

        private void InitializeSearchSubjectCodeCB()
        {
            List<string> subjectCodeList = _subjectsRepository.GetColumnData("Subjects", "SubjectCode");
            subjectCodeToolStripComboBox.Items.Clear();
            subjectCodeToolStripComboBox.Items.AddRange(subjectCodeList.ToArray());
        }

        private void InitializeSearchSubjectTitleCB()
        {
            List<string> subjectTitleList = _subjectsRepository.GetColumnData("Subjects", "SubjectTitle");
            subjectTitleToolStripComboBox.Items.Clear();
            subjectTitleToolStripComboBox.Items.AddRange(subjectTitleList.ToArray());
        }

        private void subjectTitleToolStripComboBox_TextChanged(object sender, EventArgs e) => searchSubjects();
        private void subjectCodeToolStripComboBox_TextChanged(object sender, EventArgs e) => searchSubjects();
        private void subjectGradeCodeToolStripComboBox_TextChanged(object sender, EventArgs e) => searchSubjects();
        private void searchToolStripButton_Click(object sender, EventArgs e) => searchSubjects();

        private void searchSubjects()
        {
            try
            {
                this.subjectsTableAdapter.Search(this.sTU_DBDataSet.Subjects, subjectTitleToolStripComboBox.Text, subjectCodeToolStripComboBox.Text, subjectGradeCodeToolStripComboBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        
    }
}
