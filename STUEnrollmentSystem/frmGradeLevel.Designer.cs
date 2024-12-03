namespace STUEnrollmentSystem
{
    partial class frmGradeLevel
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
            System.Windows.Forms.Label gradeLevelLabel;
            System.Windows.Forms.Label gradeCodeLabel;
            System.Windows.Forms.Label subjectGradeCodeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGradeLevel));
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.gradeLevelTextBox = new System.Windows.Forms.TextBox();
            this.gradeLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTU_DBDataSet = new STUEnrollmentSystem.STU_DBDataSet();
            this.gradeCodeTextBox = new System.Windows.Forms.TextBox();
            this.subjectGradeCodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showSearchButton = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchToolStrip = new System.Windows.Forms.ToolStrip();
            this.gradeLevelToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.gradeLevelToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.gradeCodeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.gradeCodeToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.subjectGradeCodeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.subjectGradeCodeToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.searchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.gradeLevelTableAdapter = new STUEnrollmentSystem.STU_DBDataSetTableAdapters.GradeLevelTableAdapter();
            this.tableAdapterManager = new STUEnrollmentSystem.STU_DBDataSetTableAdapters.TableAdapterManager();
            this.gradeLevelBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.gradeLevelBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorRefreshItem = new System.Windows.Forms.ToolStripButton();
            this.gradeLevelDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            gradeLevelLabel = new System.Windows.Forms.Label();
            gradeCodeLabel = new System.Windows.Forms.Label();
            subjectGradeCodeLabel = new System.Windows.Forms.Label();
            this.detailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeLevelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTU_DBDataSet)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.searchToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeLevelBindingNavigator)).BeginInit();
            this.gradeLevelBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeLevelDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gradeLevelLabel
            // 
            gradeLevelLabel.AutoSize = true;
            gradeLevelLabel.Location = new System.Drawing.Point(41, 90);
            gradeLevelLabel.Name = "gradeLevelLabel";
            gradeLevelLabel.Size = new System.Drawing.Size(68, 13);
            gradeLevelLabel.TabIndex = 1;
            gradeLevelLabel.Text = "Grade Level:";
            // 
            // gradeCodeLabel
            // 
            gradeCodeLabel.AutoSize = true;
            gradeCodeLabel.Location = new System.Drawing.Point(41, 116);
            gradeCodeLabel.Name = "gradeCodeLabel";
            gradeCodeLabel.Size = new System.Drawing.Size(67, 13);
            gradeCodeLabel.TabIndex = 3;
            gradeCodeLabel.Text = "Grade Code:";
            // 
            // subjectGradeCodeLabel
            // 
            subjectGradeCodeLabel.AutoSize = true;
            subjectGradeCodeLabel.Location = new System.Drawing.Point(41, 142);
            subjectGradeCodeLabel.Name = "subjectGradeCodeLabel";
            subjectGradeCodeLabel.Size = new System.Drawing.Size(106, 13);
            subjectGradeCodeLabel.TabIndex = 5;
            subjectGradeCodeLabel.Text = "Subject Grade Code:";
            // 
            // detailsPanel
            // 
            this.detailsPanel.AutoScroll = true;
            this.detailsPanel.Controls.Add(gradeLevelLabel);
            this.detailsPanel.Controls.Add(this.gradeLevelTextBox);
            this.detailsPanel.Controls.Add(gradeCodeLabel);
            this.detailsPanel.Controls.Add(this.gradeCodeTextBox);
            this.detailsPanel.Controls.Add(subjectGradeCodeLabel);
            this.detailsPanel.Controls.Add(this.subjectGradeCodeTextBox);
            this.detailsPanel.Controls.Add(this.label1);
            this.detailsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.detailsPanel.Location = new System.Drawing.Point(0, 115);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(301, 644);
            this.detailsPanel.TabIndex = 23;
            // 
            // gradeLevelTextBox
            // 
            this.gradeLevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gradeLevelBindingSource, "GradeLevel", true));
            this.gradeLevelTextBox.Location = new System.Drawing.Point(153, 87);
            this.gradeLevelTextBox.Name = "gradeLevelTextBox";
            this.gradeLevelTextBox.Size = new System.Drawing.Size(100, 20);
            this.gradeLevelTextBox.TabIndex = 2;
            // 
            // gradeLevelBindingSource
            // 
            this.gradeLevelBindingSource.DataMember = "GradeLevel";
            this.gradeLevelBindingSource.DataSource = this.sTU_DBDataSet;
            // 
            // sTU_DBDataSet
            // 
            this.sTU_DBDataSet.DataSetName = "STU_DBDataSet";
            this.sTU_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gradeCodeTextBox
            // 
            this.gradeCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gradeLevelBindingSource, "GradeCode", true));
            this.gradeCodeTextBox.Location = new System.Drawing.Point(153, 113);
            this.gradeCodeTextBox.Name = "gradeCodeTextBox";
            this.gradeCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.gradeCodeTextBox.TabIndex = 4;
            // 
            // subjectGradeCodeTextBox
            // 
            this.subjectGradeCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gradeLevelBindingSource, "SubjectGradeCode", true));
            this.subjectGradeCodeTextBox.Location = new System.Drawing.Point(153, 139);
            this.subjectGradeCodeTextBox.Name = "subjectGradeCodeTextBox";
            this.subjectGradeCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.subjectGradeCodeTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grade Level Information";
            // 
            // showSearchButton
            // 
            this.showSearchButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.showSearchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.showSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showSearchButton.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSearchButton.Location = new System.Drawing.Point(0, 88);
            this.showSearchButton.Name = "showSearchButton";
            this.showSearchButton.Size = new System.Drawing.Size(1264, 27);
            this.showSearchButton.TabIndex = 22;
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
            this.searchPanel.Size = new System.Drawing.Size(1264, 88);
            this.searchPanel.TabIndex = 21;
            // 
            // searchToolStrip
            // 
            this.searchToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.searchToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.searchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gradeLevelToolStripLabel,
            this.gradeLevelToolStripComboBox,
            this.gradeCodeToolStripLabel,
            this.gradeCodeToolStripComboBox,
            this.subjectGradeCodeToolStripLabel,
            this.subjectGradeCodeToolStripComboBox,
            this.searchToolStripButton});
            this.searchToolStrip.Location = new System.Drawing.Point(83, 44);
            this.searchToolStrip.Name = "searchToolStrip";
            this.searchToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.searchToolStrip.Size = new System.Drawing.Size(638, 25);
            this.searchToolStrip.TabIndex = 25;
            this.searchToolStrip.Text = "searchToolStrip";
            // 
            // gradeLevelToolStripLabel
            // 
            this.gradeLevelToolStripLabel.Name = "gradeLevelToolStripLabel";
            this.gradeLevelToolStripLabel.Size = new System.Drawing.Size(71, 22);
            this.gradeLevelToolStripLabel.Text = "Grade Level:";
            // 
            // gradeLevelToolStripComboBox
            // 
            this.gradeLevelToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.gradeLevelToolStripComboBox.Name = "gradeLevelToolStripComboBox";
            this.gradeLevelToolStripComboBox.Size = new System.Drawing.Size(100, 25);
            this.gradeLevelToolStripComboBox.TextChanged += new System.EventHandler(this.OnSearchToolStripTextChanged);
            // 
            // gradeCodeToolStripLabel
            // 
            this.gradeCodeToolStripLabel.Name = "gradeCodeToolStripLabel";
            this.gradeCodeToolStripLabel.Size = new System.Drawing.Size(87, 22);
            this.gradeCodeToolStripLabel.Text = "     Grade Code:";
            // 
            // gradeCodeToolStripComboBox
            // 
            this.gradeCodeToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.gradeCodeToolStripComboBox.Name = "gradeCodeToolStripComboBox";
            this.gradeCodeToolStripComboBox.Size = new System.Drawing.Size(100, 25);
            this.gradeCodeToolStripComboBox.TextChanged += new System.EventHandler(this.OnSearchToolStripTextChanged);
            // 
            // subjectGradeCodeToolStripLabel
            // 
            this.subjectGradeCodeToolStripLabel.Name = "subjectGradeCodeToolStripLabel";
            this.subjectGradeCodeToolStripLabel.Size = new System.Drawing.Size(125, 22);
            this.subjectGradeCodeToolStripLabel.Text = "     Subject Gade Code:";
            // 
            // subjectGradeCodeToolStripComboBox
            // 
            this.subjectGradeCodeToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.subjectGradeCodeToolStripComboBox.Name = "subjectGradeCodeToolStripComboBox";
            this.subjectGradeCodeToolStripComboBox.Size = new System.Drawing.Size(100, 25);
            this.subjectGradeCodeToolStripComboBox.TextChanged += new System.EventHandler(this.OnSearchToolStripTextChanged);
            // 
            // searchToolStripButton
            // 
            this.searchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchToolStripButton.Name = "searchToolStripButton";
            this.searchToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.searchToolStripButton.Text = "Search";
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
            // gradeLevelTableAdapter
            // 
            this.gradeLevelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BillingReportTableAdapter = null;
            this.tableAdapterManager.GradeLevelTableAdapter = this.gradeLevelTableAdapter;
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
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = STUEnrollmentSystem.STU_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // gradeLevelBindingNavigator
            // 
            this.gradeLevelBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.gradeLevelBindingNavigator.BindingSource = this.gradeLevelBindingSource;
            this.gradeLevelBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.gradeLevelBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.gradeLevelBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.gradeLevelBindingNavigatorSaveItem,
            this.bindingNavigatorRefreshItem});
            this.gradeLevelBindingNavigator.Location = new System.Drawing.Point(301, 115);
            this.gradeLevelBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.gradeLevelBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.gradeLevelBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.gradeLevelBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.gradeLevelBindingNavigator.Name = "gradeLevelBindingNavigator";
            this.gradeLevelBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.gradeLevelBindingNavigator.Size = new System.Drawing.Size(963, 25);
            this.gradeLevelBindingNavigator.TabIndex = 24;
            this.gradeLevelBindingNavigator.Text = "bindingNavigator1";
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
            // gradeLevelBindingNavigatorSaveItem
            // 
            this.gradeLevelBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gradeLevelBindingNavigatorSaveItem.Image")));
            this.gradeLevelBindingNavigatorSaveItem.Name = "gradeLevelBindingNavigatorSaveItem";
            this.gradeLevelBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.gradeLevelBindingNavigatorSaveItem.Text = "Save Data";
            this.gradeLevelBindingNavigatorSaveItem.Click += new System.EventHandler(this.gradeLevelBindingNavigatorSaveItem_Click);
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
            // gradeLevelDataGridView
            // 
            this.gradeLevelDataGridView.AutoGenerateColumns = false;
            this.gradeLevelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradeLevelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.gradeLevelDataGridView.DataSource = this.gradeLevelBindingSource;
            this.gradeLevelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradeLevelDataGridView.Location = new System.Drawing.Point(301, 140);
            this.gradeLevelDataGridView.Name = "gradeLevelDataGridView";
            this.gradeLevelDataGridView.Size = new System.Drawing.Size(963, 619);
            this.gradeLevelDataGridView.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "GradeLevel";
            this.dataGridViewTextBoxColumn1.HeaderText = "GradeLevel";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "GradeCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "GradeCode";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SubjectGradeCode";
            this.dataGridViewTextBoxColumn3.HeaderText = "SubjectGradeCode";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // frmGradeLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 759);
            this.Controls.Add(this.gradeLevelDataGridView);
            this.Controls.Add(this.gradeLevelBindingNavigator);
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.showSearchButton);
            this.Controls.Add(this.searchPanel);
            this.Name = "frmGradeLevel";
            this.Text = "frmGradeLevel";
            this.Load += new System.EventHandler(this.frmGradeLevel_Load);
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeLevelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTU_DBDataSet)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.searchToolStrip.ResumeLayout(false);
            this.searchToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeLevelBindingNavigator)).EndInit();
            this.gradeLevelBindingNavigator.ResumeLayout(false);
            this.gradeLevelBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeLevelDataGridView)).EndInit();
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
        private System.Windows.Forms.BindingSource gradeLevelBindingSource;
        private STU_DBDataSetTableAdapters.GradeLevelTableAdapter gradeLevelTableAdapter;
        private STU_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator gradeLevelBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton gradeLevelBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorRefreshItem;
        private System.Windows.Forms.DataGridView gradeLevelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox gradeLevelTextBox;
        private System.Windows.Forms.TextBox gradeCodeTextBox;
        private System.Windows.Forms.TextBox subjectGradeCodeTextBox;
        private System.Windows.Forms.ToolStrip searchToolStrip;
        private System.Windows.Forms.ToolStripLabel gradeLevelToolStripLabel;
        private System.Windows.Forms.ToolStripLabel gradeCodeToolStripLabel;
        private System.Windows.Forms.ToolStripLabel subjectGradeCodeToolStripLabel;
        private System.Windows.Forms.ToolStripButton searchToolStripButton;
        private System.Windows.Forms.ToolStripComboBox gradeLevelToolStripComboBox;
        private System.Windows.Forms.ToolStripComboBox gradeCodeToolStripComboBox;
        private System.Windows.Forms.ToolStripComboBox subjectGradeCodeToolStripComboBox;
    }
}