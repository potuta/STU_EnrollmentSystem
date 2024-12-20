﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUEnrollmentSystem
{
    public partial class frmSchedule : Form
    {
        private ScheduleRepository _scheduleRepository;

        public frmSchedule()
        {
            InitializeComponent();
            _scheduleRepository = new ScheduleRepository(ConnectionFactory.GetConnectionString());
            this.tableAdapterManager.Connection.ConnectionString = ConnectionFactory.GetConnectionString();
        }

        private void scheduleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.scheduleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTU_DBDataSet);
        }

        private void frmSchedule_Load(object sender, EventArgs e)
        {
            this.scheduleTableAdapter.Fill(this.sTU_DBDataSet.Schedule);
            searchPanel.Visible = false;
            InitializeSearchComboBoxes();
            InitializeUserRolePrivileges();
        }

        private void InitializeUserRolePrivileges()
        {
            if (!frmLogin.Role.Equals("Administrator"))
            {
                bindingNavigatorAddNewItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
                scheduleBindingNavigatorSaveItem.Enabled = false;
            }
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            this.scheduleTableAdapter.Fill(sTU_DBDataSet.Schedule);
            InitializeSearchComboBoxes();
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

        private void scheduleDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InitializeSearchComboBoxes()
        {
            InitializeSearchScheduleCodeCB();
            InitializeSearchSectionCodeCB();
            InitializeSearchTeacherCodeCB();
        }

        private void InitializeSearchScheduleCodeCB()
        {
            List<string> scheduleCodeList = _scheduleRepository.GetColumnData("Schedule", "ScheduleCode");
            scheduleCodeList.Sort();
            scheduleCodeToolStripComboBox.Items.Clear();
            foreach (string items in scheduleCodeList)
            {
                if (!scheduleCodeToolStripComboBox.Items.Contains(items))
                {
                    scheduleCodeToolStripComboBox.Items.Add(items);
                }
            }
        }

        private void InitializeSearchSectionCodeCB()
        {
            List<string> sectionCodeList = _scheduleRepository.GetColumnData("Schedule", "SectionCode");
            sectionCodeList.Sort();
            sectionCodeToolStripComboBox.Items.Clear();
            foreach (string items in sectionCodeList)
            {
                if (!sectionCodeToolStripComboBox.Items.Contains(items))
                {
                    sectionCodeToolStripComboBox.Items.Add(items);
                }
            }
        }

        private void InitializeSearchTeacherCodeCB()
        {
            List<string> teacherCodeList = _scheduleRepository.GetColumnData("Schedule", "TeacherCode");
            teacherCodeList.Sort();
            teacherCodeToolStripComboBox.Items.Clear();
            foreach (string items in teacherCodeList)
            {
                if (!teacherCodeToolStripComboBox.Items.Contains(items))
                {
                    teacherCodeToolStripComboBox.Items.Add(items);
                }
            }
        }

        private void searchToolStripButton_Click(object sender, EventArgs e) => searchSchedule();
        private void OnSearchToolStripTextChanged(object sender, EventArgs e) => searchSchedule();

        private void searchSchedule()
        {
            try
            {
                this.scheduleTableAdapter.Search(this.sTU_DBDataSet.Schedule, scheduleCodeToolStripComboBox.Text, sectionCodeToolStripComboBox.Text, teacherCodeToolStripComboBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void viewSectionButton_Click(object sender, EventArgs e)
        {
            if (sectionDataGridView.Visible == true)
            {
                sectionDataGridView.Visible = false;
                return;
            }

            sectionDataGridView.Visible = true;
            DataTable dataTable = new SectionRepository(ConnectionFactory.GetConnectionString()).GetSectionDataTableFromSectionCode(sectionCodeTextBox.Text);
            sectionDataGridView.DataSource = dataTable;
        }

        private void viewTeacherButton_Click(object sender, EventArgs e)
        {
            if (teacherDataGridView.Visible == true)
            {
                teacherDataGridView.Visible = false;
                return;
            }

            teacherDataGridView.Visible = true;
            DataTable dataTable = new TeacherRepository(ConnectionFactory.GetConnectionString()).GetTeacherDataTableFromTeacherCode(teacherCodeTextBox.Text);
            teacherDataGridView.DataSource = dataTable;
        }
    }
}
