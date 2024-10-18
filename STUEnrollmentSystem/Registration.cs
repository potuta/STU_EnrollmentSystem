using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUEnrollmentSystem
{
    public partial class Registration : Form
    {
        private RegistrationRepository _registrationRepository;

        public Registration()
        {
            InitializeComponent();
            _registrationRepository = new RegistrationRepository(Properties.Settings.Default.STU_DBConnectionString);
        }

        private void registrationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            birthDateTextBox.Text = birthDateTimePicker.Value.Date.ToShortDateString();
            this.Validate();
            this.registrationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTU_DBDataSet);
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            this.registrationTableAdapter.Fill(this.sTU_DBDataSet.Registration);
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

        private void registrationBindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            this.registrationTableAdapter.Update(sTU_DBDataSet);
            this.registrationTableAdapter.Fill(sTU_DBDataSet.Registration);
        }

        private void registrationDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                birthDateTimePicker.Text = birthDateTextBox.Text;
                checkForRequirements();
            }
            catch (FormatException fe)
            {
                _registrationRepository.CloseConnection();
                hideRequirementButtons();
                return;
            }
            catch (NullReferenceException nre)
            {
                _registrationRepository.CloseConnection();
                hideRequirementButtons();
                return;
            }
        }

        private void checkForRequirements()
        {
            var requirements = _registrationRepository.CheckRegistrationRequirements(registerIDTextBox.Text);

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
                    _registrationRepository.ViewFile(fileType, registerIDTextBox.Text);
                    break;
                case "upload":
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        byte[] fileData = File.ReadAllBytes(openFileDialog1.FileName);
                        _registrationRepository.UploadFile(fileType, registerIDTextBox.Text, fileData);
                    }
                    break;
                case "delete":
                    _registrationRepository.DeleteFile(fileType, registerIDTextBox.Text);
                    break;
            }
        }

        private void registrationBindingNavigatorMoveToCashierItem_Click(object sender, EventArgs e)
        {
            insertPendingStudents();
            checkIsNullRequirements();
            _registrationRepository.DeleteRegistration(registerIDTextBox.Text);
            registrationBindingNavigatorRefreshItem_Click(sender, e);
        }

        private void insertPendingStudents()
        {
            var studentData = new Dictionary<string, object>
            {
                {"RegisterID", Convert.ToInt32(registerIDTextBox.Text)},
                {"EnrollmentStatus", enrollmentStatusComboBox.SelectedItem},
                {"StudFirstName", studFirstNameTextBox.Text},
                {"StudMidName", studMidNameTextBox.Text},
                {"StudLastName", studLastNameTextBox.Text},
                {"Gender", genderComboBox.SelectedItem},
                {"BirthDate", birthDateTimePicker.Value.Date.ToShortDateString()},
                {"CivilStatus", civilStatusComboBox.SelectedItem},
                {"Address", addressTextBox.Text},
                {"ContactNum", Convert.ToInt32(contactNumTextBox.Text)},
                {"EnrollmentType", enrollmentTypeComboBox.SelectedItem},
                {"PaymentType", paymentTypeComboBox.SelectedItem},
                {"MotherFirstName", motherFirstNameTextBox.Text},
                {"MotherLastName", motherLastNameTextBox.Text},
                {"MotherOccupation", motherOccupationTextBox.Text},
                {"FatherFirstName", fatherFirstNameTextBox.Text},
                {"FatherLastName", fatherLastNameTextBox.Text},
                {"FatherOccupation", fatherOccupationTextBox.Text}
            };
            _registrationRepository.InsertPendingStudent(studentData);
        }

        private void checkIsNullRequirements()
        {
            var requirements = _registrationRepository.CheckRegistrationRequirements(registerIDTextBox.Text);

            if (requirements["StudForm137"] == true)
            {
                _registrationRepository.UpdateRequirements("PendingStudents", "StudForm137", registerIDTextBox.Text);
            }

            if (requirements["LRN"] == true)
            {
                _registrationRepository.UpdateRequirements("PendingStudents", "LRN", registerIDTextBox.Text);
            }

            if (requirements["BirthCertificate"] == true)
            {
                _registrationRepository.UpdateRequirements("PendingStudents", "BirthCertificate", registerIDTextBox.Text);
            }

            if (requirements["GoodMoral"] == true)
            {
                _registrationRepository.UpdateRequirements("PendingStudents", "GoodMoral", registerIDTextBox.Text);
            }

            if (requirements["TransferCertificate"] == true)
            {
                _registrationRepository.UpdateRequirements("PendingStudents", "TransferCertificate", registerIDTextBox.Text);
            }
        }
    }
}
