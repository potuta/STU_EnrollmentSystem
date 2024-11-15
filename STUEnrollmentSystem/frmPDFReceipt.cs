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
        

        public frmPDFReceipt(string studentNumber, string paymentCode, string paymentMethod, string month, string year)
        {
            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(printdoc1_PrintPage);
            this.StudentNumber = studentNumber;
            this.PaymentCode = paymentCode;
            this.PaymentMethod = paymentMethod;
            this.Month = month;
            this.Year = year;
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
            string fullName = new StudentRepository(ConnectionFactory.GetConnectionString()).GetStudentName(StudentNumber);
            string section = new StudentRepository(ConnectionFactory.GetConnectionString()).GetStudentSection(StudentNumber);
            string paymentType = string.Empty;

            if (PaymentCode.Contains("M"))
            {
                paymentType = "Monthly";
                tuitionFeeLabel.Text = "3100";
                booksFeeLabel.Text = "900";
                laboratoryFeeLabel.Text = "500";
                uniformFeeLabel.Text = "500";
                miscellanaousFeeLabel.Text = "700";
            }
            else
            {
                paymentType = "Full";
                tuitionFeeLabel.Text = "30000";
                booksFeeLabel.Text = "10000";
                laboratoryFeeLabel.Text = "500";
                uniformFeeLabel.Text = "5000";
                miscellanaousFeeLabel.Text = "7000";
            }

            string pricesCode = $"P{PaymentCode.Substring(1)}";
            Dictionary<string, int> paymentAmountDictionary = new PaymentTypeRepository(ConnectionFactory.GetConnectionString()).GetPaymentAmount(paymentType, pricesCode);

            schoolYearLabel.Text = Year;
            fullNameLabel.Text = fullName;
            gradeLabel.Text = PaymentCode.Substring(1);
            sectionLabel.Text = section;
            gradeCodeLabel.Text = PaymentCode.Substring(0);
            paymentTypeLabel.Text = paymentType;
            issueDateLabel.Text = $"{Month}, {Year}";
            paymentMethodLabel.Text = $"Paid by: {PaymentMethod}";
            totalLabel.Text = Convert.ToString(paymentAmountDictionary[Month]);
        }
    }
}
