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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUEnrollmentSystem
{
    public partial class frmRegistration : Form
    {
        private RegistrationRepository _registrationRepository;

        public frmRegistration()
        {
            InitializeComponent();
            _registrationRepository = new RegistrationRepository(ConnectionFactory.GetConnectionString());
            this.tableAdapterManager.Connection.ConnectionString = ConnectionFactory.GetConnectionString();
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
            InitializeSearchComboBoxes();
            InitializeUserRolePrivileges();
        }

        private void InitializeUserRolePrivileges()
        {
            if (!frmLogin.Role.Equals("Admin"))
            {
                bindingNavigatorDeleteItem.Enabled = false;
                bindingNavigatorAddNewItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
                registrationBindingNavigatorSaveItem.Enabled = false;
            }
        }

        private void registrationBindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            this.registrationTableAdapter.Fill(sTU_DBDataSet.Registration);
            InitializeSearchComboBoxes();
        }

        private void InitializeSearchComboBoxes()
        {
            InitializeSearchRegisterIDCB();
            InitializeSearchStudFirstName();
            InitializeSearchStudMidNameCB();
            InitializeSearchStudLastNameCB();
        }

        private void InitializeSearchStudLastNameCB()
        {
            List<string> studLastNameList = _registrationRepository.GetColumnData("Registration", "StudLastName");
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
            List<string> studMidNameList = _registrationRepository.GetColumnData("Registration", "StudMidName");
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
            List<string> studFirstNameList = _registrationRepository.GetColumnData("Registration", "StudFirstName");
            studFirstNameToolStripComboBox.Items.Clear();
            foreach (string items in studFirstNameList)
            {
                if (!studFirstNameToolStripComboBox.Items.Contains(items))
                {
                    studFirstNameToolStripComboBox.Items.Add(items);
                }
            }
        }

        private void InitializeSearchRegisterIDCB()
        {
            List<string> registerIDList = _registrationRepository.GetColumnData("Registration", "RegisterID");
            registerIDToolStripComboBox.Items.Clear();
            registerIDToolStripComboBox.Items.AddRange(registerIDList.ToArray());
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
            try
            {
                var requirements = _registrationRepository.CheckRegistrationRequirements(registerIDTextBox.Text);

                SetRequirementButtonState(viewFrm137Button, uploadFrm137Button, deleteFrm137Button, requirements["StudForm137"]);
                SetRequirementButtonState(viewGoodMoralButton, uploadGoodMoralButton, deleteGoodMoralButton, requirements["GoodMoral"]);
                SetRequirementButtonState(viewBirthCertButton, uploadBirthCertButton, deleteBirthCertButton, requirements["BirthCertificate"]);
                SetRequirementButtonState(viewTransferCertButton, uploadTransferCertButton, deleteTransferCertButton, requirements["TransferCertificate"]);
            }
            catch (KeyNotFoundException knfe)
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
                    _registrationRepository.ViewPDFFile("Registration", fileType, "RegisterID", registerIDTextBox.Text);
                    break;
                case "upload":
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        byte[] fileData = File.ReadAllBytes(openFileDialog1.FileName);
                        _registrationRepository.UploadFile("Registration", fileType, "RegisterID", registerIDTextBox.Text, fileData);
                    }
                    registrationBindingNavigatorSaveItem.PerformClick();
                    registrationBindingNavigatorRefreshItem.PerformClick();
                    break;
                case "delete":
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this file?", "Delete file", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        _registrationRepository.DeleteFile("Registration", fileType, "RegisterID", registerIDTextBox.Text);
                        registrationBindingNavigatorRefreshItem.PerformClick();
                        break;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    break;
            }
        }

        private void registrationBindingNavigatorMoveToCashierItem_Click(object sender, EventArgs e)
        {
            try
            {
                registrationBindingNavigatorSaveItem.PerformClick();
                insertPendingStudents();
                checkIsNullRequirements();
                MessageBox.Show($"Registering student no. {registerIDTextBox.Text} has been approved.", "Success!", MessageBoxButtons.OK);
                _registrationRepository.DeleteRegistration(registerIDTextBox.Text);
                registrationBindingNavigatorRefreshItem_Click(sender, e);
                LoggingService.LogInformation($"Insert successful in InsertPendingStudent to PendingNewStudents table.");
                LoggingService.LogInformation($"Deletion successful in DeleteRegistration from Registration table.");
            }
            catch (Exception ex)
            {
                LoggingService.LogError($"Unexpected error in registrationBindingNavigatorMoveToCashierItem_Click: {ex.Message}");
                return;
            }
        }

        private void insertPendingStudents()
        {
            var studentData = new Dictionary<string, object>
            {
                {"RegisterID", registerIDTextBox.Text},
                {"EnrollmentStatus", enrollmentStatusComboBox.SelectedItem},
                {"StudFirstName", studFirstNameTextBox.Text},
                {"StudMidName", studMidNameTextBox.Text},
                {"StudLastName", studLastNameTextBox.Text},
                {"Gender", genderComboBox.SelectedItem},
                {"BirthDate", birthDateTimePicker.Value.Date.ToShortDateString()},
                {"CivilStatus", civilStatusComboBox.SelectedItem},
                {"Address", addressTextBox.Text},
                {"ContactNum", contactNumTextBox.Text},
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
            try
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

                if (requirements["PersonalEmail"] == true)
                {
                    _registrationRepository.UpdateRequirements("PendingStudents", "PersonalEmail", registerIDTextBox.Text);
                }

                if (requirements["GuardianEmail"] == true)
                {
                    _registrationRepository.UpdateRequirements("PendingStudents", "GuardianEmail", registerIDTextBox.Text);
                }
            }
            catch (NullReferenceException nre)
            {
                _registrationRepository.CloseConnection();
                hideRequirementButtons();
                return;
            }
        }

        private void searchToolStripButton_Click(object sender, EventArgs e) => searchRegistration();
        private void OnSearchToolStripTextChanged(object sender, EventArgs e) => searchRegistration();

        private void searchRegistration()
        {
            try
            {
                this.registrationTableAdapter.Search(this.sTU_DBDataSet.Registration, registerIDToolStripComboBox.Text, studFirstNameToolStripComboBox.Text, studMidNameToolStripComboBox.Text, studLastNameToolStripComboBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            Regex regex;
            TextBox textBox = sender as TextBox;

            if (textBox == null) return;

            if (textBox == contactNumTextBox)
            {
                regex = new Regex(@"^[0-9]*$");
            }
            else
            {
                regex = new Regex(@"^[a-zA-Z]*$");
            }

            if (!regex.IsMatch(textBox.Text))
            {
                if (textBox == contactNumTextBox)
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
    }
}
