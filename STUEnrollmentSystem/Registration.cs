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
    public partial class Registration : Form
    {
        private SqlConnection STU_DB_Connection;
        private SqlCommand STU_Command;

        public Registration()
        {
            InitializeComponent();
            STU_DB_Connection = new SqlConnection("Data Source=112.204.105.87,16969;Initial Catalog=STU_DB;Persist Security Info=True;User ID=STU_DB_Login;Password=123;TrustServerCertificate=True");
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
            STU_DB_Connection.Open();
            try
            {
                birthDateTimePicker.Text = birthDateTextBox.Text;
                SqlCommand frm137Data = new SqlCommand("SELECT StudForm137 FROM Registration WHERE RegisterID = " + Convert.ToInt32(registerIDTextBox.Text), STU_DB_Connection);
                SqlCommand goodMoralData = new SqlCommand("SELECT GoodMoral FROM Registration WHERE RegisterID = " + Convert.ToInt32(registerIDTextBox.Text), STU_DB_Connection);
                SqlCommand birthCertData = new SqlCommand("SELECT BirthCertificate FROM Registration WHERE RegisterID = " + Convert.ToInt32(registerIDTextBox.Text), STU_DB_Connection);
                SqlCommand transferCertData = new SqlCommand("SELECT TransferCertificate FROM Registration WHERE RegisterID = " + Convert.ToInt32(registerIDTextBox.Text), STU_DB_Connection);
                bool isFrm137Data = frm137Data.ExecuteScalar().Equals(DBNull.Value) ? true : false;
                bool isGoodMoralData = goodMoralData.ExecuteScalar().Equals(DBNull.Value) ? true : false;
                bool isBirthCertData = birthCertData.ExecuteScalar().Equals(DBNull.Value) ? true : false;
                bool isTransferCertData = transferCertData.ExecuteScalar().Equals(DBNull.Value) ? true : false;
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

        private void viewFile(string Column)
        {
            string command = "SELECT " + Column + " FROM Registration WHERE RegisterID = " + registerIDTextBox.Text;
            PDFViewer pdfViewer = new PDFViewer(Column, command);
            pdfViewer.Show();
        }

        private void uploadFile(string Column)
        {
            byte[] data = File.ReadAllBytes(openFileDialog1.FileName);
            STU_Command = new SqlCommand("UPDATE Registration SET " + Column + " = @Data WHERE RegisterID = @RegID", STU_DB_Connection);
            STU_Command.Parameters.AddWithValue("@RegID", Convert.ToInt32(registerIDTextBox.Text));
            STU_Command.Parameters.AddWithValue("@Data", data);
            STU_DB_Connection.Open();
            STU_Command.ExecuteNonQuery();
            STU_DB_Connection.Close();
        }

        private void deleteFile(string Column)
        {
            STU_Command = new SqlCommand("UPDATE Registration SET " + Column + " = NULL WHERE RegisterID = @RegID", STU_DB_Connection);
            STU_Command.Parameters.AddWithValue("@RegID", Convert.ToInt32(registerIDTextBox.Text));
            STU_DB_Connection.Open();
            STU_Command.ExecuteNonQuery();
            STU_DB_Connection.Close();
        }

        private void registrationBindingNavigatorMoveToCashierItem_Click(object sender, EventArgs e)
        {
            STU_DB_Connection.Open();
            SqlCommand deleteRowFromRegistration = new SqlCommand("DELETE FROM Registration WHERE RegisterID = " + Convert.ToInt32(registerIDTextBox.Text), STU_DB_Connection);
            SqlCommand frm137Data = new SqlCommand("SELECT StudForm137 FROM Registration WHERE RegisterID = " + Convert.ToInt32(registerIDTextBox.Text), STU_DB_Connection);
            SqlCommand goodMoralData = new SqlCommand("SELECT GoodMoral FROM Registration WHERE RegisterID = " + Convert.ToInt32(registerIDTextBox.Text), STU_DB_Connection);
            SqlCommand birthCertData = new SqlCommand("SELECT BirthCertificate FROM Registration WHERE RegisterID = " + Convert.ToInt32(registerIDTextBox.Text), STU_DB_Connection);
            SqlCommand transferCertData = new SqlCommand("SELECT TransferCertificate FROM Registration WHERE RegisterID = " + Convert.ToInt32(registerIDTextBox.Text), STU_DB_Connection);
            STU_Command = new SqlCommand("INSERT INTO PendingStudents(RegisterID, EnrollmentStatus, StudFirstName, StudMidName, StudLastName, Gender, BirthDate, CivilStatus, Address, ContactNum, EnrollmentType, InstallmentType, " +
                                                         "MotherFirstName, MotherLastName, MotherOccupation, FatherFirstName, FatherLastName, FatherOccupation, StudForm137, LRN, BirthCertificate, GoodMoral, TransferCertificate) VALUES (@RegisterID, @EnrollmentStatus, @StudFirstName, @StudMidName, @StudLastName, @Gender, @BirthDate, @CivilStatus, @Address, @ContactNum, @EnrollmentType, @InstallmentType, " +
                                                         "@MotherFirstName, @MotherLastName, @MotherOccupation, @FatherFirstName, @FatherLastName, @FatherOccupation, @StudForm137, @LRN, @BirthCertificate, @GoodMoral, @TransferCertificate)",
                                                                        STU_DB_Connection);
            STU_Command.Parameters.AddWithValue("@RegisterID", Convert.ToInt32(registerIDTextBox.Text));
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
            STU_Command.Parameters.AddWithValue("@InstallmentType", installmentTypeComboBox.SelectedItem);
            STU_Command.Parameters.AddWithValue("@MotherFirstName", motherFirstNameTextBox.Text);
            STU_Command.Parameters.AddWithValue("@MotherLastName", motherLastNameTextBox.Text);
            STU_Command.Parameters.AddWithValue("@MotherOccupation", motherOccupationTextBox.Text);
            STU_Command.Parameters.AddWithValue("@FatherFirstName", fatherFirstNameTextBox.Text);
            STU_Command.Parameters.AddWithValue("@FatherLastName", fatherLastNameTextBox.Text);
            STU_Command.Parameters.AddWithValue("@FatherOccupation", fatherOccupationTextBox.Text);
            STU_Command.Parameters.AddWithValue("@StudForm137", frm137Data.ExecuteScalar());
            STU_Command.Parameters.AddWithValue("@LRN", Convert.ToInt32(lRNTextBox.Text));
            STU_Command.Parameters.AddWithValue("@BirthCertificate", birthCertData.ExecuteScalar());
            STU_Command.Parameters.AddWithValue("@GoodMoral", goodMoralData.ExecuteScalar());
            STU_Command.Parameters.AddWithValue("@TransferCertificate", transferCertData.ExecuteScalar());
            STU_Command.ExecuteNonQuery();
            deleteRowFromRegistration.ExecuteNonQuery();
            STU_DB_Connection.Close();

            registrationBindingNavigatorRefreshItem_Click(sender, e);
        }
    }
}
