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
    public partial class StudentPayment : Form
    {
        private SqlConnection STU_DB_Connection;
        private SqlCommand STU_Command;

        public StudentPayment()
        {
            InitializeComponent();
            //STU_DB_Connection = new SqlConnection("Data Source=112.204.105.87,16969;Initial Catalog=STU_DB;Persist Security Info=True;User ID=STU_DB_Login;Password=123;TrustServerCertificate=True");
            STU_DB_Connection = new SqlConnection(Properties.Settings.Default.STU_DBConnectionString);
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
        }

        private void studentPaymentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            STU_DB_Connection.Open();
            try
            {
                SqlCommand proofOfPaymentData = new SqlCommand("SELECT ProofOfPayment FROM StudentPayment WHERE StudentNumber = '" + studentNumberTextBox.Text + "' AND MonthOfPayment = '" + monthOfPaymentComboBox.SelectedItem.ToString() + "'", STU_DB_Connection);
                bool isProofOfPaymentData = proofOfPaymentData.ExecuteScalar().Equals(DBNull.Value) ? true : false;
                
                while (paymentMethodComboBox.Text.Length > 0 && (paymentMethodComboBox.SelectedItem.Equals("GCASH") || paymentMethodComboBox.SelectedItem.Equals("BANK TRANSFER")))
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
                    break;
                }
            }
            catch (FormatException fe)
            {
                STU_DB_Connection.Close();
                viewProofOfPaymentButton.Visible = false;
                deleteProofOfPaymentButton.Visible = false;
                uploadProofOfPaymentButton.Visible = false;
                return;
            }
            catch(NullReferenceException nfe)
            {
                STU_DB_Connection.Close();
                viewProofOfPaymentButton.Visible = false;
                deleteProofOfPaymentButton.Visible = false;
                uploadProofOfPaymentButton.Visible = false;
                return;
            }
            STU_DB_Connection.Close();
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
            string command = "SELECT " + Column + " FROM StudentPayment WHERE StudentNumber = '" + studentNumberTextBox.Text + "' AND MonthOfPayment = '" + monthOfPaymentComboBox.SelectedItem.ToString() + "'";
            ImageViewer imageViewer = new ImageViewer(Column, command);
            imageViewer.Show();
        }

        private void viewFile(string Column)
        {
            string command = "SELECT " + Column + " FROM StudentPayment WHERE StudentNumber = '" + studentNumberTextBox.Text + "' AND MonthOfPayment = '" + monthOfPaymentComboBox.SelectedItem.ToString() + "'";
            PDFViewer pdfViewer = new PDFViewer(Column, command);
            pdfViewer.Show();
        }

        private void uploadFile(string Column)
        {
            byte[] data = File.ReadAllBytes(openFileDialog1.FileName);
            STU_Command = new SqlCommand("UPDATE StudentPayment SET " + Column + " = @Data WHERE StudentNumber = @StudNum AND MonthOfPayment = @Month", STU_DB_Connection);
            STU_Command.Parameters.AddWithValue("@StudNum", studentNumberTextBox.Text);
            STU_Command.Parameters.AddWithValue("@Month", monthOfPaymentComboBox.SelectedItem.ToString());
            STU_Command.Parameters.AddWithValue("@Data", data);
            STU_DB_Connection.Open();
            STU_Command.ExecuteNonQuery();
            STU_DB_Connection.Close();
        }

        private void deleteFile(string Column)
        {
            STU_Command = new SqlCommand("UPDATE StudentPayment SET " + Column + " = NULL WHERE StudentNumber = @StudNum AND MonthOfPayment = @Month", STU_DB_Connection);
            STU_Command.Parameters.AddWithValue("@StudNum", studentNumberTextBox.Text);
            STU_Command.Parameters.AddWithValue("@Month", monthOfPaymentComboBox.SelectedItem.ToString());
            STU_DB_Connection.Open();
            STU_Command.ExecuteNonQuery();
            STU_DB_Connection.Close();
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

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentPaymentTableAdapter.Search(this.sTU_DBDataSet.StudentPayment, paymentCodeToolStripTextBox.Text, studentNumberToolStripTextBox.Text, monthOfPaymentToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void paymentCodeToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.studentPaymentTableAdapter.Search(this.sTU_DBDataSet.StudentPayment, paymentCodeToolStripTextBox.Text, studentNumberToolStripTextBox.Text, monthOfPaymentToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void studentNumberToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.studentPaymentTableAdapter.Search(this.sTU_DBDataSet.StudentPayment, paymentCodeToolStripTextBox.Text, studentNumberToolStripTextBox.Text, monthOfPaymentToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void monthOfPaymentToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.studentPaymentTableAdapter.Search(this.sTU_DBDataSet.StudentPayment, paymentCodeToolStripTextBox.Text, studentNumberToolStripTextBox.Text, monthOfPaymentToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
