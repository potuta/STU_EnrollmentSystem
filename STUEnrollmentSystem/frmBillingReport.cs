﻿using System;
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
    public partial class frmBillingReport : Form
    {
        private BillingReportRepository _billingReportRepository;

        public frmBillingReport()
        {
            InitializeComponent();
            _billingReportRepository = new BillingReportRepository(ConnectionFactory.GetConnectionString());
            this.tableAdapterManager.Connection.ConnectionString = ConnectionFactory.GetConnectionString();
        }

        private void billingReportBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.billingReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTU_DBDataSet);

        }

        private void frmBillingReport_Load(object sender, EventArgs e)
        {
            this.billingReportTableAdapter.Fill(this.sTU_DBDataSet.BillingReport);
            searchPanel.Visible = false;
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            this.billingReportTableAdapter.Update(this.sTU_DBDataSet);
            this.billingReportTableAdapter.Fill(this.sTU_DBDataSet.BillingReport);
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

        private void OnSearchToolStripTextChanged(object sender, EventArgs e) => searchBillingReport();
        private void searchToolStripButton_Click(object sender, EventArgs e) => searchBillingReport();
        
        private void searchBillingReport()
        {
            try
            {
                this.billingReportTableAdapter.Search(this.sTU_DBDataSet.BillingReport, paymentRNToolStripTextBox.Text, receiptRNToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
