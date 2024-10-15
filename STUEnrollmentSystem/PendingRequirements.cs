using System;
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
    public partial class PendingRequirements : Form
    {
        private StudentRepository _studentRepository;

        public PendingRequirements()
        {
            InitializeComponent();
            _studentRepository = new StudentRepository(Properties.Settings.Default.STU_DBConnectionString);
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            birthDateTextBox.Text = birthDateTimePicker.Value.Date.ToShortDateString();
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTU_DBDataSet);
        }

        private void PendingRequirements_Load(object sender, EventArgs e)
        {
            this.sectionsTableAdapter.Fill(this.sTU_DBDataSet.Sections);
            this.studentsTableAdapter.FillBy(this.sTU_DBDataSet.Students);
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
            this.studentsTableAdapter.Update(sTU_DBDataSet);
            this.studentsTableAdapter.FillBy(sTU_DBDataSet.Students);
        }

        private void studentsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                birthDateTimePicker.Text = birthDateTextBox.Text;
                checkForRequirements();
            }
            catch (FormatException fe)
            {
                _studentRepository.CloseConnection();
                hideRequirementButtons();
                return;
            }
            catch (NullReferenceException nfe)
            {
                _studentRepository.CloseConnection();
                hideRequirementButtons();
                return;
            }
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

        private void viewFrm137Button_Click(object sender, EventArgs e)
        {
            _studentRepository.ViewFile("StudForm137", studentNumberTextBox.Text);
        }

        private void uploadFrm137Button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                byte[] fileData = File.ReadAllBytes(openFileDialog1.FileName);
                _studentRepository.UploadFile("StudForm137", studentNumberTextBox.Text, fileData);
            }
        }

        private void deleteFrm137Button_Click(object sender, EventArgs e)
        {
            _studentRepository.DeleteFile("StudForm137", studentNumberTextBox.Text);
        }

        private void viewGoodMoralButton_Click(object sender, EventArgs e)
        {
            _studentRepository.ViewFile("GoodMoral", studentNumberTextBox.Text);
        }

        private void uploadGoodMoralButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                byte[] fileData = File.ReadAllBytes(openFileDialog1.FileName);
                _studentRepository.UploadFile("GoodMoral", studentNumberTextBox.Text, fileData);
            }
        }

        private void deleteGoodMoralButton_Click(object sender, EventArgs e)
        {
            _studentRepository.DeleteFile("GoodMoral", studentNumberTextBox.Text);
        }

        private void viewBirthCertButton_Click(object sender, EventArgs e)
        {
            _studentRepository.ViewFile("BirthCertificate", studentNumberTextBox.Text);
        }

        private void uploadBirthCertButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                byte[] fileData = File.ReadAllBytes(openFileDialog1.FileName);
                _studentRepository.UploadFile("BirthCertificate", studentNumberTextBox.Text, fileData);
            }
        }

        private void deleteBirthCertButton_Click(object sender, EventArgs e)
        {
            _studentRepository.DeleteFile("BirthCertificate", studentNumberTextBox.Text);
        }

        private void viewTransferCertButton_Click(object sender, EventArgs e)
        {
            _studentRepository.ViewFile("TransferCertificate", studentNumberTextBox.Text);
        }

        private void uploadTransferCertButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                byte[] fileData = File.ReadAllBytes(openFileDialog1.FileName);
                _studentRepository.UploadFile("TransferCertificate", studentNumberTextBox.Text, fileData);
            }
        }

        private void deleteTransferCertButton_Click(object sender, EventArgs e)
        {
            _studentRepository.DeleteFile("TransferCertificate", studentNumberTextBox.Text);
        }

        private void bindingNavigatorUpdateRequirementsItem_Click(object sender, EventArgs e)
        {
            studentsBindingNavigatorSaveItem_Click(sender, e);
            bindingNavigatorRefreshItem_Click(sender, e);
        }
    }
}
