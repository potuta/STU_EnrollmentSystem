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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void teachersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teachersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTU_DBDataSet);

        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTU_DBDataSet.Teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.sTU_DBDataSet.Teachers);

        }
    }
}
