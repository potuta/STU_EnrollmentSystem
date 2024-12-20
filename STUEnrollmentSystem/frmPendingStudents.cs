﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUEnrollmentSystem
{
    public partial class frmPendingStudents : Form
    {
        private PendingStudentsRepository _pendingStudentsRepository;

        public frmPendingStudents()
        {
            InitializeComponent();
            _pendingStudentsRepository = new PendingStudentsRepository(ConnectionFactory.GetConnectionString());
            this.tableAdapterManager.Connection.ConnectionString = ConnectionFactory.GetConnectionString();
        }

        private void pendingStudentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pendingStudentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTU_DBDataSet);
            selectCurrentDataGridViewCell();
        }

        private void PendingStudents_Load(object sender, EventArgs e)
        {
            this.pendingStudentsTableAdapter.Fill(this.sTU_DBDataSet.PendingStudents);
            searchPanel.Visible = false;
            InitializeSearchComboBoxes();
            InitializeUserRolePrivileges();
            selectCurrentDataGridViewCell();
        }

        private void InitializeUserRolePrivileges()
        {
            if (!frmLogin.Role.Equals("Administrator"))
            {
                bindingNavigatorDeleteItem.Enabled = false;
            }
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            this.pendingStudentsTableAdapter.Fill(sTU_DBDataSet.PendingStudents);
            InitializeSearchComboBoxes();
            selectCurrentDataGridViewCell();
        }

        private void InitializeSearchComboBoxes()
        {
            InitializeSearchRegisterIDCB();
            InitializeSearchStudentNumberCB();
            InitializeSearchStudFirstNameCB();
            InitializeSearchStudMidNameCB();
            InitializeSearchStudLastNameCB();
        }

        private void InitializeSearchStudLastNameCB()
        {
            List<string> studLastNameList = _pendingStudentsRepository.GetColumnData("PendingStudents", "StudLastName");
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
            List<string> studMidNameList = _pendingStudentsRepository.GetColumnData("PendingStudents", "StudMidName");
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

        private void InitializeSearchStudFirstNameCB()
        {
            List<string> studFirstNameList = _pendingStudentsRepository.GetColumnData("PendingStudents", "StudFirstName");
            studFirstNameList.Sort();
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
            List<string> studentNumberList = _pendingStudentsRepository.GetColumnData("PendingStudents", "StudentNumber");
            studentNumberList.Sort();
            studentNumberToolStripComboBox.Items.Clear();
            studentNumberToolStripComboBox.Items.AddRange(studentNumberList.ToArray());
        }

        private void InitializeSearchRegisterIDCB()
        {
            List<string> regIDList = _pendingStudentsRepository.GetColumnData("PendingStudents", "RegisterID");
            regIDList.Sort();
            registerIDToolStripComboBox.Items.Clear();
            registerIDToolStripComboBox.Items.AddRange(regIDList.ToArray());
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

        private void pendingStudentsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                checkForRequirements();
            }
            catch (FormatException fe)
            {
                _pendingStudentsRepository.CloseConnection();
                hideRequirementButtons();
                return;
            }
            catch (NullReferenceException nre)
            {
                _pendingStudentsRepository.CloseConnection();
                hideRequirementButtons();
                return;
            }
        }

        private void checkForRequirements()
        {
            try
            {
                var requirements = _pendingStudentsRepository.CheckPendingStudentsRequirements(registerIDTextBox.Text);

                SetRequirementButtonState(viewFrm137Button, uploadFrm137Button, deleteFrm137Button, requirements["StudForm137"]);
                SetRequirementButtonState(viewGoodMoralButton, uploadGoodMoralButton, deleteGoodMoralButton, requirements["GoodMoral"]);
                SetRequirementButtonState(viewBirthCertButton, uploadBirthCertButton, deleteBirthCertButton, requirements["BirthCertificate"]);
                
                if (enrollmentStatusTextBox.Text.Equals("TRANSFEREE"))
                {
                    SetRequirementButtonState(viewTransferCertButton, uploadTransferCertButton, deleteTransferCertButton, requirements["TransferCertificate"]);
                }
                else
                {
                    viewTransferCertButton.Visible = false;
                    deleteTransferCertButton.Visible = false;
                    uploadTransferCertButton.Visible = false;
                }

                if (!paymentMethodComboBox.Text.Equals(string.Empty) && (paymentMethodComboBox.Text.Equals("GCASH") || paymentMethodComboBox.Text.Equals("BANK TRANSFER")))
                {
                    SetRequirementButtonState(viewProofOfPaymentButton, uploadProofOfPaymentButton, deleteProofOfPaymentButton, requirements["ProofOfPayment"]);
                }
                else
                {
                    viewProofOfPaymentButton.Visible = false;
                    deleteProofOfPaymentButton.Visible = false;
                    uploadProofOfPaymentButton.Visible = false;
                }
            }
            catch (KeyNotFoundException knfe)
            {
                _pendingStudentsRepository.CloseConnection();
                hideRequirementButtons();   
                return;
            }
            catch (NullReferenceException nre)
            {
                _pendingStudentsRepository.CloseConnection();
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
            viewProofOfPaymentButton.Visible = false;
            deleteProofOfPaymentButton.Visible = false;
            uploadProofOfPaymentButton.Visible = false;
        }

        private void selectCurrentDataGridViewCell()
        {
            if (pendingStudentsDataGridView.Rows.Count > 0)
            {
                int rowIndex = pendingStudentsDataGridView.CurrentCell.RowIndex;
                int columnIndex = pendingStudentsDataGridView.CurrentCell.ColumnIndex;

                if (rowIndex >= 0 && rowIndex < pendingStudentsDataGridView.Rows.Count &&
                    columnIndex >= 0 && columnIndex < pendingStudentsDataGridView.Columns.Count)
                {
                    DataGridViewCellEventArgs args = new DataGridViewCellEventArgs(columnIndex, rowIndex);
                    pendingStudentsDataGridView_CellClick(pendingStudentsDataGridView, args);
                }
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            Regex regex;
            TextBox textBox = sender as TextBox;

            if (textBox == null) return;

            if (textBox == contactNumTextBox || textBox == paidAmountTextBox)
            {
                regex = new Regex(@"^[0-9]*$");
            }
            else
            {
                regex = new Regex(@"^[a-zA-Z]*$");
            }

            if (!regex.IsMatch(textBox.Text))
            {
                if (textBox == contactNumTextBox || textBox == paidAmountTextBox)
                {
                    textBox.Text = new string(textBox.Text.Where(char.IsDigit).ToArray());
                }
                else
                {
                    textBox.Text = new string(textBox.Text.Where(char.IsLetter).ToArray());
                }
                textBox.SelectionStart = textBox.Text.Length; // Maintain cursor position
            }
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
        private void viewProofOfPaymentButton_Click(object sender, EventArgs e) => HandleFileOperation("ProofOfPayment", "view");
        private void uploadProofOfPaymentButton_Click(object sender, EventArgs e) => HandleFileOperation("ProofOfPayment", "upload");
        private void deleteProofOfPaymentButton_Click(object sender, EventArgs e) => HandleFileOperation("ProofOfPayment", "delete");

        private void HandleFileOperation(string fileType, string operation)
        {
            if (fileType.Equals("ProofOfPayment"))
            {
                openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            }
            else 
            {
                openFileDialog1.Filter = "PDF Files|*.pdf";
            }

            switch (operation)
            {
                case "view":
                    if (fileType.Equals("ProofOfPayment"))
                    {
                        _pendingStudentsRepository.ViewImageFile("PendingStudents", fileType, "RegisterID", registerIDTextBox.Text);
                    }
                    else
                    {
                        _pendingStudentsRepository.ViewPDFFile("PendingStudents", fileType, "RegisterID", registerIDTextBox.Text);
                    }
                    break;
                case "upload":
                    pendingStudentsBindingNavigatorSaveItem.PerformClick();
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        byte[] fileData = File.ReadAllBytes(openFileDialog1.FileName);
                        _pendingStudentsRepository.UploadFile("PendingStudents", fileType, "RegisterID", registerIDTextBox.Text, fileData);
                    }
                    bindingNavigatorRefreshItem.PerformClick();
                    break;
                case "delete":
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this file?", "Delete file", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        _pendingStudentsRepository.DeleteFile("PendingStudents", fileType, "RegisterID", registerIDTextBox.Text);
                        selectCurrentDataGridViewCell();
                        break;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    break;
            }
        }

        private bool checkCompleteDetails()
        {
            if (string.IsNullOrWhiteSpace(studentNumberTextBox.Text))
            {
                MessageBox.Show("Student Number not assigned.", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (string.IsNullOrWhiteSpace(paymentTypeComboBox.Text) || string.IsNullOrWhiteSpace(paymentMethodComboBox.Text))
            {
                MessageBox.Show("Missing Payment Details.", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (!paymentTypeComboBox.Text.Equals("Monthly") && !paymentTypeComboBox.Text.Equals("Full"))
            {
                MessageBox.Show("Payment Type must only be 'Monthly' or 'Full'", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (!paymentMethodComboBox.Text.Equals("CASH") && !paymentMethodComboBox.Text.Equals("GCASH") && !paymentMethodComboBox.Text.Equals("BANK TRANSFER"))
            {
                MessageBox.Show("Accepted Payment Methods are only 'CASH', 'GCASH', and 'BANK TRANSFER'", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (string.IsNullOrWhiteSpace(paidAmountTextBox.Text))
            {
                MessageBox.Show("Missing Paid Amount. Paid Amount must be specified", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (int.Parse(paidAmountTextBox.Text) != int.Parse(amountToPayLabel.Text))
            {
                MessageBox.Show("Paid Amount doesn't match the amount to pay.", "Error", MessageBoxButtons.OK);
                return false;
            }

            var requirements = _pendingStudentsRepository.CheckPendingStudentsRequirements(registerIDTextBox.Text);
            if (requirements["ProofOfPayment"] == false && !paymentMethodComboBox.Text.Equals("CASH"))
            {
                MessageBox.Show("Missing Proof Of Payment. It is required for Payment Methods of 'GCASH' and 'BANK TRANSFER'", "Error", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private void bindingNavigatorEnrollStudentItem_Click(object sender, EventArgs e)
        {
            if (checkCompleteDetails() == false)
            {
                return;
            }

            try
            {
                pendingStudentsBindingNavigatorSaveItem.PerformClick();
                insertStudents();
                insertStudentPayment();
                checkIsNullRequirements();
                MessageBox.Show($"Student {studentNumberTextBox.Text} has been successfully enrolled.", "Success!", MessageBoxButtons.OK);
                _pendingStudentsRepository.DeletePendingStudents(registerIDTextBox.Text);
                bindingNavigatorRefreshItem.PerformClick();
                LoggingService.LogInformation($"Insert successful in InsertStudents to Students table");
                LoggingService.LogInformation($"Insert successful in InsertStudentPayment to StudentPayment table");
                LoggingService.LogInformation($"Deletion successful in  DeletePendingStudents from PendingNewStudents table");
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL Error in bindingNavigatorEnrollStudentItem_Click: {ex.Message}");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in bindingNavigatorEnrollStudentItem_Click: {ex.Message}");
                return;
            }
        }

        private void insertStudents()
        {
            var studentData = new Dictionary<string, object>
            {
                {"RegisterID", Convert.ToInt32(registerIDTextBox.Text)},
                {"StudentNumber", studentNumberTextBox.Text},
                {"StudFirstName", studFirstNameTextBox.Text},
                {"StudMidName", studMidNameTextBox.Text},
                {"StudLastName", studLastNameTextBox.Text},
                {"Gender", genderTextBox.Text},
                {"BirthDate", birthDateTextBox.Text},
                {"CivilStatus", civilStatusTextBox.Text},
                {"Address", addressTextBox.Text},
                {"ContactNum", contactNumTextBox.Text},
                {"EnrollmentStatus", enrollmentStatusTextBox.Text},
                {"EnrollmentType", enrollmentTypeTextBox.Text},
                {"PaymentType", paymentTypeComboBox.SelectedItem},
                {"MotherFirstName", motherFirstNameTextBox.Text},
                {"MotherLastName", motherLastNameTextBox.Text},
                {"MotherOccupation", motherOccupationTextBox.Text},
                {"FatherFirstName", fatherFirstNameTextBox.Text},
                {"FatherLastName", fatherLastNameTextBox.Text},
                {"FatherOccupation", fatherOccupationTextBox.Text}
            };
            new StudentRepository(ConnectionFactory.GetConnectionString()).InsertStudents(studentData);
        }

        private void insertStudentPayment()
        {
            string paymentCode = getPaymentCode(paymentTypeComboBox.Text, enrollmentTypeTextBox.Text);
            var studentPaymentData = new Dictionary<string, object>
            {
                {"PaymentCode", paymentCode},
                {"PaymentMethod", paymentMethodComboBox.Text},
                {"StudentNumber", studentNumberTextBox.Text}
            };

            int paidAmount = Convert.ToInt32(paidAmountTextBox.Text);
            int? nullableInt = null;
            if (paymentTypeComboBox.Text.Equals("Monthly"))
            {
                new StudentPaymentRepository(ConnectionFactory.GetConnectionString()).InsertStudentPayment(studentPaymentData, paidAmount, "August", "Paid", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
                new StudentPaymentRepository(ConnectionFactory.GetConnectionString()).InsertStudentPayment(studentPaymentData, nullableInt, "September", "Pending", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
                new StudentPaymentRepository(ConnectionFactory.GetConnectionString()).InsertStudentPayment(studentPaymentData, nullableInt, "October", "Pending", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
                new StudentPaymentRepository(ConnectionFactory.GetConnectionString()).InsertStudentPayment(studentPaymentData, nullableInt, "November", "Pending", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
                new StudentPaymentRepository(ConnectionFactory.GetConnectionString()).InsertStudentPayment(studentPaymentData, nullableInt, "December", "Pending", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
                new StudentPaymentRepository(ConnectionFactory.GetConnectionString()).InsertStudentPayment(studentPaymentData, nullableInt, "January", "Pending", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
                new StudentPaymentRepository(ConnectionFactory.GetConnectionString()).InsertStudentPayment(studentPaymentData, nullableInt, "February", "Pending", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
                new StudentPaymentRepository(ConnectionFactory.GetConnectionString()).InsertStudentPayment(studentPaymentData, nullableInt, "March", "Pending", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
                new StudentPaymentRepository(ConnectionFactory.GetConnectionString()).InsertStudentPayment(studentPaymentData, nullableInt, "April", "Pending", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
                new StudentPaymentRepository(ConnectionFactory.GetConnectionString()).InsertStudentPayment(studentPaymentData, nullableInt, "May", "Pending", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
            }
            else if (paymentTypeComboBox.Text.Equals("Full"))
            {
                new StudentPaymentRepository(ConnectionFactory.GetConnectionString()).InsertStudentPayment(studentPaymentData, paidAmount, "August", "Paid", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
            }
        }

        public static string getPaymentCode(string paymentType, string enrollmentType)
        {
            string paymentCode = string.Empty;
            if (paymentType.Equals("Monthly") && enrollmentType.Equals("Grade 7"))
            {
                paymentCode = "MG7";
            }
            else if (paymentType.Equals("Full") && enrollmentType.Equals("Grade 7"))
            {
                paymentCode = "FG7";
            }
            else if (paymentType.Equals("Monthly") && enrollmentType.Equals("Grade 8"))
            {
                paymentCode = "MG8";
            }
            else if (paymentType.Equals("Full") && enrollmentType.Equals("Grade 8"))
            {
                paymentCode = "FG8";
            }
            else if (paymentType.Equals("Monthly") && enrollmentType.Equals("Grade 9"))
            {
                paymentCode = "MG9";
            }
            else if (paymentType.Equals("Full") && enrollmentType.Equals("Grade 9"))
            {
                paymentCode = "FG9";
            }
            else if (paymentType.Equals("Monthly") && enrollmentType.Equals("Grade 10"))
            {
                paymentCode = "MG10";
            }
            else if (paymentType.Equals("Full") && enrollmentType.Equals("Grade 10"))
            {
                paymentCode = "FG10";
            }
            return paymentCode;
        }

        private void checkIsNullRequirements()
        {
            try
            {
                var requirements = _pendingStudentsRepository.CheckPendingStudentsRequirements(registerIDTextBox.Text);

                if (requirements["StudForm137"] == true)
                {
                    _pendingStudentsRepository.UpdateRequirements("Students", "StudForm137", registerIDTextBox.Text);
                }

                if (requirements["LRN"] == true)
                {
                    _pendingStudentsRepository.UpdateRequirements("Students", "LRN", registerIDTextBox.Text);
                }

                if (requirements["BirthCertificate"] == true)
                {
                    _pendingStudentsRepository.UpdateRequirements("Students", "BirthCertificate", registerIDTextBox.Text);
                }

                if (requirements["GoodMoral"] == true)
                {
                    _pendingStudentsRepository.UpdateRequirements("Students", "GoodMoral", registerIDTextBox.Text);
                }

                if (requirements["TransferCertificate"] == true)
                {
                    _pendingStudentsRepository.UpdateRequirements("Students", "TransferCertificate", registerIDTextBox.Text);
                }

                if (requirements["PersonalEmail"] == true)
                {
                    _pendingStudentsRepository.UpdateRequirements("Students", "PersonalEmail", registerIDTextBox.Text);
                }

                if (requirements["GuardianEmail"] == true)
                {
                    _pendingStudentsRepository.UpdateRequirements("Students", "GuardianEmail", registerIDTextBox.Text);
                }

                if (requirements["ProofOfPayment"] == true)
                {
                    _pendingStudentsRepository.UpdateProofOfPayment("StudentPayment", "ProofOfPayment", registerIDTextBox.Text, studentNumberTextBox.Text, ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
                }
            }
            catch (NullReferenceException nre)
            {
                _pendingStudentsRepository.CloseConnection();
                hideRequirementButtons();
                return;
            }
        }

        private void generateStudNumButton_Click(object sender, EventArgs e)
        {
            int studentNumber = _pendingStudentsRepository.GenerateStudentNumber();

            if (studentNumber < 10)
            {
                studentNumberTextBox.Text = "S000" + studentNumber.ToString();
            }
            else if (studentNumber >= 10 && studentNumber < 100)
            {
                studentNumberTextBox.Text = "S00" + studentNumber.ToString();
            }
            else if (studentNumber >= 100 && studentNumber < 1000)
            {
                studentNumberTextBox.Text = "S0" + studentNumber.ToString();
            }
            else if (studentNumber >= 1000)
            {
                studentNumberTextBox.Text = "S" + studentNumber.ToString();
            }
        }

        private void paymentMethodComboBox_TextChanged(object sender, EventArgs e)
        {
            if (paymentMethodComboBox.Text.Equals("GCASH") || paymentMethodComboBox.Text.Equals("BANK TRANSFER"))
            {
                proofOfPaymentLabel.Visible = true;
                viewProofOfPaymentButton.Visible = true;
                deleteProofOfPaymentButton.Visible = true;
                uploadProofOfPaymentButton.Visible = true;
            }
            else
            {
                proofOfPaymentLabel.Visible = false;
                viewProofOfPaymentButton.Visible = false;
                deleteProofOfPaymentButton.Visible = false;
                uploadProofOfPaymentButton.Visible = false;
            }
        }

        private void paymentTypeComboBox_TextChanged(object sender, EventArgs e)
        {
            amountToPayLabel.Text = Convert.ToString(new PricesRepository(ConnectionFactory.GetConnectionString()).GetPaymentAmountPerGrade(paymentTypeComboBox.Text, enrollmentTypeTextBox.Text));
        }

        private void searchToolStripButton_Click(object sender, EventArgs e) => searchPendingStudents();
        private void OnSearchToolStripTextChanged(object sender, EventArgs e) => searchPendingStudents();

        private void searchPendingStudents()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(studFirstNameToolStripComboBox.Text) && !string.IsNullOrWhiteSpace(studMidNameToolStripComboBox.Text) && !string.IsNullOrWhiteSpace(studLastNameToolStripComboBox.Text))
                {
                    this.pendingStudentsTableAdapter.Search2(this.sTU_DBDataSet.PendingStudents, studFirstNameToolStripComboBox.Text, studMidNameToolStripComboBox.Text, studLastNameToolStripComboBox.Text);
                    return;
                }

                this.pendingStudentsTableAdapter.Search(this.sTU_DBDataSet.PendingStudents, registerIDToolStripComboBox.Text, studentNumberToolStripComboBox.Text, studFirstNameToolStripComboBox.Text, studMidNameToolStripComboBox.Text, studLastNameToolStripComboBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        
    }
}
