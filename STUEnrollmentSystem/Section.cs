using System;
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
    public partial class Section : Form
    {
        public Section()
        {
            InitializeComponent();
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
                this.sectionsTableAdapter.Search(this.sTU_DBDataSet.Sections, sectionTitleToolStripTextBox.Text, sectionCodeToolStripTextBox.Text, roomToolStripTextBox.Text, gradeCodeToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void sectionTitleToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.sectionsTableAdapter.Search(this.sTU_DBDataSet.Sections, sectionTitleToolStripTextBox.Text, sectionCodeToolStripTextBox.Text, roomToolStripTextBox.Text, gradeCodeToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void sectionCodeToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.sectionsTableAdapter.Search(this.sTU_DBDataSet.Sections, sectionTitleToolStripTextBox.Text, sectionCodeToolStripTextBox.Text, roomToolStripTextBox.Text, gradeCodeToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void roomToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.sectionsTableAdapter.Search(this.sTU_DBDataSet.Sections, sectionTitleToolStripTextBox.Text, sectionCodeToolStripTextBox.Text, roomToolStripTextBox.Text, gradeCodeToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void gradeCodeToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.sectionsTableAdapter.Search(this.sTU_DBDataSet.Sections, sectionTitleToolStripTextBox.Text, sectionCodeToolStripTextBox.Text, roomToolStripTextBox.Text, gradeCodeToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
