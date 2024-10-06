using Syncfusion.XPS;
using System;
using System.Collections;
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
    public partial class Student : Form
    {
        private SqlConnection STU_DB_Connection;
        private SqlCommand STU_Command;

        public Student()
        {
            InitializeComponent();
            STU_DB_Connection = new SqlConnection("Data Source=112.204.105.87,16969;Initial Catalog=STU_DB;Persist Security Info=True;User ID=STU_DB_Login;Password=123;TrustServerCertificate=True");
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            birthDateTextBox.Text = birthDateTimePicker.Value.Date.ToShortDateString();
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTU_DBDataSet);
        }

        private void Student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTU_DBDataSet.GradeLevel' table. You can move, or remove it, as needed.
            this.gradeLevelTableAdapter.Fill(this.sTU_DBDataSet.GradeLevel);
            this.sectionsTableAdapter.Fill(this.sTU_DBDataSet.Sections);
            this.studentsTableAdapter.Fill(this.sTU_DBDataSet.Students);
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
            this.studentsTableAdapter.Fill(sTU_DBDataSet.Students);
        }

        private void studentsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            STU_DB_Connection.Open();
            try
            {
                birthDateTimePicker.Text = birthDateTextBox.Text;

                SqlCommand sectionData = new SqlCommand("SELECT SectionTitle FROM Sections WHERE GradeCode = " + enrollmentTypeComboBox.ValueMember + " AND StudCount < Capacity", STU_DB_Connection);
                List<string> sectionList = new List<string>();
                using (SqlDataReader reader = sectionData.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        sectionList.Add(reader[0].ToString());
                    }
                }

                sectionComboBox.Items.Clear();
                foreach (string items in sectionList)
                {
                    sectionComboBox.Items.Add(items);
                }

                SqlCommand frm137Data = new SqlCommand("SELECT StudForm137 FROM Students WHERE StudentNumber = '" + studentNumberTextBox.Text + "'", STU_DB_Connection);
                SqlCommand goodMoralData = new SqlCommand("SELECT GoodMoral FROM Students WHERE StudentNumber = '" + studentNumberTextBox.Text + "'", STU_DB_Connection);
                SqlCommand birthCertData = new SqlCommand("SELECT BirthCertificate FROM Students WHERE StudentNumber = '" + studentNumberTextBox.Text + "'", STU_DB_Connection);
                SqlCommand transferCertData = new SqlCommand("SELECT TransferCertificate FROM Students WHERE StudentNumber = '" + studentNumberTextBox.Text + "'", STU_DB_Connection);
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
            catch(NullReferenceException nfe)
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
            string command = "SELECT " + Column + " FROM Students WHERE StudentNumber = '" + studentNumberTextBox.Text + "'";
            PDFViewer pdfViewer = new PDFViewer(Column, command);
            pdfViewer.Show();
        }

        private void uploadFile(string Column)
        {
            byte[] data = File.ReadAllBytes(openFileDialog1.FileName);
            STU_Command = new SqlCommand("UPDATE Students SET " + Column + " = @Data WHERE StudentNumber = @StudNum", STU_DB_Connection);
            STU_Command.Parameters.AddWithValue("@StudNum", studentNumberTextBox.Text);
            STU_Command.Parameters.AddWithValue("@Data", data);
            STU_DB_Connection.Open();
            STU_Command.ExecuteNonQuery();
            STU_DB_Connection.Close();
        }

        private void deleteFile(string Column)
        {
            STU_Command = new SqlCommand("UPDATE Students SET " + Column + " = NULL WHERE StudentNumber = @StudNum", STU_DB_Connection);
            STU_Command.Parameters.AddWithValue("@StudNum", studentNumberTextBox.Text);
            STU_DB_Connection.Open();
            STU_Command.ExecuteNonQuery();
            STU_DB_Connection.Close();
        }
    }
}
