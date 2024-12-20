﻿using Spire.Pdf.OPC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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
            selectCurrentDataGridViewCell();
        }

        private void StudentPayment_Load(object sender, EventArgs e)
        {
            this.studentPaymentTableAdapter.Fill(this.sTU_DBDataSet.StudentPayment);
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
            selectCurrentDataGridViewCell();
        }

        private void studentPaymentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                checkForRequirements();
                checkBalance();
                updateBillingReportButton();
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
                paidAmountTextBox.Enabled = false;
            }
            else
            {
                paymentMethodComboBox.Enabled = true;
                paymentStatusComboBox.Enabled = true;
                paymentRNTextBox.Enabled = true;
                paidAmountTextBox.Enabled = true;
            }
        }

        private void checkForRequirements()
        {
            try
            {
                _studentPaymentRepository.SchoolYear = schoolYearTextBox.Text;
                _studentPaymentRepository.PaymentCode = paymentCodeTextBox.Text;

                var requirements = _studentPaymentRepository.CheckStudentPaymentRequirements(studentNumberTextBox.Text, monthOfPaymentTextBox.Text);
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
                    if (string.IsNullOrWhiteSpace(receiptRNTextBox.Text) && string.IsNullOrWhiteSpace(transactionDateTextBox.Text) && string.IsNullOrWhiteSpace(transactionNumberTextBox.Text))
                    {
                        refreshButton.Visible = true;
                    }
                    else
                    {
                        refreshButton.Visible = false;
                    }
                }
                else
                {
                    refreshButton.Visible = false;
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
                Dictionary<string, int> monthlyPendingList = new PaymentTypeRepository(ConnectionFactory.GetConnectionString()).GetTotalPendingPaymentAmount(studentNumberTextBox.Text, paymentCodeTextBox.Text, schoolYearTextBox.Text);
                int totalRemainingBalance = getTotalRemainingBalance();

                string monthlyPending = string.Empty;
                int monthlyRemainingBalance = 0;
                if (monthlyPendingList.Count == 0)
                {
                    monthlyPending = "None";
                    monthlyRemainingBalance = totalRemainingBalance;
                }
                else
                {
                    monthlyPending = monthlyPendingList.Keys.ElementAt(0);
                    monthlyRemainingBalance = totalRemainingBalance / monthlyPendingList.Count;
                }

                if (paymentCodeTextBox.Text.Contains("M"))
                {
                    paymentTypeLabel.Text = "Monthly";
                    remainingBalanceLabel.Text = "₱" + Convert.ToString(totalRemainingBalance);
                    paymentDueLabel.Text = $"{monthlyPending}, ₱{monthlyRemainingBalance}";

                    if (monthlyPendingList.Count == 0)
                    {
                        notifyButton.Visible = false;
                    }
                    else
                    {
                        showNotifyButton();
                    }
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

        private int getTotalRemainingBalance()
        {
            int totalPaymentAmount = new PaymentTypeRepository(ConnectionFactory.GetConnectionString()).GetSumTotalPaymentAmountFromPaymentCode(paymentCodeTextBox.Text);
            int totalPaidAmount = _studentPaymentRepository.GetSumTotalPaidAmount(studentNumberTextBox.Text, paymentCodeTextBox.Text, schoolYearTextBox.Text);
            return totalPaymentAmount - totalPaidAmount;
        }

        private void showNotifyButton()
        {
            Dictionary<string, int> monthlyPendingList = new PaymentTypeRepository(ConnectionFactory.GetConnectionString()).GetTotalPendingPaymentAmount(studentNumberTextBox.Text, paymentCodeTextBox.Text, schoolYearTextBox.Text);
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
            refreshButton.Visible = false;
        }

        private void selectCurrentDataGridViewCell()
        {
            if (studentPaymentDataGridView.Rows.Count > 0)
            {
                int rowIndex = studentPaymentDataGridView.CurrentCell.RowIndex;
                int columnIndex = studentPaymentDataGridView.CurrentCell.ColumnIndex;

                if (rowIndex >= 0 && rowIndex < studentPaymentDataGridView.Rows.Count &&
                    columnIndex >= 0 && columnIndex < studentPaymentDataGridView.Columns.Count)
                {
                    DataGridViewCellEventArgs args = new DataGridViewCellEventArgs(columnIndex, rowIndex);
                    studentPaymentDataGridView_CellClick(studentPaymentDataGridView, args);
                }
            }
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
            _studentPaymentRepository.PaymentCode = paymentCodeTextBox.Text;

            switch (operation)
            {
                case "view":
                    _studentPaymentRepository.ViewImageFile("StudentPayment", fileType, "StudentNumber", studentNumberTextBox.Text);
                    break;
                case "upload":
                    paidAmountTextBox.Clear();
                    studentPaymentBindingNavigatorSaveItem.PerformClick();
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        byte[] fileData = File.ReadAllBytes(openFileDialog1.FileName);
                        _studentPaymentRepository.UploadFile("StudentPayment", fileType, "StudentNumber", studentNumberTextBox.Text, fileData);
                    }
                    bindingNavigatorRefreshItem.PerformClick();
                    break;
                case "delete":
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this file?", "Delete file", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        _studentPaymentRepository.DeleteFile("StudentPayment", fileType, "StudentNumber", studentNumberTextBox.Text);
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

        private void paymentMethodComboBox_TextChanged(object sender, EventArgs e)
        {
            if (paymentMethodComboBox.Text.Equals("GCASH") || paymentMethodComboBox.Text.Equals("BANK TRANSFER"))
            {
                viewProofOfPaymentButton.Visible = true;
                deleteProofOfPaymentButton.Visible = true;
                uploadProofOfPaymentButton.Visible = true;
                paymentRNTextBox.Enabled = true;
            }
            else
            {
                viewProofOfPaymentButton.Visible = false;
                deleteProofOfPaymentButton.Visible = false;
                uploadProofOfPaymentButton.Visible = false;
                paymentRNTextBox.Enabled = false;
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
            Dictionary<string, int> monthlyPendingList = new PaymentTypeRepository(ConnectionFactory.GetConnectionString()).GetTotalPendingPaymentAmount(studentNumberTextBox.Text, paymentCodeTextBox.Text, schoolYearTextBox.Text);
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
                            body += $"\n{month}: ₱{getTotalRemainingBalance() / monthlyPendingList.Count}, {schoolYearTextBox.Text}";
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
            frmPDFReceipt frmPDFReceipt = new frmPDFReceipt(studentNumberTextBox.Text, paymentCodeTextBox.Text, paymentMethodComboBox.Text, monthOfPaymentTextBox.Text, schoolYearTextBox.Text, transactionDateTextBox.Text, receiptRNTextBox.Text, paidAmountTextBox.Text);
            frmPDFReceipt.Show();
        }

        private void paymentStatusComboBox_TextChanged(object sender, EventArgs e)
        {
            if (paymentStatusComboBox.Text.Equals("Paid"))
            {
                if (string.IsNullOrWhiteSpace(receiptRNTextBox.Text) && string.IsNullOrWhiteSpace(transactionDateTextBox.Text) && string.IsNullOrWhiteSpace(transactionNumberTextBox.Text))
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
                if (string.IsNullOrWhiteSpace(paidAmountTextBox.Text)) 
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

        private bool checkCompleteDetails()
        {
            if (!paymentStatusComboBox.Text.Equals("Paid") && !paymentStatusComboBox.Text.Equals("Pending"))
            {
                MessageBox.Show($"Invalid Payment Status '{paymentStatusComboBox.Text}'. Payment Status must only contain 'Paid' or 'Pending'", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (paymentStatusComboBox.Text.Equals("Pending"))
            {
                MessageBox.Show("Payment Status must be set to 'Paid' to add to Billing Report", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (string.IsNullOrWhiteSpace(receiptRNTextBox.Text) || string.IsNullOrWhiteSpace(transactionDateTextBox.Text) || string.IsNullOrWhiteSpace(transactionNumberTextBox.Text))
            {
                MessageBox.Show("Missing Payment Details.", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (string.IsNullOrWhiteSpace(paymentMethodComboBox.Text) || string.IsNullOrWhiteSpace(paymentStatusComboBox.Text))
            {
                MessageBox.Show("Missing Payment Details.", "Error", MessageBoxButtons.OK);
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

            if (string.IsNullOrWhiteSpace(paymentRNTextBox.Text) && !paymentMethodComboBox.Text.Equals("CASH"))
            {
                MessageBox.Show("Missing PaymentRN. It is required for Payment Methods of 'GCASH' and 'BANK TRANSFER'", "Error", MessageBoxButtons.OK);
                return false;
            }

            var requirements = _studentPaymentRepository.CheckStudentPaymentRequirements(studentNumberTextBox.Text, monthOfPaymentTextBox.Text);
            if (requirements["ProofOfPayment"] == false && !paymentMethodComboBox.Text.Equals("CASH"))
            {
                MessageBox.Show("Missing Proof Of Payment. It is required for Payment Methods of 'GCASH' and 'BANK TRANSFER'", "Error", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private void addBillingReportButton_Click(object sender, EventArgs e)
        {
            if (checkCompleteDetails() == false)
            {
                return;
            }

            var billingReportData = new Dictionary<string, object>()
            {
                {"TransactionNumber", transactionNumberTextBox.Text},
                {"StudentNumber", studentNumberTextBox.Text},
                {"PaymentAmount", paidAmountTextBox.Text},
                {"TransactionDate", transactionDateTextBox.Text},
                {"PaymentRN", paymentRNTextBox.Text},
                {"ReceiptRN", receiptRNTextBox.Text}
            };

            studentPaymentBindingNavigatorSaveItem.PerformClick();
            new BillingReportRepository(ConnectionFactory.GetConnectionString()).InsertBillingReport(billingReportData);
            selectCurrentDataGridViewCell();
            MessageBox.Show("Successfully added to billing report!", "Success", MessageBoxButtons.OK);
            LoggingService.LogInformation($"Insert successful in InsertBillingReport to BillingReport table");
        }

        private void paidAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            Regex regex;
            TextBox textBox = sender as TextBox;

            if (textBox == null) return;

            if (textBox == paidAmountTextBox)
            {
                regex = new Regex(@"^[0-9]*$");
            }
            else
            {
                regex = new Regex(@"^[a-zA-Z]*$");
            }

            if (!regex.IsMatch(textBox.Text))
            {
                if (textBox == paidAmountTextBox)
                {
                    textBox.Text = new string(textBox.Text.Where(char.IsDigit).ToArray());
                }
                else
                {
                    textBox.Text = new string(textBox.Text.Where(char.IsLetter).ToArray());
                }
                textBox.SelectionStart = textBox.Text.Length; // Maintain cursor position
            }

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
            var controlsToValidate = new ToolStripComboBox[]
            {
                addReturningStudentToolStripStudentNumberComboBox,
                addReturningStudentToolStripPaymentTypeComboBox,
                addReturningStudentToolStripPaymentMethodComboBox,
                addReturningStudentToolStripEnrollmentTypeComboBox,
            };

            if (controlsToValidate.Any(control => string.IsNullOrWhiteSpace(control.Text)))
            {
                MessageBox.Show("Missing details, please make sure to enter complete details.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(addReturningStudentToolStripPaidAmountTextBox.Text))
            {
                MessageBox.Show("Missing Paid Amount. Paid amount must be specified.", "Error", MessageBoxButtons.OK);
                return;
            }

            string studentGrade = new StudentRepository(ConnectionFactory.GetConnectionString()).GetStudentGrade(addReturningStudentToolStripStudentNumberComboBox.Text);
            if (studentGrade == addReturningStudentToolStripEnrollmentTypeComboBox.Text)
            {
                MessageBox.Show($"Student {addReturningStudentToolStripStudentNumberComboBox.Text}'s current grade is {addReturningStudentToolStripEnrollmentTypeComboBox.Text} and already contains a payment record for {addReturningStudentToolStripEnrollmentTypeComboBox.Text}. Please select a higher grade.", "Error", MessageBoxButtons.OK);
                return;
            }

            string paymentCode = frmPendingStudents.getPaymentCode(addReturningStudentToolStripPaymentTypeComboBox.Text, addReturningStudentToolStripEnrollmentTypeComboBox.Text);
            var studentPaymentData = new Dictionary<string, object>
            {
                {"PaymentCode", paymentCode},
                {"PaymentMethod", addReturningStudentToolStripPaymentMethodComboBox.Text},
                {"StudentNumber", addReturningStudentToolStripStudentNumberComboBox.Text}
            };

            int paidAmount = Convert.ToInt32(addReturningStudentToolStripPaidAmountTextBox.Text);
            int? nullableInt = null;
            try
            {
                if (addReturningStudentToolStripPaymentTypeComboBox.Text.Equals("Monthly"))
                {
                    _studentPaymentRepository.InsertStudentPayment(studentPaymentData, paidAmount, "August", "Paid", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
                    _studentPaymentRepository.InsertStudentPayment(studentPaymentData, nullableInt, "September", "Pending", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
                    _studentPaymentRepository.InsertStudentPayment(studentPaymentData, nullableInt, "October", "Pending", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
                    _studentPaymentRepository.InsertStudentPayment(studentPaymentData, nullableInt, "November", "Pending", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
                    _studentPaymentRepository.InsertStudentPayment(studentPaymentData, nullableInt, "December", "Pending", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
                    _studentPaymentRepository.InsertStudentPayment(studentPaymentData, nullableInt, "January", "Pending", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
                    _studentPaymentRepository.InsertStudentPayment(studentPaymentData, nullableInt, "February", "Pending", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
                    _studentPaymentRepository.InsertStudentPayment(studentPaymentData, nullableInt, "March", "Pending", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
                    _studentPaymentRepository.InsertStudentPayment(studentPaymentData, nullableInt, "April", "Pending", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
                    _studentPaymentRepository.InsertStudentPayment(studentPaymentData, nullableInt, "May", "Pending", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
                }
                else if (addReturningStudentToolStripPaymentTypeComboBox.Text.Equals("Full"))
                {
                    _studentPaymentRepository.InsertStudentPayment(studentPaymentData, paidAmount, "August", "Paid", ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString()));
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL Error in addReturningStudentToolStripInsertMenuItem_Click: {ex.Message}");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in addReturningStudentToolStripInsertMenuItem_Click: {ex.Message}");
                return;
            }

            new StudentRepository(ConnectionFactory.GetConnectionString()).UpdateStudentYearLevel(addReturningStudentToolStripStudentNumberComboBox.Text, addReturningStudentToolStripEnrollmentTypeComboBox.Text, addReturningStudentToolStripPaymentTypeComboBox.Text);
            bindingNavigatorRefreshItem.PerformClick();
            MessageBox.Show($"Successfully added old student {addReturningStudentToolStripStudentNumberComboBox.Text} as {addReturningStudentToolStripEnrollmentTypeComboBox.Text}");
        }

        private void bindingNavigatorNotifyAllButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"(This feature is still a work in progress) Notify all students?", "Notify Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            List<string> studentNumberList = _studentPaymentRepository.GetColumnData("StudentPayment", "StudentNumber");

            int count = 0;
            foreach (string studentNumber in studentNumberList)
            {
                string schoolYear = ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString());
                Dictionary<string, int> monthlyPendingList = new PaymentTypeRepository(ConnectionFactory.GetConnectionString()).GetTotalPendingPaymentAmount(studentNumber, _studentPaymentRepository.GetPaymentCode(studentNumber, schoolYear), schoolYear);
                Dictionary<string, string> emails = new StudentRepository(ConnectionFactory.GetConnectionString()).GetStudentEmail(studentNumber);

                foreach (string email in emails.Keys)
                {
                    if (!emails[email].Equals(string.Empty))
                    {
                        string studentName = new StudentRepository(ConnectionFactory.GetConnectionString()).GetStudentName(studentNumber);

                        string studentEmail = emails[email];
                        string subject = $"STU Payment Due";
                        string body = $"Good day student {studentName}. We are here to inform you that you have pending balances due for payment.";

                        foreach (string month in monthlyPendingList.Keys)
                        {
                            if (assignIntValueToMonth(month) <= assignIntValueToMonth(DateTime.Now.ToString("MMMM")))
                            {
                                body += $"\n{month}: ₱{monthlyPendingList[month]}, {schoolYear}";
                            }
                        }

                        EmailSender emailSender = new EmailSender();
                        emailSender.SendEmail(studentEmail, subject, body);
                    }

                    //_studentPaymentRepository.UpdateStudentNotificationCount(studentNumber, _studentPaymentRepository.GetPaymentCode(studentNumber, schoolYear), schoolYear, monthOfPaymentTextBox.Text);
                    foreach (string month in monthlyPendingList.Keys)
                    {
                        if (assignIntValueToMonth(month) <= assignIntValueToMonth(DateTime.Now.ToString("MMMM")))
                        {
                            _studentPaymentRepository.UpdateStudentNotificationCount(studentNumber, _studentPaymentRepository.GetPaymentCode(studentNumber, schoolYear), schoolYear, month);
                        }
                    }
                }

                count++;
            }

            MessageBox.Show($"Email has been sent to {count} students", "Notification Successful", MessageBoxButtons.OK);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(receiptRNTextBox.Text) && !string.IsNullOrWhiteSpace(transactionDateTextBox.Text) && !string.IsNullOrWhiteSpace(transactionNumberTextBox.Text))
            { 
                return;
            }

            generateTransactionNumber();
            transactionDateTextBox.Text = DateTime.Now.ToShortDateString();
            generateReceiptRN();
            updateBillingReportButton();
        }

        private void addReturningStudentToolStripPaidAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            Regex regex;
            TextBox textBox = sender as TextBox;

            if (textBox == null) return;

            if (textBox == paidAmountTextBox)
            {
                regex = new Regex(@"^[0-9]*$");
            }
            else
            {
                regex = new Regex(@"^[a-zA-Z]*$");
            }

            if (!regex.IsMatch(textBox.Text))
            {
                if (textBox == paidAmountTextBox)
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

        private void viewStudentNumberButton_Click(object sender, EventArgs e)
        {
            if (studentsDataGridView.Visible == true)
            {
                studentsDataGridView.Visible = false;
                return;
            }

            studentsDataGridView.Visible = true;
            DataTable dataTable = new StudentRepository(ConnectionFactory.GetConnectionString()).GetStudentNumberDataTable(studentNumberTextBox.Text);
            studentsDataGridView.DataSource = dataTable;
        }
    }
}
