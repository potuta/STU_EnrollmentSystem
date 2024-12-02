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
using System.Text.RegularExpressions;
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
            _connection = new SqlConnection(Properties.Settings.Default.STU_DBConnectionString);
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void register_Button_Click(object sender, EventArgs e)
        {
            var controlsToValidate = new Control[]
            {
                enrollmentStatusComboBox,
                studFirstNameTextBox,
                studMidNameTextBox,
                studLastNameTextBox,
                genderComboBox,
                birthDateTimePicker,
                civilStatusComboBox,
                addressTextBox,
                contactNumTextBox,
                guardianEmailTextBox,
                enrollmentTypeComboBox,
                paymentTypeComboBox,
                motherFirstNameTextBox,
                motherLastNameTextBox,
                motherOccupationTextBox,
                fatherFirstNameTextBox,
                fatherLastNameTextBox,
                fatherOccupationTextBox
            };

            if (controlsToValidate.Any(control => string.IsNullOrWhiteSpace(control.Text)))
            {
                MessageBox.Show("Missing details, please make sure to enter complete details.", "Error", MessageBoxButtons.OK);
                return;
            }

            insertIntoRegistration();

            string message = "Your registration has been successfully submitted! To stay updated with STU enrollment and payment dates, follow our official FB page at @STU_FB. " +
                "We will also notify you through your specified email for the enrollment details. Thank you for choosing STU!";

            MessageBox.Show(message, "Registration Complete!", MessageBoxButtons.OK);

            foreach (Control control in controlsToValidate) 
            {
                control.ResetText();
            }

            personalEmailTextBox.Clear();
        }

        private void insertIntoRegistration()
        {
            string query = "INSERT INTO Registration(RegisterID, EnrollmentStatus, StudFirstName, StudMidName, StudLastName, Gender, BirthDate, CivilStatus, Address, ContactNum, EnrollmentType, PaymentType, " +
                            "MotherFirstName, MotherLastName, MotherOccupation, FatherFirstName, FatherLastName, FatherOccupation) VALUES (@RegisterID, @EnrollmentStatus, @StudFirstName, @StudMidName, @StudLastName, @Gender, @BirthDate, @CivilStatus, @Address, @ContactNum, @EnrollmentType, @PaymentType, " +
                            "@MotherFirstName, @MotherLastName, @MotherOccupation, @FatherFirstName, @FatherLastName, @FatherOccupation)";

            try
            {
                int regID = generateRegisterID();
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@RegisterID", Convert.ToString(regID));
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

                    _connection.Open();
                    command.ExecuteNonQuery();
                    _connection.Close();
                }

                if (!personalEmailTextBox.Text.Equals(string.Empty))
                {
                    UpdateRegistration("Registration", "PersonalEmail", personalEmailTextBox.Text, Convert.ToString(regID));
                }

                if (!guardianEmailTextBox.Text.Equals(string.Empty))
                {
                    UpdateRegistration("Registration", "GuardianEmail", guardianEmailTextBox.Text, Convert.ToString(regID));
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in insertIntoRegistration: {ex.Message}");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in insertIntoRegistration: {ex.Message}");
                return;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        private int generateRegisterID()
        {
            string queryRegID = "SELECT MAX(CAST(RegisterID AS INT)) FROM Registration";
            string queryPendingStudentRegID = "SELECT MAX(CAST(RegisterID AS INT)) FROM PendingStudents";
            string queryStudentsRegID = "SELECT MAX(CAST(RegisterID AS INT)) FROM Students";
            int result = 0;

            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    _connection.Open();
                    command.Connection = _connection;

                    // Registration RegisterID
                    command.CommandText = queryRegID;
                    int registerID = 0;
                    var getRegID = command.ExecuteScalar();
                    if (getRegID != null && getRegID != DBNull.Value)
                    {
                        registerID = Convert.ToInt32(getRegID) + 1;
                    }
                    else
                    {
                        registerID = 1;
                    }

                    // PendingStudents RegisterID
                    command.CommandText = queryPendingStudentRegID;
                    int pendingStudentRegID = 0;
                    var getPendingStudentID = command.ExecuteScalar();
                    if (getPendingStudentID != null && getPendingStudentID != DBNull.Value)
                    {
                        pendingStudentRegID = Convert.ToInt32(getPendingStudentID) + 1;
                    }
                    else
                    {
                        pendingStudentRegID = 1;
                    }

                    // Students RegisterID
                    command.CommandText = queryStudentsRegID;
                    int studentsRegisterID = 0;
                    var getStudentsRegID = command.ExecuteScalar();
                    if (getStudentsRegID != null && getStudentsRegID != DBNull.Value)
                    {
                        studentsRegisterID = Convert.ToInt32(getStudentsRegID) + 1;
                    }
                    else
                    {
                        studentsRegisterID = 1;
                    }

                    result = Math.Max(Math.Max(registerID, pendingStudentRegID), studentsRegisterID);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in generateRegisterID: {ex.Message}");
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in generateRegisterID: {ex.Message}");
                return result;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return result;
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

        private void UpdateRegistration(string table, string column, string data, string registerID)
        {
            string query = $"UPDATE {table} SET {column} = @Param WHERE RegisterID = @RegisterID";

            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    _connection.Open();
                    command.Parameters.AddWithValue("@Param", data);
                    command.Parameters.AddWithValue("@RegisterID", registerID);
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in UpdateRegistration: {ex.Message}");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error in UpdateRegistration: {ex.Message}");
                return;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        private void showSubPanel(Panel subPanel)
        {
            if (subPanel.Visible == false)
            {
                subPanel.Visible = true;
            }
            else
            {
                subPanel.Visible = false;
            }
        }

        private void studentsInfoButton_Click(object sender, EventArgs e)
        {
            showSubPanel(studentsPanel);
        }

        private void contactInfoButton_Click(object sender, EventArgs e)
        {
            showSubPanel(contactPanel);
        }

        private void parentsInfoButton_Click(object sender, EventArgs e)
        {
            showSubPanel(parentsPanel);
        }
    }
}
