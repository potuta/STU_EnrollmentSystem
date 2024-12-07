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
        public frmRoles()
        {
            InitializeComponent();
        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
            InitializeUserRoles();
        }

        private void InitializeUserRoles()
        {
            InitializeAdminRole();
            InitializeAdmissionRole();
            InitializeCashierRole();
            InitializeRegistrarRole();
        }

        public static void InitializeRegistrarRole()
        {

        }

        public static void InitializeCashierRole()
        {

        }

        public static void InitializeAdmissionRole()
        {

        }

        public static void InitializeAdminRole()
        {

        }

        private void checkBox_Toggle_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked)
            {
                checkBox.Text = "ON";
                checkBox.BackColor = Color.MediumSeaGreen;
                // Do something for ON state
            }
            else
            {
                checkBox.Text = "OFF";
                checkBox.BackColor = Color.Red;
                // Do something for OFF state
            }
        }

    }
}
