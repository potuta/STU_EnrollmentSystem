using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUEnrollmentSystem
{
    public partial class frmSTU_Dashboard : Form
    {
        public static frmSTU_Dashboard Instance {  get; private set; }
        private Dictionary<string, Button> _buttons;
        public Label SchoolYearLabel => schoolYearLabel;
        //public Button EnrollmentButton => enrollmentButton;
        //public Button StudentButton => studentButton;
        //public Button BillingButton => billingButton;
        //public Button AcademicButton => academicButton;
        //public Button FacultyButton => facultyButton;
        //public Button RegistrationButton => registrationButton;
        //public Button ApprovedButton => approvedButton;
        //public Button ManageStudentButton => manageStudentButton;
        //public Button PendingRequirementsButton => pendingRequirementsButton;
        //public Button ManagePaymentButton => managePaymentButton;
        //public Button BillingReportButton => billingReportButton;
        //public Button FeesButton => feesButton;
        //public Button PaymentTypeButton => paymentTypeButton;
        //public Button Section_ScheduleButton => section_ScheduleButton;
        //public Button Level_SubjectButton => level_SubjectsButton;
        //public Button TeacherButton => teacherButton;
        //public Button Users_RolesButton => users_RolesButton;

        public frmSTU_Dashboard()
        {
            InitializeComponent();
            Instance = this;
            InitializeButtons();
            InitializeSelectedSchoolYear();
            InitializeUserLoginRole(frmLogin.Role);
            MessageBox.Show("Welcome " + frmLogin.Role + ": " + frmLogin.Username);
        }

        private void STU_Dashboard_Load(object sender, EventArgs e)
        {
            userLabel.Text = "User: " + frmLogin.Username;
            roleLabel.Text = "Role: " + frmLogin.Role;
            openChildForm(new frmDashboardDisplay());
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

        private void InitializeButtons()
        {
            _buttons = new Dictionary<string, Button>
            {
                { "EnrollmentButton", enrollmentButton },
                { "StudentButton", studentButton },
                { "BillingButton", billingButton },
                { "AcademicButton", academicButton },
                { "FacultyButton", facultyButton },
                { "RegistrationButton", registrationButton },
                { "ApprovedButton", approvedButton },
                { "ManageStudentButton", manageStudentButton },
                { "PendingRequirementsButton", pendingRequirementsButton },
                { "ManagePaymentButton", managePaymentButton },
                { "BillingReportButton", billingReportButton },
                { "FeesButton", feesButton },
                { "PaymentTypeButton", paymentTypeButton },
                { "Section_ScheduleButton", section_ScheduleButton },
                { "Level_SubjectButton", level_SubjectsButton },
                { "TeacherButton", teacherButton },
                { "Users_RolesButton", users_RolesButton }
            };
        }

        public Button GetButton(string buttonName)
        {
            if (_buttons.TryGetValue(buttonName, out var button))
            {
                return button;
            }
            throw new KeyNotFoundException($"Button '{buttonName}' does not exist.");
        }

        public void SetButtonEnabled(string buttonName, bool isEnabled)
        {
            var button = GetButton(buttonName);
            button.Enabled = isEnabled;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                panel_main.Controls.Remove(activeForm);
                activeForm.Close();
                activeForm.Dispose(); 
                activeForm = null;
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(activeForm);
            panel_main.Tag = activeForm;
            activeForm.BringToFront();
            activeForm.Show();
        }

        private void InitializeUserLoginRole(string role)
        {
            if (role.Equals("Admin"))
            {
                frmLogin.Role = "Administrator";

                enrollmentButton.Enabled = true;
                studentButton.Enabled = true;
                billingButton.Enabled = true;
                academicButton.Enabled = true;
                facultyButton.Enabled = true;
            }
            else if (role.Equals("A"))
            {
                frmLogin.Role = "Admission";

                enrollmentButton.Enabled = true;
                    registrationButton.Enabled = true;
                    approvedButton.Enabled = false;

                studentButton.Enabled = true;
                    manageStudentButton.Enabled = false;
                    pendingRequirementsButton.Enabled = true;

                billingButton.Enabled = false;
                academicButton.Enabled = true;
                facultyButton.Enabled = false;
            }
            else if (role.Equals("C"))
            {
                frmLogin.Role = "Cashier";

                enrollmentButton.Enabled = true;
                    registrationButton.Enabled = false;
                    approvedButton.Enabled = true;

                studentButton.Enabled = false;
                billingButton.Enabled = true;
                academicButton.Enabled = true;
                facultyButton.Enabled = false;
            }
            else if (role.Equals("R")) 
            {
                frmLogin.Role = "Registrar";

                enrollmentButton.Enabled = false;

                studentButton.Enabled = true;
                    manageStudentButton.Enabled = true;
                    pendingRequirementsButton.Enabled = true;

                billingButton.Enabled = false;
                academicButton.Enabled = true;
                facultyButton.Enabled = false;
            }
        }

        public void InitializeSelectedSchoolYear()
        {
            string selectedSchoolYear = ConnectionFactory.GetSelectedSchoolYearInConnectionString(ConnectionFactory.GetConnectionString());
            schoolYearLabel.Text = "S.Y.";
            schoolYearLabel.Text += $" {selectedSchoolYear}";
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            LoggingService.LogInformation($"User has logged out: UserID: {frmLogin.UserID} Username: {frmLogin.Username}");
        }

        private void enrollmentButton_Click(object sender, EventArgs e)
        {
            showSubPanel(enrollmentSubPanel);
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            showSubPanel(studentSubPanel);
        }

        private void billingButton_Click(object sender, EventArgs e)
        {
            showSubPanel(billingSubPanel);
        }

        private void academicButton_Click(object sender, EventArgs e)
        {
            showSubPanel(academicSubPanel);
        }

        private void facultyButton_Click(object sender, EventArgs e)
        {
            showSubPanel(facultySubPanel);
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            if (sender == registrationButton)
            {
                openChildForm(new frmRegistration());
            }
            else if (sender == approvedButton)
            {
                openChildForm(new frmPendingStudents());
            }
            else if (sender == manageStudentButton)
            {
                openChildForm(new frmStudent());
            }
            else if (sender == pendingRequirementsButton)
            {
                openChildForm(new frmPendingRequirements());
            }
            else if (sender == managePaymentButton)
            {
                openChildForm(new frmStudentPayment());
            }
            else if (sender == section_ScheduleButton)
            {
                openChildForm(new frmSection_Schedule());
            }
            else if (sender == users_RolesButton)
            {
                openChildForm(new frmUsers_Roles());
            }
            else if (sender == teacherButton)
            {
                openChildForm(new frmTeacher());
            }
            else if (sender == feesButton)
            {
                openChildForm(new frmPrices());
            }
            else if (sender == paymentTypeButton)
            {
                openChildForm(new frmPaymentType());
            }
            else if (sender == billingReportButton)
            {
                openChildForm(new frmBillingReport());
            }
            else if (sender == level_SubjectsButton)
            {
                openChildForm(new frmGradeLevel_Subjects());
            }
            else if (sender == logoButton)
            {
                openChildForm(new frmDashboardDisplay());
            }
            else if (sender == homeButton)
            {
                openChildForm(new frmDashboardDisplay());
            }
            else if (sender == settingsButton)
            {
                openChildForm(new frmSettings());
            }
        }
    }
}
