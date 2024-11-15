using Spire.Pdf.OPC;
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
            _studentPaymentRepository = new StudentPaymentRepository(ConnectionFactory.GetConnectionString());
            this.tableAdapterManager.Connection.ConnectionString = ConnectionFactory.GetConnectionString();
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

        private void InitializeSearchComboBoxes()
        {
            InitializeSearchStudentNumCB();
            InitializeSearchPaymentCodeCB();
            InitializeSearchSchoolYearCB();
        }

        private void InitializeSearchSchoolYearCB()
        {
            List<string> schoolYearList = _studentPaymentRepository.GetColumnData("StudentPayment", "SchoolYear");
            schoolYearList.Sort();
            schoolYearToolStripComboBox.Items.Clear();
            foreach (string items in schoolYearList)
            {
                if (!schoolYearToolStripComboBox.Items.Contains(items))
                {
                    schoolYearToolStripComboBox.Items.Add(items);
                }
            }
        }

        private void InitializeSearchStudentNumCB()
        {
            List<string> studentNumList = _studentPaymentRepository.GetColumnData("StudentPayment", "StudentNumber");
            studentNumList.Sort();
            studentNumberToolStripComboBox.Items.Clear();
            studentNumberToolStripComboBox.Items.AddRange(studentNumList.ToArray());
        }

        private void InitializeSearchPaymentCodeCB()
        {
            List<string> paymentCodeList = _studentPaymentRepository.GetColumnData("StudentPayment", "PaymentCode");
            paymentCodeList.Sort();
            paymentCodeToolStripComboBox.Items.Clear();
            foreach (string items in paymentCodeList)
            {
                if (!paymentCodeToolStripComboBox.Items.Contains(items))
                {
                    paymentCodeToolStripComboBox.Items.Add(items);
                }
            }
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
                checkBalance();
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
            try
            {
                _studentPaymentRepository.SchoolYear = schoolYearTextBox.Text;
                var requirements = _studentPaymentRepository.CheckStudentPaymentRequirements(studentNumberTextBox.Text, monthOfPaymentComboBox.Text);

                if (!paymentMethodComboBox.Text.Equals(string.Empty) && (paymentMethodComboBox.Text.Equals("GCASH") || paymentMethodComboBox.Text.Equals("BANK TRANSFER")))
                {
                    SetRequirementButtonState(viewProofOfPaymentButton, uploadProofOfPaymentButton, deleteProofOfPaymentButton, requirements["ProofOfPayment"]);
                }
                else
                {
                    hideRequirementButtons();
                }

                if (paymentStatusComboBox.Text.Equals("Paid"))
                {
                    viewPaymentReceiptButton.Visible = true;
                }
                else
                {
                    viewPaymentReceiptButton.Visible = false;
                }
            }
            catch (KeyNotFoundException knfe)
            {
                _studentPaymentRepository.CloseConnection();
                Console.WriteLine($"Unexpected error in checkForRequirements: {knfe.Message}");
                hideRequirementButtons();
                return;
            }
        }

        private void checkBalance()
        {
            try
            {
                Dictionary<string, int> monthlyPendingList = _studentPaymentRepository.GetTotalPendingPaymentAmount(studentNumberTextBox.Text, paymentCodeComboBox.Text);

                if (paymentCodeComboBox.Text.Contains("M"))
                {
                    paymentTypeLabel.Text = "Monthly";
                    remainingBalanceLabel.Text = "₱" + Convert.ToString(calculateTotalPendingAmount(monthlyPendingList));
                    paymentDueLabel.Text = $"{monthlyPendingList.Keys.ElementAt(0)}, ₱{monthlyPendingList.Values.ElementAt(0)}";

                    if (assignIntValueToMonth(monthlyPendingList.Keys.ElementAt(0)) <= assignIntValueToMonth(DateTime.Now.ToString("MMMM")))
                    {
                        notifyButton.Visible = true;
                    }
                    else
                    {
                        notifyButton.Visible = false;
                    }
                }
                else if (paymentCodeComboBox.Text.Contains("F"))
                {
                    paymentTypeLabel.Text = "Full";
                    remainingBalanceLabel.Text = "0";
                    paymentDueLabel.Text = "None";
                    notifyButton.Visible = false;
                }
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                _studentPaymentRepository.CloseConnection();
                Console.WriteLine($"Unexpected error in checkBalance: {aoore.Message}");
                hideRequirementButtons();
                notifyButton.Visible = false;
                return;
            }
        }

        private int calculateTotalPendingAmount(Dictionary<string, int> monthlyPendingList)
        {
            int totalPendingAmount = 0;
            foreach (string month in monthlyPendingList.Keys)
            {
                totalPendingAmount += monthlyPendingList[month];
            }
            return totalPendingAmount;
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

        private int assignIntValueToMonth(string month)
        {
            Dictionary<string, int> months = new Dictionary<string, int>();

            try
            {
                months = new Dictionary<string, int>
                {
                    { "August", 1 },
                    { "September", 2 },
                    { "October", 3 },
                    { "November", 4 },
                    { "December", 5 },
                    { "January", 6 },
                    { "February", 7 },
                    { "March", 8 },
                    { "April", 9 },
                    { "May", 10 },
                    { "June", 11 },
                    { "July", 12 },
                };
            }
            catch (KeyNotFoundException knfe)
            {
                _studentPaymentRepository.CloseConnection();
                hideRequirementButtons();
                notifyButton.Visible = false;
                Console.WriteLine($"Unexpected error in assignIntValueToMonth: {knfe.Message}");
                return months[month];
            }
            return months[month];
        }

        private void viewProofOfPaymentButton_Click(object sender, EventArgs e) => HandleFileOperation("ProofOfPayment", "view");
        private void uploadProofOfPaymentButton_Click(object sender, EventArgs e) => HandleFileOperation("ProofOfPayment", "upload");
        private void deleteProofOfPaymentButton_Click(object sender, EventArgs e) => HandleFileOperation("ProofOfPayment", "delete");

        private void HandleFileOperation(string fileType, string operation)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            _studentPaymentRepository.MonthOfPayment = monthOfPaymentComboBox.Text;
            _studentPaymentRepository.SchoolYear = schoolYearTextBox.Text;
            switch (operation)
            {
                case "view":
                    _studentPaymentRepository.ViewImageFile("StudentPayment", fileType, "StudentNumber", studentNumberTextBox.Text);
                    break;
                case "upload":
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        byte[] fileData = File.ReadAllBytes(openFileDialog1.FileName);
                        _studentPaymentRepository.UploadFile("StudentPayment", fileType, "StudentNumber", studentNumberTextBox.Text, fileData);
                    }
                    break;
                case "delete":
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this file?", "Delete file", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        _studentPaymentRepository.DeleteFile("StudentPayment", fileType, "StudentNumber", studentNumberTextBox.Text);
                        break;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    break;
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

        private void searchToolStripButton_Click(object sender, EventArgs e) => searchStudentPayment();
        private void OnSearchToolStripTextChanged(object sender, EventArgs e) => searchStudentPayment();

        private void searchStudentPayment()
        {
            try
            {
                this.studentPaymentTableAdapter.Search(this.sTU_DBDataSet.StudentPayment, paymentCodeToolStripComboBox.Text, studentNumberToolStripComboBox.Text, schoolYearToolStripComboBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void notifyButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> emails = new StudentRepository(ConnectionFactory.GetConnectionString()).GetStudentEmail(studentNumberTextBox.Text);
            foreach (string email in emails.Keys)
            {
                if (!emails[email].Equals(string.Empty))
                {
                    Dictionary<string, int> monthlyPendingList = _studentPaymentRepository.GetTotalPendingPaymentAmount(studentNumberTextBox.Text, paymentCodeComboBox.Text);
                    string studentName = new StudentRepository(ConnectionFactory.GetConnectionString()).GetStudentName(studentNumberTextBox.Text);

                    string studentEmail = emails[email];
                    string subject = $"STU Payment Due";
                    string body = $"Good day student {studentName}. We are here to inform you that you have pending balances due for payment.";

                    foreach (string month in monthlyPendingList.Keys)
                    {
                        if (assignIntValueToMonth(month) <= assignIntValueToMonth(DateTime.Now.ToString("MMMM")))
                        {
                            body += $"\n{month}: ₱{monthlyPendingList[month]}, {schoolYearTextBox.Text}";
                        }
                    }

                    EmailSender emailSender = new EmailSender();
                    emailSender.SendEmail(studentEmail, subject, body);
                }
            }

            MessageBox.Show("Email has been sent", "Email", MessageBoxButtons.OK);
        }

        private void viewPaymentReceiptButton_Click(object sender, EventArgs e)
        {
            frmPDFReceipt frmPDFReceipt = new frmPDFReceipt(studentNumberTextBox.Text, paymentCodeComboBox.Text, paymentMethodComboBox.Text, monthOfPaymentComboBox.Text, schoolYearTextBox.Text);
            frmPDFReceipt.Show();
        }
    }
}
