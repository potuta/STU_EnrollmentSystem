using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUEnrollmentSystem
{
    public partial class Section : Form
    {
        private SqlConnection STU_DB_Connection;
        private SqlCommand STU_Command;

        public Section()
        {
            InitializeComponent();
            STU_DB_Connection = new SqlConnection(Properties.Settings.Default.STU_DBConnectionString);
        }

        private void sectionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sectionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTU_DBDataSet);
        }

        private void Section_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTU_DBDataSet.Teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.sTU_DBDataSet.Teachers);
            this.sectionsTableAdapter.Fill(this.sTU_DBDataSet.Sections);
            searchPanel.Visible = false;
            InitializeSearchSectionTitleCB();
        }

        private void InitializeSearchSectionTitleCB()
        {
            SqlCommand sectionTitleData = new SqlCommand("SELECT SectionTitle FROM Sections", STU_DB_Connection);
            List<string> sectionTitleList = new List<string>();
            STU_DB_Connection.Open();
            using (SqlDataReader reader = sectionTitleData.ExecuteReader())
            {
                while (reader.Read())
                {
                    sectionTitleList.Add(reader[0].ToString());
                }
            }
            STU_DB_Connection.Close();
            sectionTitleToolStripComboBox.Items.Clear();
            foreach (string items in sectionTitleList)
            {
                if (!sectionTitleToolStripComboBox.Items.Contains(items))
                {
                    sectionTitleToolStripComboBox.Items.Add(items);
                }
            }
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

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            this.sectionsTableAdapter.Update(sTU_DBDataSet);
            this.sectionsTableAdapter.Fill(this.sTU_DBDataSet.Sections);
        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sectionsTableAdapter.Search(this.sTU_DBDataSet.Sections, sectionTitleToolStripComboBox.Text, sectionCodeToolStripComboBox.Text, roomToolStripComboBox.Text, gradeCodeToolStripComboBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void sectionTitleToolStripComboBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.sectionsTableAdapter.Search(this.sTU_DBDataSet.Sections, sectionTitleToolStripComboBox.Text, sectionCodeToolStripComboBox.Text, roomToolStripComboBox.Text, gradeCodeToolStripComboBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void sectionCodeToolStripComboBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.sectionsTableAdapter.Search(this.sTU_DBDataSet.Sections, sectionTitleToolStripComboBox.Text, sectionCodeToolStripComboBox.Text, roomToolStripComboBox.Text, gradeCodeToolStripComboBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void roomToolStripComboBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.sectionsTableAdapter.Search(this.sTU_DBDataSet.Sections, sectionTitleToolStripComboBox.Text, sectionCodeToolStripComboBox.Text, roomToolStripComboBox.Text, gradeCodeToolStripComboBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void gradeCodeToolStripComboBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.sectionsTableAdapter.Search(this.sTU_DBDataSet.Sections, sectionTitleToolStripComboBox.Text, sectionCodeToolStripComboBox.Text, roomToolStripComboBox.Text, gradeCodeToolStripComboBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

    }
}
