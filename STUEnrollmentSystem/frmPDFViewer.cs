using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUEnrollmentSystem
{
    public partial class frmPDFViewer : Form
    {
        public frmPDFViewer(byte[] fileData)
        {
            InitializeComponent();
            MemoryStream ms = new MemoryStream(fileData);
            pdfViewer1.LoadFromStream(ms);
        }
    }
}
