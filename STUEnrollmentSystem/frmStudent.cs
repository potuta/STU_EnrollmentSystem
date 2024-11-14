﻿using System;
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
            _studentRepository = new StudentRepository(ConnectionFactory.GetConnectionString());
            this.tableAdapterManager.Connection.ConnectionString = ConnectionFactory.GetConnectionString();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            birthDateTextBox.Text = birthDateTimePicker.Value.Date.ToShortDateString();
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTU_DBDataSet);
        }

        private void Student_Load(object sender, EventArgs e)
        {
            this.gradeLevelTableAdapter.Fill(this.sTU_DBDataSet.GradeLevel);
            this.sectionsTableAdapter.Fill(this.sTU_DBDataSet.Sections);
            this.studentsTableAdapter.Fill(this.sTU_DBDataSet.Students);
            searchPanel.Visible = false;
            InitializeSearchComboBoxes();
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter.Update(sTU_DBDataSet);
            this.studentsTableAdapter.Fill(sTU_DBDataSet.Students);
            InitializeSearchComboBoxes();
        }

        private void InitializeSearchComboBoxes()
        {
            InitializeSearchStudentNumberCB();
            InitializeSearchStudFirstName();
            InitializeSearchStudMidNameCB();
            InitializeSearchStudLastNameCB();
        }

        private void InitializeSearchStudLastNameCB()
        {
            List<string> studLastNameList = _studentRepository.GetColumnData("Students", "StudLastName");
            studLastNameList.Sort();
            studLastNameToolStripComboBox.Items.Clear();
            foreach (string items in studLastNameList)
            {
                if (!studLastNameToolStripComboBox.Items.Contains(items))
                {
                    studLastNameToolStripComboBox.Items.Add(items);
                }
            }
        }

        private void InitializeSearchStudMidNameCB()
        {
            List<string> studMidNameList = _studentRepository.GetColumnData("Students", "StudMidName");
            studMidNameList.Sort();
            studMidNameToolStripComboBox.Items.Clear();
            foreach (string items in studMidNameList)
            {
                if (!studMidNameToolStripComboBox.Items.Contains(items))
                {
                    studMidNameToolStripComboBox.Items.Add(items);
                }
            }
        }

        private void InitializeSearchStudFirstName()
        {
            List<string> studFirstNameList = _studentRepository.GetColumnData("Students", "StudFirstName");
            studFirstNameToolStripComboBox.Items.Clear();
            foreach (string items in studFirstNameList)
            {
                if (!studFirstNameToolStripComboBox.Items.Contains(items))
                {
                    studFirstNameToolStripComboBox.Items.Add(items);
                }
            }
        }

        private void InitializeSearchStudentNumberCB()
        {
            List<string> studentNumberList = _studentRepository.GetColumnData("Students", "StudentNumber");
            studentNumberToolStripComboBox.Items.Clear();
            studentNumberToolStripComboBox.Items.AddRange(studentNumberList.ToArray());
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
            switch (enrollmentType)
            {
                case "Grade 7":
                    gradeCode = "G7";
                    break;
                case "Grade 8":
                    gradeCode = "G8";
                    break;
                case "Grade 9":
                    gradeCode = "G9";
                    break;
                case "Grade 10":
                    gradeCode = "G10";
                    break;
            }
            return gradeCode;
        }

        private void checkForRequirements()
        {
            try
            {
                var requirements = _studentRepository.CheckStudentRequirements(studentNumberTextBox.Text);

                SetRequirementButtonState(viewFrm137Button, uploadFrm137Button, deleteFrm137Button, requirements["StudForm137"]);
                SetRequirementButtonState(viewGoodMoralButton, uploadGoodMoralButton, deleteGoodMoralButton, requirements["GoodMoral"]);
                SetRequirementButtonState(viewBirthCertButton, uploadBirthCertButton, deleteBirthCertButton, requirements["BirthCertificate"]);
                SetRequirementButtonState(viewTransferCertButton, uploadTransferCertButton, deleteTransferCertButton, requirements["TransferCertificate"]);

                if (!sectionComboBox.Text.Equals(string.Empty))
                {
                    viewRAFButton.Visible = true;
                }
                else
                {
                    viewRAFButton.Visible = false;
                }

            }
            catch (KeyNotFoundException knfe)
            {
                _studentRepository.CloseConnection();
                hideRequirementButtons();
                return;
            }
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
            viewRAFButton.Visible = false;
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
        private void viewRAFButton_Click(object sender, EventArgs e)
        {
            frmPDFRAF pdfRAF = new frmPDFRAF(studentNumberTextBox.Text, getGradeCode(enrollmentTypeComboBox.Text), sectionComboBox.Text);
            pdfRAF.Show();
        }

        private void HandleFileOperation(string fileType, string operation)
        {
            openFileDialog1.Filter = "PDF Files|*.pdf";
            switch (operation)
            {
                case "view":
                    _studentRepository.ViewPDFFile("Students", fileType, "StudentNumber", studentNumberTextBox.Text);
                    break;
                case "upload":
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        byte[] fileData = File.ReadAllBytes(openFileDialog1.FileName);
                        _studentRepository.UploadFile("Students", fileType, "StudentNumber", studentNumberTextBox.Text, fileData);
                    }
                    break;
                case "delete":
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this file?", "Delete file", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        _studentRepository.DeleteFile("Students", fileType, "StudentNumber", studentNumberTextBox.Text);
                        break;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    break;
            }
        }

        private void bindingNavigatorTotalStudentsItem_Click(object sender, EventArgs e)
        {
            ShowTotalStudentsDataGridView();
            DataTable dt = _studentRepository.GetTotalEnrolledStudentsByGrade();
            totalEnrolledStudentsGridView.DataSource = dt;
        }

        private void ShowTotalStudentsDataGridView()
        {
            if (totalEnrolledStudentsGridView.Visible == true)
            {
                totalEnrolledStudentsGridView.Visible = false;
                studentsDataGridView.Visible = true;
                bindingNavigatorDeleteItem.Enabled = true;
                bindingNavigatorAddNewItem.Enabled = true;
                studentsBindingNavigatorSaveItem.Enabled = true;
                bindingNavigatorRefreshItem.Enabled = true;
            }
            else
            {
                totalEnrolledStudentsGridView.Visible = true;
                studentsDataGridView.Visible = false;
                bindingNavigatorDeleteItem.Enabled = false;
                bindingNavigatorAddNewItem.Enabled = false;
                studentsBindingNavigatorSaveItem.Enabled = false;
                bindingNavigatorRefreshItem.Enabled = false;
            }
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e) => searchStudents();
        private void OnSearchToolStripTextChanged(object sender, EventArgs e) => searchStudents();

        private void searchStudents()
        {
            try
            {
                this.studentsTableAdapter.FillBy1(this.sTU_DBDataSet.Students, studentNumberToolStripComboBox.Text, studFirstNameToolStripComboBox.Text, studMidNameToolStripComboBox.Text, studLastNameToolStripComboBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

    }
}
