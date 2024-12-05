namespace STUEnrollmentSystem
{
    partial class frmPrices
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
            System.Windows.Forms.Label priceCodeLabel;
            System.Windows.Forms.Label gradeCodeLabel;
            System.Windows.Forms.Label tuitionFeeLabel;
            System.Windows.Forms.Label booksLabel;
            System.Windows.Forms.Label laboratoryFeeLabel;
            System.Windows.Forms.Label uniformLabel;
            System.Windows.Forms.Label miscellanaousFeeLabel;
            System.Windows.Forms.Label totalAmountLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrices));
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.priceCodeTextBox = new System.Windows.Forms.TextBox();
            this.pricesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTU_DBDataSet = new STUEnrollmentSystem.STU_DBDataSet();
            this.gradeCodeTextBox = new System.Windows.Forms.TextBox();
            this.tuitionFeeTextBox = new System.Windows.Forms.TextBox();
            this.booksTextBox = new System.Windows.Forms.TextBox();
            this.laboratoryFeeTextBox = new System.Windows.Forms.TextBox();
            this.uniformTextBox = new System.Windows.Forms.TextBox();
            this.miscellanaousFeeTextBox = new System.Windows.Forms.TextBox();
            this.totalAmountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showSearchButton = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchToolStrip = new System.Windows.Forms.ToolStrip();
            this.priceCodeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.priceCodeToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.gradeCodeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.gradeCodeToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.searchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pricesTableAdapter = new STUEnrollmentSystem.STU_DBDataSetTableAdapters.PricesTableAdapter();
            this.tableAdapterManager = new STUEnrollmentSystem.STU_DBDataSetTableAdapters.TableAdapterManager();
            this.pricesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pricesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorRefreshItem = new System.Windows.Forms.ToolStripButton();
            this.pricesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            priceCodeLabel = new System.Windows.Forms.Label();
            gradeCodeLabel = new System.Windows.Forms.Label();
            tuitionFeeLabel = new System.Windows.Forms.Label();
            booksLabel = new System.Windows.Forms.Label();
            laboratoryFeeLabel = new System.Windows.Forms.Label();
            uniformLabel = new System.Windows.Forms.Label();
            miscellanaousFeeLabel = new System.Windows.Forms.Label();
            totalAmountLabel = new System.Windows.Forms.Label();
            this.detailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pricesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTU_DBDataSet)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.searchToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pricesBindingNavigator)).BeginInit();
            this.pricesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pricesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // priceCodeLabel
            // 
            priceCodeLabel.AutoSize = true;
            priceCodeLabel.Location = new System.Drawing.Point(54, 93);
            priceCodeLabel.Name = "priceCodeLabel";
            priceCodeLabel.Size = new System.Drawing.Size(62, 13);
            priceCodeLabel.TabIndex = 1;
            priceCodeLabel.Text = "Price Code:";
            // 
            // gradeCodeLabel
            // 
            gradeCodeLabel.AutoSize = true;
            gradeCodeLabel.Location = new System.Drawing.Point(54, 119);
            gradeCodeLabel.Name = "gradeCodeLabel";
            gradeCodeLabel.Size = new System.Drawing.Size(67, 13);
            gradeCodeLabel.TabIndex = 3;
            gradeCodeLabel.Text = "Grade Code:";
            // 
            // tuitionFeeLabel
            // 
            tuitionFeeLabel.AutoSize = true;
            tuitionFeeLabel.Location = new System.Drawing.Point(54, 145);
            tuitionFeeLabel.Name = "tuitionFeeLabel";
            tuitionFeeLabel.Size = new System.Drawing.Size(63, 13);
            tuitionFeeLabel.TabIndex = 5;
            tuitionFeeLabel.Text = "Tuition Fee:";
            // 
            // booksLabel
            // 
            booksLabel.AutoSize = true;
            booksLabel.Location = new System.Drawing.Point(54, 171);
            booksLabel.Name = "booksLabel";
            booksLabel.Size = new System.Drawing.Size(40, 13);
            booksLabel.TabIndex = 7;
            booksLabel.Text = "Books:";
            // 
            // laboratoryFeeLabel
            // 
            laboratoryFeeLabel.AutoSize = true;
            laboratoryFeeLabel.Location = new System.Drawing.Point(54, 197);
            laboratoryFeeLabel.Name = "laboratoryFeeLabel";
            laboratoryFeeLabel.Size = new System.Drawing.Size(81, 13);
            laboratoryFeeLabel.TabIndex = 9;
            laboratoryFeeLabel.Text = "Laboratory Fee:";
            // 
            // uniformLabel
            // 
            uniformLabel.AutoSize = true;
            uniformLabel.Location = new System.Drawing.Point(54, 223);
            uniformLabel.Name = "uniformLabel";
            uniformLabel.Size = new System.Drawing.Size(46, 13);
            uniformLabel.TabIndex = 11;
            uniformLabel.Text = "Uniform:";
            // 
            // miscellanaousFeeLabel
            // 
            miscellanaousFeeLabel.AutoSize = true;
            miscellanaousFeeLabel.Location = new System.Drawing.Point(54, 249);
            miscellanaousFeeLabel.Name = "miscellanaousFeeLabel";
            miscellanaousFeeLabel.Size = new System.Drawing.Size(98, 13);
            miscellanaousFeeLabel.TabIndex = 13;
            miscellanaousFeeLabel.Text = "Miscellanaous Fee:";
            // 
            // totalAmountLabel
            // 
            totalAmountLabel.AutoSize = true;
            totalAmountLabel.Location = new System.Drawing.Point(54, 278);
            totalAmountLabel.Name = "totalAmountLabel";
            totalAmountLabel.Size = new System.Drawing.Size(73, 13);
            totalAmountLabel.TabIndex = 15;
            totalAmountLabel.Text = "Total Amount:";
            // 
            // detailsPanel
            // 
            this.detailsPanel.AutoScroll = true;
            this.detailsPanel.Controls.Add(priceCodeLabel);
            this.detailsPanel.Controls.Add(this.priceCodeTextBox);
            this.detailsPanel.Controls.Add(gradeCodeLabel);
            this.detailsPanel.Controls.Add(this.gradeCodeTextBox);
            this.detailsPanel.Controls.Add(tuitionFeeLabel);
            this.detailsPanel.Controls.Add(this.tuitionFeeTextBox);
            this.detailsPanel.Controls.Add(booksLabel);
            this.detailsPanel.Controls.Add(this.booksTextBox);
            this.detailsPanel.Controls.Add(laboratoryFeeLabel);
            this.detailsPanel.Controls.Add(this.laboratoryFeeTextBox);
            this.detailsPanel.Controls.Add(uniformLabel);
            this.detailsPanel.Controls.Add(this.uniformTextBox);
            this.detailsPanel.Controls.Add(miscellanaousFeeLabel);
            this.detailsPanel.Controls.Add(this.miscellanaousFeeTextBox);
            this.detailsPanel.Controls.Add(totalAmountLabel);
            this.detailsPanel.Controls.Add(this.totalAmountTextBox);
            this.detailsPanel.Controls.Add(this.label1);
            this.detailsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.detailsPanel.Location = new System.Drawing.Point(0, 115);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(322, 644);
            this.detailsPanel.TabIndex = 17;
            // 
            // priceCodeTextBox
            // 
            this.priceCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pricesBindingSource, "PriceCode", true));
            this.priceCodeTextBox.Location = new System.Drawing.Point(158, 90);
            this.priceCodeTextBox.Name = "priceCodeTextBox";
            this.priceCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceCodeTextBox.TabIndex = 2;
            // 
            // pricesBindingSource
            // 
            this.pricesBindingSource.DataMember = "Prices";
            this.pricesBindingSource.DataSource = this.sTU_DBDataSet;
            // 
            // sTU_DBDataSet
            // 
            this.sTU_DBDataSet.DataSetName = "STU_DBDataSet";
            this.sTU_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gradeCodeTextBox
            // 
            this.gradeCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pricesBindingSource, "GradeCode", true));
            this.gradeCodeTextBox.Location = new System.Drawing.Point(158, 116);
            this.gradeCodeTextBox.Name = "gradeCodeTextBox";
            this.gradeCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.gradeCodeTextBox.TabIndex = 4;
            // 
            // tuitionFeeTextBox
            // 
            this.tuitionFeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pricesBindingSource, "TuitionFee", true));
            this.tuitionFeeTextBox.Location = new System.Drawing.Point(158, 142);
            this.tuitionFeeTextBox.Name = "tuitionFeeTextBox";
            this.tuitionFeeTextBox.Size = new System.Drawing.Size(100, 20);
            this.tuitionFeeTextBox.TabIndex = 6;
            this.tuitionFeeTextBox.TextChanged += new System.EventHandler(this.pricesFeeTextBox_TextChanged);
            // 
            // booksTextBox
            // 
            this.booksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pricesBindingSource, "Books", true));
            this.booksTextBox.Location = new System.Drawing.Point(158, 168);
            this.booksTextBox.Name = "booksTextBox";
            this.booksTextBox.Size = new System.Drawing.Size(100, 20);
            this.booksTextBox.TabIndex = 8;
            this.booksTextBox.TextChanged += new System.EventHandler(this.pricesFeeTextBox_TextChanged);
            // 
            // laboratoryFeeTextBox
            // 
            this.laboratoryFeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pricesBindingSource, "LaboratoryFee", true));
            this.laboratoryFeeTextBox.Location = new System.Drawing.Point(158, 194);
            this.laboratoryFeeTextBox.Name = "laboratoryFeeTextBox";
            this.laboratoryFeeTextBox.Size = new System.Drawing.Size(100, 20);
            this.laboratoryFeeTextBox.TabIndex = 10;
            this.laboratoryFeeTextBox.TextChanged += new System.EventHandler(this.pricesFeeTextBox_TextChanged);
            // 
            // uniformTextBox
            // 
            this.uniformTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pricesBindingSource, "Uniform", true));
            this.uniformTextBox.Location = new System.Drawing.Point(158, 220);
            this.uniformTextBox.Name = "uniformTextBox";
            this.uniformTextBox.Size = new System.Drawing.Size(100, 20);
            this.uniformTextBox.TabIndex = 12;
            this.uniformTextBox.TextChanged += new System.EventHandler(this.pricesFeeTextBox_TextChanged);
            // 
            // miscellanaousFeeTextBox
            // 
            this.miscellanaousFeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pricesBindingSource, "MiscellanaousFee", true));
            this.miscellanaousFeeTextBox.Location = new System.Drawing.Point(158, 246);
            this.miscellanaousFeeTextBox.Name = "miscellanaousFeeTextBox";
            this.miscellanaousFeeTextBox.Size = new System.Drawing.Size(100, 20);
            this.miscellanaousFeeTextBox.TabIndex = 14;
            this.miscellanaousFeeTextBox.TextChanged += new System.EventHandler(this.pricesFeeTextBox_TextChanged);
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pricesBindingSource, "TotalAmount", true));
            this.totalAmountTextBox.Location = new System.Drawing.Point(158, 274);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.ReadOnly = true;
            this.totalAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalAmountTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fee\'s Information";
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
            this.showSearchButton.TabIndex = 16;
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
            this.searchPanel.TabIndex = 15;
            // 
            // searchToolStrip
            // 
            this.searchToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.searchToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.searchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.priceCodeToolStripLabel,
            this.priceCodeToolStripComboBox,
            this.gradeCodeToolStripLabel,
            this.gradeCodeToolStripComboBox,
            this.searchToolStripButton});
            this.searchToolStrip.Location = new System.Drawing.Point(106, 37);
            this.searchToolStrip.Name = "searchToolStrip";
            this.searchToolStrip.Size = new System.Drawing.Size(422, 25);
            this.searchToolStrip.TabIndex = 19;
            this.searchToolStrip.Text = "searchToolStrip";
            // 
            // priceCodeToolStripLabel
            // 
            this.priceCodeToolStripLabel.Name = "priceCodeToolStripLabel";
            this.priceCodeToolStripLabel.Size = new System.Drawing.Size(67, 22);
            this.priceCodeToolStripLabel.Text = "Price Code:";
            // 
            // priceCodeToolStripComboBox
            // 
            this.priceCodeToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.priceCodeToolStripComboBox.Name = "priceCodeToolStripComboBox";
            this.priceCodeToolStripComboBox.Size = new System.Drawing.Size(100, 25);
            this.priceCodeToolStripComboBox.TextChanged += new System.EventHandler(this.OnSearchToolStripTextChanged);
            // 
            // gradeCodeToolStripLabel
            // 
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
            // pricesTableAdapter
            // 
            this.pricesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BillingReportTableAdapter = null;
            this.tableAdapterManager.GradeLevelTableAdapter = null;
            this.tableAdapterManager.LogsTableAdapter = null;
            this.tableAdapterManager.PaymentTypeTableAdapter = null;
            this.tableAdapterManager.PendingStudentsTableAdapter = null;
            this.tableAdapterManager.PricesTableAdapter = this.pricesTableAdapter;
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
            // pricesBindingNavigator
            // 
            this.pricesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pricesBindingNavigator.BindingSource = this.pricesBindingSource;
            this.pricesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pricesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pricesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pricesBindingNavigatorSaveItem,
            this.bindingNavigatorRefreshItem});
            this.pricesBindingNavigator.Location = new System.Drawing.Point(322, 115);
            this.pricesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pricesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pricesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pricesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pricesBindingNavigator.Name = "pricesBindingNavigator";
            this.pricesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pricesBindingNavigator.Size = new System.Drawing.Size(942, 25);
            this.pricesBindingNavigator.TabIndex = 18;
            this.pricesBindingNavigator.Text = "bindingNavigator1";
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
            // pricesBindingNavigatorSaveItem
            // 
            this.pricesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pricesBindingNavigatorSaveItem.Image")));
            this.pricesBindingNavigatorSaveItem.Name = "pricesBindingNavigatorSaveItem";
            this.pricesBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.pricesBindingNavigatorSaveItem.Text = "Save Data";
            this.pricesBindingNavigatorSaveItem.Click += new System.EventHandler(this.pricesBindingNavigatorSaveItem_Click);
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
            // pricesDataGridView
            // 
            this.pricesDataGridView.AutoGenerateColumns = false;
            this.pricesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pricesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pricesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.pricesDataGridView.DataSource = this.pricesBindingSource;
            this.pricesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pricesDataGridView.Location = new System.Drawing.Point(322, 140);
            this.pricesDataGridView.Name = "pricesDataGridView";
            this.pricesDataGridView.ReadOnly = true;
            this.pricesDataGridView.Size = new System.Drawing.Size(942, 619);
            this.pricesDataGridView.TabIndex = 18;
            this.pricesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pricesDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PriceCode";
            this.dataGridViewTextBoxColumn1.HeaderText = "PriceCode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "GradeCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "GradeCode";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TuitionFee";
            this.dataGridViewTextBoxColumn3.HeaderText = "TuitionFee";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Books";
            this.dataGridViewTextBoxColumn4.HeaderText = "Books";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LaboratoryFee";
            this.dataGridViewTextBoxColumn5.HeaderText = "LaboratoryFee";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Uniform";
            this.dataGridViewTextBoxColumn6.HeaderText = "Uniform";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MiscellanaousFee";
            this.dataGridViewTextBoxColumn7.HeaderText = "MiscellanaousFee";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TotalAmount";
            this.dataGridViewTextBoxColumn8.HeaderText = "TotalAmount";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // frmPrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 759);
            this.Controls.Add(this.pricesDataGridView);
            this.Controls.Add(this.pricesBindingNavigator);
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.showSearchButton);
            this.Controls.Add(this.searchPanel);
            this.Name = "frmPrices";
            this.Text = "frmPrices";
            this.Load += new System.EventHandler(this.frmPrices_Load);
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pricesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTU_DBDataSet)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.searchToolStrip.ResumeLayout(false);
            this.searchToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pricesBindingNavigator)).EndInit();
            this.pricesBindingNavigator.ResumeLayout(false);
            this.pricesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pricesDataGridView)).EndInit();
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
        private System.Windows.Forms.BindingSource pricesBindingSource;
        private STU_DBDataSetTableAdapters.PricesTableAdapter pricesTableAdapter;
        private STU_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pricesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pricesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pricesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox priceCodeTextBox;
        private System.Windows.Forms.TextBox gradeCodeTextBox;
        private System.Windows.Forms.TextBox tuitionFeeTextBox;
        private System.Windows.Forms.TextBox booksTextBox;
        private System.Windows.Forms.TextBox laboratoryFeeTextBox;
        private System.Windows.Forms.TextBox uniformTextBox;
        private System.Windows.Forms.TextBox miscellanaousFeeTextBox;
        private System.Windows.Forms.TextBox totalAmountTextBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorRefreshItem;
        private System.Windows.Forms.ToolStrip searchToolStrip;
        private System.Windows.Forms.ToolStripLabel priceCodeToolStripLabel;
        private System.Windows.Forms.ToolStripLabel gradeCodeToolStripLabel;
        private System.Windows.Forms.ToolStripButton searchToolStripButton;
        private System.Windows.Forms.ToolStripComboBox priceCodeToolStripComboBox;
        private System.Windows.Forms.ToolStripComboBox gradeCodeToolStripComboBox;
    }
}