using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUEnrollmentSystem
{
    public partial class frmRoles : Form
    {
        private RolesRepository _rolesRepository;
        private List<string> roleNameList;

        public frmRoles()
        {
            InitializeComponent();
            _rolesRepository = new RolesRepository(ConnectionFactory.GetConnectionString());
            this.tableAdapterManager.Connection.ConnectionString = ConnectionFactory.GetConnectionString();
            roleNameList = _rolesRepository.GetRolesList();
        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
            this.rolesTableAdapter.Fill(this.sTU_DBDataSet.Roles);
            InitializeRolesComboBox();
            rolesComboBox.Text = frmLogin.Role;
        }

        private void rolesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rolesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTU_DBDataSet);
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            this.rolesTableAdapter.Fill(this.sTU_DBDataSet.Roles);
        }

        private void InitializeRolesComboBox()
        {
            rolesComboBox.Items.Clear();
            rolesComboBox.Items.AddRange(roleNameList.ToArray());
        }

        private void InitializeUserRolePrivilegesCheckBoxes(Dictionary<string, bool> userRolePrivilegesMap)
        {
            var checkBoxes = new CheckBox[]
            {
                Enrollment_Module,
                Registration_SubModule,
                ApprovedStudents_SubModule,
                StudentRecords_Module,
                ManageStudents_SubModule,
                PendingRequirements_SubModule,
                Billing_Module,
                ManagePayments_SubModule,
                BillingReport_SubModule,
                Academic_Module,
                Fees_SubModule,
                PaymentType_SubModule,
                SectionsSchedule_SubModule,
                GradeLevelSubjects_SubModule,
                Faculty_Module,
                Teachers_SubModule,
                UsersRoles_SubModule
            };

            foreach (string name in userRolePrivilegesMap.Keys)
            {
                foreach (CheckBox checkBox in checkBoxes)
                {
                    if (checkBox.Name == name)
                    {
                        checkBox.Checked = userRolePrivilegesMap[name];
                    }
                }
            }
        }

        private void checkBox_Toggle_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked)
            {
                checkBox.Text = "ON";
                checkBox.BackColor = Color.MediumSeaGreen;
            }
            else
            {
                checkBox.Text = "OFF";
                checkBox.BackColor = Color.Red;
            }
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to save changes?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            Dictionary<string, bool> map = new Dictionary<string, bool>
            {
                {"Enrollment_Module", Enrollment_Module.Checked },
                {"Registration_SubModule", Registration_SubModule.Checked },
                {"ApprovedStudents_SubModule", ApprovedStudents_SubModule.Checked },
                {"StudentRecords_Module", StudentRecords_Module.Checked },
                {"ManageStudents_SubModule", ManageStudents_SubModule.Checked },
                {"PendingRequirements_SubModule", PendingRequirements_SubModule.Checked },
                {"Billing_Module", Billing_Module.Checked },
                {"ManagePayments_SubModule", ManagePayments_SubModule.Checked },
                {"BillingReport_SubModule", BillingReport_SubModule.Checked },
                {"Academic_Module", Academic_Module.Checked },
                {"Fees_SubModule", Fees_SubModule.Checked },
                {"PaymentType_SubModule", PaymentType_SubModule.Checked },
                {"SectionsSchedule_SubModule", SectionsSchedule_SubModule.Checked },
                {"GradeLevelSubjects_SubModule", GradeLevelSubjects_SubModule.Checked },
                {"Faculty_Module", Faculty_Module.Checked },
                {"Teachers_SubModule", Teachers_SubModule.Checked },
                {"UsersRoles_SubModule", UsersRoles_SubModule.Checked }
            };

            _rolesRepository.UpdateRolePrivileges(rolesComboBox.Text, map);
            bindingNavigatorRefreshItem.PerformClick();
            MessageBox.Show($"Successfully updated role privileges/access for {rolesComboBox.Text}", "Success!", MessageBoxButtons.OK);
        }

        private void rolesComboBox_TextChanged(object sender, EventArgs e)
        {
            foreach (string roleName in roleNameList)
            {
                if (rolesComboBox.Text.Equals(roleName))
                {
                    Dictionary<string, bool> map = _rolesRepository.GetRolePriviligesDictionary(roleName);
                    InitializeUserRolePrivilegesCheckBoxes(map);
                }
            }
        }
    }
}
