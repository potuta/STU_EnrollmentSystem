namespace STUEnrollmentSystem
{
    partial class frmTeacher
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
            System.Windows.Forms.Label teacherNameLabel;
            System.Windows.Forms.Label teacherCodeLabel;
            System.Windows.Forms.Label sectionCodeLabel;
            System.Windows.Forms.Label subjectCodeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeacher));
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.generateTeacherCodeButton = new System.Windows.Forms.Button();
            this.subjectCodeComboBox = new System.Windows.Forms.ComboBox();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTU_DBDataSet = new STUEnrollmentSystem.STU_DBDataSet();
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectionCodeComboBox = new System.Windows.Forms.ComboBox();
            this.teacherNameTextBox = new System.Windows.Forms.TextBox();
            this.teacherCodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showSearchButton = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchTeachersToolStrip = new System.Windows.Forms.ToolStrip();
            this.teacherNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.teacherNameToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.teacherCodeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.teacherCodeToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.sectionCodeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.sectionCodeToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.subjectCodeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.subjectCodeToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.searchTeachersToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.teachersTableAdapter = new STUEnrollmentSystem.STU_DBDataSetTableAdapters.TeachersTableAdapter();
            this.tableAdapterManager = new STUEnrollmentSystem.STU_DBDataSetTableAdapters.TableAdapterManager();
            this.teachersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.teachersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorRefreshItem = new System.Windows.Forms.ToolStripButton();
            this.teachersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectsTableAdapter = new STUEnrollmentSystem.STU_DBDataSetTableAdapters.SubjectsTableAdapter();
            teacherNameLabel = new System.Windows.Forms.Label();
            teacherCodeLabel = new System.Windows.Forms.Label();
            sectionCodeLabel = new System.Windows.Forms.Label();
            subjectCodeLabel = new System.Windows.Forms.Label();
            this.detailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTU_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.searchTeachersToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingNavigator)).BeginInit();
            this.teachersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // teacherNameLabel
            // 
            teacherNameLabel.AutoSize = true;
            teacherNameLabel.Location = new System.Drawing.Point(46, 82);
            teacherNameLabel.Name = "teacherNameLabel";
            teacherNameLabel.Size = new System.Drawing.Size(81, 13);
            teacherNameLabel.TabIndex = 1;
            teacherNameLabel.Text = "Teacher Name:";
            // 
            // teacherCodeLabel
            // 
            teacherCodeLabel.AutoSize = true;
            teacherCodeLabel.Location = new System.Drawing.Point(49, 108);
            teacherCodeLabel.Name = "teacherCodeLabel";
            teacherCodeLabel.Size = new System.Drawing.Size(78, 13);
            teacherCodeLabel.TabIndex = 3;
            teacherCodeLabel.Text = "Teacher Code:";
            // 
            // sectionCodeLabel
            // 
            sectionCodeLabel.AutoSize = true;
            sectionCodeLabel.Location = new System.Drawing.Point(53, 134);
            sectionCodeLabel.Name = "sectionCodeLabel";
            sectionCodeLabel.Size = new System.Drawing.Size(74, 13);
            sectionCodeLabel.TabIndex = 5;
            sectionCodeLabel.Text = "Section Code:";
            // 
            // subjectCodeLabel
            // 
            subjectCodeLabel.AutoSize = true;
            subjectCodeLabel.Location = new System.Drawing.Point(53, 160);
            subjectCodeLabel.Name = "subjectCodeLabel";
            subjectCodeLabel.Size = new System.Drawing.Size(74, 13);
            subjectCodeLabel.TabIndex = 7;
            subjectCodeLabel.Text = "Subject Code:";
            // 
            // detailsPanel
            // 
            this.detailsPanel.AutoScroll = true;
            this.detailsPanel.Controls.Add(this.generateTeacherCodeButton);
            this.detailsPanel.Controls.Add(this.subjectCodeComboBox);
            this.detailsPanel.Controls.Add(this.sectionCodeComboBox);
            this.detailsPanel.Controls.Add(teacherNameLabel);
            this.detailsPanel.Controls.Add(this.teacherNameTextBox);
            this.detailsPanel.Controls.Add(teacherCodeLabel);
            this.detailsPanel.Controls.Add(this.teacherCodeTextBox);
            this.detailsPanel.Controls.Add(sectionCodeLabel);
            this.detailsPanel.Controls.Add(subjectCodeLabel);
            this.detailsPanel.Controls.Add(this.label1);
            this.detailsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.detailsPanel.Location = new System.Drawing.Point(0, 116);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(317, 643);
            this.detailsPanel.TabIndex = 21;
            // 
            // generateTeacherCodeButton
            // 
            this.generateTeacherCodeButton.BackColor = System.Drawing.Color.Transparent;
            this.generateTeacherCodeButton.FlatAppearance.BorderSize = 0;
            this.generateTeacherCodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateTeacherCodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateTeacherCodeButton.Location = new System.Drawing.Point(237, 97);
            this.generateTeacherCodeButton.Name = "generateTeacherCodeButton";
            this.generateTeacherCodeButton.Size = new System.Drawing.Size(23, 29);
            this.generateTeacherCodeButton.TabIndex = 66;
            this.generateTeacherCodeButton.Text = "🗘";
            this.generateTeacherCodeButton.UseVisualStyleBackColor = false;
            this.generateTeacherCodeButton.Click += new System.EventHandler(this.generateTeacherCodeButton_Click);
            // 
            // subjectCodeComboBox
            // 
            this.subjectCodeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teachersBindingSource, "SubjectCode", true));
            this.subjectCodeComboBox.DataSource = this.subjectsBindingSource;
            this.subjectCodeComboBox.DisplayMember = "SubjectCode";
            this.subjectCodeComboBox.FormattingEnabled = true;
            this.subjectCodeComboBox.Location = new System.Drawing.Point(136, 157);
            this.subjectCodeComboBox.Name = "subjectCodeComboBox";
            this.subjectCodeComboBox.Size = new System.Drawing.Size(100, 21);
            this.subjectCodeComboBox.TabIndex = 11;
            this.subjectCodeComboBox.ValueMember = "SubjectCode";
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            this.teachersBindingSource.DataSource = this.sTU_DBDataSet;
            // 
            // sTU_DBDataSet
            // 
            this.sTU_DBDataSet.DataSetName = "STU_DBDataSet";
            this.sTU_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectsBindingSource
            // 
            this.subjectsBindingSource.DataMember = "Subjects";
            this.subjectsBindingSource.DataSource = this.sTU_DBDataSet;
            // 
            // sectionCodeComboBox
            // 
            this.sectionCodeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teachersBindingSource, "SectionCode", true));
            this.sectionCodeComboBox.FormattingEnabled = true;
            this.sectionCodeComboBox.Location = new System.Drawing.Point(136, 130);
            this.sectionCodeComboBox.Name = "sectionCodeComboBox";
            this.sectionCodeComboBox.Size = new System.Drawing.Size(100, 21);
            this.sectionCodeComboBox.TabIndex = 10;
            // 
            // teacherNameTextBox
            // 
            this.teacherNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teachersBindingSource, "TeacherName", true));
            this.teacherNameTextBox.Location = new System.Drawing.Point(136, 79);
            this.teacherNameTextBox.Name = "teacherNameTextBox";
            this.teacherNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.teacherNameTextBox.TabIndex = 2;
            // 
            // teacherCodeTextBox
            // 
            this.teacherCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teachersBindingSource, "TeacherCode", true));
            this.teacherCodeTextBox.Location = new System.Drawing.Point(136, 105);
            this.teacherCodeTextBox.Name = "teacherCodeTextBox";
            this.teacherCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.teacherCodeTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher\'s Information";
            // 
            // showSearchButton
            // 
            this.showSearchButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.showSearchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.showSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showSearchButton.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSearchButton.Location = new System.Drawing.Point(0, 89);
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
            this.searchPanel.Controls.Add(this.searchTeachersToolStrip);
            this.searchPanel.Controls.Add(this.label2);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel.Location = new System.Drawing.Point(0, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1264, 89);
            this.searchPanel.TabIndex = 19;
            // 
            // searchTeachersToolStrip
            // 
            this.searchTeachersToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.searchTeachersToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.searchTeachersToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teacherNameToolStripLabel,
            this.teacherNameToolStripComboBox,
            this.teacherCodeToolStripLabel,
            this.teacherCodeToolStripComboBox,
            this.sectionCodeToolStripLabel,
            this.sectionCodeToolStripComboBox,
            this.subjectCodeToolStripLabel,
            this.subjectCodeToolStripComboBox,
            this.searchTeachersToolStripButton});
            this.searchTeachersToolStrip.Location = new System.Drawing.Point(61, 41);
            this.searchTeachersToolStrip.Name = "searchTeachersToolStrip";
            this.searchTeachersToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.searchTeachersToolStrip.Size = new System.Drawing.Size(905, 25);
            this.searchTeachersToolStrip.TabIndex = 23;
            this.searchTeachersToolStrip.Text = "searchTeachersToolStrip";
            // 
            // teacherNameToolStripLabel
            // 
            this.teacherNameToolStripLabel.BackColor = System.Drawing.Color.Transparent;
            this.teacherNameToolStripLabel.Name = "teacherNameToolStripLabel";
            this.teacherNameToolStripLabel.Size = new System.Drawing.Size(86, 22);
            this.teacherNameToolStripLabel.Text = "Teacher Name:";
            // 
            // teacherNameToolStripComboBox
            // 
            this.teacherNameToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.teacherNameToolStripComboBox.Name = "teacherNameToolStripComboBox";
            this.teacherNameToolStripComboBox.Size = new System.Drawing.Size(100, 25);
            this.teacherNameToolStripComboBox.TextChanged += new System.EventHandler(this.OnSearchToolStripTextChanged);
            // 
            // teacherCodeToolStripLabel
            // 
            this.teacherCodeToolStripLabel.BackColor = System.Drawing.Color.Transparent;
            this.teacherCodeToolStripLabel.Name = "teacherCodeToolStripLabel";
            this.teacherCodeToolStripLabel.Size = new System.Drawing.Size(112, 22);
            this.teacherCodeToolStripLabel.Text = "          Teacher Code:";
            // 
            // teacherCodeToolStripComboBox
            // 
            this.teacherCodeToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.teacherCodeToolStripComboBox.Name = "teacherCodeToolStripComboBox";
            this.teacherCodeToolStripComboBox.Size = new System.Drawing.Size(100, 25);
            this.teacherCodeToolStripComboBox.TextChanged += new System.EventHandler(this.OnSearchToolStripTextChanged);
            // 
            // sectionCodeToolStripLabel
            // 
            this.sectionCodeToolStripLabel.BackColor = System.Drawing.Color.Transparent;
            this.sectionCodeToolStripLabel.Name = "sectionCodeToolStripLabel";
            this.sectionCodeToolStripLabel.Size = new System.Drawing.Size(110, 22);
            this.sectionCodeToolStripLabel.Text = "          Section Code:";
            // 
            // sectionCodeToolStripComboBox
            // 
            this.sectionCodeToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sectionCodeToolStripComboBox.Name = "sectionCodeToolStripComboBox";
            this.sectionCodeToolStripComboBox.Size = new System.Drawing.Size(100, 25);
            this.sectionCodeToolStripComboBox.TextChanged += new System.EventHandler(this.OnSearchToolStripTextChanged);
            // 
            // subjectCodeToolStripLabel
            // 
            this.subjectCodeToolStripLabel.BackColor = System.Drawing.Color.Transparent;
            this.subjectCodeToolStripLabel.Name = "subjectCodeToolStripLabel";
            this.subjectCodeToolStripLabel.Size = new System.Drawing.Size(110, 22);
            this.subjectCodeToolStripLabel.Text = "          Subject Code:";
            // 
            // subjectCodeToolStripComboBox
            // 
            this.subjectCodeToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.subjectCodeToolStripComboBox.Name = "subjectCodeToolStripComboBox";
            this.subjectCodeToolStripComboBox.Size = new System.Drawing.Size(100, 25);
            this.subjectCodeToolStripComboBox.TextChanged += new System.EventHandler(this.OnSearchToolStripTextChanged);
            // 
            // searchTeachersToolStripButton
            // 
            this.searchTeachersToolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.searchTeachersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchTeachersToolStripButton.Name = "searchTeachersToolStripButton";
            this.searchTeachersToolStripButton.Size = new System.Drawing.Size(76, 22);
            this.searchTeachersToolStripButton.Text = "          Search";
            this.searchTeachersToolStripButton.Click += new System.EventHandler(this.searchTeachersToolStripButton_Click);
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
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ScheduleTableAdapter = null;
            this.tableAdapterManager.SectionsTableAdapter = null;
            this.tableAdapterManager.StudentPaymentTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.SubjectsTableAdapter = null;
            this.tableAdapterManager.TeachersTableAdapter = this.teachersTableAdapter;
            this.tableAdapterManager.UpdateOrder = STUEnrollmentSystem.STU_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // teachersBindingNavigator
            // 
            this.teachersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.teachersBindingNavigator.BindingSource = this.teachersBindingSource;
            this.teachersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.teachersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.teachersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.teachersBindingNavigatorSaveItem,
            this.bindingNavigatorRefreshItem});
            this.teachersBindingNavigator.Location = new System.Drawing.Point(317, 116);
            this.teachersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.teachersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.teachersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.teachersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.teachersBindingNavigator.Name = "teachersBindingNavigator";
            this.teachersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.teachersBindingNavigator.Size = new System.Drawing.Size(947, 25);
            this.teachersBindingNavigator.TabIndex = 22;
            this.teachersBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // teachersBindingNavigatorSaveItem
            // 
            this.teachersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.teachersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("teachersBindingNavigatorSaveItem.Image")));
            this.teachersBindingNavigatorSaveItem.Name = "teachersBindingNavigatorSaveItem";
            this.teachersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.teachersBindingNavigatorSaveItem.Text = "Save Data";
            this.teachersBindingNavigatorSaveItem.Click += new System.EventHandler(this.teachersBindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorRefreshItem
            // 
            this.bindingNavigatorRefreshItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorRefreshItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorRefreshItem.Image")));
            this.bindingNavigatorRefreshItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorRefreshItem.Name = "bindingNavigatorRefreshItem";
            this.bindingNavigatorRefreshItem.Size = new System.Drawing.Size(77, 22);
            this.bindingNavigatorRefreshItem.Text = "Refresh Data";
            this.bindingNavigatorRefreshItem.Click += new System.EventHandler(this.bindingNavigatorRefreshItem_Click);
            // 
            // teachersDataGridView
            // 
            this.teachersDataGridView.AutoGenerateColumns = false;
            this.teachersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.teachersDataGridView.DataSource = this.teachersBindingSource;
            this.teachersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teachersDataGridView.Location = new System.Drawing.Point(317, 141);
            this.teachersDataGridView.Name = "teachersDataGridView";
            this.teachersDataGridView.Size = new System.Drawing.Size(947, 618);
            this.teachersDataGridView.TabIndex = 22;
            this.teachersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teachersDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TeacherName";
            this.dataGridViewTextBoxColumn1.HeaderText = "TeacherName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TeacherCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "TeacherCode";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SectionCode";
            this.dataGridViewTextBoxColumn3.HeaderText = "SectionCode";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SubjectCode";
            this.dataGridViewTextBoxColumn4.HeaderText = "SubjectCode";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // subjectsTableAdapter
            // 
            this.subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // frmTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 759);
            this.Controls.Add(this.teachersDataGridView);
            this.Controls.Add(this.teachersBindingNavigator);
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.showSearchButton);
            this.Controls.Add(this.searchPanel);
            this.Name = "frmTeacher";
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.Teacher_Load);
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTU_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.searchTeachersToolStrip.ResumeLayout(false);
            this.searchTeachersToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingNavigator)).EndInit();
            this.teachersBindingNavigator.ResumeLayout(false);
            this.teachersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataGridView)).EndInit();
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
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private STU_DBDataSetTableAdapters.TeachersTableAdapter teachersTableAdapter;
        private STU_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator teachersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton teachersBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView teachersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox teacherNameTextBox;
        private System.Windows.Forms.TextBox teacherCodeTextBox;
        private System.Windows.Forms.ComboBox sectionCodeComboBox;
        private System.Windows.Forms.ComboBox subjectCodeComboBox;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private STU_DBDataSetTableAdapters.SubjectsTableAdapter subjectsTableAdapter;
        private System.Windows.Forms.ToolStripButton bindingNavigatorRefreshItem;
        private System.Windows.Forms.Button generateTeacherCodeButton;
        private System.Windows.Forms.ToolStrip searchTeachersToolStrip;
        private System.Windows.Forms.ToolStripLabel teacherNameToolStripLabel;
        private System.Windows.Forms.ToolStripLabel teacherCodeToolStripLabel;
        private System.Windows.Forms.ToolStripLabel sectionCodeToolStripLabel;
        private System.Windows.Forms.ToolStripLabel subjectCodeToolStripLabel;
        private System.Windows.Forms.ToolStripButton searchTeachersToolStripButton;
        private System.Windows.Forms.ToolStripComboBox teacherNameToolStripComboBox;
        private System.Windows.Forms.ToolStripComboBox teacherCodeToolStripComboBox;
        private System.Windows.Forms.ToolStripComboBox sectionCodeToolStripComboBox;
        private System.Windows.Forms.ToolStripComboBox subjectCodeToolStripComboBox;
    }
}