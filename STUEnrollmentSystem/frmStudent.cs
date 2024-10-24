using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUEnrollmentSystem
{
    public partial class frmStudent : Form
    {
        private StudentRepository _studentRepository;

        public frmStudent()
        {
            InitializeComponent();
            _studentRepository = new StudentRepository(Properties.Settings.Default.STU_DBConnectionString);
        }

        private void Student_Load(object sender, EventArgs e)
        {
            this.gradeLevelTableAdapter.Fill(this.sTU_DBDataSet.GradeLevel);
            this.sectionsTableAdapter.Fill(this.sTU_DBDataSet.Sections);
            this.studentsTableAdapter.Fill(this.sTU_DBDataSet.Students);
            searchPanel.Visible = false;
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            birthDateTextBox.Text = birthDateTimePicker.Value.Date.ToShortDateString();
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTU_DBDataSet);
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

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter.Update(sTU_DBDataSet);
            this.studentsTableAdapter.Fill(sTU_DBDataSet.Students);
        }

        private void studentsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                birthDateTimePicker.Text = birthDateTextBox.Text;
                InitializeSectionCB();
                checkForRequirements();
            }
            catch (FormatException fe)
            {
                _studentRepository.CloseConnection();
                hideRequirementButtons();
                return;
            }
            catch(NullReferenceException nfe)
            {
                _studentRepository.CloseConnection();
                hideRequirementButtons();
                return;
            }
        }

        private void InitializeSectionCB()
        {
            string gradeCode = getGradeCode(enrollmentTypeComboBox.Text);
            List<string> sections = _studentRepository.GetSectionsByGrade(gradeCode);
            sectionComboBox.Items.Clear();
            sectionComboBox.Items.AddRange(sections.ToArray());
        }

        private string getGradeCode(string enrollmentType)
        {
            string gradeCode = string.Empty;
            if (enrollmentType.Equals("Grade 7"))
            {
                gradeCode = "G7";
            }
            else if (enrollmentType.Equals("Grade 8"))
            {
                gradeCode = "G8";
            }
            else if (enrollmentType.Equals("Grade 9"))
            {
                gradeCode = "G9";
            }
            else if (enrollmentType.Equals("Grade 10"))
            {
                gradeCode = "G10";
            }
            return gradeCode;
        }

        private void checkForRequirements()
        {
            var requirements = _studentRepository.CheckStudentRequirements(studentNumberTextBox.Text);

            SetRequirementButtonState(viewFrm137Button, uploadFrm137Button, deleteFrm137Button, requirements["StudForm137"]);
            SetRequirementButtonState(viewGoodMoralButton, uploadGoodMoralButton, deleteGoodMoralButton, requirements["GoodMoral"]);
            SetRequirementButtonState(viewBirthCertButton, uploadBirthCertButton, deleteBirthCertButton, requirements["BirthCertificate"]);
            SetRequirementButtonState(viewTransferCertButton, uploadTransferCertButton, deleteTransferCertButton, requirements["TransferCertificate"]);
        }

        private void SetRequirementButtonState(Button viewButton, Button uploadButton, Button deleteButton, bool hasRequirement)
        {
            if (hasRequirement)
            {
                viewButton.Visible = true;
                deleteButton.Visible = true;
                uploadButton.Visible = false;
            }
            else
            {
                viewButton.Visible = false;
                deleteButton.Visible = false;
                uploadButton.Visible = true;
            }
        }

        private void hideRequirementButtons()
        {
            viewFrm137Button.Visible = false;
            deleteFrm137Button.Visible = false;
            uploadFrm137Button.Visible = false;
            viewGoodMoralButton.Visible = false;
            deleteGoodMoralButton.Visible = false;
            uploadGoodMoralButton.Visible = false;
            viewBirthCertButton.Visible = false;
            deleteBirthCertButton.Visible = false;
            uploadBirthCertButton.Visible = false;
            viewTransferCertButton.Visible = false;
            deleteTransferCertButton.Visible = false;
            uploadTransferCertButton.Visible = false;
        }

        private void viewFrm137Button_Click(object sender, EventArgs e) => HandleFileOperation("StudForm137", "view");
        private void uploadFrm137Button_Click(object sender, EventArgs e) => HandleFileOperation("StudForm137", "upload");
        private void deleteFrm137Button_Click(object sender, EventArgs e) => HandleFileOperation("StudForm137", "delete");
        private void viewGoodMoralButton_Click(object sender, EventArgs e) => HandleFileOperation("GoodMoral", "view");
        private void uploadGoodMoralButton_Click(object sender, EventArgs e) => HandleFileOperation("GoodMoral", "upload");
        private void deleteGoodMoralButton_Click(object sender, EventArgs e) => HandleFileOperation("GoodMoral", "delete");
        private void viewBirthCertButton_Click(object sender, EventArgs e) => HandleFileOperation("BirthCertificate", "view");
        private void uploadBirthCertButton_Click(object sender, EventArgs e) => HandleFileOperation("BirthCertificate", "upload");
        private void deleteBirthCertButton_Click(object sender, EventArgs e) => HandleFileOperation("BirthCertificate", "delete");
        private void viewTransferCertButton_Click(object sender, EventArgs e) => HandleFileOperation("TransferCertificate", "view");
        private void uploadTransferCertButton_Click(object sender, EventArgs e) => HandleFileOperation("TransferCertificate", "upload");
        private void deleteTransferCertButton_Click(object sender, EventArgs e) => HandleFileOperation("TransferCertificate", "delete");

        private void HandleFileOperation(string fileType, string operation)
        {
            openFileDialog1.Filter = "PDF Files|*.pdf";
            switch (operation)
            {
                case "view":
                    _studentRepository.ViewFile(fileType, studentNumberTextBox.Text);
                    break;
                case "upload":
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        byte[] fileData = File.ReadAllBytes(openFileDialog1.FileName);
                        _studentRepository.UploadFile(fileType, studentNumberTextBox.Text, fileData);
                    }
                    break;
                case "delete":
                    _studentRepository.DeleteFile(fileType, studentNumberTextBox.Text);
                    break;
            }
        }

        private void bindingNavigatorTotalStudentsItem_Click(object sender, EventArgs e)
        {
            ShowTotalStudentsDataGridView();
            DataTable dt = _studentRepository.GetTotalEnrolledStudentsByGrade();
            dataGridView1.DataSource = dt;
        }

        private void ShowTotalStudentsDataGridView()
        {
            if (dataGridView1.Visible == true)
            {
                dataGridView1.Visible = false;
                studentsDataGridView.Visible = true;
                bindingNavigatorDeleteItem.Enabled = true;
                bindingNavigatorAddNewItem.Enabled = true;
                studentsBindingNavigatorSaveItem.Enabled = true;
                bindingNavigatorRefreshItem.Enabled = true;
            }
            else
            {
                dataGridView1.Visible = true;
                studentsDataGridView.Visible = false;
                bindingNavigatorDeleteItem.Enabled = false;
                bindingNavigatorAddNewItem.Enabled = false;
                studentsBindingNavigatorSaveItem.Enabled = false;
                bindingNavigatorRefreshItem.Enabled = false;
            }
        }
    }
}
