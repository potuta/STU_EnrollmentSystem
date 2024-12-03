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
            InitializeUserRolePrivileges();
        }

        private void InitializeUserRolePrivileges()
        {
            if (!frmLogin.Role.Equals("Admin"))
            {
                bindingNavigatorDeleteItem.Enabled = false;
            }
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
            foreach (string items in studentNumList)
            {
                if (!studentNumberToolStripComboBox.Items.Contains(items))
                {
                    studentNumberToolStripComboBox.Items.Add(items);
                }
            }
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
            this.studentPaymentTableAdapter.Fill(sTU_DBDataSet.StudentPayment);
            InitializeSearchComboBoxes();
        }

        private void studentPaymentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                checkForRequirements();
                checkBalance();
                checkTransactionNumberExist();
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

        private void checkTransactionNumberExist()
        {
            bool isTransactionNumberExist = new BillingReportRepository(ConnectionFactory.GetConnectionString()).CheckIfTransactionNumberExists(transactionNumberTextBox.Text);
            if (isTransactionNumberExist == true)
            {
                addBillingReportButton.Enabled = false;
                paymentMethodComboBox.Enabled = false;
                paymentStatusComboBox.Enabled = false;
                paymentRNTextBox.Enabled = false;
                deleteProofOfPaymentButton.Visible = false;
            }
            else
            {
                paymentMethodComboBox.Enabled = true;
                paymentStatusComboBox.Enabled = true;
                paymentRNTextBox.Enabled = true;
            }
        }

        private void checkForRequirements()
        {
            try
            {
                _studentPaymentRepository.SchoolYear = schoolYearTextBox.Text;
                var requirements = _studentPaymentRepository.CheckStudentPaymentRequirements(studentNumberTextBox.Text, monthOfPaymentTextBox.Text);
                if (!paymentMethodComboBox.Text.Equals(string.Empty) && (paymentMethodComboBox.Text.Equals("GCASH") || paymentMethodComboBox.Text.Equals("BANK TRANSFER")))
                {
                    SetRequirementButtonState(viewProofOfPaymentButton, uploadProofOfPaymentButton, deleteProofOfPaymentButton, requirements["ProofOfPayment"]);
                }
                else
                {
                    hideRequirementButtons();
                }
            }
            catch (KeyNotFoundException knfe)
            {
                _studentPaymentRepository.CloseConnection();
                Console.WriteLine($"Unexpected error in checkForRequirements: {knfe.Message}");
                hideRequirementButtons();
                return;
            }
            catch (NullReferenceException nfe)
            {
                _studentPaymentRepository.CloseConnection();
                hideRequirementButtons();
                return;
            }
        }

        private void checkBalance()
        {
            try
            {
                Dictionary<string, int> monthlyPendingList = _studentPaymentRepository.GetTotalPendingPaymentAmount(studentNumberTextBox.Text, paymentCodeTextBox.Text);

                if (paymentCodeTextBox.Text.Contains("M"))
                {
                    paymentTypeLabel.Text = "Monthly";
                    remainingBalanceLabel.Text = "₱" + Convert.ToString(calculateTotalPendingAmount(monthlyPendingList));
                    paymentDueLabel.Text = $"{monthlyPendingList.Keys.ElementAt(0)}, ₱{monthlyPendingList.Values.ElementAt(0)}";
                    showNotifyButton();
                }
                else if (paymentCodeTextBox.Text.Contains("F"))
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
            catch (NullReferenceException nfe)
            {
                _studentPaymentRepository.CloseConnection();
                hideRequirementButtons();
                notifyButton.Visible = false;
                return;
            }
        }

        private void showNotifyButton()
        {
            Dictionary<string, int> monthlyPendingList = _studentPaymentRepository.GetTotalPendingPaymentAmount(studentNumberTextBox.Text, paymentCodeTextBox.Text);
            int notificationCount = _studentPaymentRepository.GetStudentNotificationCount(studentNumberTextBox.Text, paymentCodeTextBox.Text, schoolYearTextBox.Text, monthOfPaymentTextBox.Text);

            if (notificationCount == 0)
            {
                if (assignIntValueToMonth(monthlyPendingList.Keys.ElementAt(0)) <= assignIntValueToMonth(DateTime.Now.ToString("MMMM")))
                {
                    notifyButton.Visible = true;
                }
                else
                {
                    notifyButton.Visible = false;
                }
            }
            else
            {
                notifyButton.Visible = false;
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
            _studentPaymentRepository.MonthOfPayment = monthOfPaymentTextBox.Text;
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
                    studentPaymentBindingNavigatorSaveItem.PerformClick();
                    bindingNavigatorRefreshItem.PerformClick();
                    break;
                case "delete":
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this file?", "Delete file", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        _studentPaymentRepository.DeleteFile("StudentPayment", fileType, "StudentNumber", studentNumberTextBox.Text);
                        bindingNavigatorRefreshItem.PerformClick();
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
                viewProofOfPaymentButton.Visible = true;
                deleteProofOfPaymentButton.Visible = true;
                uploadProofOfPaymentButton.Visible = true;
            }
            else
            {
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
                if (!paymentCodeToolStripComboBox.Text.Equals(string.Empty) && !studentNumberToolStripComboBox.Text.Equals(string.Empty) && !schoolYearToolStripComboBox.Text.Equals(string.Empty))
                {
                    this.studentPaymentTableAdapter.Search2(this.sTU_DBDataSet.StudentPayment, paymentCodeToolStripComboBox.Text, studentNumberToolStripComboBox.Text, schoolYearToolStripComboBox.Text);
                    return;
                }

                this.studentPaymentTableAdapter.Search(this.sTU_DBDataSet.StudentPayment, paymentCodeToolStripComboBox.Text, studentNumberToolStripComboBox.Text, schoolYearToolStripComboBox.Text, paymentRNToolStripTextBox.Text, receiptRNToolStripTextBox.Text, transactionNumberToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void notifyButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> monthlyPendingList = _studentPaymentRepository.GetTotalPendingPaymentAmount(studentNumberTextBox.Text, paymentCodeTextBox.Text);
            Dictionary<string, string> emails = new StudentRepository(ConnectionFactory.GetConnectionString()).GetStudentEmail(studentNumberTextBox.Text);

            foreach (string email in emails.Keys)
            {
                if (!emails[email].Equals(string.Empty))
                {
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

            _studentPaymentRepository.UpdateStudentNotificationCount(studentNumberTextBox.Text, paymentCodeTextBox.Text, schoolYearTextBox.Text, monthOfPaymentTextBox.Text);
            foreach (string month in monthlyPendingList.Keys)
            {
                if (assignIntValueToMonth(month) <= assignIntValueToMonth(DateTime.Now.ToString("MMMM")))
                {
                    _studentPaymentRepository.UpdateStudentNotificationCount(studentNumberTextBox.Text, paymentCodeTextBox.Text, schoolYearTextBox.Text, month);
                }
            }

            MessageBox.Show("Email has been sent", "Email", MessageBoxButtons.OK);
        }

        private void viewPaymentReceiptButton_Click(object sender, EventArgs e)
        {
            frmPDFReceipt frmPDFReceipt = new frmPDFReceipt(studentNumberTextBox.Text, paymentCodeTextBox.Text, paymentMethodComboBox.Text, monthOfPaymentTextBox.Text, schoolYearTextBox.Text, transactionDateTextBox.Text, receiptRNTextBox.Text);
            frmPDFReceipt.Show();
        }

        private void paymentStatusComboBox_TextChanged(object sender, EventArgs e)
        {
            if (paymentStatusComboBox.Text.Equals("Paid"))
            {
                if (transactionNumberTextBox.Text.Equals(string.Empty) && transactionDateTextBox.Text.Equals(string.Empty) && receiptRNTextBox.Text.Equals(string.Empty))
                {
                    generateTransactionNumber();
                    transactionDateTextBox.Text = DateTime.Now.ToShortDateString();
                    generateReceiptRN();
                    updateBillingReportButton();
                }
                else
                {
                    viewPaymentReceiptButton.Visible = true;
                }
            }
            else
            {
                viewPaymentReceiptButton.Visible = false;
                receiptRNTextBox.Clear();
                transactionDateTextBox.Clear();
                transactionNumberTextBox.Clear();
            }
        }

        private void generateReceiptRN()
        {
            string[] dateParts = DateTime.Now.ToShortDateString().Split('/');
            string date = dateParts[0]+dateParts[1]+dateParts[2];
            string receiptRN = $"STU01D{date}T{transactionNumberTextBox.Text}";
            receiptRNTextBox.Text = receiptRN;
        }

        private void generateTransactionNumber()
        {
            int number = new BillingReportRepository(ConnectionFactory.GetConnectionString()).GenerateTransactionNumber();
            transactionNumberTextBox.Text = number.ToString();
        }

        private void updateBillingReportButton()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(paymentRNTextBox.Text)) 
                {
                    if (addBillingReportButton.Enabled == true)
                    {
                        addBillingReportButton.Enabled = false;
                    }
                    return;
                }

                bool isTransactionNumberExist = new BillingReportRepository(ConnectionFactory.GetConnectionString()).CheckIfTransactionNumberExists(transactionNumberTextBox.Text);

                if (isTransactionNumberExist == true)
                {
                    addBillingReportButton.Enabled = false;
                }
                else
                {
                    addBillingReportButton.Enabled = true;
                }
            }
            catch (IndexOutOfRangeException ioore)
            {
                return;
            }
        }

        private void addBillingReportButton_Click(object sender, EventArgs e)
        {
            int totalPaymentAmount = _studentPaymentRepository.GetTotalPaymentAmountFromMonth(paymentCodeTextBox.Text, monthOfPaymentTextBox.Text);

            var billingReportData = new Dictionary<string, object>()
            {
                {"TransactionNumber", transactionNumberTextBox.Text},
                {"StudentNumber", studentNumberTextBox.Text},
                {"PaymentAmount", totalPaymentAmount},
                {"TransactionDate", transactionDateTextBox.Text},
                {"PaymentRN", paymentRNTextBox.Text},
                {"ReceiptRN", receiptRNTextBox.Text}
            };

            _studentPaymentRepository.InsertBillingReport(billingReportData);
            studentPaymentBindingNavigatorSaveItem.PerformClick();
            bindingNavigatorRefreshItem.PerformClick();
            MessageBox.Show("Successfully added to billing report!", "Success", MessageBoxButtons.OK);
            LoggingService.LogInformation($"Insert successful in InsertBillingReport to BillingReport table");
        }

        private void paymentRNTextBox_TextChanged(object sender, EventArgs e)
        {
            updateBillingReportButton();
        }

        private void addReturningStudentToolStripDropDownButton_Click(object sender, EventArgs e)
        {
            List<string> studentNumberList = new StudentRepository(ConnectionFactory.GetConnectionString()).GetColumnData("Students", "StudentNumber");
            studentNumberList.Sort();
            addReturningStudentToolStripStudentNumberComboBox.Items.Clear();
            addReturningStudentToolStripStudentNumberComboBox.Items.AddRange(studentNumberList.ToArray());
        }

        private void addReturningStudentToolStripInsertMenuItem_Click(object sender, EventArgs e)
        {
            string paymentCode = frmPendingStudents.getPaymentCode(addReturningStudentToolStripPaymentTypeComboBox.Text, addReturningStudentToolStripEnrollmentTypeComboBox.Text);
            var studentPaymentData = new Dictionary<string, object>
            {
                {"PaymentCode", paymentCode},
                {"PaymentMethod", addReturningStudentToolStripPaymentMethodComboBox.Text},
                {"StudentNumber", addReturningStudentToolStripStudentNumberComboBox.Text}
            };

            if (addReturningStudentToolStripPaymentTypeComboBox.Text.Equals("Monthly"))
            {
                _studentPaymentRepository.InsertStudentPayment(studentPaymentData, "August", "Paid", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
                _studentPaymentRepository.InsertStudentPayment(studentPaymentData, "September", "Pending", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
                _studentPaymentRepository.InsertStudentPayment(studentPaymentData, "October", "Pending", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
                _studentPaymentRepository.InsertStudentPayment(studentPaymentData, "November", "Pending", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
                _studentPaymentRepository.InsertStudentPayment(studentPaymentData, "December", "Pending", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
                _studentPaymentRepository.InsertStudentPayment(studentPaymentData, "January", "Pending", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
                _studentPaymentRepository.InsertStudentPayment(studentPaymentData, "February", "Pending", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
                _studentPaymentRepository.InsertStudentPayment(studentPaymentData, "March", "Pending", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
                _studentPaymentRepository.InsertStudentPayment(studentPaymentData, "April", "Pending", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
                _studentPaymentRepository.InsertStudentPayment(studentPaymentData, "May", "Pending", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
            }
            else if (addReturningStudentToolStripPaymentTypeComboBox.Text.Equals("Full"))
            {
                _studentPaymentRepository.InsertStudentPayment(studentPaymentData, "August", "Paid", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
            }

            new StudentRepository(ConnectionFactory.GetConnectionString()).UpdateStudentYearLevel(addReturningStudentToolStripStudentNumberComboBox.Text, addReturningStudentToolStripEnrollmentTypeComboBox.Text, addReturningStudentToolStripPaymentTypeComboBox.Text);
            bindingNavigatorRefreshItem.PerformClick();
            MessageBox.Show($"Successfully added returning student {addReturningStudentToolStripStudentNumberComboBox.Text} as {addReturningStudentToolStripEnrollmentTypeComboBox.Text}");
        }
    }
}
