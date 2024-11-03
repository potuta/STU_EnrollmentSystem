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
    public partial class frmPrices : Form
    {
        private PricesRepository _pricesRepository;

        public frmPrices()
        {
            InitializeComponent();
            _pricesRepository = new PricesRepository(Properties.Settings.Default.STU_DBConnectionString);
        }

        private void pricesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pricesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTU_DBDataSet);
        }

        private void frmPrices_Load(object sender, EventArgs e)
        {
            this.pricesTableAdapter.Fill(this.sTU_DBDataSet.Prices);
            searchPanel.Visible = false;
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            this.pricesTableAdapter.Update(sTU_DBDataSet);
            this.pricesTableAdapter.Fill(sTU_DBDataSet.Prices);
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

        private void pricesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void calculateTotalAmount()
        {
            double totalAmount = 0;
            if (!tuitionFeeTextBox.Text.Equals(string.Empty) && !booksTextBox.Text.Equals(string.Empty) && !laboratoryFeeTextBox.Text.Equals(string.Empty) && !uniformTextBox.Text.Equals(string.Empty) && !miscellanaousFeeTextBox.Text.Equals(string.Empty))
            {
                totalAmount = Convert.ToDouble(tuitionFeeTextBox.Text) + Convert.ToDouble(booksTextBox.Text) + Convert.ToDouble(laboratoryFeeTextBox.Text) + Convert.ToDouble(uniformTextBox.Text) + Convert.ToDouble(miscellanaousFeeTextBox.Text);
            }
            totalAmountTextBox.Text = totalAmount.ToString();
        }

        private void pricesFeeTextBox_TextChanged(object sender, EventArgs e) => calculateTotalAmount();
    }
}
