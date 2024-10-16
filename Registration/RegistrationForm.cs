﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class RegistrationForm : Form
    {
        private SqlConnection STU_DB_Connection;
        private SqlCommand STU_Command;

        public RegistrationForm()
        {
            InitializeComponent();
            //STU_DB_Connection = new SqlConnection("Data Source=112.204.105.87,16969;Initial Catalog=STU_DB;Persist Security Info=True;User ID=STU_DB_Login;Password=123;TrustServerCertificate=True");
            STU_DB_Connection = new SqlConnection(Properties.Settings.Default.STU_DBConnectionString);
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void register_Button_Click(object sender, EventArgs e)
        {
            STU_DB_Connection.Open();
            SqlCommand regId = new SqlCommand("SELECT MAX(RegisterID) FROM Registration", STU_DB_Connection);
            SqlCommand pendingStudId = new SqlCommand("SELECT MAX(RegisterID) FROM PendingStudents", STU_DB_Connection);
            SqlCommand studentsId = new SqlCommand("SELECT MAX(RegisterID) FROM Students", STU_DB_Connection);
            int RegisterID = regId.ExecuteScalar().Equals(DBNull.Value) ? 1 : Convert.ToInt32(regId.ExecuteScalar()) + 1;
            int PendingID = pendingStudId.ExecuteScalar().Equals(DBNull.Value) ? 1 : Convert.ToInt32(pendingStudId.ExecuteScalar()) + 1;
            int StudentsID = studentsId.ExecuteScalar().Equals(DBNull.Value) ? 1 : Convert.ToInt32(studentsId.ExecuteScalar()) + 1;
            int finalID = Math.Max(Math.Max(RegisterID, PendingID), StudentsID);

            STU_Command = new SqlCommand("INSERT INTO Registration(RegisterID, EnrollmentStatus, StudFirstName, StudMidName, StudLastName, Gender, BirthDate, CivilStatus, Address, ContactNum, EnrollmentType, PaymentType, " +
                                                         "MotherFirstName, MotherLastName, MotherOccupation, FatherFirstName, FatherLastName, FatherOccupation) VALUES (@RegisterID, @EnrollmentStatus, @StudFirstName, @StudMidName, @StudLastName, @Gender, @BirthDate, @CivilStatus, @Address, @ContactNum, @EnrollmentType, @PaymentType, " +
                                                         "@MotherFirstName, @MotherLastName, @MotherOccupation, @FatherFirstName, @FatherLastName, @FatherOccupation)",
                                                                        STU_DB_Connection);
            STU_Command.Parameters.AddWithValue("@RegisterID", finalID);
            STU_Command.Parameters.AddWithValue("@EnrollmentStatus", enrollmentStatusComboBox.SelectedItem);
            STU_Command.Parameters.AddWithValue("@StudFirstName", studFirstNameTextBox.Text);
            STU_Command.Parameters.AddWithValue("@StudMidName", studMidNameTextBox.Text);
            STU_Command.Parameters.AddWithValue("@StudLastName", studLastNameTextBox.Text);
            STU_Command.Parameters.AddWithValue("@Gender", genderComboBox.SelectedItem);
            STU_Command.Parameters.AddWithValue("@BirthDate", birthDateTimePicker.Value.Date.ToShortDateString());
            STU_Command.Parameters.AddWithValue("@CivilStatus", civilStatusComboBox.SelectedItem);
            STU_Command.Parameters.AddWithValue("@Address", addressTextBox.Text);
            STU_Command.Parameters.AddWithValue("@ContactNum", Convert.ToInt32(contactNumTextBox.Text));
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
        }

        private void enrollmentStatusComboBox_TextChanged(object sender, EventArgs e)
        {
            if (enrollmentStatusComboBox.SelectedItem.Equals("NEW"))
            {
                label3.Text = "• LRN, Form 137 / 138, Birth Certificate, Good Moral";
            }
            else if (enrollmentStatusComboBox.SelectedItem.Equals("TRANSFEREE"))
            {
                label3.Text = "• Transfer Certificate, LRN, Form 137/138, Birth Certificate, Good Moral";
            }
        }
    }
}
