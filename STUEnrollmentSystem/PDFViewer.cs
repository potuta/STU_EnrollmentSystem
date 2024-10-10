using Syncfusion.Windows.Forms.PdfViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUEnrollmentSystem
{
    public partial class PDFViewer : Form
    {
        private SqlConnection STU_DB_Connection;

        public PDFViewer()
        {
            InitializeComponent();
        }

        public PDFViewer(string Column, string SQLCommand)
        {
            InitializeComponent();
            //STU_DB_Connection = new SqlConnection("Data Source=112.204.105.87,16969;Initial Catalog=STU_DB;Persist Security Info=True;User ID=STU_DB_Login;Password=123;TrustServerCertificate=True");
            STU_DB_Connection = new SqlConnection(Properties.Settings.Default.STU_DBConnectionString);
            DataTable dt = new DataTable();
            SqlCommand verDoc = new SqlCommand(SQLCommand, STU_DB_Connection);
            SqlDataAdapter adapter = new SqlDataAdapter(verDoc);
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                byte[] ap = (byte[])dt.Rows[0][Column];
                MemoryStream ms = new MemoryStream(ap);
                pdfDocumentView1.Load(ms);
            }
        }
    }
}
