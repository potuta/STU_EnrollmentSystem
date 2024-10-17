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
    public partial class ImageViewer : Form
    {
        public ImageViewer()
        {
            InitializeComponent();
        }

        public ImageViewer(string Column, string SQLCommand)
        {
            InitializeComponent();
            SqlConnection _connection = new SqlConnection(Properties.Settings.Default.STU_DBConnectionString);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand(SQLCommand, _connection));
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count == 1)
            {
                Byte[] data = new Byte[0];
                data = (Byte[])(dataSet.Tables[0].Rows[0][Column]);
                MemoryStream mem = new MemoryStream(data);
                pictureBox1.Image = Image.FromStream(mem);
            }
        }
    }
}
