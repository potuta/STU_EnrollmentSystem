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
            _paymentTypeRepository = new PaymentTypeRepository(ConnectionFactory.GetConnectionString());
            this.tableAdapterManager.Connection.ConnectionString = ConnectionFactory.GetConnectionString();
        }

        private void paymentTypeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentTypeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTU_DBDataSet);
        }

        private void frmPaymentType_Load(object sender, EventArgs e)
        {
            this.pricesTableAdapter.Fill(this.sTU_DBDataSet.Prices);
            this.paymentTypeTableAdapter.Fill(this.sTU_DBDataSet.PaymentType);
            searchPanel.Visible = false;
            InitializeSearchComboBoxes();
            InitializeUserRolePrivileges();
        }

        private void InitializeUserRolePrivileges()
        {
            if (!frmLogin.Role.Equals("Admin"))
            {
                bindingNavigatorDeleteItem.Enabled = false;
            }
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            this.paymentTypeTableAdapter.Update(sTU_DBDataSet);
            this.paymentTypeTableAdapter.Fill(sTU_DBDataSet.PaymentType);
            InitializeSearchComboBoxes();
        }

        private void InitializeSearchComboBoxes()
        {
            InitializeSearchPaymentTypeCB();
            InitializeSearchPaymentCodeCB();
            InitializeSearchPricesCodeCB();
            InitializeSearchMonthCB();
            InitializeSearchSchoolYearCB();
        }

        private void InitializeSearchSchoolYearCB()
        {
            List<string> schoolYearList = _paymentTypeRepository.GetColumnData("PaymentType", "SchoolYear");
            schoolYearList.Sort();
            schoolYearToolStripComboBox.Items.Clear();
            foreach (string items in schoolYearList)
            {
                if (!schoolYearToolStripComboBox.Items.Contains(items))
                {
                    schoolYearToolStripComboBox.Items.Add(items);
                }
            }
        }

        private void InitializeSearchMonthCB()
        {
            List<string> monthList = _paymentTypeRepository.GetColumnData("PaymentType", "Month");
            monthToolStripComboBox.Items.Clear();
            foreach (string items in monthList)
            {
                if (!monthToolStripComboBox.Items.Contains(items))
                {
                    monthToolStripComboBox.Items.Add(items);
                }
            }
        }

        private void InitializeSearchPricesCodeCB()
        {
            List<string> pricesCodeList = _paymentTypeRepository.GetColumnData("PaymentType", "PricesCode");
            pricesCodeList.Sort();
            pricesCodeToolStripComboBox.Items.Clear();
            foreach (string items in pricesCodeList)
            {
                if (!pricesCodeToolStripComboBox.Items.Contains(items))
                {
                    pricesCodeToolStripComboBox.Items.Add(items);
                }
            }
        }

        private void InitializeSearchPaymentCodeCB()
        {
            List<string> paymentCodeList = _paymentTypeRepository.GetColumnData("PaymentType", "PaymentCode");
            paymentCodeList.Sort();
            paymentCodeToolStripComboBox.Items.Clear();
            foreach (string items in paymentCodeList)
            {
                if (!paymentCodeToolStripComboBox.Items.Contains(items))
                {
                    paymentCodeToolStripComboBox.Items.Add(items);
                }
            }
        }

        private void InitializeSearchPaymentTypeCB()
        {
            List<string> paymentTypeList = _paymentTypeRepository.GetColumnData("PaymentType", "PaymentType");
            paymentTypeToolStripComboBox.Items.Clear();
            foreach (string items in paymentTypeList)
            {
                if (!paymentTypeToolStripComboBox.Items.Contains(items))
                {
                    paymentTypeToolStripComboBox.Items.Add(items);
                }
            }
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

        private void searchToolStripButton_Click(object sender, EventArgs e) => searchPaymentType();
        private void OnSearchToolStripTextChanged(object sender, EventArgs e) => searchPaymentType();

        private void searchPaymentType()
        {
            try
            {
                this.paymentTypeTableAdapter.Search(this.sTU_DBDataSet.PaymentType, paymentTypeToolStripComboBox.Text, paymentCodeToolStripComboBox.Text, pricesCodeToolStripComboBox.Text,  monthToolStripComboBox.Text, schoolYearToolStripComboBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
