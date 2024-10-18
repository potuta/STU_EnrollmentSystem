using System;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUEnrollmentSystem
{
    public partial class PendingStudents : Form
    {
        private PendingStudentsRepository _pendingStudentsRepository;

        public PendingStudents()
        {
            InitializeComponent();
            _pendingStudentsRepository = new PendingStudentsRepository(Properties.Settings.Default.STU_DBConnectionString);
        }

        private void pendingStudentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            birthDateTextBox.Text = birthDateTimePicker.Value.Date.ToShortDateString();
            this.Validate();
            this.pendingStudentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTU_DBDataSet);
        }

        private void PendingStudents_Load(object sender, EventArgs e)
        {
            this.pendingStudentsTableAdapter.Fill(this.sTU_DBDataSet.PendingStudents);
            searchPanel.Visible = false;
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
            this.pendingStudentsTableAdapter.Update(sTU_DBDataSet);
            this.pendingStudentsTableAdapter.Fill(sTU_DBDataSet.PendingStudents);
        }

        private void pendingStudentsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                birthDateTimePicker.Text = birthDateTextBox.Text;
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
            var requirements = _pendingStudentsRepository.CheckPendingStudentsRequirements(registerIDTextBox.Text);

            SetRequirementButtonState(viewFrm137Button, uploadFrm137Button, deleteFrm137Button, requirements["StudForm137"]);
            SetRequirementButtonState(viewGoodMoralButton, uploadGoodMoralButton, deleteGoodMoralButton, requirements["GoodMoral"]);
            SetRequirementButtonState(viewBirthCertButton, uploadBirthCertButton, deleteBirthCertButton, requirements["BirthCertificate"]);
            SetRequirementButtonState(viewTransferCertButton, uploadTransferCertButton, deleteTransferCertButton, requirements["TransferCertificate"]);

            if (!paymentMethodComboBox.Text.Equals(string.Empty) && (paymentMethodComboBox.SelectedItem.Equals("GCASH") || paymentMethodComboBox.SelectedItem.Equals("BANK TRANSFER")))
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
        private void viewProofOfPaymentButton_Click(object sender, EventArgs e)
        {
            _pendingStudentsRepository.ViewImageFile("ProofOfPayment", registerIDTextBox.Text);
        }
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
                    _pendingStudentsRepository.ViewFile(fileType, registerIDTextBox.Text);
                    break;
                case "upload":
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        byte[] fileData = File.ReadAllBytes(openFileDialog1.FileName);
                        _pendingStudentsRepository.UploadFile(fileType, registerIDTextBox.Text, fileData);
                    }
                    break;
                case "delete":
                    _pendingStudentsRepository.DeleteFile(fileType, registerIDTextBox.Text);
                    break;
            }
        }

        private void bindingNavigatorEnrollStudentItem_Click(object sender, EventArgs e)
        {
            insertStudents();
            insertStudentPayment();
            checkIsNullRequirements();
            _pendingStudentsRepository.DeletePendingStudents(registerIDTextBox.Text);
            bindingNavigatorRefreshItem_Click(sender, e);
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
                {"Gender", genderComboBox.SelectedItem},
                {"BirthDate", birthDateTimePicker.Value.Date.ToShortDateString()},
                {"CivilStatus", civilStatusComboBox.SelectedItem},
                {"Address", addressTextBox.Text},
                {"ContactNum", Convert.ToInt32(contactNumTextBox.Text)},
                {"EnrollmentStatus", enrollmentStatusComboBox.SelectedItem},
                {"EnrollmentType", enrollmentTypeComboBox.SelectedItem},
                {"PaymentType", paymentTypeComboBox.SelectedItem},
                {"MotherFirstName", motherFirstNameTextBox.Text},
                {"MotherLastName", motherLastNameTextBox.Text},
                {"MotherOccupation", motherOccupationTextBox.Text},
                {"FatherFirstName", fatherFirstNameTextBox.Text},
                {"FatherLastName", fatherLastNameTextBox.Text},
                {"FatherOccupation", fatherOccupationTextBox.Text}
            };
            _pendingStudentsRepository.InsertStudents(studentData);
        }

        private void insertStudentPayment()
        {
            string paymentCode = getPaymentCode(paymentTypeComboBox.SelectedItem.ToString(), enrollmentTypeComboBox.SelectedItem.ToString());
            var studentPaymentData = new Dictionary<string, object>
            {
                {"PaymentCode", paymentCode},
                {"PaymentMethod", paymentMethodComboBox.SelectedItem.ToString()},
                {"StudentNumber", studentNumberTextBox.Text}
            };

            if (paymentTypeComboBox.SelectedItem.Equals("Monthly"))
            {
                _pendingStudentsRepository.InsertStudentPayment(studentPaymentData, "August", "Paid");
                _pendingStudentsRepository.InsertStudentPayment(studentPaymentData, "September", "Pending");
                _pendingStudentsRepository.InsertStudentPayment(studentPaymentData, "October", "Pending");
                _pendingStudentsRepository.InsertStudentPayment(studentPaymentData, "November", "Pending");
                _pendingStudentsRepository.InsertStudentPayment(studentPaymentData, "December", "Pending");
                _pendingStudentsRepository.InsertStudentPayment(studentPaymentData, "January", "Pending");
                _pendingStudentsRepository.InsertStudentPayment(studentPaymentData, "February", "Pending");
                _pendingStudentsRepository.InsertStudentPayment(studentPaymentData, "March", "Pending");
                _pendingStudentsRepository.InsertStudentPayment(studentPaymentData, "April", "Pending");
                _pendingStudentsRepository.InsertStudentPayment(studentPaymentData, "May", "Pending");
            }
            else if (paymentTypeComboBox.SelectedItem.Equals("Full"))
            {
                _pendingStudentsRepository.InsertStudentPayment(studentPaymentData, "August", "Paid");
            }
        }

        private string getPaymentCode(string paymentType, string enrollmentType)
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
            return paymentCode;
        }

        private void checkIsNullRequirements()
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

            if (requirements["ProofOfPayment"] == true)
            {
                _pendingStudentsRepository.UpdateProofOfPayment("StudentPayment", "ProofOfPayment", registerIDTextBox.Text, studentNumberTextBox.Text);
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
            if (paymentMethodComboBox.SelectedItem.Equals("GCASH") || paymentMethodComboBox.SelectedItem.Equals("BANK TRANSFER"))
            {
                proofOfPaymentLabel.Visible = true;
            }
            else
            {
                proofOfPaymentLabel.Visible = false;
            }
        }

        private void paymentTypeComboBox_TextChanged(object sender, EventArgs e)
        {
            if (paymentTypeComboBox.SelectedItem.Equals("Monthly") && enrollmentTypeComboBox.SelectedItem.Equals("Grade 7"))
            {
                amountToPayLabel.Text = "5700.00";
            }
            else if (paymentTypeComboBox.SelectedItem.Equals("Full") && enrollmentTypeComboBox.SelectedItem.Equals("Grade 7"))
            {
                amountToPayLabel.Text = "57000.00";
            }
        }
    }
}
