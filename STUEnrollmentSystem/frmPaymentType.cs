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
    public partial class frmPaymentType : Form
    {
        private PaymentTypeRepository _paymentTypeRepository;

        public frmPaymentType()
        {
            InitializeComponent();
            _paymentTypeRepository = new PaymentTypeRepository(Properties.Settings.Default.STU_DBConnectionString);
        }

        private void paymentTypeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentTypeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTU_DBDataSet);
        }

        private void frmPaymentType_Load(object sender, EventArgs e)
        {
            this.paymentTypeTableAdapter.Fill(this.sTU_DBDataSet.PaymentType);
            searchPanel.Visible = false;
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            this.paymentTypeTableAdapter.Update(sTU_DBDataSet);
            this.paymentTypeTableAdapter.Fill(sTU_DBDataSet.PaymentType);
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


    }
}
