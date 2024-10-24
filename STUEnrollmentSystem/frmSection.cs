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
    public partial class frmSection : Form
    {
        private SectionRepository _sectionRepository;

        public frmSection()
        {
            InitializeComponent();
            _sectionRepository = new SectionRepository(Properties.Settings.Default.STU_DBConnectionString);
        }

        private void sectionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sectionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTU_DBDataSet);
        }

        private void Section_Load(object sender, EventArgs e)
        {
            this.teachersTableAdapter.Fill(this.sTU_DBDataSet.Teachers);
            this.sectionsTableAdapter.Fill(this.sTU_DBDataSet.Sections);
            searchPanel.Visible = false;
            InitializeSearchComboBoxes();
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            this.sectionsTableAdapter.Update(sTU_DBDataSet);
            this.sectionsTableAdapter.Fill(this.sTU_DBDataSet.Sections);
            InitializeSearchComboBoxes();
        }

        private void InitializeSearchComboBoxes()
        {
            InitializeSearchSectionTitleCB();
            InitializeSearchSectionCodeCB();
            InitializeSearchRoomCB();
            InitializeSearchGradeCodeCB();
        }

        private void InitializeSearchSectionTitleCB()
        {
            List<string> sectionTitleList = _sectionRepository.GetSectionData("SectionTitle");
            sectionTitleToolStripComboBox.Items.Clear();
            sectionTitleToolStripComboBox.Items.AddRange(sectionTitleList.ToArray());
        }

        private void InitializeSearchSectionCodeCB()
        {
            List<string> sectionCodeList = _sectionRepository.GetSectionData("SectionCode");
            sectionCodeToolStripComboBox.Items.Clear();
            sectionCodeToolStripComboBox.Items.AddRange(sectionCodeList.ToArray());
        }

        private void InitializeSearchRoomCB()
        {
            List<string> roomList = _sectionRepository.GetSectionData("Room");
            roomToolStripComboBox.Items.Clear();
            roomToolStripComboBox.Items.AddRange(roomList.ToArray());
        }

        private void InitializeSearchGradeCodeCB()
        {
            List<string> gradeCodeList = _sectionRepository.GetSectionData("GradeCode");
            gradeCodeToolStripComboBox.Items.Clear();
            foreach (string items in gradeCodeList)
            {
                if (!gradeCodeToolStripComboBox.Items.Contains(items))
                {
                    gradeCodeToolStripComboBox.Items.Add(items);
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

        private void searchToolStripButton_Click(object sender, EventArgs e) => searchSection();
        private void sectionTitleToolStripComboBox_TextChanged(object sender, EventArgs e) => searchSection();
        private void sectionCodeToolStripComboBox_TextChanged(object sender, EventArgs e) => searchSection();
        private void roomToolStripComboBox_TextChanged(object sender, EventArgs e) => searchSection();
        private void gradeCodeToolStripComboBox_TextChanged(object sender, EventArgs e) => searchSection();

        private void searchSection()
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
