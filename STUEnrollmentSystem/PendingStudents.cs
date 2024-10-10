using Syncfusion.Styles;
using Syncfusion.XPS;
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
        private SqlConnection STU_DB_Connection;
        private SqlCommand STU_Command;

        public PendingStudents()
        {
            InitializeComponent();
            //STU_DB_Connection = new SqlConnection("Data Source=112.204.105.87,16969;Initial Catalog=STU_DB;Persist Security Info=True;User ID=STU_DB_Login;Password=123;TrustServerCertificate=True");
            STU_DB_Connection = new SqlConnection(Properties.Settings.Default.STU_DBConnectionString);
        }

        private void pendingStudentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            studentNumberTextBox.Text = genStudNumTextBox.Text;
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
            STU_DB_Connection.Open();
            try
            {
                birthDateTimePicker.Text = birthDateTextBox.Text;
                SqlCommand frm137Data = new SqlCommand("SELECT StudForm137 FROM PendingStudents WHERE RegisterID = " + Convert.ToInt32(registerIDTextBox.Text), STU_DB_Connection);
                SqlCommand goodMoralData = new SqlCommand("SELECT GoodMoral FROM PendingStudents WHERE RegisterID = " + Convert.ToInt32(registerIDTextBox.Text), STU_DB_Connection);
                SqlCommand birthCertData = new SqlCommand("SELECT BirthCertificate FROM PendingStudents WHERE RegisterID = " + Convert.ToInt32(registerIDTextBox.Text), STU_DB_Connection);
                SqlCommand transferCertData = new SqlCommand("SELECT TransferCertificate FROM PendingStudents WHERE RegisterID = " + Convert.ToInt32(registerIDTextBox.Text), STU_DB_Connection);
                SqlCommand proofOfPaymentData = new SqlCommand("SELECT ProofOfPayment FROM PendingStudents WHERE RegisterID = " + Convert.ToInt32(registerIDTextBox.Text), STU_DB_Connection);
                bool isFrm137Data = frm137Data.ExecuteScalar().Equals(DBNull.Value) ? true : false;
                bool isGoodMoralData = goodMoralData.ExecuteScalar().Equals(DBNull.Value) ? true : false;
                bool isBirthCertData = birthCertData.ExecuteScalar().Equals(DBNull.Value) ? true : false;
                bool isTransferCertData = transferCertData.ExecuteScalar().Equals(DBNull.Value) ? true : false;
                bool isProofOfPaymentData = proofOfPaymentData.ExecuteScalar().Equals(DBNull.Value) ? true : false;
                if (isFrm137Data == false)
                {
                    viewFrm137Button.Visible = true;
                    deleteFrm137Button.Visible = true;
                    uploadFrm137Button.Visible = false;
                }
                else
                {
                    uploadFrm137Button.Visible = true;
                    deleteFrm137Button.Visible = false;
                    viewFrm137Button.Visible = false;
                }

                if (isGoodMoralData == false)
                {
                    viewGoodMoralButton.Visible = true;
                    deleteGoodMoralButton.Visible = true;
                    uploadGoodMoralButton.Visible = false;
                }
                else
                {
                    uploadGoodMoralButton.Visible = true;
                    deleteGoodMoralButton.Visible = false;
                    viewGoodMoralButton.Visible = false;
                }

                if (isBirthCertData == false)
                {
                    viewBirthCertButton.Visible = true;
                    deleteBirthCertButton.Visible = true;
                    uploadBirthCertButton.Visible = false;
                }
                else
                {
                    uploadBirthCertButton.Visible = true;
                    deleteBirthCertButton.Visible = false;
                    viewBirthCertButton.Visible = false;
                }

                if (isTransferCertData == false)
                {
                    viewTransferCertButton.Visible = true;
                    deleteTransferCertButton.Visible = true;
                    uploadTransferCertButton.Visible = false;
                }
                else
                {
                    uploadTransferCertButton.Visible = true;
                    deleteTransferCertButton.Visible = false;
                    viewTransferCertButton.Visible = false;
                }


                if(paymentMethodComboBox.Text.Length > 0 && (paymentMethodComboBox.SelectedItem.Equals("GCASH") || paymentMethodComboBox.SelectedItem.Equals("BANK TRANSFER")))
                {
                    if (isProofOfPaymentData == false)
                    {
                        viewProofOfPaymentButton.Visible = true;
                        deleteProofOfPaymentButton.Visible = true;
                        uploadProofOfPaymentButton.Visible = false;
                    }
                    else
                    {
                        uploadProofOfPaymentButton.Visible = true;
                        deleteProofOfPaymentButton.Visible = false;
                        viewProofOfPaymentButton.Visible = false;
                    }
                }
               
            }
            catch (FormatException fe)
            {
                STU_DB_Connection.Close();
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
                return;
            }
            STU_DB_Connection.Close();
        }

        private void viewFrm137Button_Click(object sender, EventArgs e)
        {
            viewFile("StudForm137");
        }

        private void uploadFrm137Button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                uploadFile("StudForm137");
            }
        }

        private void deleteFrm137Button_Click(object sender, EventArgs e)
        {
            deleteFile("StudForm137");
        }

        private void viewGoodMoralButton_Click(object sender, EventArgs e)
        {
            viewFile("GoodMoral");
        }

        private void uploadGoodMoralButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                uploadFile("GoodMoral");
            }
        }

        private void deleteGoodMoralButton_Click(object sender, EventArgs e)
        {
            deleteFile("GoodMoral");
        }

        private void viewBirthCertButton_Click(object sender, EventArgs e)
        {
            viewFile("BirthCertificate");
        }

        private void uploadBirthCertButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                uploadFile("BirthCertificate");
            }
        }

        private void deleteBirthCertButton_Click(object sender, EventArgs e)
        {
            deleteFile("BirthCertificate");
        }

        private void viewTransferCertButton_Click(object sender, EventArgs e)
        {
            viewFile("TransferCertificate");
        }

        private void uploadTransferCertButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                uploadFile("TransferCertificate");
            }
        }

        private void deleteTransferCertButton_Click(object sender, EventArgs e)
        {
            deleteFile("TransferCertificate");
        }

        private void viewProofOfPaymentButton_Click(object sender, EventArgs e)
        {
            viewImageFile("ProofOfPayment");
        }

        private void uploadProofOfPaymentButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                uploadFile("ProofOfPayment");
            }
        }

        private void deleteProofOfPaymentButton_Click(object sender, EventArgs e)
        {
            deleteFile("ProofOfPayment");
        }

        private void viewImageFile(string Column)
        {
            string command = "SELECT " + Column + " FROM PendingStudents WHERE RegisterID = " + registerIDTextBox.Text;
            ImageViewer imageViewer = new ImageViewer(Column, command);
            imageViewer.Show();
        }

        private void viewFile(string Column)
        {
            string command = "SELECT " + Column + " FROM PendingStudents WHERE RegisterID = " + registerIDTextBox.Text;
            PDFViewer pdfViewer = new PDFViewer(Column, command);
            pdfViewer.Show();
        }

        private void uploadFile(string Column)
        {
            byte[] data = File.ReadAllBytes(openFileDialog1.FileName);
            STU_Command = new SqlCommand("UPDATE PendingStudents SET " + Column + " = @Data WHERE RegisterID = @RegID", STU_DB_Connection);
            STU_Command.Parameters.AddWithValue("@RegID", Convert.ToInt32(registerIDTextBox.Text));
            STU_Command.Parameters.AddWithValue("@Data", data);
            STU_DB_Connection.Open();
            STU_Command.ExecuteNonQuery();
            STU_DB_Connection.Close();
        }

        private void deleteFile(string Column)
        {
            STU_Command = new SqlCommand("UPDATE PendingStudents SET " + Column + " = NULL WHERE RegisterID = @RegID", STU_DB_Connection);
            STU_Command.Parameters.AddWithValue("@RegID", Convert.ToInt32(registerIDTextBox.Text));
            STU_DB_Connection.Open();
            STU_Command.ExecuteNonQuery();
            STU_DB_Connection.Close();
        }

        private void bindingNavigatorEnrollStudentItem_Click(object sender, EventArgs e)
        {
            STU_DB_Connection.Open();

            SqlCommand deleteRowFromPendingStudents = new SqlCommand("DELETE FROM PendingStudents WHERE RegisterID = " + Convert.ToInt32(registerIDTextBox.Text), STU_DB_Connection);

            STU_Command = new SqlCommand("INSERT INTO Students(RegisterID, StudentNumber, EnrollmentStatus, StudFirstName, StudMidName, StudLastName, Gender, BirthDate, CivilStatus, Address, ContactNum, EnrollmentType, PaymentType, " +
                                                         "MotherFirstName, MotherLastName, MotherOccupation, FatherFirstName, FatherLastName, FatherOccupation) VALUES (@RegisterID, @StudentNumber, @EnrollmentStatus, @StudFirstName, @StudMidName, @StudLastName, @Gender, @BirthDate, @CivilStatus, @Address, @ContactNum, @EnrollmentType, @PaymentType, " +
                                                         "@MotherFirstName, @MotherLastName, @MotherOccupation, @FatherFirstName, @FatherLastName, @FatherOccupation)",
                                                                        STU_DB_Connection);
            STU_Command.Parameters.AddWithValue("@RegisterID", Convert.ToInt32(registerIDTextBox.Text));
            STU_Command.Parameters.AddWithValue("@StudentNumber", studentNumberTextBox.Text);
            STU_Command.Parameters.AddWithValue("@StudFirstName", studFirstNameTextBox.Text);
            STU_Command.Parameters.AddWithValue("@StudMidName", studMidNameTextBox.Text);
            STU_Command.Parameters.AddWithValue("@StudLastName", studLastNameTextBox.Text);
            STU_Command.Parameters.AddWithValue("@Gender", genderComboBox.SelectedItem);
            STU_Command.Parameters.AddWithValue("@BirthDate", birthDateTimePicker.Value.Date.ToShortDateString());
            STU_Command.Parameters.AddWithValue("@CivilStatus", civilStatusComboBox.SelectedItem);
            STU_Command.Parameters.AddWithValue("@Address", addressTextBox.Text);
            STU_Command.Parameters.AddWithValue("@ContactNum", Convert.ToInt32(contactNumTextBox.Text));
            STU_Command.Parameters.AddWithValue("@EnrollmentStatus", enrollmentStatusComboBox.SelectedItem);
            STU_Command.Parameters.AddWithValue("@EnrollmentType", enrollmentTypeComboBox.SelectedItem);
            STU_Command.Parameters.AddWithValue("@PaymentType", paymentTypeComboBox.SelectedItem);
            STU_Command.Parameters.AddWithValue("@MotherFirstName", motherFirstNameTextBox.Text);
            STU_Command.Parameters.AddWithValue("@MotherLastName", motherLastNameTextBox.Text);
            STU_Command.Parameters.AddWithValue("@MotherOccupation", motherOccupationTextBox.Text);
            STU_Command.Parameters.AddWithValue("@FatherFirstName", fatherFirstNameTextBox.Text);
            STU_Command.Parameters.AddWithValue("@FatherLastName", fatherLastNameTextBox.Text);
            STU_Command.Parameters.AddWithValue("@FatherOccupation", fatherOccupationTextBox.Text);
            STU_Command.ExecuteNonQuery();
            STU_DB_Connection.Close();

            insertStudentPayment();
            checkIsNullRequirements();

            STU_DB_Connection.Open();
            deleteRowFromPendingStudents.ExecuteNonQuery();
            STU_DB_Connection.Close();
            bindingNavigatorRefreshItem_Click(sender, e);
        }

        private void updateRequirements(string Table, string Column, SqlCommand Command)
        {
            STU_Command = new SqlCommand("UPDATE " + Table + " SET " + Column + " = @Param WHERE RegisterID = " + Convert.ToInt32(registerIDTextBox.Text), STU_DB_Connection);
            STU_Command.Parameters.AddWithValue("@Param", Command.ExecuteScalar());
            STU_Command.ExecuteNonQuery();
        }

        private void checkIsNullRequirements()
        {
            STU_DB_Connection.Open();
            SqlCommand frm137Data = new SqlCommand("SELECT StudForm137 FROM PendingStudents WHERE RegisterID = " + Convert.ToInt32(registerIDTextBox.Text), STU_DB_Connection);
            SqlCommand goodMoralData = new SqlCommand("SELECT GoodMoral FROM PendingStudents WHERE RegisterID = " + Convert.ToInt32(registerIDTextBox.Text), STU_DB_Connection);
            SqlCommand birthCertData = new SqlCommand("SELECT BirthCertificate FROM PendingStudents WHERE RegisterID = " + Convert.ToInt32(registerIDTextBox.Text), STU_DB_Connection);
            SqlCommand transferCertData = new SqlCommand("SELECT TransferCertificate FROM PendingStudents WHERE RegisterID = " + Convert.ToInt32(registerIDTextBox.Text), STU_DB_Connection);
            SqlCommand proofOfPaymentData = new SqlCommand("SELECT ProofOfPayment FROM PendingStudents WHERE RegisterID = " + Convert.ToInt32(registerIDTextBox.Text), STU_DB_Connection);
            if (!frm137Data.ExecuteScalar().Equals(DBNull.Value))
            {
                updateRequirements("Students", "StudForm137", frm137Data);
            }

            if (lRNTextBox.Text.Length > 0)
            {
                STU_Command = new SqlCommand("UPDATE Students SET LRN = @LRN WHERE RegisterID = " + Convert.ToInt32(registerIDTextBox.Text), STU_DB_Connection);
                STU_Command.Parameters.AddWithValue("@LRN", Convert.ToInt32(lRNTextBox.Text));
                STU_Command.ExecuteNonQuery();
            }

            if (!birthCertData.ExecuteScalar().Equals(DBNull.Value))
            {
                updateRequirements("Students", "BirthCertificate", birthCertData);
            }

            if (!goodMoralData.ExecuteScalar().Equals(DBNull.Value))
            {
                updateRequirements("Students", "GoodMoral", goodMoralData);
            }

            if (!transferCertData.ExecuteScalar().Equals(DBNull.Value))
            {
                updateRequirements("Students", "TransferCertificate", transferCertData);
            }

            if (!proofOfPaymentData.ExecuteScalar().Equals(DBNull.Value))
            {
                STU_Command = new SqlCommand("UPDATE StudentPayment SET ProofOfPayment = @Param WHERE StudentNumber = '" + studentNumberTextBox.Text + "' AND MonthOfPayment = 'August'", STU_DB_Connection);
                STU_Command.Parameters.AddWithValue("@Param", proofOfPaymentData.ExecuteScalar());
                STU_Command.ExecuteNonQuery();
            }

            STU_DB_Connection.Close();
        }

        private void insertStudentPayment()
        {

            string paymentCode = string.Empty;
            if (paymentTypeComboBox.SelectedItem.Equals("Monthly") && enrollmentTypeComboBox.SelectedItem.Equals("Grade 7"))
            {
                paymentCode = "MG7";
            }
            else if (paymentTypeComboBox.SelectedItem.Equals("Full") && enrollmentTypeComboBox.SelectedItem.Equals("Grade 7"))
            {
                paymentCode = "FG7";
            }

            if (paymentTypeComboBox.SelectedItem.Equals("Monthly"))
            {
                addPaymentType(paymentCode, paymentMethodComboBox.SelectedItem.ToString(), studentNumberTextBox.Text, "August", "Paid");
                addPaymentType(paymentCode, paymentMethodComboBox.SelectedItem.ToString(), studentNumberTextBox.Text, "September", "Pending");
                addPaymentType(paymentCode, paymentMethodComboBox.SelectedItem.ToString(), studentNumberTextBox.Text, "October", "Pending");
                addPaymentType(paymentCode, paymentMethodComboBox.SelectedItem.ToString(), studentNumberTextBox.Text, "November", "Pending");
                addPaymentType(paymentCode, paymentMethodComboBox.SelectedItem.ToString(), studentNumberTextBox.Text, "December", "Pending");
                addPaymentType(paymentCode, paymentMethodComboBox.SelectedItem.ToString(), studentNumberTextBox.Text, "January", "Pending");
                addPaymentType(paymentCode, paymentMethodComboBox.SelectedItem.ToString(), studentNumberTextBox.Text, "February", "Pending");
                addPaymentType(paymentCode, paymentMethodComboBox.SelectedItem.ToString(), studentNumberTextBox.Text, "March", "Pending");
                addPaymentType(paymentCode, paymentMethodComboBox.SelectedItem.ToString(), studentNumberTextBox.Text, "April", "Pending");
                addPaymentType(paymentCode, paymentMethodComboBox.SelectedItem.ToString(), studentNumberTextBox.Text, "May", "Pending");
            }
            else if (paymentTypeComboBox.SelectedItem.Equals("Full"))
            {
                addPaymentType(paymentCode, paymentMethodComboBox.SelectedItem.ToString(), studentNumberTextBox.Text, "August", "Paid");
            }
        }

        private void addPaymentType(string paymentCode, string paymentMethod, string studentNumber, string month, string status)
        {
            if (STU_DB_Connection.State == ConnectionState.Open)
            {
                STU_DB_Connection.Close();
            }

            STU_Command = new SqlCommand("INSERT INTO StudentPayment(PaymentCode, PaymentMethod, StudentNumber, MonthOfPayment, PaymentStatus)" +
                                             "VALUES (@PaymentCode, @PaymentMethod, @StudentNumber, @MonthOfPayment, @PaymentStatus)", STU_DB_Connection);
            STU_Command.Parameters.AddWithValue("@PaymentCode", paymentCode);
            STU_Command.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
            STU_Command.Parameters.AddWithValue("@StudentNumber", studentNumber);
            STU_Command.Parameters.AddWithValue("@MonthOfPayment", month);
            STU_Command.Parameters.AddWithValue("@PaymentStatus", status);

            STU_DB_Connection.Open();
            STU_Command.ExecuteNonQuery();
            STU_DB_Connection.Close();
        }

        private void generateStudNumButton_Click(object sender, EventArgs e)
        {
            SqlCommand studNumData = new SqlCommand("SELECT COUNT(*) FROM Students", STU_DB_Connection);
            STU_DB_Connection.Open();
            int generateStudNum = studNumData.ExecuteScalar().Equals(DBNull.Value) ? 1 : Convert.ToInt32(studNumData.ExecuteScalar()) + 1;
            STU_DB_Connection.Close();
            string studNum = string.Empty;

            if (generateStudNum < 10)
            {
                studNum = "S000" + generateStudNum.ToString();
            }
            else if (generateStudNum >= 10 && generateStudNum < 100)
            {
                studNum = "S00" + generateStudNum.ToString();
            }
            else if (generateStudNum >= 100 && generateStudNum < 1000)
            {
                studNum = "S0" + generateStudNum.ToString();
            }
            else if (generateStudNum >= 1000)
            {
                studNum = "S" + generateStudNum.ToString();
            }

            genStudNumTextBox.Text = studNum;
            studentNumberTextBox.Text = genStudNumTextBox.Text;
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
