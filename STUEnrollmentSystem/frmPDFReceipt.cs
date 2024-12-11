using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUEnrollmentSystem
{
    public partial class frmPDFReceipt : Form
    {
        private Bitmap MemoryImage;
        private PrintDocument printDocument1 = new PrintDocument();
        private PrintPreviewDialog previewdlg = new PrintPreviewDialog();
        private string StudentNumber { get; set; }
        private string PaymentCode {  get; set; }
        private string PaymentMethod { get; set; }
        private string Month {  get; set; }
        private string Year { get; set; }
        private string TransactionDate {  get; set; }
        private string ReceiptRN {  get; set; }
        private string PaidAmount {  get; set; }

        public frmPDFReceipt(string studentNumber, string paymentCode, string paymentMethod, string month, string year, string transactionDate, string receiptRN, string paidAmount)
        {
            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(printdoc1_PrintPage);
            printDocument1.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            this.MaximizeBox = false;
            this.StudentNumber = studentNumber;
            this.PaymentCode = paymentCode;
            this.PaymentMethod = paymentMethod;
            this.Month = month;
            this.Year = year;
            this.TransactionDate = transactionDate;
            this.ReceiptRN = receiptRN;
            this.PaidAmount = paidAmount;
        }

        public void GetPrintArea(Panel pnl)
        {
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (MemoryImage != null)
            {
                e.Graphics.DrawImage(MemoryImage, 0, 0);
                base.OnPaint(e);
            }
        }

        void printdoc1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage, (pagearea.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);
        }

        public void Print(Panel pnl)
        {
            Panel pannel = pnl;
            GetPrintArea(pnl);
            previewdlg.Document = printDocument1;
            previewdlg.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Print(this.panel1);
        }

        private void frmPDFReceipt_Load(object sender, EventArgs e)
        {
            string pricesCode = $"P{PaymentCode.Substring(1)}";
            string gradeCode = PaymentCode.Substring(1);
            string paymentType = string.Empty;

            string fullName = new StudentRepository(ConnectionFactory.GetConnectionString()).GetStudentName(StudentNumber);
            string section = new StudentRepository(ConnectionFactory.GetConnectionString()).GetStudentSection(StudentNumber);
            List<int> pricesList = new PricesRepository(ConnectionFactory.GetConnectionString()).GetPaymentAmountListFromGradeCode(gradeCode);

            if (PaymentCode.Contains("M"))
            {
                paymentType = "Monthly";
                Dictionary<string, int> paymentAmountDictionary = new PaymentTypeRepository(ConnectionFactory.GetConnectionString()).GetPaymentAmount(paymentType, pricesCode);
                tuitionFeeLabel.Text = Convert.ToString(pricesList[0] / paymentAmountDictionary.Count);
                booksFeeLabel.Text = Convert.ToString(pricesList[1] / paymentAmountDictionary.Count);
                laboratoryFeeLabel.Text = Convert.ToString(pricesList[2] / paymentAmountDictionary.Count);
                uniformFeeLabel.Text = Convert.ToString(pricesList[3] / paymentAmountDictionary.Count);
                miscellanaousFeeLabel.Text = Convert.ToString(pricesList[4] / paymentAmountDictionary.Count);
            }
            else
            {
                paymentType = "Full";
                tuitionFeeLabel.Text = Convert.ToString(pricesList[0]);
                booksFeeLabel.Text = Convert.ToString(pricesList[1]);
                laboratoryFeeLabel.Text = Convert.ToString(pricesList[2]);
                uniformFeeLabel.Text = Convert.ToString(pricesList[3]);
                miscellanaousFeeLabel.Text = Convert.ToString(pricesList[4]);
            }

            schoolYearLabel.Text = Year;
            fullNameLabel.Text = fullName;
            gradeLabel.Text = PaymentCode.Substring(1);
            sectionLabel.Text = section;
            gradeCodeLabel.Text = PaymentCode.Substring(0);
            paymentTypeLabel.Text = paymentType;
            issueDateLabel.Text = $"Issue Date: {TransactionDate}";
            receiptRNLabel.Text = $"Receipt RN: {ReceiptRN}";
            paymentMethodLabel.Text = $"Paid by: {PaymentMethod}";
            totalLabel.Text = PaidAmount;
        }
    }
}
