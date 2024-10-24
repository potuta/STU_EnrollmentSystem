using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUEnrollmentSystem
{
    public partial class frmImageViewer : Form
    {
        public frmImageViewer(MemoryStream ms)
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromStream(ms);
        }
    }
}
