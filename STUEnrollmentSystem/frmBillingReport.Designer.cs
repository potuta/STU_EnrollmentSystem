namespace STUEnrollmentSystem
{
    partial class frmBillingReport
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
            System.Windows.Forms.Label transactionNumberLabel;
            System.Windows.Forms.Label studentNumberLabel;
            System.Windows.Forms.Label paymentAmountLabel;
            System.Windows.Forms.Label transactionDateLabel;
            System.Windows.Forms.Label paymentRNLabel;
            System.Windows.Forms.Label receiptRNLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillingReport));
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.transactionNumberTextBox = new System.Windows.Forms.TextBox();
            this.billingReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTU_DBDataSet = new STUEnrollmentSystem.STU_DBDataSet();
            this.studentNumberTextBox = new System.Windows.Forms.TextBox();
            this.paymentAmountTextBox = new System.Windows.Forms.TextBox();
            this.transactionDateTextBox = new System.Windows.Forms.TextBox();
            this.paymentRNTextBox = new System.Windows.Forms.TextBox();
            this.receiptRNTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showSearchButton = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchToolStrip = new System.Windows.Forms.ToolStrip();
            this.paymentRNToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.paymentRNToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.receiptRNToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.receiptRNToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.billingReportTableAdapter = new STUEnrollmentSystem.STU_DBDataSetTableAdapters.BillingReportTableAdapter();
            this.tableAdapterManager = new STUEnrollmentSystem.STU_DBDataSetTableAdapters.TableAdapterManager();
            this.billingReportBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.billingReportBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorRefreshItem = new System.Windows.Forms.ToolStripButton();
            this.billingReportDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            transactionNumberLabel = new System.Windows.Forms.Label();
            studentNumberLabel = new System.Windows.Forms.Label();
            paymentAmountLabel = new System.Windows.Forms.Label();
            transactionDateLabel = new System.Windows.Forms.Label();
            paymentRNLabel = new System.Windows.Forms.Label();
            receiptRNLabel = new System.Windows.Forms.Label();
            this.detailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billingReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTU_DBDataSet)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.searchToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billingReportBindingNavigator)).BeginInit();
            this.billingReportBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billingReportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionNumberLabel
            // 
            transactionNumberLabel.AutoSize = true;
            transactionNumberLabel.Location = new System.Drawing.Point(45, 95);
            transactionNumberLabel.Name = "transactionNumberLabel";
            transactionNumberLabel.Size = new System.Drawing.Size(106, 13);
            transactionNumberLabel.TabIndex = 1;
            transactionNumberLabel.Text = "Transaction Number:";
            // 
            // studentNumberLabel
            // 
            studentNumberLabel.AutoSize = true;
            studentNumberLabel.Location = new System.Drawing.Point(45, 121);
            studentNumberLabel.Name = "studentNumberLabel";
            studentNumberLabel.Size = new System.Drawing.Size(87, 13);
            studentNumberLabel.TabIndex = 3;
            studentNumberLabel.Text = "Student Number:";
            // 
            // paymentAmountLabel
            // 
            paymentAmountLabel.AutoSize = true;
            paymentAmountLabel.Location = new System.Drawing.Point(45, 147);
            paymentAmountLabel.Name = "paymentAmountLabel";
            paymentAmountLabel.Size = new System.Drawing.Size(90, 13);
            paymentAmountLabel.TabIndex = 5;
            paymentAmountLabel.Text = "Payment Amount:";
            // 
            // transactionDateLabel
            // 
            transactionDateLabel.AutoSize = true;
            transactionDateLabel.Location = new System.Drawing.Point(45, 173);
            transactionDateLabel.Name = "transactionDateLabel";
            transactionDateLabel.Size = new System.Drawing.Size(92, 13);
            transactionDateLabel.TabIndex = 7;
            transactionDateLabel.Text = "Transaction Date:";
            // 
            // paymentRNLabel
            // 
            paymentRNLabel.AutoSize = true;
            paymentRNLabel.Location = new System.Drawing.Point(45, 199);
            paymentRNLabel.Name = "paymentRNLabel";
            paymentRNLabel.Size = new System.Drawing.Size(70, 13);
            paymentRNLabel.TabIndex = 9;
            paymentRNLabel.Text = "Payment RN:";
            // 
            // receiptRNLabel
            // 
            receiptRNLabel.AutoSize = true;
            receiptRNLabel.Location = new System.Drawing.Point(45, 225);
            receiptRNLabel.Name = "receiptRNLabel";
            receiptRNLabel.Size = new System.Drawing.Size(66, 13);
            receiptRNLabel.TabIndex = 11;
            receiptRNLabel.Text = "Receipt RN:";
            // 
            // detailsPanel
            // 
            this.detailsPanel.AutoScroll = true;
            this.detailsPanel.Controls.Add(transactionNumberLabel);
            this.detailsPanel.Controls.Add(this.transactionNumberTextBox);
            this.detailsPanel.Controls.Add(studentNumberLabel);
            this.detailsPanel.Controls.Add(this.studentNumberTextBox);
            this.detailsPanel.Controls.Add(paymentAmountLabel);
            this.detailsPanel.Controls.Add(this.paymentAmountTextBox);
            this.detailsPanel.Controls.Add(transactionDateLabel);
            this.detailsPanel.Controls.Add(this.transactionDateTextBox);
            this.detailsPanel.Controls.Add(paymentRNLabel);
            this.detailsPanel.Controls.Add(this.paymentRNTextBox);
            this.detailsPanel.Controls.Add(receiptRNLabel);
            this.detailsPanel.Controls.Add(this.receiptRNTextBox);
            this.detailsPanel.Controls.Add(this.label1);
            this.detailsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.detailsPanel.Location = new System.Drawing.Point(0, 115);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(301, 644);
            this.detailsPanel.TabIndex = 20;
            // 
            // transactionNumberTextBox
            // 
            this.transactionNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transactionNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billingReportBindingSource, "TransactionNumber", true));
            this.transactionNumberTextBox.Location = new System.Drawing.Point(157, 92);
            this.transactionNumberTextBox.Name = "transactionNumberTextBox";
            this.transactionNumberTextBox.ReadOnly = true;
            this.transactionNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.transactionNumberTextBox.TabIndex = 2;
            // 
            // billingReportBindingSource
            // 
            this.billingReportBindingSource.DataMember = "BillingReport";
            this.billingReportBindingSource.DataSource = this.sTU_DBDataSet;
            // 
            // sTU_DBDataSet
            // 
            this.sTU_DBDataSet.DataSetName = "STU_DBDataSet";
            this.sTU_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentNumberTextBox
            // 
            this.studentNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billingReportBindingSource, "StudentNumber", true));
            this.studentNumberTextBox.Location = new System.Drawing.Point(157, 118);
            this.studentNumberTextBox.Name = "studentNumberTextBox";
            this.studentNumberTextBox.ReadOnly = true;
            this.studentNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentNumberTextBox.TabIndex = 4;
            // 
            // paymentAmountTextBox
            // 
            this.paymentAmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paymentAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billingReportBindingSource, "PaymentAmount", true));
            this.paymentAmountTextBox.Location = new System.Drawing.Point(157, 144);
            this.paymentAmountTextBox.Name = "paymentAmountTextBox";
            this.paymentAmountTextBox.ReadOnly = true;
            this.paymentAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.paymentAmountTextBox.TabIndex = 6;
            // 
            // transactionDateTextBox
            // 
            this.transactionDateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transactionDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billingReportBindingSource, "TransactionDate", true));
            this.transactionDateTextBox.Location = new System.Drawing.Point(157, 170);
            this.transactionDateTextBox.Name = "transactionDateTextBox";
            this.transactionDateTextBox.ReadOnly = true;
            this.transactionDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.transactionDateTextBox.TabIndex = 8;
            // 
            // paymentRNTextBox
            // 
            this.paymentRNTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paymentRNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billingReportBindingSource, "PaymentRN", true));
            this.paymentRNTextBox.Location = new System.Drawing.Point(157, 196);
            this.paymentRNTextBox.Name = "paymentRNTextBox";
            this.paymentRNTextBox.ReadOnly = true;
            this.paymentRNTextBox.Size = new System.Drawing.Size(100, 20);
            this.paymentRNTextBox.TabIndex = 10;
            // 
            // receiptRNTextBox
            // 
            this.receiptRNTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receiptRNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billingReportBindingSource, "ReceiptRN", true));
            this.receiptRNTextBox.Location = new System.Drawing.Point(157, 222);
            this.receiptRNTextBox.Name = "receiptRNTextBox";
            this.receiptRNTextBox.ReadOnly = true;
            this.receiptRNTextBox.Size = new System.Drawing.Size(100, 20);
            this.receiptRNTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Billing Report Information";
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
            this.showSearchButton.TabIndex = 19;
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
            this.searchPanel.TabIndex = 18;
            // 
            // searchToolStrip
            // 
            this.searchToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.searchToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.searchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paymentRNToolStripLabel,
            this.paymentRNToolStripTextBox,
            this.receiptRNToolStripLabel,
            this.receiptRNToolStripTextBox,
            this.searchToolStripButton});
            this.searchToolStrip.Location = new System.Drawing.Point(71, 40);
            this.searchToolStrip.Name = "searchToolStrip";
            this.searchToolStrip.Size = new System.Drawing.Size(421, 25);
            this.searchToolStrip.TabIndex = 22;
            this.searchToolStrip.Text = "searchToolStrip";
            // 
            // paymentRNToolStripLabel
            // 
            this.paymentRNToolStripLabel.Name = "paymentRNToolStripLabel";
            this.paymentRNToolStripLabel.Size = new System.Drawing.Size(73, 22);
            this.paymentRNToolStripLabel.Text = "PaymentRN:";
            // 
            // paymentRNToolStripTextBox
            // 
            this.paymentRNToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paymentRNToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.paymentRNToolStripTextBox.Name = "paymentRNToolStripTextBox";
            this.paymentRNToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.paymentRNToolStripTextBox.TextChanged += new System.EventHandler(this.OnSearchToolStripTextChanged);
            // 
            // receiptRNToolStripLabel
            // 
            this.receiptRNToolStripLabel.Name = "receiptRNToolStripLabel";
            this.receiptRNToolStripLabel.Size = new System.Drawing.Size(80, 22);
            this.receiptRNToolStripLabel.Text = "     ReceiptRN:";
            // 
            // receiptRNToolStripTextBox
            // 
            this.receiptRNToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receiptRNToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.receiptRNToolStripTextBox.Name = "receiptRNToolStripTextBox";
            this.receiptRNToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.receiptRNToolStripTextBox.TextChanged += new System.EventHandler(this.OnSearchToolStripTextChanged);
            // 
            // searchToolStripButton
            // 
            this.searchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchToolStripButton.Name = "searchToolStripButton";
            this.searchToolStripButton.Size = new System.Drawing.Size(61, 22);
            this.searchToolStripButton.Text = "     Search";
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
            // billingReportTableAdapter
            // 
            this.billingReportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BillingReportTableAdapter = this.billingReportTableAdapter;
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
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = STUEnrollmentSystem.STU_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // billingReportBindingNavigator
            // 
            this.billingReportBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.billingReportBindingNavigator.BindingSource = this.billingReportBindingSource;
            this.billingReportBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.billingReportBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.billingReportBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.billingReportBindingNavigatorSaveItem,
            this.bindingNavigatorRefreshItem});
            this.billingReportBindingNavigator.Location = new System.Drawing.Point(301, 115);
            this.billingReportBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.billingReportBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.billingReportBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.billingReportBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.billingReportBindingNavigator.Name = "billingReportBindingNavigator";
            this.billingReportBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.billingReportBindingNavigator.Size = new System.Drawing.Size(963, 25);
            this.billingReportBindingNavigator.TabIndex = 21;
            this.billingReportBindingNavigator.Text = "bindingNavigator1";
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
            // billingReportBindingNavigatorSaveItem
            // 
            this.billingReportBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.billingReportBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("billingReportBindingNavigatorSaveItem.Image")));
            this.billingReportBindingNavigatorSaveItem.Name = "billingReportBindingNavigatorSaveItem";
            this.billingReportBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.billingReportBindingNavigatorSaveItem.Text = "Save Data";
            this.billingReportBindingNavigatorSaveItem.Click += new System.EventHandler(this.billingReportBindingNavigatorSaveItem_Click);
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
            // billingReportDataGridView
            // 
            this.billingReportDataGridView.AutoGenerateColumns = false;
            this.billingReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billingReportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.billingReportDataGridView.DataSource = this.billingReportBindingSource;
            this.billingReportDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billingReportDataGridView.Location = new System.Drawing.Point(301, 140);
            this.billingReportDataGridView.Name = "billingReportDataGridView";
            this.billingReportDataGridView.Size = new System.Drawing.Size(963, 619);
            this.billingReportDataGridView.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TransactionNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "TransactionNumber";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StudentNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "StudentNumber";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PaymentAmount";
            this.dataGridViewTextBoxColumn3.HeaderText = "PaymentAmount";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TransactionDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "TransactionDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PaymentRN";
            this.dataGridViewTextBoxColumn5.HeaderText = "PaymentRN";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ReceiptRN";
            this.dataGridViewTextBoxColumn6.HeaderText = "ReceiptRN";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // frmBillingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 759);
            this.Controls.Add(this.billingReportDataGridView);
            this.Controls.Add(this.billingReportBindingNavigator);
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.showSearchButton);
            this.Controls.Add(this.searchPanel);
            this.Name = "frmBillingReport";
            this.Text = "frmBillingReport";
            this.Load += new System.EventHandler(this.frmBillingReport_Load);
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billingReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTU_DBDataSet)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.searchToolStrip.ResumeLayout(false);
            this.searchToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billingReportBindingNavigator)).EndInit();
            this.billingReportBindingNavigator.ResumeLayout(false);
            this.billingReportBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billingReportDataGridView)).EndInit();
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
        private System.Windows.Forms.BindingSource billingReportBindingSource;
        private STU_DBDataSetTableAdapters.BillingReportTableAdapter billingReportTableAdapter;
        private STU_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator billingReportBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton billingReportBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorRefreshItem;
        private System.Windows.Forms.DataGridView billingReportDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox transactionNumberTextBox;
        private System.Windows.Forms.TextBox studentNumberTextBox;
        private System.Windows.Forms.TextBox paymentAmountTextBox;
        private System.Windows.Forms.TextBox transactionDateTextBox;
        private System.Windows.Forms.TextBox paymentRNTextBox;
        private System.Windows.Forms.TextBox receiptRNTextBox;
        private System.Windows.Forms.ToolStrip searchToolStrip;
        private System.Windows.Forms.ToolStripLabel paymentRNToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox paymentRNToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel receiptRNToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox receiptRNToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchToolStripButton;
    }
}