namespace STUEnrollmentSystem
{
    partial class frmSchedule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label scheduleCodeLabel;
            System.Windows.Forms.Label sectionCodeLabel;
            System.Windows.Forms.Label subjectCodeLabel;
            System.Windows.Forms.Label startTimeLabel;
            System.Windows.Forms.Label endTimeLabel;
            System.Windows.Forms.Label daysLabel;
            System.Windows.Forms.Label teacherCodeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSchedule));
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.scheduleCodeTextBox = new System.Windows.Forms.TextBox();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTU_DBDataSet = new STUEnrollmentSystem.STU_DBDataSet();
            this.sectionCodeTextBox = new System.Windows.Forms.TextBox();
            this.subjectCodeTextBox = new System.Windows.Forms.TextBox();
            this.startTimeTextBox = new System.Windows.Forms.TextBox();
            this.endTimeTextBox = new System.Windows.Forms.TextBox();
            this.daysTextBox = new System.Windows.Forms.TextBox();
            this.teacherCodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showSearchButton = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchToolStrip = new System.Windows.Forms.ToolStrip();
            this.scheduleCodeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.scheduleCodeToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.sectionCodeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.sectionCodeToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.teacherCodeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.teacherCodeToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.searchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.scheduleTableAdapter = new STUEnrollmentSystem.STU_DBDataSetTableAdapters.ScheduleTableAdapter();
            this.tableAdapterManager = new STUEnrollmentSystem.STU_DBDataSetTableAdapters.TableAdapterManager();
            this.scheduleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.scheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewSectionButton = new System.Windows.Forms.Button();
            this.viewTeacherButton = new System.Windows.Forms.Button();
            this.sectionDataGridView = new System.Windows.Forms.DataGridView();
            this.teacherDataGridView = new System.Windows.Forms.DataGridView();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.scheduleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorRefreshItem = new System.Windows.Forms.ToolStripButton();
            scheduleCodeLabel = new System.Windows.Forms.Label();
            sectionCodeLabel = new System.Windows.Forms.Label();
            subjectCodeLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            endTimeLabel = new System.Windows.Forms.Label();
            daysLabel = new System.Windows.Forms.Label();
            teacherCodeLabel = new System.Windows.Forms.Label();
            this.detailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTU_DBDataSet)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.searchToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingNavigator)).BeginInit();
            this.scheduleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // scheduleCodeLabel
            // 
            scheduleCodeLabel.AutoSize = true;
            scheduleCodeLabel.Location = new System.Drawing.Point(56, 94);
            scheduleCodeLabel.Name = "scheduleCodeLabel";
            scheduleCodeLabel.Size = new System.Drawing.Size(83, 13);
            scheduleCodeLabel.TabIndex = 1;
            scheduleCodeLabel.Text = "Schedule Code:";
            // 
            // sectionCodeLabel
            // 
            sectionCodeLabel.AutoSize = true;
            sectionCodeLabel.Location = new System.Drawing.Point(56, 120);
            sectionCodeLabel.Name = "sectionCodeLabel";
            sectionCodeLabel.Size = new System.Drawing.Size(74, 13);
            sectionCodeLabel.TabIndex = 3;
            sectionCodeLabel.Text = "Section Code:";
            // 
            // subjectCodeLabel
            // 
            subjectCodeLabel.AutoSize = true;
            subjectCodeLabel.Location = new System.Drawing.Point(56, 146);
            subjectCodeLabel.Name = "subjectCodeLabel";
            subjectCodeLabel.Size = new System.Drawing.Size(74, 13);
            subjectCodeLabel.TabIndex = 5;
            subjectCodeLabel.Text = "Subject Code:";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new System.Drawing.Point(56, 172);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(58, 13);
            startTimeLabel.TabIndex = 7;
            startTimeLabel.Text = "Start Time:";
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Location = new System.Drawing.Point(56, 198);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(55, 13);
            endTimeLabel.TabIndex = 9;
            endTimeLabel.Text = "End Time:";
            // 
            // daysLabel
            // 
            daysLabel.AutoSize = true;
            daysLabel.Location = new System.Drawing.Point(56, 224);
            daysLabel.Name = "daysLabel";
            daysLabel.Size = new System.Drawing.Size(34, 13);
            daysLabel.TabIndex = 11;
            daysLabel.Text = "Days:";
            // 
            // teacherCodeLabel
            // 
            teacherCodeLabel.AutoSize = true;
            teacherCodeLabel.Location = new System.Drawing.Point(56, 250);
            teacherCodeLabel.Name = "teacherCodeLabel";
            teacherCodeLabel.Size = new System.Drawing.Size(78, 13);
            teacherCodeLabel.TabIndex = 13;
            teacherCodeLabel.Text = "Teacher Code:";
            // 
            // detailsPanel
            // 
            this.detailsPanel.AutoScroll = true;
            this.detailsPanel.Controls.Add(this.viewTeacherButton);
            this.detailsPanel.Controls.Add(this.viewSectionButton);
            this.detailsPanel.Controls.Add(scheduleCodeLabel);
            this.detailsPanel.Controls.Add(this.scheduleCodeTextBox);
            this.detailsPanel.Controls.Add(sectionCodeLabel);
            this.detailsPanel.Controls.Add(this.sectionCodeTextBox);
            this.detailsPanel.Controls.Add(subjectCodeLabel);
            this.detailsPanel.Controls.Add(this.subjectCodeTextBox);
            this.detailsPanel.Controls.Add(startTimeLabel);
            this.detailsPanel.Controls.Add(this.startTimeTextBox);
            this.detailsPanel.Controls.Add(endTimeLabel);
            this.detailsPanel.Controls.Add(this.endTimeTextBox);
            this.detailsPanel.Controls.Add(daysLabel);
            this.detailsPanel.Controls.Add(this.daysTextBox);
            this.detailsPanel.Controls.Add(teacherCodeLabel);
            this.detailsPanel.Controls.Add(this.teacherCodeTextBox);
            this.detailsPanel.Controls.Add(this.label1);
            this.detailsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.detailsPanel.Location = new System.Drawing.Point(0, 112);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(307, 647);
            this.detailsPanel.TabIndex = 21;
            // 
            // scheduleCodeTextBox
            // 
            this.scheduleCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "ScheduleCode", true));
            this.scheduleCodeTextBox.Location = new System.Drawing.Point(145, 91);
            this.scheduleCodeTextBox.Name = "scheduleCodeTextBox";
            this.scheduleCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.scheduleCodeTextBox.TabIndex = 2;
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataMember = "Schedule";
            this.scheduleBindingSource.DataSource = this.sTU_DBDataSet;
            // 
            // sTU_DBDataSet
            // 
            this.sTU_DBDataSet.DataSetName = "STU_DBDataSet";
            this.sTU_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sectionCodeTextBox
            // 
            this.sectionCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "SectionCode", true));
            this.sectionCodeTextBox.Location = new System.Drawing.Point(145, 117);
            this.sectionCodeTextBox.Name = "sectionCodeTextBox";
            this.sectionCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sectionCodeTextBox.TabIndex = 4;
            // 
            // subjectCodeTextBox
            // 
            this.subjectCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "SubjectCode", true));
            this.subjectCodeTextBox.Location = new System.Drawing.Point(145, 143);
            this.subjectCodeTextBox.Name = "subjectCodeTextBox";
            this.subjectCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.subjectCodeTextBox.TabIndex = 6;
            // 
            // startTimeTextBox
            // 
            this.startTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "StartTime", true));
            this.startTimeTextBox.Location = new System.Drawing.Point(145, 169);
            this.startTimeTextBox.Name = "startTimeTextBox";
            this.startTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.startTimeTextBox.TabIndex = 8;
            // 
            // endTimeTextBox
            // 
            this.endTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "EndTime", true));
            this.endTimeTextBox.Location = new System.Drawing.Point(145, 195);
            this.endTimeTextBox.Name = "endTimeTextBox";
            this.endTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.endTimeTextBox.TabIndex = 10;
            // 
            // daysTextBox
            // 
            this.daysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "Days", true));
            this.daysTextBox.Location = new System.Drawing.Point(145, 221);
            this.daysTextBox.Name = "daysTextBox";
            this.daysTextBox.Size = new System.Drawing.Size(100, 20);
            this.daysTextBox.TabIndex = 12;
            // 
            // teacherCodeTextBox
            // 
            this.teacherCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "TeacherCode", true));
            this.teacherCodeTextBox.Location = new System.Drawing.Point(145, 247);
            this.teacherCodeTextBox.Name = "teacherCodeTextBox";
            this.teacherCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.teacherCodeTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Schedule Information";
            // 
            // showSearchButton
            // 
            this.showSearchButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.showSearchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.showSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showSearchButton.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSearchButton.Location = new System.Drawing.Point(0, 85);
            this.showSearchButton.Name = "showSearchButton";
            this.showSearchButton.Size = new System.Drawing.Size(1264, 27);
            this.showSearchButton.TabIndex = 20;
            this.showSearchButton.Text = "Search ▼";
            this.showSearchButton.UseVisualStyleBackColor = false;
            this.showSearchButton.Click += new System.EventHandler(this.showSearchButton_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.AutoScroll = true;
            this.searchPanel.Controls.Add(this.searchToolStrip);
            this.searchPanel.Controls.Add(this.label2);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel.Location = new System.Drawing.Point(0, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1264, 85);
            this.searchPanel.TabIndex = 19;
            // 
            // searchToolStrip
            // 
            this.searchToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.searchToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.searchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleCodeToolStripLabel,
            this.scheduleCodeToolStripComboBox,
            this.sectionCodeToolStripLabel,
            this.sectionCodeToolStripComboBox,
            this.teacherCodeToolStripLabel,
            this.teacherCodeToolStripComboBox,
            this.searchToolStripButton});
            this.searchToolStrip.Location = new System.Drawing.Point(108, 37);
            this.searchToolStrip.Name = "searchToolStrip";
            this.searchToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.searchToolStrip.Size = new System.Drawing.Size(687, 25);
            this.searchToolStrip.TabIndex = 23;
            this.searchToolStrip.Text = "searchToolStrip";
            // 
            // scheduleCodeToolStripLabel
            // 
            this.scheduleCodeToolStripLabel.Name = "scheduleCodeToolStripLabel";
            this.scheduleCodeToolStripLabel.Size = new System.Drawing.Size(86, 22);
            this.scheduleCodeToolStripLabel.Text = "ScheduleCode:";
            // 
            // scheduleCodeToolStripComboBox
            // 
            this.scheduleCodeToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.scheduleCodeToolStripComboBox.Name = "scheduleCodeToolStripComboBox";
            this.scheduleCodeToolStripComboBox.Size = new System.Drawing.Size(100, 25);
            this.scheduleCodeToolStripComboBox.TextChanged += new System.EventHandler(this.OnSearchToolStripTextChanged);
            // 
            // sectionCodeToolStripLabel
            // 
            this.sectionCodeToolStripLabel.Name = "sectionCodeToolStripLabel";
            this.sectionCodeToolStripLabel.Size = new System.Drawing.Size(107, 22);
            this.sectionCodeToolStripLabel.Text = "          SectionCode:";
            // 
            // sectionCodeToolStripComboBox
            // 
            this.sectionCodeToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.sectionCodeToolStripComboBox.Name = "sectionCodeToolStripComboBox";
            this.sectionCodeToolStripComboBox.Size = new System.Drawing.Size(100, 25);
            this.sectionCodeToolStripComboBox.TextChanged += new System.EventHandler(this.OnSearchToolStripTextChanged);
            // 
            // teacherCodeToolStripLabel
            // 
            this.teacherCodeToolStripLabel.Name = "teacherCodeToolStripLabel";
            this.teacherCodeToolStripLabel.Size = new System.Drawing.Size(109, 22);
            this.teacherCodeToolStripLabel.Text = "          TeacherCode:";
            // 
            // teacherCodeToolStripComboBox
            // 
            this.teacherCodeToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.teacherCodeToolStripComboBox.Name = "teacherCodeToolStripComboBox";
            this.teacherCodeToolStripComboBox.Size = new System.Drawing.Size(100, 25);
            this.teacherCodeToolStripComboBox.TextChanged += new System.EventHandler(this.OnSearchToolStripTextChanged);
            // 
            // searchToolStripButton
            // 
            this.searchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchToolStripButton.Name = "searchToolStripButton";
            this.searchToolStripButton.Size = new System.Drawing.Size(76, 22);
            this.searchToolStripButton.Text = "          Search";
            this.searchToolStripButton.Click += new System.EventHandler(this.searchToolStripButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search:";
            // 
            // scheduleTableAdapter
            // 
            this.scheduleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BillingReportTableAdapter = null;
            this.tableAdapterManager.GradeLevelTableAdapter = null;
            this.tableAdapterManager.LogsTableAdapter = null;
            this.tableAdapterManager.PaymentTypeTableAdapter = null;
            this.tableAdapterManager.PendingStudentsTableAdapter = null;
            this.tableAdapterManager.PricesTableAdapter = null;
            this.tableAdapterManager.RegistrationTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.ScheduleTableAdapter = this.scheduleTableAdapter;
            this.tableAdapterManager.SectionsTableAdapter = null;
            this.tableAdapterManager.StudentPaymentTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.SubjectsTableAdapter = null;
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = STUEnrollmentSystem.STU_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // scheduleBindingNavigator
            // 
            this.scheduleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.scheduleBindingNavigator.BindingSource = this.scheduleBindingSource;
            this.scheduleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.scheduleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.scheduleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.scheduleBindingNavigatorSaveItem,
            this.bindingNavigatorRefreshItem});
            this.scheduleBindingNavigator.Location = new System.Drawing.Point(307, 112);
            this.scheduleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.scheduleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.scheduleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.scheduleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.scheduleBindingNavigator.Name = "scheduleBindingNavigator";
            this.scheduleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.scheduleBindingNavigator.Size = new System.Drawing.Size(957, 25);
            this.scheduleBindingNavigator.TabIndex = 22;
            this.scheduleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // scheduleDataGridView
            // 
            this.scheduleDataGridView.AutoGenerateColumns = false;
            this.scheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.scheduleDataGridView.DataSource = this.scheduleBindingSource;
            this.scheduleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scheduleDataGridView.Location = new System.Drawing.Point(307, 353);
            this.scheduleDataGridView.Name = "scheduleDataGridView";
            this.scheduleDataGridView.ReadOnly = true;
            this.scheduleDataGridView.Size = new System.Drawing.Size(957, 406);
            this.scheduleDataGridView.TabIndex = 22;
            this.scheduleDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.scheduleDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ScheduleCode";
            this.dataGridViewTextBoxColumn1.HeaderText = "ScheduleCode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SectionCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "SectionCode";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SubjectCode";
            this.dataGridViewTextBoxColumn3.HeaderText = "SubjectCode";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StartTime";
            this.dataGridViewTextBoxColumn4.HeaderText = "StartTime";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EndTime";
            this.dataGridViewTextBoxColumn5.HeaderText = "EndTime";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Days";
            this.dataGridViewTextBoxColumn6.HeaderText = "Days";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TeacherCode";
            this.dataGridViewTextBoxColumn7.HeaderText = "TeacherCode";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // viewSectionButton
            // 
            this.viewSectionButton.Location = new System.Drawing.Point(251, 115);
            this.viewSectionButton.Name = "viewSectionButton";
            this.viewSectionButton.Size = new System.Drawing.Size(38, 23);
            this.viewSectionButton.TabIndex = 80;
            this.viewSectionButton.Text = "View";
            this.viewSectionButton.UseVisualStyleBackColor = true;
            this.viewSectionButton.Click += new System.EventHandler(this.viewSectionButton_Click);
            // 
            // viewTeacherButton
            // 
            this.viewTeacherButton.Location = new System.Drawing.Point(251, 245);
            this.viewTeacherButton.Name = "viewTeacherButton";
            this.viewTeacherButton.Size = new System.Drawing.Size(38, 23);
            this.viewTeacherButton.TabIndex = 81;
            this.viewTeacherButton.Text = "View";
            this.viewTeacherButton.UseVisualStyleBackColor = true;
            this.viewTeacherButton.Click += new System.EventHandler(this.viewTeacherButton_Click);
            // 
            // sectionDataGridView
            // 
            this.sectionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sectionDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.sectionDataGridView.Location = new System.Drawing.Point(307, 137);
            this.sectionDataGridView.Name = "sectionDataGridView";
            this.sectionDataGridView.ReadOnly = true;
            this.sectionDataGridView.Size = new System.Drawing.Size(957, 108);
            this.sectionDataGridView.TabIndex = 23;
            this.sectionDataGridView.Visible = false;
            // 
            // teacherDataGridView
            // 
            this.teacherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.teacherDataGridView.Location = new System.Drawing.Point(307, 245);
            this.teacherDataGridView.Name = "teacherDataGridView";
            this.teacherDataGridView.ReadOnly = true;
            this.teacherDataGridView.Size = new System.Drawing.Size(957, 108);
            this.teacherDataGridView.TabIndex = 24;
            this.teacherDataGridView.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // scheduleBindingNavigatorSaveItem
            // 
            this.scheduleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("scheduleBindingNavigatorSaveItem.Image")));
            this.scheduleBindingNavigatorSaveItem.Name = "scheduleBindingNavigatorSaveItem";
            this.scheduleBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.scheduleBindingNavigatorSaveItem.Text = "Save Data";
            this.scheduleBindingNavigatorSaveItem.Click += new System.EventHandler(this.scheduleBindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorRefreshItem
            // 
            this.bindingNavigatorRefreshItem.Image = global::STUEnrollmentSystem.Properties.Resources.pngwing_com_1_;
            this.bindingNavigatorRefreshItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorRefreshItem.Name = "bindingNavigatorRefreshItem";
            this.bindingNavigatorRefreshItem.Size = new System.Drawing.Size(93, 22);
            this.bindingNavigatorRefreshItem.Text = "Refresh Data";
            this.bindingNavigatorRefreshItem.Click += new System.EventHandler(this.bindingNavigatorRefreshItem_Click);
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 759);
            this.Controls.Add(this.scheduleDataGridView);
            this.Controls.Add(this.teacherDataGridView);
            this.Controls.Add(this.sectionDataGridView);
            this.Controls.Add(this.scheduleBindingNavigator);
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.showSearchButton);
            this.Controls.Add(this.searchPanel);
            this.Name = "frmSchedule";
            this.Text = "frmSchedule";
            this.Load += new System.EventHandler(this.frmSchedule_Load);
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTU_DBDataSet)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.searchToolStrip.ResumeLayout(false);
            this.searchToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingNavigator)).EndInit();
            this.scheduleBindingNavigator.ResumeLayout(false);
            this.scheduleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showSearchButton;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label label2;
        private STU_DBDataSet sTU_DBDataSet;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private STU_DBDataSetTableAdapters.ScheduleTableAdapter scheduleTableAdapter;
        private STU_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator scheduleBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton scheduleBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView scheduleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorRefreshItem;
        private System.Windows.Forms.TextBox scheduleCodeTextBox;
        private System.Windows.Forms.TextBox sectionCodeTextBox;
        private System.Windows.Forms.TextBox subjectCodeTextBox;
        private System.Windows.Forms.TextBox startTimeTextBox;
        private System.Windows.Forms.TextBox endTimeTextBox;
        private System.Windows.Forms.TextBox daysTextBox;
        private System.Windows.Forms.TextBox teacherCodeTextBox;
        private System.Windows.Forms.ToolStrip searchToolStrip;
        private System.Windows.Forms.ToolStripLabel scheduleCodeToolStripLabel;
        private System.Windows.Forms.ToolStripLabel sectionCodeToolStripLabel;
        private System.Windows.Forms.ToolStripLabel teacherCodeToolStripLabel;
        private System.Windows.Forms.ToolStripButton searchToolStripButton;
        private System.Windows.Forms.ToolStripComboBox scheduleCodeToolStripComboBox;
        private System.Windows.Forms.ToolStripComboBox sectionCodeToolStripComboBox;
        private System.Windows.Forms.ToolStripComboBox teacherCodeToolStripComboBox;
        private System.Windows.Forms.Button viewSectionButton;
        private System.Windows.Forms.Button viewTeacherButton;
        private System.Windows.Forms.DataGridView sectionDataGridView;
        private System.Windows.Forms.DataGridView teacherDataGridView;
    }
}