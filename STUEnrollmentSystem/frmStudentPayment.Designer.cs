namespace STUEnrollmentSystem
{
    partial class frmStudentPayment
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
            System.Windows.Forms.Label paymentCodeLabel;
            System.Windows.Forms.Label paymentMethodLabel;
            System.Windows.Forms.Label studentNumberLabel;
            System.Windows.Forms.Label monthOfPaymentLabel;
            System.Windows.Forms.Label paymentStatusLabel1;
            System.Windows.Forms.Label paymentReceiptLabel;
            System.Windows.Forms.Label schoolYearLabel;
            System.Windows.Forms.Label paymentRNLabel;
            System.Windows.Forms.Label receiptRNLabel;
            System.Windows.Forms.Label transactionDateLabel;
            System.Windows.Forms.Label transactionNumberLabel;
            System.Windows.Forms.Label paidAmountLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentPayment));
            this.showSearchButton = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.schoolYearToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.paymentCodeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.paymentCodeToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.studentNumberToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.studentNumberToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.paymentRNToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.receiptRNToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.transactionNumberToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.paidAmountTextBox = new System.Windows.Forms.TextBox();
            this.studentPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTU_DBDataSet = new STUEnrollmentSystem.STU_DBDataSet();
            this.refreshButton = new System.Windows.Forms.Button();
            this.transactionNumberTextBox = new System.Windows.Forms.TextBox();
            this.monthOfPaymentTextBox = new System.Windows.Forms.TextBox();
            this.paymentCodeTextBox = new System.Windows.Forms.TextBox();
            this.addBillingReportButton = new System.Windows.Forms.Button();
            this.transactionDateTextBox = new System.Windows.Forms.TextBox();
            this.receiptRNTextBox = new System.Windows.Forms.TextBox();
            this.paymentRNTextBox = new System.Windows.Forms.TextBox();
            this.viewPaymentReceiptButton = new System.Windows.Forms.Button();
            this.notifyButton = new System.Windows.Forms.Button();
            this.schoolYearTextBox = new System.Windows.Forms.TextBox();
            this.paymentDueLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.remainingBalanceLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.paymentTypeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteProofOfPaymentButton = new System.Windows.Forms.Button();
            this.proofOfPaymentLabel = new System.Windows.Forms.Label();
            this.paymentMethodComboBox = new System.Windows.Forms.ComboBox();
            this.paymentStatusComboBox = new System.Windows.Forms.ComboBox();
            this.studentNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uploadProofOfPaymentButton = new System.Windows.Forms.Button();
            this.viewProofOfPaymentButton = new System.Windows.Forms.Button();
            this.proofOfPaymentTextBox = new System.Windows.Forms.TextBox();
            this.studentPaymentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.studentPaymentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorRefreshItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addReturningStudentToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.addReturningStudentToolStripStudentNumberComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.addReturningStudentToolStripPaymentTypeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.addReturningStudentToolStripPaymentMethodComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.addReturningStudentToolStripEnrollmentTypeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addReturningStudentToolStripInsertMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorNotifyAllButton = new System.Windows.Forms.ToolStripButton();
            this.studentPaymentDataGridView = new System.Windows.Forms.DataGridView();
            this.SchoolYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.PaidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentRN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptRN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotificationCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.studentPaymentTableAdapter = new STUEnrollmentSystem.STU_DBDataSetTableAdapters.StudentPaymentTableAdapter();
            this.tableAdapterManager = new STUEnrollmentSystem.STU_DBDataSetTableAdapters.TableAdapterManager();
            this.addReturningStudentToolStripPaidAmountTextBox = new System.Windows.Forms.ToolStripTextBox();
            paymentCodeLabel = new System.Windows.Forms.Label();
            paymentMethodLabel = new System.Windows.Forms.Label();
            studentNumberLabel = new System.Windows.Forms.Label();
            monthOfPaymentLabel = new System.Windows.Forms.Label();
            paymentStatusLabel1 = new System.Windows.Forms.Label();
            paymentReceiptLabel = new System.Windows.Forms.Label();
            schoolYearLabel = new System.Windows.Forms.Label();
            paymentRNLabel = new System.Windows.Forms.Label();
            receiptRNLabel = new System.Windows.Forms.Label();
            transactionDateLabel = new System.Windows.Forms.Label();
            transactionNumberLabel = new System.Windows.Forms.Label();
            paidAmountLabel = new System.Windows.Forms.Label();
            this.searchPanel.SuspendLayout();
            this.searchToolStrip.SuspendLayout();
            this.detailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentPaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTU_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentPaymentBindingNavigator)).BeginInit();
            this.studentPaymentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentPaymentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // paymentCodeLabel
            // 
            paymentCodeLabel.AutoSize = true;
            paymentCodeLabel.Location = new System.Drawing.Point(57, 118);
            paymentCodeLabel.Name = "paymentCodeLabel";
            paymentCodeLabel.Size = new System.Drawing.Size(79, 13);
            paymentCodeLabel.TabIndex = 49;
            paymentCodeLabel.Text = "Payment Code:";
            // 
            // paymentMethodLabel
            // 
            paymentMethodLabel.AutoSize = true;
            paymentMethodLabel.Location = new System.Drawing.Point(57, 144);
            paymentMethodLabel.Name = "paymentMethodLabel";
            paymentMethodLabel.Size = new System.Drawing.Size(90, 13);
            paymentMethodLabel.TabIndex = 51;
            paymentMethodLabel.Text = "Payment Method:";
            // 
            // studentNumberLabel
            // 
            studentNumberLabel.AutoSize = true;
            studentNumberLabel.Location = new System.Drawing.Point(57, 170);
            studentNumberLabel.Name = "studentNumberLabel";
            studentNumberLabel.Size = new System.Drawing.Size(87, 13);
            studentNumberLabel.TabIndex = 53;
            studentNumberLabel.Text = "Student Number:";
            // 
            // monthOfPaymentLabel
            // 
            monthOfPaymentLabel.AutoSize = true;
            monthOfPaymentLabel.Location = new System.Drawing.Point(57, 196);
            monthOfPaymentLabel.Name = "monthOfPaymentLabel";
            monthOfPaymentLabel.Size = new System.Drawing.Size(98, 13);
            monthOfPaymentLabel.TabIndex = 55;
            monthOfPaymentLabel.Text = "Month Of Payment:";
            // 
            // paymentStatusLabel1
            // 
            paymentStatusLabel1.AutoSize = true;
            paymentStatusLabel1.Location = new System.Drawing.Point(57, 222);
            paymentStatusLabel1.Name = "paymentStatusLabel1";
            paymentStatusLabel1.Size = new System.Drawing.Size(84, 13);
            paymentStatusLabel1.TabIndex = 58;
            paymentStatusLabel1.Text = "Payment Status:";
            // 
            // paymentReceiptLabel
            // 
            paymentReceiptLabel.AutoSize = true;
            paymentReceiptLabel.Location = new System.Drawing.Point(57, 278);
            paymentReceiptLabel.Name = "paymentReceiptLabel";
            paymentReceiptLabel.Size = new System.Drawing.Size(91, 13);
            paymentReceiptLabel.TabIndex = 63;
            paymentReceiptLabel.Text = "Payment Receipt:";
            // 
            // schoolYearLabel
            // 
            schoolYearLabel.AutoSize = true;
            schoolYearLabel.Location = new System.Drawing.Point(57, 92);
            schoolYearLabel.Name = "schoolYearLabel";
            schoolYearLabel.Size = new System.Drawing.Size(68, 13);
            schoolYearLabel.TabIndex = 87;
            schoolYearLabel.Text = "School Year:";
            // 
            // paymentRNLabel
            // 
            paymentRNLabel.AutoSize = true;
            paymentRNLabel.Location = new System.Drawing.Point(57, 335);
            paymentRNLabel.Name = "paymentRNLabel";
            paymentRNLabel.Size = new System.Drawing.Size(70, 13);
            paymentRNLabel.TabIndex = 90;
            paymentRNLabel.Text = "Payment RN:";
            // 
            // receiptRNLabel
            // 
            receiptRNLabel.AutoSize = true;
            receiptRNLabel.Location = new System.Drawing.Point(57, 362);
            receiptRNLabel.Name = "receiptRNLabel";
            receiptRNLabel.Size = new System.Drawing.Size(66, 13);
            receiptRNLabel.TabIndex = 91;
            receiptRNLabel.Text = "Receipt RN:";
            // 
            // transactionDateLabel
            // 
            transactionDateLabel.AutoSize = true;
            transactionDateLabel.Location = new System.Drawing.Point(56, 389);
            transactionDateLabel.Name = "transactionDateLabel";
            transactionDateLabel.Size = new System.Drawing.Size(92, 13);
            transactionDateLabel.TabIndex = 92;
            transactionDateLabel.Text = "Transaction Date:";
            // 
            // transactionNumberLabel
            // 
            transactionNumberLabel.AutoSize = true;
            transactionNumberLabel.Location = new System.Drawing.Point(57, 416);
            transactionNumberLabel.Name = "transactionNumberLabel";
            transactionNumberLabel.Size = new System.Drawing.Size(106, 13);
            transactionNumberLabel.TabIndex = 93;
            transactionNumberLabel.Text = "Transaction Number:";
            // 
            // paidAmountLabel
            // 
            paidAmountLabel.AutoSize = true;
            paidAmountLabel.Location = new System.Drawing.Point(58, 307);
            paidAmountLabel.Name = "paidAmountLabel";
            paidAmountLabel.Size = new System.Drawing.Size(70, 13);
            paidAmountLabel.TabIndex = 98;
            paidAmountLabel.Text = "Paid Amount:";
            // 
            // showSearchButton
            // 
            this.showSearchButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.showSearchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.showSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showSearchButton.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSearchButton.Location = new System.Drawing.Point(0, 105);
            this.showSearchButton.Name = "showSearchButton";
            this.showSearchButton.Size = new System.Drawing.Size(1264, 27);
            this.showSearchButton.TabIndex = 7;
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
            this.searchPanel.Size = new System.Drawing.Size(1264, 105);
            this.searchPanel.TabIndex = 6;
            // 
            // searchToolStrip
            // 
            this.searchToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.searchToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.searchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.schoolYearToolStripComboBox,
            this.paymentCodeToolStripLabel,
            this.paymentCodeToolStripComboBox,
            this.studentNumberToolStripLabel,
            this.studentNumberToolStripComboBox,
            this.toolStripLabel2,
            this.paymentRNToolStripTextBox,
            this.toolStripLabel3,
            this.receiptRNToolStripTextBox,
            this.toolStripLabel4,
            this.transactionNumberToolStripTextBox,
            this.searchToolStripButton});
            this.searchToolStrip.Location = new System.Drawing.Point(15, 46);
            this.searchToolStrip.Name = "searchToolStrip";
            this.searchToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.searchToolStrip.Size = new System.Drawing.Size(1241, 25);
            this.searchToolStrip.TabIndex = 16;
            this.searchToolStrip.Text = "searchToolStrip";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(71, 22);
            this.toolStripLabel1.Text = "School Year:";
            // 
            // schoolYearToolStripComboBox
            // 
            this.schoolYearToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.schoolYearToolStripComboBox.Name = "schoolYearToolStripComboBox";
            this.schoolYearToolStripComboBox.Size = new System.Drawing.Size(100, 25);
            this.schoolYearToolStripComboBox.TextChanged += new System.EventHandler(this.OnSearchToolStripTextChanged);
            // 
            // paymentCodeToolStripLabel
            // 
            this.paymentCodeToolStripLabel.BackColor = System.Drawing.Color.Transparent;
            this.paymentCodeToolStripLabel.Name = "paymentCodeToolStripLabel";
            this.paymentCodeToolStripLabel.Size = new System.Drawing.Size(103, 22);
            this.paymentCodeToolStripLabel.Text = "     Payment Code:";
            // 
            // paymentCodeToolStripComboBox
            // 
            this.paymentCodeToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.paymentCodeToolStripComboBox.Name = "paymentCodeToolStripComboBox";
            this.paymentCodeToolStripComboBox.Size = new System.Drawing.Size(100, 25);
            this.paymentCodeToolStripComboBox.TextChanged += new System.EventHandler(this.OnSearchToolStripTextChanged);
            // 
            // studentNumberToolStripLabel
            // 
            this.studentNumberToolStripLabel.BackColor = System.Drawing.Color.Transparent;
            this.studentNumberToolStripLabel.Name = "studentNumberToolStripLabel";
            this.studentNumberToolStripLabel.Size = new System.Drawing.Size(113, 22);
            this.studentNumberToolStripLabel.Text = "     Student Number:";
            // 
            // studentNumberToolStripComboBox
            // 
            this.studentNumberToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.studentNumberToolStripComboBox.Name = "studentNumberToolStripComboBox";
            this.studentNumberToolStripComboBox.Size = new System.Drawing.Size(100, 25);
            this.studentNumberToolStripComboBox.TextChanged += new System.EventHandler(this.OnSearchToolStripTextChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(88, 22);
            this.toolStripLabel2.Text = "     PaymentRN:";
            // 
            // paymentRNToolStripTextBox
            // 
            this.paymentRNToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paymentRNToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.paymentRNToolStripTextBox.Name = "paymentRNToolStripTextBox";
            this.paymentRNToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.paymentRNToolStripTextBox.TextChanged += new System.EventHandler(this.OnSearchToolStripTextChanged);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(77, 22);
            this.toolStripLabel3.Text = "    ReceiptRN:";
            // 
            // receiptRNToolStripTextBox
            // 
            this.receiptRNToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receiptRNToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.receiptRNToolStripTextBox.Name = "receiptRNToolStripTextBox";
            this.receiptRNToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.receiptRNToolStripTextBox.TextChanged += new System.EventHandler(this.OnSearchToolStripTextChanged);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(113, 22);
            this.toolStripLabel4.Text = "     TransactionNum:";
            // 
            // transactionNumberToolStripTextBox
            // 
            this.transactionNumberToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transactionNumberToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.transactionNumberToolStripTextBox.Name = "transactionNumberToolStripTextBox";
            this.transactionNumberToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.transactionNumberToolStripTextBox.TextChanged += new System.EventHandler(this.OnSearchToolStripTextChanged);
            // 
            // searchToolStripButton
            // 
            this.searchToolStripButton.BackColor = System.Drawing.Color.Transparent;
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
            // detailsPanel
            // 
            this.detailsPanel.AutoScroll = true;
            this.detailsPanel.Controls.Add(paidAmountLabel);
            this.detailsPanel.Controls.Add(this.paidAmountTextBox);
            this.detailsPanel.Controls.Add(this.refreshButton);
            this.detailsPanel.Controls.Add(this.transactionNumberTextBox);
            this.detailsPanel.Controls.Add(transactionNumberLabel);
            this.detailsPanel.Controls.Add(this.monthOfPaymentTextBox);
            this.detailsPanel.Controls.Add(this.paymentCodeTextBox);
            this.detailsPanel.Controls.Add(this.addBillingReportButton);
            this.detailsPanel.Controls.Add(transactionDateLabel);
            this.detailsPanel.Controls.Add(this.transactionDateTextBox);
            this.detailsPanel.Controls.Add(receiptRNLabel);
            this.detailsPanel.Controls.Add(this.receiptRNTextBox);
            this.detailsPanel.Controls.Add(paymentRNLabel);
            this.detailsPanel.Controls.Add(this.paymentRNTextBox);
            this.detailsPanel.Controls.Add(this.viewPaymentReceiptButton);
            this.detailsPanel.Controls.Add(this.notifyButton);
            this.detailsPanel.Controls.Add(schoolYearLabel);
            this.detailsPanel.Controls.Add(this.schoolYearTextBox);
            this.detailsPanel.Controls.Add(this.paymentDueLabel);
            this.detailsPanel.Controls.Add(this.label7);
            this.detailsPanel.Controls.Add(this.remainingBalanceLabel);
            this.detailsPanel.Controls.Add(this.label5);
            this.detailsPanel.Controls.Add(this.paymentTypeLabel);
            this.detailsPanel.Controls.Add(this.label4);
            this.detailsPanel.Controls.Add(this.label3);
            this.detailsPanel.Controls.Add(this.deleteProofOfPaymentButton);
            this.detailsPanel.Controls.Add(paymentReceiptLabel);
            this.detailsPanel.Controls.Add(this.proofOfPaymentLabel);
            this.detailsPanel.Controls.Add(this.paymentMethodComboBox);
            this.detailsPanel.Controls.Add(paymentStatusLabel1);
            this.detailsPanel.Controls.Add(this.paymentStatusComboBox);
            this.detailsPanel.Controls.Add(paymentCodeLabel);
            this.detailsPanel.Controls.Add(paymentMethodLabel);
            this.detailsPanel.Controls.Add(studentNumberLabel);
            this.detailsPanel.Controls.Add(this.studentNumberTextBox);
            this.detailsPanel.Controls.Add(monthOfPaymentLabel);
            this.detailsPanel.Controls.Add(this.label1);
            this.detailsPanel.Controls.Add(this.uploadProofOfPaymentButton);
            this.detailsPanel.Controls.Add(this.viewProofOfPaymentButton);
            this.detailsPanel.Controls.Add(this.proofOfPaymentTextBox);
            this.detailsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.detailsPanel.Location = new System.Drawing.Point(0, 132);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(359, 692);
            this.detailsPanel.TabIndex = 14;
            // 
            // paidAmountTextBox
            // 
            this.paidAmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paidAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentPaymentBindingSource, "PaidAmount", true));
            this.paidAmountTextBox.Location = new System.Drawing.Point(169, 304);
            this.paidAmountTextBox.Name = "paidAmountTextBox";
            this.paidAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.paidAmountTextBox.TabIndex = 99;
            this.paidAmountTextBox.TextChanged += new System.EventHandler(this.paidAmountTextBox_TextChanged);
            // 
            // studentPaymentBindingSource
            // 
            this.studentPaymentBindingSource.DataMember = "StudentPayment";
            this.studentPaymentBindingSource.DataSource = this.sTU_DBDataSet;
            // 
            // sTU_DBDataSet
            // 
            this.sTU_DBDataSet.DataSetName = "STU_DBDataSet";
            this.sTU_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.Control;
            this.refreshButton.BackgroundImage = global::STUEnrollmentSystem.Properties.Resources.pngwing_com_1_;
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshButton.FlatAppearance.BorderSize = 0;
            this.refreshButton.Location = new System.Drawing.Point(275, 357);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(21, 21);
            this.refreshButton.TabIndex = 98;
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Visible = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // transactionNumberTextBox
            // 
            this.transactionNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transactionNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentPaymentBindingSource, "TransactionNumber", true));
            this.transactionNumberTextBox.Location = new System.Drawing.Point(169, 412);
            this.transactionNumberTextBox.Name = "transactionNumberTextBox";
            this.transactionNumberTextBox.ReadOnly = true;
            this.transactionNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.transactionNumberTextBox.TabIndex = 94;
            // 
            // monthOfPaymentTextBox
            // 
            this.monthOfPaymentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthOfPaymentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentPaymentBindingSource, "MonthOfPayment", true));
            this.monthOfPaymentTextBox.Location = new System.Drawing.Point(169, 194);
            this.monthOfPaymentTextBox.Name = "monthOfPaymentTextBox";
            this.monthOfPaymentTextBox.ReadOnly = true;
            this.monthOfPaymentTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthOfPaymentTextBox.TabIndex = 97;
            // 
            // paymentCodeTextBox
            // 
            this.paymentCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paymentCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentPaymentBindingSource, "PaymentCode", true));
            this.paymentCodeTextBox.Location = new System.Drawing.Point(169, 116);
            this.paymentCodeTextBox.Name = "paymentCodeTextBox";
            this.paymentCodeTextBox.ReadOnly = true;
            this.paymentCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.paymentCodeTextBox.TabIndex = 96;
            // 
            // addBillingReportButton
            // 
            this.addBillingReportButton.Enabled = false;
            this.addBillingReportButton.Location = new System.Drawing.Point(124, 455);
            this.addBillingReportButton.Name = "addBillingReportButton";
            this.addBillingReportButton.Size = new System.Drawing.Size(104, 23);
            this.addBillingReportButton.TabIndex = 95;
            this.addBillingReportButton.Text = "Add Billing Report";
            this.addBillingReportButton.UseVisualStyleBackColor = true;
            this.addBillingReportButton.Click += new System.EventHandler(this.addBillingReportButton_Click);
            // 
            // transactionDateTextBox
            // 
            this.transactionDateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transactionDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentPaymentBindingSource, "TransactionDate", true));
            this.transactionDateTextBox.Location = new System.Drawing.Point(169, 386);
            this.transactionDateTextBox.Name = "transactionDateTextBox";
            this.transactionDateTextBox.ReadOnly = true;
            this.transactionDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.transactionDateTextBox.TabIndex = 93;
            // 
            // receiptRNTextBox
            // 
            this.receiptRNTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receiptRNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentPaymentBindingSource, "ReceiptRN", true));
            this.receiptRNTextBox.Location = new System.Drawing.Point(169, 358);
            this.receiptRNTextBox.Name = "receiptRNTextBox";
            this.receiptRNTextBox.ReadOnly = true;
            this.receiptRNTextBox.Size = new System.Drawing.Size(100, 20);
            this.receiptRNTextBox.TabIndex = 92;
            // 
            // paymentRNTextBox
            // 
            this.paymentRNTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paymentRNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentPaymentBindingSource, "PaymentRN", true));
            this.paymentRNTextBox.Location = new System.Drawing.Point(169, 332);
            this.paymentRNTextBox.Name = "paymentRNTextBox";
            this.paymentRNTextBox.Size = new System.Drawing.Size(100, 20);
            this.paymentRNTextBox.TabIndex = 91;
            // 
            // viewPaymentReceiptButton
            // 
            this.viewPaymentReceiptButton.Location = new System.Drawing.Point(169, 275);
            this.viewPaymentReceiptButton.Name = "viewPaymentReceiptButton";
            this.viewPaymentReceiptButton.Size = new System.Drawing.Size(100, 23);
            this.viewPaymentReceiptButton.TabIndex = 90;
            this.viewPaymentReceiptButton.Text = "View File";
            this.viewPaymentReceiptButton.UseVisualStyleBackColor = true;
            this.viewPaymentReceiptButton.Visible = false;
            this.viewPaymentReceiptButton.Click += new System.EventHandler(this.viewPaymentReceiptButton_Click);
            // 
            // notifyButton
            // 
            this.notifyButton.Location = new System.Drawing.Point(275, 593);
            this.notifyButton.Name = "notifyButton";
            this.notifyButton.Size = new System.Drawing.Size(58, 23);
            this.notifyButton.TabIndex = 89;
            this.notifyButton.Text = "Notify";
            this.notifyButton.UseVisualStyleBackColor = true;
            this.notifyButton.Visible = false;
            this.notifyButton.Click += new System.EventHandler(this.notifyButton_Click);
            // 
            // schoolYearTextBox
            // 
            this.schoolYearTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.schoolYearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentPaymentBindingSource, "SchoolYear", true));
            this.schoolYearTextBox.Location = new System.Drawing.Point(169, 89);
            this.schoolYearTextBox.Name = "schoolYearTextBox";
            this.schoolYearTextBox.ReadOnly = true;
            this.schoolYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.schoolYearTextBox.TabIndex = 88;
            // 
            // paymentDueLabel
            // 
            this.paymentDueLabel.AutoSize = true;
            this.paymentDueLabel.Location = new System.Drawing.Point(166, 598);
            this.paymentDueLabel.Name = "paymentDueLabel";
            this.paymentDueLabel.Size = new System.Drawing.Size(109, 13);
            this.paymentDueLabel.TabIndex = 87;
            this.paymentDueLabel.Text = "----------------------------------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 598);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 86;
            this.label7.Text = "Payment due:";
            // 
            // remainingBalanceLabel
            // 
            this.remainingBalanceLabel.AutoSize = true;
            this.remainingBalanceLabel.Location = new System.Drawing.Point(166, 570);
            this.remainingBalanceLabel.Name = "remainingBalanceLabel";
            this.remainingBalanceLabel.Size = new System.Drawing.Size(109, 13);
            this.remainingBalanceLabel.TabIndex = 85;
            this.remainingBalanceLabel.Text = "----------------------------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 569);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 84;
            this.label5.Text = "Remaining Balance:";
            // 
            // paymentTypeLabel
            // 
            this.paymentTypeLabel.AutoSize = true;
            this.paymentTypeLabel.Location = new System.Drawing.Point(166, 541);
            this.paymentTypeLabel.Name = "paymentTypeLabel";
            this.paymentTypeLabel.Size = new System.Drawing.Size(109, 13);
            this.paymentTypeLabel.TabIndex = 83;
            this.paymentTypeLabel.Text = "----------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 540);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 82;
            this.label4.Text = "Payment Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 81;
            this.label3.Text = "Balance";
            // 
            // deleteProofOfPaymentButton
            // 
            this.deleteProofOfPaymentButton.Location = new System.Drawing.Point(273, 247);
            this.deleteProofOfPaymentButton.Name = "deleteProofOfPaymentButton";
            this.deleteProofOfPaymentButton.Size = new System.Drawing.Size(33, 23);
            this.deleteProofOfPaymentButton.TabIndex = 78;
            this.deleteProofOfPaymentButton.Text = "Del";
            this.deleteProofOfPaymentButton.UseVisualStyleBackColor = true;
            this.deleteProofOfPaymentButton.Visible = false;
            this.deleteProofOfPaymentButton.Click += new System.EventHandler(this.deleteProofOfPaymentButton_Click);
            // 
            // proofOfPaymentLabel
            // 
            this.proofOfPaymentLabel.AutoSize = true;
            this.proofOfPaymentLabel.Location = new System.Drawing.Point(57, 251);
            this.proofOfPaymentLabel.Name = "proofOfPaymentLabel";
            this.proofOfPaymentLabel.Size = new System.Drawing.Size(93, 13);
            this.proofOfPaymentLabel.TabIndex = 62;
            this.proofOfPaymentLabel.Text = "Proof Of Payment:";
            // 
            // paymentMethodComboBox
            // 
            this.paymentMethodComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentPaymentBindingSource, "PaymentMethod", true));
            this.paymentMethodComboBox.FormattingEnabled = true;
            this.paymentMethodComboBox.Items.AddRange(new object[] {
            "CASH",
            "GCASH",
            "BANK TRANSFER"});
            this.paymentMethodComboBox.Location = new System.Drawing.Point(169, 142);
            this.paymentMethodComboBox.Name = "paymentMethodComboBox";
            this.paymentMethodComboBox.Size = new System.Drawing.Size(100, 21);
            this.paymentMethodComboBox.TabIndex = 61;
            this.paymentMethodComboBox.TextChanged += new System.EventHandler(this.paymentMethodComboBox_TextChanged);
            // 
            // paymentStatusComboBox
            // 
            this.paymentStatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentPaymentBindingSource, "PaymentStatus", true));
            this.paymentStatusComboBox.FormattingEnabled = true;
            this.paymentStatusComboBox.Items.AddRange(new object[] {
            "Paid",
            "Pending"});
            this.paymentStatusComboBox.Location = new System.Drawing.Point(169, 220);
            this.paymentStatusComboBox.Name = "paymentStatusComboBox";
            this.paymentStatusComboBox.Size = new System.Drawing.Size(100, 21);
            this.paymentStatusComboBox.TabIndex = 59;
            this.paymentStatusComboBox.TextChanged += new System.EventHandler(this.paymentStatusComboBox_TextChanged);
            // 
            // studentNumberTextBox
            // 
            this.studentNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentPaymentBindingSource, "StudentNumber", true));
            this.studentNumberTextBox.Location = new System.Drawing.Point(169, 168);
            this.studentNumberTextBox.Name = "studentNumberTextBox";
            this.studentNumberTextBox.ReadOnly = true;
            this.studentNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentNumberTextBox.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student\'s Payment Information";
            // 
            // uploadProofOfPaymentButton
            // 
            this.uploadProofOfPaymentButton.Location = new System.Drawing.Point(169, 247);
            this.uploadProofOfPaymentButton.Name = "uploadProofOfPaymentButton";
            this.uploadProofOfPaymentButton.Size = new System.Drawing.Size(100, 23);
            this.uploadProofOfPaymentButton.TabIndex = 79;
            this.uploadProofOfPaymentButton.Text = "Upload File";
            this.uploadProofOfPaymentButton.UseVisualStyleBackColor = true;
            this.uploadProofOfPaymentButton.Visible = false;
            this.uploadProofOfPaymentButton.Click += new System.EventHandler(this.uploadProofOfPaymentButton_Click);
            // 
            // viewProofOfPaymentButton
            // 
            this.viewProofOfPaymentButton.Location = new System.Drawing.Point(169, 247);
            this.viewProofOfPaymentButton.Name = "viewProofOfPaymentButton";
            this.viewProofOfPaymentButton.Size = new System.Drawing.Size(100, 23);
            this.viewProofOfPaymentButton.TabIndex = 80;
            this.viewProofOfPaymentButton.Text = "View File";
            this.viewProofOfPaymentButton.UseVisualStyleBackColor = true;
            this.viewProofOfPaymentButton.Visible = false;
            this.viewProofOfPaymentButton.Click += new System.EventHandler(this.viewProofOfPaymentButton_Click);
            // 
            // proofOfPaymentTextBox
            // 
            this.proofOfPaymentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentPaymentBindingSource, "ProofOfPayment", true));
            this.proofOfPaymentTextBox.Location = new System.Drawing.Point(169, 249);
            this.proofOfPaymentTextBox.Name = "proofOfPaymentTextBox";
            this.proofOfPaymentTextBox.Size = new System.Drawing.Size(100, 20);
            this.proofOfPaymentTextBox.TabIndex = 63;
            this.proofOfPaymentTextBox.Visible = false;
            // 
            // studentPaymentBindingNavigator
            // 
            this.studentPaymentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentPaymentBindingNavigator.BindingSource = this.studentPaymentBindingSource;
            this.studentPaymentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentPaymentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentPaymentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.studentPaymentBindingNavigatorSaveItem,
            this.bindingNavigatorRefreshItem,
            this.toolStripSeparator1,
            this.addReturningStudentToolStripDropDownButton,
            this.toolStripSeparator3,
            this.bindingNavigatorNotifyAllButton});
            this.studentPaymentBindingNavigator.Location = new System.Drawing.Point(359, 132);
            this.studentPaymentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentPaymentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentPaymentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentPaymentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentPaymentBindingNavigator.Name = "studentPaymentBindingNavigator";
            this.studentPaymentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentPaymentBindingNavigator.Size = new System.Drawing.Size(905, 25);
            this.studentPaymentBindingNavigator.TabIndex = 15;
            this.studentPaymentBindingNavigator.Text = "bindingNavigator1";
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
            // studentPaymentBindingNavigatorSaveItem
            // 
            this.studentPaymentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentPaymentBindingNavigatorSaveItem.Image")));
            this.studentPaymentBindingNavigatorSaveItem.Name = "studentPaymentBindingNavigatorSaveItem";
            this.studentPaymentBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.studentPaymentBindingNavigatorSaveItem.Text = "Save Data";
            this.studentPaymentBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentPaymentBindingNavigatorSaveItem_Click);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // addReturningStudentToolStripDropDownButton
            // 
            this.addReturningStudentToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addReturningStudentToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addReturningStudentToolStripStudentNumberComboBox,
            this.addReturningStudentToolStripPaymentTypeComboBox,
            this.addReturningStudentToolStripPaymentMethodComboBox,
            this.addReturningStudentToolStripEnrollmentTypeComboBox,
            this.addReturningStudentToolStripPaidAmountTextBox,
            this.toolStripSeparator2,
            this.addReturningStudentToolStripInsertMenuItem});
            this.addReturningStudentToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("addReturningStudentToolStripDropDownButton.Image")));
            this.addReturningStudentToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addReturningStudentToolStripDropDownButton.Name = "addReturningStudentToolStripDropDownButton";
            this.addReturningStudentToolStripDropDownButton.Size = new System.Drawing.Size(141, 22);
            this.addReturningStudentToolStripDropDownButton.Text = "Add Returning Student";
            this.addReturningStudentToolStripDropDownButton.Click += new System.EventHandler(this.addReturningStudentToolStripDropDownButton_Click);
            // 
            // addReturningStudentToolStripStudentNumberComboBox
            // 
            this.addReturningStudentToolStripStudentNumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addReturningStudentToolStripStudentNumberComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.addReturningStudentToolStripStudentNumberComboBox.Name = "addReturningStudentToolStripStudentNumberComboBox";
            this.addReturningStudentToolStripStudentNumberComboBox.Size = new System.Drawing.Size(121, 23);
            // 
            // addReturningStudentToolStripPaymentTypeComboBox
            // 
            this.addReturningStudentToolStripPaymentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addReturningStudentToolStripPaymentTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.addReturningStudentToolStripPaymentTypeComboBox.Items.AddRange(new object[] {
            "Monthly",
            "Full"});
            this.addReturningStudentToolStripPaymentTypeComboBox.Name = "addReturningStudentToolStripPaymentTypeComboBox";
            this.addReturningStudentToolStripPaymentTypeComboBox.Size = new System.Drawing.Size(121, 23);
            // 
            // addReturningStudentToolStripPaymentMethodComboBox
            // 
            this.addReturningStudentToolStripPaymentMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addReturningStudentToolStripPaymentMethodComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.addReturningStudentToolStripPaymentMethodComboBox.Items.AddRange(new object[] {
            "CASH",
            "GCASH",
            "BANK TRANSFER"});
            this.addReturningStudentToolStripPaymentMethodComboBox.Name = "addReturningStudentToolStripPaymentMethodComboBox";
            this.addReturningStudentToolStripPaymentMethodComboBox.Size = new System.Drawing.Size(121, 23);
            // 
            // addReturningStudentToolStripEnrollmentTypeComboBox
            // 
            this.addReturningStudentToolStripEnrollmentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addReturningStudentToolStripEnrollmentTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.addReturningStudentToolStripEnrollmentTypeComboBox.Items.AddRange(new object[] {
            "Grade 7",
            "Grade 8",
            "Grade 9",
            "Grade 10"});
            this.addReturningStudentToolStripEnrollmentTypeComboBox.Name = "addReturningStudentToolStripEnrollmentTypeComboBox";
            this.addReturningStudentToolStripEnrollmentTypeComboBox.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // addReturningStudentToolStripInsertMenuItem
            // 
            this.addReturningStudentToolStripInsertMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addReturningStudentToolStripInsertMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addReturningStudentToolStripInsertMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addReturningStudentToolStripInsertMenuItem.Name = "addReturningStudentToolStripInsertMenuItem";
            this.addReturningStudentToolStripInsertMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addReturningStudentToolStripInsertMenuItem.Size = new System.Drawing.Size(181, 22);
            this.addReturningStudentToolStripInsertMenuItem.Text = "Insert";
            this.addReturningStudentToolStripInsertMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.addReturningStudentToolStripInsertMenuItem.Click += new System.EventHandler(this.addReturningStudentToolStripInsertMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorNotifyAllButton
            // 
            this.bindingNavigatorNotifyAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorNotifyAllButton.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorNotifyAllButton.Image")));
            this.bindingNavigatorNotifyAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorNotifyAllButton.Name = "bindingNavigatorNotifyAllButton";
            this.bindingNavigatorNotifyAllButton.Size = new System.Drawing.Size(135, 22);
            this.bindingNavigatorNotifyAllButton.Text = "Notify All Payment Due";
            this.bindingNavigatorNotifyAllButton.Click += new System.EventHandler(this.bindingNavigatorNotifyAllButton_Click);
            // 
            // studentPaymentDataGridView
            // 
            this.studentPaymentDataGridView.AllowUserToAddRows = false;
            this.studentPaymentDataGridView.AllowUserToDeleteRows = false;
            this.studentPaymentDataGridView.AutoGenerateColumns = false;
            this.studentPaymentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.studentPaymentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentPaymentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SchoolYear,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewImageColumn1,
            this.PaidAmount,
            this.PaymentRN,
            this.ReceiptRN,
            this.TransactionDate,
            this.TransactionNumber,
            this.NotificationCount});
            this.studentPaymentDataGridView.DataSource = this.studentPaymentBindingSource;
            this.studentPaymentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentPaymentDataGridView.Location = new System.Drawing.Point(359, 157);
            this.studentPaymentDataGridView.Name = "studentPaymentDataGridView";
            this.studentPaymentDataGridView.ReadOnly = true;
            this.studentPaymentDataGridView.Size = new System.Drawing.Size(905, 667);
            this.studentPaymentDataGridView.TabIndex = 15;
            this.studentPaymentDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentPaymentDataGridView_CellClick);
            // 
            // SchoolYear
            // 
            this.SchoolYear.DataPropertyName = "SchoolYear";
            this.SchoolYear.HeaderText = "SchoolYear";
            this.SchoolYear.Name = "SchoolYear";
            this.SchoolYear.ReadOnly = true;
            this.SchoolYear.Width = 87;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PaymentCode";
            this.dataGridViewTextBoxColumn1.HeaderText = "PaymentCode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 98;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PaymentMethod";
            this.dataGridViewTextBoxColumn2.HeaderText = "PaymentMethod";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 109;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StudentNumber";
            this.dataGridViewTextBoxColumn3.HeaderText = "StudentNumber";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 106;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MonthOfPayment";
            this.dataGridViewTextBoxColumn4.HeaderText = "MonthOfPayment";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 114;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PaymentStatus";
            this.dataGridViewTextBoxColumn5.HeaderText = "PaymentStatus";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 103;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "ProofOfPayment";
            this.dataGridViewImageColumn1.HeaderText = "ProofOfPayment";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 90;
            // 
            // PaidAmount
            // 
            this.PaidAmount.DataPropertyName = "PaidAmount";
            this.PaidAmount.HeaderText = "PaidAmount";
            this.PaidAmount.Name = "PaidAmount";
            this.PaidAmount.ReadOnly = true;
            this.PaidAmount.Width = 89;
            // 
            // PaymentRN
            // 
            this.PaymentRN.DataPropertyName = "PaymentRN";
            this.PaymentRN.HeaderText = "PaymentRN";
            this.PaymentRN.Name = "PaymentRN";
            this.PaymentRN.ReadOnly = true;
            this.PaymentRN.Width = 89;
            // 
            // ReceiptRN
            // 
            this.ReceiptRN.DataPropertyName = "ReceiptRN";
            this.ReceiptRN.HeaderText = "ReceiptRN";
            this.ReceiptRN.Name = "ReceiptRN";
            this.ReceiptRN.ReadOnly = true;
            this.ReceiptRN.Width = 85;
            // 
            // TransactionDate
            // 
            this.TransactionDate.DataPropertyName = "TransactionDate";
            this.TransactionDate.HeaderText = "TransactionDate";
            this.TransactionDate.Name = "TransactionDate";
            this.TransactionDate.ReadOnly = true;
            this.TransactionDate.Width = 111;
            // 
            // TransactionNumber
            // 
            this.TransactionNumber.DataPropertyName = "TransactionNumber";
            this.TransactionNumber.HeaderText = "TransactionNumber";
            this.TransactionNumber.Name = "TransactionNumber";
            this.TransactionNumber.ReadOnly = true;
            this.TransactionNumber.Width = 125;
            // 
            // NotificationCount
            // 
            this.NotificationCount.DataPropertyName = "NotificationCount";
            this.NotificationCount.HeaderText = "NotificationCount";
            this.NotificationCount.Name = "NotificationCount";
            this.NotificationCount.ReadOnly = true;
            this.NotificationCount.Width = 113;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // studentPaymentTableAdapter
            // 
            this.studentPaymentTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.StudentPaymentTableAdapter = this.studentPaymentTableAdapter;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.SubjectsTableAdapter = null;
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = STUEnrollmentSystem.STU_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // addReturningStudentToolStripPaidAmountTextBox
            // 
            this.addReturningStudentToolStripPaidAmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addReturningStudentToolStripPaidAmountTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addReturningStudentToolStripPaidAmountTextBox.Name = "addReturningStudentToolStripPaidAmountTextBox";
            this.addReturningStudentToolStripPaidAmountTextBox.Size = new System.Drawing.Size(100, 23);
            this.addReturningStudentToolStripPaidAmountTextBox.TextChanged += new System.EventHandler(this.addReturningStudentToolStripPaidAmountTextBox_TextChanged);
            // 
            // frmStudentPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 824);
            this.Controls.Add(this.studentPaymentDataGridView);
            this.Controls.Add(this.studentPaymentBindingNavigator);
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.showSearchButton);
            this.Controls.Add(this.searchPanel);
            this.Name = "frmStudentPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentPayment";
            this.Load += new System.EventHandler(this.StudentPayment_Load);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.searchToolStrip.ResumeLayout(false);
            this.searchToolStrip.PerformLayout();
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentPaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTU_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentPaymentBindingNavigator)).EndInit();
            this.studentPaymentBindingNavigator.ResumeLayout(false);
            this.studentPaymentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentPaymentDataGridView)).EndInit();
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
        private System.Windows.Forms.BindingSource studentPaymentBindingSource;
        private STU_DBDataSetTableAdapters.StudentPaymentTableAdapter studentPaymentTableAdapter;
        private STU_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studentPaymentBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton studentPaymentBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView studentPaymentDataGridView;
        private System.Windows.Forms.TextBox studentNumberTextBox;
        private System.Windows.Forms.ComboBox paymentStatusComboBox;
        private System.Windows.Forms.ComboBox paymentMethodComboBox;
        private System.Windows.Forms.TextBox proofOfPaymentTextBox;
        private System.Windows.Forms.Button deleteProofOfPaymentButton;
        private System.Windows.Forms.Button uploadProofOfPaymentButton;
        private System.Windows.Forms.Button viewProofOfPaymentButton;
        private System.Windows.Forms.ToolStripButton bindingNavigatorRefreshItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label proofOfPaymentLabel;
        private System.Windows.Forms.ToolStrip searchToolStrip;
        private System.Windows.Forms.ToolStripLabel paymentCodeToolStripLabel;
        private System.Windows.Forms.ToolStripLabel studentNumberToolStripLabel;
        private System.Windows.Forms.ToolStripButton searchToolStripButton;
        private System.Windows.Forms.ToolStripComboBox studentNumberToolStripComboBox;
        private System.Windows.Forms.ToolStripComboBox paymentCodeToolStripComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label paymentTypeLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label remainingBalanceLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label paymentDueLabel;
        private System.Windows.Forms.TextBox schoolYearTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox schoolYearToolStripComboBox;
        private System.Windows.Forms.Button notifyButton;
        private System.Windows.Forms.Button viewPaymentReceiptButton;
        private System.Windows.Forms.TextBox transactionNumberTextBox;
        private System.Windows.Forms.TextBox transactionDateTextBox;
        private System.Windows.Forms.TextBox receiptRNTextBox;
        private System.Windows.Forms.TextBox paymentRNTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox paymentRNToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox receiptRNToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox transactionNumberToolStripTextBox;
        private System.Windows.Forms.Button addBillingReportButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton addReturningStudentToolStripDropDownButton;
        private System.Windows.Forms.ToolStripComboBox addReturningStudentToolStripStudentNumberComboBox;
        private System.Windows.Forms.ToolStripComboBox addReturningStudentToolStripPaymentTypeComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem addReturningStudentToolStripInsertMenuItem;
        private System.Windows.Forms.ToolStripComboBox addReturningStudentToolStripEnrollmentTypeComboBox;
        private System.Windows.Forms.ToolStripComboBox addReturningStudentToolStripPaymentMethodComboBox;
        private System.Windows.Forms.TextBox paymentCodeTextBox;
        private System.Windows.Forms.TextBox monthOfPaymentTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorNotifyAllButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox paidAmountTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchoolYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentRN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptRN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotificationCount;
        private System.Windows.Forms.ToolStripTextBox addReturningStudentToolStripPaidAmountTextBox;
    }
}