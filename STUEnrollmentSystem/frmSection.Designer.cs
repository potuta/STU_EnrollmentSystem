namespace STUEnrollmentSystem
{
    partial class frmSection
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
            System.Windows.Forms.Label sectionTitleLabel;
            System.Windows.Forms.Label sectionCodeLabel;
            System.Windows.Forms.Label roomLabel;
            System.Windows.Forms.Label teacherCodeLabel;
            System.Windows.Forms.Label gradeCodeLabel;
            System.Windows.Forms.Label scheduleCodeLabel;
            System.Windows.Forms.Label capacityLabel;
            System.Windows.Forms.Label studCountLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSection));
            this.showSearchButton = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchToolStrip = new System.Windows.Forms.ToolStrip();
            this.sectionTitleToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.sectionTitleToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.sectionCodeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.sectionCodeToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.roomToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.roomToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.gradeCodeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.gradeCodeToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.searchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.teacherCodeComboBox = new System.Windows.Forms.ComboBox();
            this.sectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTU_DBDataSet = new STUEnrollmentSystem.STU_DBDataSet();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectionTitleTextBox = new System.Windows.Forms.TextBox();
            this.sectionCodeTextBox = new System.Windows.Forms.TextBox();
            this.roomTextBox = new System.Windows.Forms.TextBox();
            this.gradeCodeTextBox = new System.Windows.Forms.TextBox();
            this.scheduleCodeTextBox = new System.Windows.Forms.TextBox();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.studCountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sectionsTableAdapter = new STUEnrollmentSystem.STU_DBDataSetTableAdapters.SectionsTableAdapter();
            this.tableAdapterManager = new STUEnrollmentSystem.STU_DBDataSetTableAdapters.TableAdapterManager();
            this.teachersTableAdapter = new STUEnrollmentSystem.STU_DBDataSetTableAdapters.TeachersTableAdapter();
            this.sectionsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sectionsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorRefreshItem = new System.Windows.Forms.ToolStripButton();
            this.sectionsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sectionTitleLabel = new System.Windows.Forms.Label();
            sectionCodeLabel = new System.Windows.Forms.Label();
            roomLabel = new System.Windows.Forms.Label();
            teacherCodeLabel = new System.Windows.Forms.Label();
            gradeCodeLabel = new System.Windows.Forms.Label();
            scheduleCodeLabel = new System.Windows.Forms.Label();
            capacityLabel = new System.Windows.Forms.Label();
            studCountLabel = new System.Windows.Forms.Label();
            this.searchPanel.SuspendLayout();
            this.searchToolStrip.SuspendLayout();
            this.detailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTU_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingNavigator)).BeginInit();
            this.sectionsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sectionTitleLabel
            // 
            sectionTitleLabel.AutoSize = true;
            sectionTitleLabel.Location = new System.Drawing.Point(53, 90);
            sectionTitleLabel.Name = "sectionTitleLabel";
            sectionTitleLabel.Size = new System.Drawing.Size(69, 13);
            sectionTitleLabel.TabIndex = 1;
            sectionTitleLabel.Text = "Section Title:";
            // 
            // sectionCodeLabel
            // 
            sectionCodeLabel.AutoSize = true;
            sectionCodeLabel.Location = new System.Drawing.Point(53, 116);
            sectionCodeLabel.Name = "sectionCodeLabel";
            sectionCodeLabel.Size = new System.Drawing.Size(74, 13);
            sectionCodeLabel.TabIndex = 3;
            sectionCodeLabel.Text = "Section Code:";
            // 
            // roomLabel
            // 
            roomLabel.AutoSize = true;
            roomLabel.Location = new System.Drawing.Point(53, 142);
            roomLabel.Name = "roomLabel";
            roomLabel.Size = new System.Drawing.Size(38, 13);
            roomLabel.TabIndex = 5;
            roomLabel.Text = "Room:";
            // 
            // teacherCodeLabel
            // 
            teacherCodeLabel.AutoSize = true;
            teacherCodeLabel.Location = new System.Drawing.Point(53, 168);
            teacherCodeLabel.Name = "teacherCodeLabel";
            teacherCodeLabel.Size = new System.Drawing.Size(78, 13);
            teacherCodeLabel.TabIndex = 7;
            teacherCodeLabel.Text = "Teacher Code:";
            // 
            // gradeCodeLabel
            // 
            gradeCodeLabel.AutoSize = true;
            gradeCodeLabel.Location = new System.Drawing.Point(53, 194);
            gradeCodeLabel.Name = "gradeCodeLabel";
            gradeCodeLabel.Size = new System.Drawing.Size(67, 13);
            gradeCodeLabel.TabIndex = 9;
            gradeCodeLabel.Text = "Grade Code:";
            // 
            // scheduleCodeLabel
            // 
            scheduleCodeLabel.AutoSize = true;
            scheduleCodeLabel.Location = new System.Drawing.Point(53, 220);
            scheduleCodeLabel.Name = "scheduleCodeLabel";
            scheduleCodeLabel.Size = new System.Drawing.Size(83, 13);
            scheduleCodeLabel.TabIndex = 11;
            scheduleCodeLabel.Text = "Schedule Code:";
            // 
            // capacityLabel
            // 
            capacityLabel.AutoSize = true;
            capacityLabel.Location = new System.Drawing.Point(53, 246);
            capacityLabel.Name = "capacityLabel";
            capacityLabel.Size = new System.Drawing.Size(51, 13);
            capacityLabel.TabIndex = 13;
            capacityLabel.Text = "Capacity:";
            // 
            // studCountLabel
            // 
            studCountLabel.AutoSize = true;
            studCountLabel.Location = new System.Drawing.Point(53, 272);
            studCountLabel.Name = "studCountLabel";
            studCountLabel.Size = new System.Drawing.Size(63, 13);
            studCountLabel.TabIndex = 15;
            studCountLabel.Text = "Stud Count:";
            // 
            // showSearchButton
            // 
            this.showSearchButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.showSearchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.showSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showSearchButton.Font = new System.Drawing.Font("Subway", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSearchButton.Location = new System.Drawing.Point(0, 117);
            this.showSearchButton.Name = "showSearchButton";
            this.showSearchButton.Size = new System.Drawing.Size(1264, 27);
            this.showSearchButton.TabIndex = 9;
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
            this.searchPanel.Size = new System.Drawing.Size(1264, 117);
            this.searchPanel.TabIndex = 8;
            // 
            // searchToolStrip
            // 
            this.searchToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.searchToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.searchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sectionTitleToolStripLabel,
            this.sectionTitleToolStripComboBox,
            this.sectionCodeToolStripLabel,
            this.sectionCodeToolStripComboBox,
            this.roomToolStripLabel,
            this.roomToolStripComboBox,
            this.gradeCodeToolStripLabel,
            this.gradeCodeToolStripComboBox,
            this.searchToolStripButton});
            this.searchToolStrip.Location = new System.Drawing.Point(67, 50);
            this.searchToolStrip.Name = "searchToolStrip";
            this.searchToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.searchToolStrip.Size = new System.Drawing.Size(876, 25);
            this.searchToolStrip.TabIndex = 17;
            this.searchToolStrip.Text = "searchToolStrip";
            // 
            // sectionTitleToolStripLabel
            // 
            this.sectionTitleToolStripLabel.BackColor = System.Drawing.Color.Transparent;
            this.sectionTitleToolStripLabel.Name = "sectionTitleToolStripLabel";
            this.sectionTitleToolStripLabel.Size = new System.Drawing.Size(74, 22);
            this.sectionTitleToolStripLabel.Text = "Section Title:";
            // 
            // sectionTitleToolStripComboBox
            // 
            this.sectionTitleToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.sectionTitleToolStripComboBox.Name = "sectionTitleToolStripComboBox";
            this.sectionTitleToolStripComboBox.Size = new System.Drawing.Size(100, 25);
            this.sectionTitleToolStripComboBox.TextChanged += new System.EventHandler(this.OnSearchToolStripTextChanged);
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
            this.sectionCodeToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.sectionCodeToolStripComboBox.Name = "sectionCodeToolStripComboBox";
            this.sectionCodeToolStripComboBox.Size = new System.Drawing.Size(100, 25);
            this.sectionCodeToolStripComboBox.TextChanged += new System.EventHandler(this.OnSearchToolStripTextChanged);
            // 
            // roomToolStripLabel
            // 
            this.roomToolStripLabel.BackColor = System.Drawing.Color.Transparent;
            this.roomToolStripLabel.Name = "roomToolStripLabel";
            this.roomToolStripLabel.Size = new System.Drawing.Size(72, 22);
            this.roomToolStripLabel.Text = "          Room:";
            // 
            // roomToolStripComboBox
            // 
            this.roomToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.roomToolStripComboBox.Name = "roomToolStripComboBox";
            this.roomToolStripComboBox.Size = new System.Drawing.Size(100, 25);
            this.roomToolStripComboBox.TextChanged += new System.EventHandler(this.OnSearchToolStripTextChanged);
            // 
            // gradeCodeToolStripLabel
            // 
            this.gradeCodeToolStripLabel.BackColor = System.Drawing.Color.Transparent;
            this.gradeCodeToolStripLabel.Name = "gradeCodeToolStripLabel";
            this.gradeCodeToolStripLabel.Size = new System.Drawing.Size(102, 22);
            this.gradeCodeToolStripLabel.Text = "          Grade Code:";
            // 
            // gradeCodeToolStripComboBox
            // 
            this.gradeCodeToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.gradeCodeToolStripComboBox.Name = "gradeCodeToolStripComboBox";
            this.gradeCodeToolStripComboBox.Size = new System.Drawing.Size(100, 25);
            this.gradeCodeToolStripComboBox.TextChanged += new System.EventHandler(this.OnSearchToolStripTextChanged);
            // 
            // searchToolStripButton
            // 
            this.searchToolStripButton.BackColor = System.Drawing.Color.Transparent;
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
            // detailsPanel
            // 
            this.detailsPanel.AutoScroll = true;
            this.detailsPanel.Controls.Add(this.teacherCodeComboBox);
            this.detailsPanel.Controls.Add(sectionTitleLabel);
            this.detailsPanel.Controls.Add(this.sectionTitleTextBox);
            this.detailsPanel.Controls.Add(sectionCodeLabel);
            this.detailsPanel.Controls.Add(this.sectionCodeTextBox);
            this.detailsPanel.Controls.Add(roomLabel);
            this.detailsPanel.Controls.Add(this.roomTextBox);
            this.detailsPanel.Controls.Add(teacherCodeLabel);
            this.detailsPanel.Controls.Add(gradeCodeLabel);
            this.detailsPanel.Controls.Add(this.gradeCodeTextBox);
            this.detailsPanel.Controls.Add(scheduleCodeLabel);
            this.detailsPanel.Controls.Add(this.scheduleCodeTextBox);
            this.detailsPanel.Controls.Add(capacityLabel);
            this.detailsPanel.Controls.Add(this.capacityTextBox);
            this.detailsPanel.Controls.Add(studCountLabel);
            this.detailsPanel.Controls.Add(this.studCountTextBox);
            this.detailsPanel.Controls.Add(this.label1);
            this.detailsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.detailsPanel.Location = new System.Drawing.Point(0, 144);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(316, 615);
            this.detailsPanel.TabIndex = 15;
            // 
            // teacherCodeComboBox
            // 
            this.teacherCodeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionsBindingSource, "TeacherCode", true));
            this.teacherCodeComboBox.DataSource = this.teachersBindingSource;
            this.teacherCodeComboBox.DisplayMember = "TeacherCode";
            this.teacherCodeComboBox.FormattingEnabled = true;
            this.teacherCodeComboBox.Location = new System.Drawing.Point(142, 165);
            this.teacherCodeComboBox.Name = "teacherCodeComboBox";
            this.teacherCodeComboBox.Size = new System.Drawing.Size(100, 21);
            this.teacherCodeComboBox.TabIndex = 17;
            this.teacherCodeComboBox.ValueMember = "TeacherCode";
            // 
            // sectionsBindingSource
            // 
            this.sectionsBindingSource.DataMember = "Sections";
            this.sectionsBindingSource.DataSource = this.sTU_DBDataSet;
            // 
            // sTU_DBDataSet
            // 
            this.sTU_DBDataSet.DataSetName = "STU_DBDataSet";
            this.sTU_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            this.teachersBindingSource.DataSource = this.sTU_DBDataSet;
            // 
            // sectionTitleTextBox
            // 
            this.sectionTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionsBindingSource, "SectionTitle", true));
            this.sectionTitleTextBox.Location = new System.Drawing.Point(142, 87);
            this.sectionTitleTextBox.Name = "sectionTitleTextBox";
            this.sectionTitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.sectionTitleTextBox.TabIndex = 2;
            // 
            // sectionCodeTextBox
            // 
            this.sectionCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionsBindingSource, "SectionCode", true));
            this.sectionCodeTextBox.Location = new System.Drawing.Point(142, 113);
            this.sectionCodeTextBox.Name = "sectionCodeTextBox";
            this.sectionCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sectionCodeTextBox.TabIndex = 4;
            // 
            // roomTextBox
            // 
            this.roomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionsBindingSource, "Room", true));
            this.roomTextBox.Location = new System.Drawing.Point(142, 139);
            this.roomTextBox.Name = "roomTextBox";
            this.roomTextBox.Size = new System.Drawing.Size(100, 20);
            this.roomTextBox.TabIndex = 6;
            // 
            // gradeCodeTextBox
            // 
            this.gradeCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionsBindingSource, "GradeCode", true));
            this.gradeCodeTextBox.Location = new System.Drawing.Point(142, 191);
            this.gradeCodeTextBox.Name = "gradeCodeTextBox";
            this.gradeCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.gradeCodeTextBox.TabIndex = 10;
            // 
            // scheduleCodeTextBox
            // 
            this.scheduleCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionsBindingSource, "ScheduleCode", true));
            this.scheduleCodeTextBox.Location = new System.Drawing.Point(142, 217);
            this.scheduleCodeTextBox.Name = "scheduleCodeTextBox";
            this.scheduleCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.scheduleCodeTextBox.TabIndex = 12;
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionsBindingSource, "Capacity", true));
            this.capacityTextBox.Location = new System.Drawing.Point(142, 243);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(100, 20);
            this.capacityTextBox.TabIndex = 14;
            // 
            // studCountTextBox
            // 
            this.studCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionsBindingSource, "StudCount", true));
            this.studCountTextBox.Location = new System.Drawing.Point(142, 269);
            this.studCountTextBox.Name = "studCountTextBox";
            this.studCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.studCountTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Section Information";
            // 
            // sectionsTableAdapter
            // 
            this.sectionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GradeLevelTableAdapter = null;
            this.tableAdapterManager.PaymentTypeTableAdapter = null;
            this.tableAdapterManager.PendingStudentsTableAdapter = null;
            this.tableAdapterManager.PricesTableAdapter = null;
            this.tableAdapterManager.RegistrationTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.ScheduleTableAdapter = null;
            this.tableAdapterManager.SectionsTableAdapter = this.sectionsTableAdapter;
            this.tableAdapterManager.StudentPaymentTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.SubjectsTableAdapter = null;
            this.tableAdapterManager.TeachersTableAdapter = this.teachersTableAdapter;
            this.tableAdapterManager.UpdateOrder = STUEnrollmentSystem.STU_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // sectionsBindingNavigator
            // 
            this.sectionsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sectionsBindingNavigator.BindingSource = this.sectionsBindingSource;
            this.sectionsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sectionsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sectionsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sectionsBindingNavigatorSaveItem,
            this.bindingNavigatorRefreshItem});
            this.sectionsBindingNavigator.Location = new System.Drawing.Point(316, 144);
            this.sectionsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sectionsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sectionsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sectionsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sectionsBindingNavigator.Name = "sectionsBindingNavigator";
            this.sectionsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sectionsBindingNavigator.Size = new System.Drawing.Size(948, 25);
            this.sectionsBindingNavigator.TabIndex = 16;
            this.sectionsBindingNavigator.Text = "bindingNavigator1";
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
            // sectionsBindingNavigatorSaveItem
            // 
            this.sectionsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sectionsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sectionsBindingNavigatorSaveItem.Image")));
            this.sectionsBindingNavigatorSaveItem.Name = "sectionsBindingNavigatorSaveItem";
            this.sectionsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sectionsBindingNavigatorSaveItem.Text = "Save Data";
            this.sectionsBindingNavigatorSaveItem.Click += new System.EventHandler(this.sectionsBindingNavigatorSaveItem_Click);
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
            // sectionsDataGridView
            // 
            this.sectionsDataGridView.AutoGenerateColumns = false;
            this.sectionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sectionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sectionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.sectionsDataGridView.DataSource = this.sectionsBindingSource;
            this.sectionsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sectionsDataGridView.Location = new System.Drawing.Point(316, 169);
            this.sectionsDataGridView.Name = "sectionsDataGridView";
            this.sectionsDataGridView.Size = new System.Drawing.Size(948, 590);
            this.sectionsDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SectionTitle";
            this.dataGridViewTextBoxColumn1.HeaderText = "SectionTitle";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SectionCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "SectionCode";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Room";
            this.dataGridViewTextBoxColumn3.HeaderText = "Room";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TeacherCode";
            this.dataGridViewTextBoxColumn4.HeaderText = "TeacherCode";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GradeCode";
            this.dataGridViewTextBoxColumn5.HeaderText = "GradeCode";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ScheduleCode";
            this.dataGridViewTextBoxColumn6.HeaderText = "ScheduleCode";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Capacity";
            this.dataGridViewTextBoxColumn7.HeaderText = "Capacity";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "StudCount";
            this.dataGridViewTextBoxColumn8.HeaderText = "StudCount";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // frmSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 759);
            this.Controls.Add(this.sectionsDataGridView);
            this.Controls.Add(this.sectionsBindingNavigator);
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.showSearchButton);
            this.Controls.Add(this.searchPanel);
            this.Name = "frmSection";
            this.Text = "Section";
            this.Load += new System.EventHandler(this.Section_Load);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.searchToolStrip.ResumeLayout(false);
            this.searchToolStrip.PerformLayout();
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTU_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingNavigator)).EndInit();
            this.sectionsBindingNavigator.ResumeLayout(false);
            this.sectionsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showSearchButton;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.Label label1;
        private STU_DBDataSet sTU_DBDataSet;
        private System.Windows.Forms.BindingSource sectionsBindingSource;
        private STU_DBDataSetTableAdapters.SectionsTableAdapter sectionsTableAdapter;
        private STU_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sectionsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sectionsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView sectionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox sectionTitleTextBox;
        private System.Windows.Forms.TextBox sectionCodeTextBox;
        private System.Windows.Forms.TextBox roomTextBox;
        private System.Windows.Forms.TextBox gradeCodeTextBox;
        private System.Windows.Forms.TextBox scheduleCodeTextBox;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.TextBox studCountTextBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorRefreshItem;
        private System.Windows.Forms.ComboBox teacherCodeComboBox;
        private STU_DBDataSetTableAdapters.TeachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private System.Windows.Forms.ToolStrip searchToolStrip;
        private System.Windows.Forms.ToolStripLabel sectionTitleToolStripLabel;
        private System.Windows.Forms.ToolStripLabel sectionCodeToolStripLabel;
        private System.Windows.Forms.ToolStripLabel roomToolStripLabel;
        private System.Windows.Forms.ToolStripLabel gradeCodeToolStripLabel;
        private System.Windows.Forms.ToolStripButton searchToolStripButton;
        private System.Windows.Forms.ToolStripComboBox sectionTitleToolStripComboBox;
        private System.Windows.Forms.ToolStripComboBox sectionCodeToolStripComboBox;
        private System.Windows.Forms.ToolStripComboBox roomToolStripComboBox;
        private System.Windows.Forms.ToolStripComboBox gradeCodeToolStripComboBox;
    }
}