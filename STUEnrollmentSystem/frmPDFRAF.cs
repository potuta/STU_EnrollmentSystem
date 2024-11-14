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
    public partial class frmPDFRAF : Form
    {
        private Bitmap MemoryImage;
        private PrintDocument printDocument1 = new PrintDocument();
        private PrintPreviewDialog previewdlg = new PrintPreviewDialog();
        private string StudentNumber {  get; set; }
        private string GradeCode { get; set; }
        private string SectionTitle { get; set; }
        private string PaymentType {  get; set; }

        public frmPDFRAF(string studentNumber, string gradeCode, string sectionTitle, string paymentType)
        {
            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(printdoc1_PrintPage);
            this.StudentNumber = studentNumber;
            this.GradeCode = gradeCode;
            this.SectionTitle = sectionTitle;
            this.PaymentType = paymentType;
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

        private void frmPDFRAF_Load(object sender, EventArgs e)
        {
            // Student Information
            string fullName = new StudentRepository(ConnectionFactory.GetConnectionString()).GetStudentName(StudentNumber);
            string[] nameParts = fullName.Split(' ');
            string firstName = nameParts[0];
            string middleName = nameParts[1];
            string lastName = nameParts[2];
            string sectionCode = new SectionRepository(ConnectionFactory.GetConnectionString()).GetSectionCode(SectionTitle);

            labelStudentNo.Text = StudentNumber;
            labelFirstName.Text = firstName;
            labelMiddleName.Text = middleName;
            labelLastName.Text = lastName;
            labelYearLevel.Text = GradeCode;
            labelSection.Text = SectionTitle;

            // Schedule Information
            Dictionary<string, string> subjectDictionary = new Dictionary<string, string>();
            List<string> subjectCodeList = new ScheduleRepository(ConnectionFactory.GetConnectionString()).GetColumnDataFromSectionCode("SubjectCode", sectionCode);
            List<string> daysList = new ScheduleRepository(ConnectionFactory.GetConnectionString()).GetColumnDataFromSectionCode("Days", sectionCode);
            foreach (string subject in subjectCodeList)
            {
                foreach (string day in daysList)
                {
                    subjectDictionary[subject] = day;
                }
            }

            List<string> startTime = new ScheduleRepository(ConnectionFactory.GetConnectionString()).GetColumnDataFromSectionCode("StartTime", sectionCode);
            List<string> endTime = new ScheduleRepository(ConnectionFactory.GetConnectionString()).GetColumnDataFromSectionCode("EndTime", sectionCode);
            List<string> fullTime = new List<string>();

            for (int i = 0; i < startTime.Count; i++)
            {
                    string[] joinTime = { startTime[i], endTime[i] };
                    fullTime.Add(string.Join("-", joinTime));
            }

            List<string> teacherCodeList = new ScheduleRepository(ConnectionFactory.GetConnectionString()).GetColumnDataFromSectionCode("TeacherCode", sectionCode);
            Dictionary<string, string> teacherNames = new TeacherRepository(ConnectionFactory.GetConnectionString()).GetTeacherNameAndTeacherCodeDictionary(teacherCodeList);

            // Schedule Subject & Days
            //labelDay1.Text = subjectDictionary.Values.ElementAt(0);
            //labelDay2.Text = subjectDictionary.Values.ElementAt(1);
            //labelDay3.Text = subjectDictionary.Values.ElementAt(2);
            //labelDay4.Text = subjectDictionary.Values.ElementAt(3);
            //labelDay5.Text = subjectDictionary.Values.ElementAt(4);
            //labelDay6.Text = subjectDictionary.Values.ElementAt(5);

            labelSubject1.Text = subjectCodeList[0];
            labelSubject2.Text = subjectCodeList[1];
            labelSubject3.Text = subjectCodeList[2];
            labelSubject4.Text = subjectCodeList[3];
            labelSubject5.Text = subjectCodeList[4];
            labelSubject6.Text = subjectCodeList[5];

            labelDay1.Text = daysList[0];
            labelDay2.Text = daysList[1];
            labelDay3.Text = daysList[2];
            labelDay4.Text = daysList[3];
            labelDay5.Text = daysList[4];
            labelDay6.Text = daysList[5];

            if (subjectCodeList.Count == 7)
            {
                labelSubject7.Text = subjectCodeList[6];
                labelDay7.Text = daysList[6];
            }
            else
            {
                labelSubject7.Visible = false;
                labelDay7.Visible = false;
            }

            // Schedule Time
            labelTime1.Text = fullTime[0];
            labelTime2.Text = fullTime[1];
            labelTime3.Text = fullTime[2];
            labelTime4.Text = fullTime[3];
            labelTime5.Text = fullTime[4];
            labelTime6.Text = fullTime[5];

            if (fullTime.Count == 7)
            {
                labelTime7.Text = fullTime[6];
            }
            else
            {
                labelTime7.Visible = false;
            }


            // Schedule Teacher
            labelInstructor1.Text = teacherNames.Values.ElementAt(0);
            labelInstructor2.Text = teacherNames.Values.ElementAt(1);
            labelInstructor3.Text = teacherNames.Values.ElementAt(2);
            labelInstructor4.Text = teacherNames.Values.ElementAt(3);
            labelInstructor5.Text = teacherNames.Values.ElementAt(4);
            labelInstructor6.Text = teacherNames.Values.ElementAt(5);

            if (teacherNames.Count == 7)
            {
                labelInstructor7.Text = teacherNames.Values.ElementAt(6);
            }
            else
            {
                labelInstructor7.Visible = false;
            }

            // Academic Information
            List<int> paymentAmountList = new PricesRepository(ConnectionFactory.GetConnectionString()).GetPaymentAmountListFromGradeCode(GradeCode);
            int tuitionFee = paymentAmountList[0];
            int booksFee = paymentAmountList[1];
            int laboratoryFee = paymentAmountList[2];
            int uniformFee = paymentAmountList[3];
            int miscellanaousFee = paymentAmountList[4];
            int totalFee = paymentAmountList[5];

            string priceCode = $"P{GradeCode}";
            Dictionary<string, int> paymentAmountDictionary = new PaymentTypeRepository(ConnectionFactory.GetConnectionString()).GetPaymentAmount(PaymentType, priceCode);

            labelGradeLevel.Text = GradeCode;
            labelPayment.Text = PaymentType;
            labelTF.Text = Convert.ToString(tuitionFee + ".00");
            labelOSF.Text = Convert.ToString(booksFee+laboratoryFee+ uniformFee + ".00");
            labelMF.Text = Convert.ToString(miscellanaousFee + ".00");
            labelTO.Text = Convert.ToString(totalFee + ".00");

            if (PaymentType.Equals("Monthly"))
            {
                labelDue1.Text = Convert.ToString(paymentAmountDictionary.Values.ElementAt(0) + ".00");
                labelDue2.Text = Convert.ToString(paymentAmountDictionary.Values.ElementAt(1) + ".00");
                labelDue3.Text = Convert.ToString(paymentAmountDictionary.Values.ElementAt(2) + ".00");
                labelDue4.Text = Convert.ToString(paymentAmountDictionary.Values.ElementAt(3) + ".00");
                labelDue5.Text = Convert.ToString(paymentAmountDictionary.Values.ElementAt(4) + ".00");
                labelDue6.Text = Convert.ToString(paymentAmountDictionary.Values.ElementAt(5) + ".00");
                labelDue7.Text = Convert.ToString(paymentAmountDictionary.Values.ElementAt(6) + ".00");
                labelDue8.Text = Convert.ToString(paymentAmountDictionary.Values.ElementAt(7) + ".00");
                labelDue9.Text = Convert.ToString(paymentAmountDictionary.Values.ElementAt(8) + ".00");
                labelDue10.Text = Convert.ToString(paymentAmountDictionary.Values.ElementAt(9) + ".00");
            }
            else if (PaymentType.Equals("Full"))
            {
                labelDue1.Text = Convert.ToString(paymentAmountDictionary.Values.ElementAt(0) + ".00");
                labelDue2.Text = "0.00";
                labelDue3.Text = "0.00";
                labelDue4.Text = "0.00";
                labelDue5.Text = "0.00";
                labelDue6.Text = "0.00";
                labelDue7.Text = "0.00";
                labelDue8.Text = "0.00";
                labelDue9.Text = "0.00";
                labelDue10.Text = "0.00";
            }

            labelTOB.Text = Convert.ToString(totalFee + ".00");
        }
    }
}
