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
        public PDFViewer()
        {
            InitializeComponent();
        }

        public PDFViewer(string Column, string SQLCommand)
        {
            InitializeComponent();
            SqlConnection _connection = new SqlConnection(Properties.Settings.Default.STU_DBConnectionString);
            DataTable dt = new DataTable();
            SqlCommand verDoc = new SqlCommand(SQLCommand, _connection);
            SqlDataAdapter adapter = new SqlDataAdapter(verDoc);
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                byte[] ap = (byte[])dt.Rows[0][Column];
                MemoryStream ms = new MemoryStream(ap);
                pdfDocumentView1.Load(ms);
                pdfViewerControl1.Load(ms);
            }
        }
    }
}
