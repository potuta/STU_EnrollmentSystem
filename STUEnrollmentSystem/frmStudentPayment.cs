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
    public partial class frmStudentPayment : Form
    {
        private StudentPaymentRepository _studentPaymentRepository;

        public frmStudentPayment()
        {
            InitializeComponent();
            _studentPaymentRepository = new StudentPaymentRepository(Properties.Settings.Default.STU_DBConnectionString);
        }

        private void studentPaymentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentPaymentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTU_DBDataSet);
        }

        private void StudentPayment_Load(object sender, EventArgs e)
        {
            this.studentPaymentTableAdapter.Fill(this.sTU_DBDataSet.StudentPayment);
            searchPanel.Visible = false;
            InitializeSearchComboBoxes();
        }

        private void InitializeSearchStudentNumCB()
        {
            List<string> studentNumList = _studentPaymentRepository.GetStudentPaymentData("StudentNumber");
            studentNumberToolStripComboBox.Items.Clear();
            studentNumberToolStripComboBox.Items.AddRange(studentNumList.ToArray());
        }

        private void InitializeSearchPaymentCodeCB()
        {
            List<string> paymentCodeList = _studentPaymentRepository.GetStudentPaymentData("PaymentCode");
            paymentCodeToolStripComboBox.Items.Clear();
            foreach (string items in paymentCodeList)
            {
                if (!paymentCodeToolStripComboBox.Items.Contains(items))
                {
                    paymentCodeToolStripComboBox.Items.Add(items);
                }
            }
        }

        private void InitializeSearchComboBoxes()
        {
            InitializeSearchStudentNumCB();
            InitializeSearchPaymentCodeCB();
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
            this.studentPaymentTableAdapter.Update(sTU_DBDataSet);
            this.studentPaymentTableAdapter.Fill(sTU_DBDataSet.StudentPayment);
            InitializeSearchComboBoxes();
        }

        private void studentPaymentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                checkForRequirements();
            }
            catch (FormatException fe)
            {
                _studentPaymentRepository.CloseConnection();
                hideRequirementButtons();
                return;
            }
            catch(NullReferenceException nfe)
            {
                _studentPaymentRepository.CloseConnection();
                hideRequirementButtons();
                return;
            }
        }

        private void checkForRequirements()
        {
            var requirements = _studentPaymentRepository.CheckStudentPaymentRequirements(studentNumberTextBox.Text, monthOfPaymentComboBox.SelectedItem.ToString());

            if (!paymentMethodComboBox.Text.Equals(string.Empty) && (paymentMethodComboBox.SelectedItem.Equals("GCASH") || paymentMethodComboBox.SelectedItem.Equals("BANK TRANSFER")))
            {
                SetRequirementButtonState(viewProofOfPaymentButton, uploadProofOfPaymentButton, deleteProofOfPaymentButton, requirements["ProofOfPayment"]);
            }
            else
            {
                hideRequirementButtons();
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
            viewProofOfPaymentButton.Visible = false;
            deleteProofOfPaymentButton.Visible = false;
            uploadProofOfPaymentButton.Visible = false;
        }

        private void viewProofOfPaymentButton_Click(object sender, EventArgs e) => HandleFileOperation("ProofOfPayment", "view");
        private void uploadProofOfPaymentButton_Click(object sender, EventArgs e) => HandleFileOperation("ProofOfPayment", "upload");
        private void deleteProofOfPaymentButton_Click(object sender, EventArgs e) => HandleFileOperation("ProofOfPayment", "delete");

        private void HandleFileOperation(string fileType, string operation)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            switch (operation)
            {
                case "view":
                    _studentPaymentRepository.ViewImageFile(fileType, studentNumberTextBox.Text, monthOfPaymentComboBox.SelectedItem.ToString());
                    break;
                case "upload":
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        byte[] fileData = File.ReadAllBytes(openFileDialog1.FileName);
                        _studentPaymentRepository.UploadFile(fileType, studentNumberTextBox.Text, monthOfPaymentComboBox.SelectedItem.ToString(), fileData);
                    }
                    break;
                case "delete":
                    _studentPaymentRepository.DeleteFile(fileType, studentNumberTextBox.Text, monthOfPaymentComboBox.SelectedItem.ToString());
                    break;
            }
        }

        private void paymentMethodComboBox_TextChanged(object sender, EventArgs e)
        {
            if (paymentMethodComboBox.SelectedItem.Equals("GCASH") || paymentMethodComboBox.SelectedItem.Equals("BANK TRANSFER"))
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

        private void searchToolStripButton_Click(object sender, EventArgs e) => searchStudentPayment();
        private void paymentCodeToolStripComboBox_TextChanged(object sender, EventArgs e) => searchStudentPayment();
        private void studentNumberToolStripComboBox_TextChanged(object sender, EventArgs e) => searchStudentPayment();
        private void monthOfPaymentToolStripTextBox_TextChanged(object sender, EventArgs e) => searchStudentPayment();

        private void searchStudentPayment()
        {
            try
            {
                this.studentPaymentTableAdapter.Search(this.sTU_DBDataSet.StudentPayment, paymentCodeToolStripComboBox.Text, studentNumberToolStripComboBox.Text, monthOfPaymentToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
