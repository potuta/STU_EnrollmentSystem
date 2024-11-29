using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
        private SqlConnection _connection;

        public RegistrationForm()
        {
            InitializeComponent();
            //STU_DB_Connection = new SqlConnection("Data Source=112.204.105.87,16969;Initial Catalog=STU_DB;Persist Security Info=True;User ID=STU_DB_Login;Password=123;TrustServerCertificate=True");
            _connection = new SqlConnection(Properties.Settings.Default.STU_DBConnectionString);
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void register_Button_Click(object sender, EventArgs e)
        {
            _connection.Open();
            SqlCommand regId = new SqlCommand("SELECT MAX(RegisterID) FROM Registration", _connection);
            SqlCommand pendingStudId = new SqlCommand("SELECT MAX(RegisterID) FROM PendingStudents", _connection);
            SqlCommand studentsId = new SqlCommand("SELECT MAX(RegisterID) FROM Students", _connection);
            int RegisterID = regId.ExecuteScalar().Equals(DBNull.Value) ? 1 : Convert.ToInt32(regId.ExecuteScalar()) + 1;
            int PendingID = pendingStudId.ExecuteScalar().Equals(DBNull.Value) ? 1 : Convert.ToInt32(pendingStudId.ExecuteScalar()) + 1;
            int StudentsID = studentsId.ExecuteScalar().Equals(DBNull.Value) ? 1 : Convert.ToInt32(studentsId.ExecuteScalar()) + 1;
            int finalID = Math.Max(Math.Max(RegisterID, PendingID), StudentsID);

            SqlCommand command = new SqlCommand("INSERT INTO Registration(RegisterID, EnrollmentStatus, StudFirstName, StudMidName, StudLastName, Gender, BirthDate, CivilStatus, Address, ContactNum, EnrollmentType, PaymentType, " +
                                                         "MotherFirstName, MotherLastName, MotherOccupation, FatherFirstName, FatherLastName, FatherOccupation) VALUES (@RegisterID, @EnrollmentStatus, @StudFirstName, @StudMidName, @StudLastName, @Gender, @BirthDate, @CivilStatus, @Address, @ContactNum, @EnrollmentType, @PaymentType, " +
                                                         "@MotherFirstName, @MotherLastName, @MotherOccupation, @FatherFirstName, @FatherLastName, @FatherOccupation)",
                                                                        _connection);
            command.Parameters.AddWithValue("@RegisterID", Convert.ToString(finalID));
            command.Parameters.AddWithValue("@EnrollmentStatus", enrollmentStatusComboBox.SelectedItem);
            command.Parameters.AddWithValue("@StudFirstName", studFirstNameTextBox.Text);
            command.Parameters.AddWithValue("@StudMidName", studMidNameTextBox.Text);
            command.Parameters.AddWithValue("@StudLastName", studLastNameTextBox.Text);
            command.Parameters.AddWithValue("@Gender", genderComboBox.SelectedItem);
            command.Parameters.AddWithValue("@BirthDate", birthDateTimePicker.Value.Date.ToShortDateString());
            command.Parameters.AddWithValue("@CivilStatus", civilStatusComboBox.SelectedItem);
            command.Parameters.AddWithValue("@Address", addressTextBox.Text);
            command.Parameters.AddWithValue("@ContactNum", contactNumTextBox.Text);
            command.Parameters.AddWithValue("@EnrollmentType", enrollmentTypeComboBox.SelectedItem);
            command.Parameters.AddWithValue("@PaymentType", paymentTypeComboBox.SelectedItem);
            command.Parameters.AddWithValue("@MotherFirstName", motherFirstNameTextBox.Text);
            command.Parameters.AddWithValue("@MotherLastName", motherLastNameTextBox.Text);
            command.Parameters.AddWithValue("@MotherOccupation", motherOccupationTextBox.Text);
            command.Parameters.AddWithValue("@FatherFirstName", fatherFirstNameTextBox.Text);
            command.Parameters.AddWithValue("@FatherLastName", fatherLastNameTextBox.Text);
            command.Parameters.AddWithValue("@FatherOccupation", fatherOccupationTextBox.Text);
            command.ExecuteNonQuery();
            _connection.Close();

            if (!personalEmailTextBox.Text.Equals(string.Empty))
            {
                UpdateRegistration("Registration", "PersonalEmail", personalEmailTextBox.Text, Convert.ToString(finalID));
            }

            if (!guardianEmailTextBox.Text.Equals(string.Empty))
            {
                UpdateRegistration("Registration", "GuardianEmail", guardianEmailTextBox.Text, Convert.ToString(finalID));
            }
        }

        private void enrollmentStatusComboBox_TextChanged(object sender, EventArgs e)
        {
            if (enrollmentStatusComboBox.Text.Equals("NEW"))
            {
                label3.Text = "• LRN, Form 137 / 138, Birth Certificate, Good Moral";
            }
            else if (enrollmentStatusComboBox.Text.Equals("TRANSFEREE"))
            {
                label3.Text = "• Transfer Certificate, LRN, Form 137/138, Birth Certificate, Good Moral";
            }
        }

        public void UpdateRegistration(string table, string column, string data, string registerID)
        {
            string query = $"UPDATE {table} SET {column} = @Param WHERE RegisterID = @RegisterID";
            SqlCommand command = new SqlCommand(query, _connection);
            _connection.Open();
            command.Parameters.AddWithValue("@Param", data);
            command.Parameters.AddWithValue("@RegisterID", registerID);
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
