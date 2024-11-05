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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentPayment));
            this.showSearchButton = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchToolStrip = new System.Windows.Forms.ToolStrip();
            this.paymentCodeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.paymentCodeToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.studentNumberToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.studentNumberToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.monthOfPaymentToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.monthOfPaymentToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.deleteProofOfPaymentButton = new System.Windows.Forms.Button();
            this.paymentReceiptTextBox = new System.Windows.Forms.TextBox();
            this.studentPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTU_DBDataSet = new STUEnrollmentSystem.STU_DBDataSet();
            this.proofOfPaymentLabel = new System.Windows.Forms.Label();
            this.paymentCodeComboBox = new System.Windows.Forms.ComboBox();
            this.paymentMethodComboBox = new System.Windows.Forms.ComboBox();
            this.monthOfPaymentComboBox = new System.Windows.Forms.ComboBox();
            this.paymentStatusComboBox = new System.Windows.Forms.ComboBox();
            this.studentNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.viewProofOfPaymentButton = new System.Windows.Forms.Button();
            this.proofOfPaymentTextBox = new System.Windows.Forms.TextBox();
            this.uploadProofOfPaymentButton = new System.Windows.Forms.Button();
            this.studentPaymentTableAdapter = new STUEnrollmentSystem.STU_DBDataSetTableAdapters.StudentPaymentTableAdapter();
            this.tableAdapterManager = new STUEnrollmentSystem.STU_DBDataSetTableAdapters.TableAdapterManager();
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
            this.studentPaymentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.paymentTypeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.remainingBalanceLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.paymentDueLabel = new System.Windows.Forms.Label();
            paymentCodeLabel = new System.Windows.Forms.Label();
            paymentMethodLabel = new System.Windows.Forms.Label();
            studentNumberLabel = new System.Windows.Forms.Label();
            monthOfPaymentLabel = new System.Windows.Forms.Label();
            paymentStatusLabel1 = new System.Windows.Forms.Label();
            paymentReceiptLabel = new System.Windows.Forms.Label();
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
            paymentCodeLabel.Location = new System.Drawing.Point(61, 84);
            paymentCodeLabel.Name = "paymentCodeLabel";
            paymentCodeLabel.Size = new System.Drawing.Size(79, 13);
            paymentCodeLabel.TabIndex = 49;
            paymentCodeLabel.Text = "Payment Code:";
            // 
            // paymentMethodLabel
            // 
            paymentMethodLabel.AutoSize = true;
            paymentMethodLabel.Location = new System.Drawing.Point(61, 110);
            paymentMethodLabel.Name = "paymentMethodLabel";
            paymentMethodLabel.Size = new System.Drawing.Size(90, 13);
            paymentMethodLabel.TabIndex = 51;
            paymentMethodLabel.Text = "Payment Method:";
            // 
            // studentNumberLabel
            // 
            studentNumberLabel.AutoSize = true;
            studentNumberLabel.Location = new System.Drawing.Point(61, 136);
            studentNumberLabel.Name = "studentNumberLabel";
            studentNumberLabel.Size = new System.Drawing.Size(87, 13);
            studentNumberLabel.TabIndex = 53;
            studentNumberLabel.Text = "Student Number:";
            // 
            // monthOfPaymentLabel
            // 
            monthOfPaymentLabel.AutoSize = true;
            monthOfPaymentLabel.Location = new System.Drawing.Point(61, 162);
            monthOfPaymentLabel.Name = "monthOfPaymentLabel";
            monthOfPaymentLabel.Size = new System.Drawing.Size(98, 13);
            monthOfPaymentLabel.TabIndex = 55;
            monthOfPaymentLabel.Text = "Month Of Payment:";
            // 
            // paymentStatusLabel1
            // 
            paymentStatusLabel1.AutoSize = true;
            paymentStatusLabel1.Location = new System.Drawing.Point(61, 188);
            paymentStatusLabel1.Name = "paymentStatusLabel1";
            paymentStatusLabel1.Size = new System.Drawing.Size(84, 13);
            paymentStatusLabel1.TabIndex = 58;
            paymentStatusLabel1.Text = "Payment Status:";
            // 
            // paymentReceiptLabel
            // 
            paymentReceiptLabel.AutoSize = true;
            paymentReceiptLabel.Location = new System.Drawing.Point(61, 215);
            paymentReceiptLabel.Name = "paymentReceiptLabel";
            paymentReceiptLabel.Size = new System.Drawing.Size(91, 13);
            paymentReceiptLabel.TabIndex = 63;
            paymentReceiptLabel.Text = "Payment Receipt:";
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
            this.searchPanel.Size = new System.Drawing.Size(1264, 117);
            this.searchPanel.TabIndex = 6;
            // 
            // searchToolStrip
            // 
            this.searchToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.searchToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.searchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paymentCodeToolStripLabel,
            this.paymentCodeToolStripComboBox,
            this.studentNumberToolStripLabel,
            this.studentNumberToolStripComboBox,
            this.monthOfPaymentToolStripLabel,
            this.monthOfPaymentToolStripTextBox,
            this.searchToolStripButton});
            this.searchToolStrip.Location = new System.Drawing.Point(52, 50);
            this.searchToolStrip.Name = "searchToolStrip";
            this.searchToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.searchToolStrip.Size = new System.Drawing.Size(743, 25);
            this.searchToolStrip.TabIndex = 16;
            this.searchToolStrip.Text = "searchToolStrip";
            // 
            // paymentCodeToolStripLabel
            // 
            this.paymentCodeToolStripLabel.BackColor = System.Drawing.Color.Transparent;
            this.paymentCodeToolStripLabel.Name = "paymentCodeToolStripLabel";
            this.paymentCodeToolStripLabel.Size = new System.Drawing.Size(88, 22);
            this.paymentCodeToolStripLabel.Text = "Payment Code:";
            // 
            // paymentCodeToolStripComboBox
            // 
            this.paymentCodeToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.paymentCodeToolStripComboBox.Name = "paymentCodeToolStripComboBox";
            this.paymentCodeToolStripComboBox.Size = new System.Drawing.Size(100, 25);
            this.paymentCodeToolStripComboBox.TextChanged += new System.EventHandler(this.paymentCodeToolStripComboBox_TextChanged);
            // 
            // studentNumberToolStripLabel
            // 
            this.studentNumberToolStripLabel.BackColor = System.Drawing.Color.Transparent;
            this.studentNumberToolStripLabel.Name = "studentNumberToolStripLabel";
            this.studentNumberToolStripLabel.Size = new System.Drawing.Size(128, 22);
            this.studentNumberToolStripLabel.Text = "          Student Number:";
            // 
            // studentNumberToolStripComboBox
            // 
            this.studentNumberToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.studentNumberToolStripComboBox.Name = "studentNumberToolStripComboBox";
            this.studentNumberToolStripComboBox.Size = new System.Drawing.Size(100, 25);
            this.studentNumberToolStripComboBox.TextChanged += new System.EventHandler(this.studentNumberToolStripComboBox_TextChanged);
            // 
            // monthOfPaymentToolStripLabel
            // 
            this.monthOfPaymentToolStripLabel.BackColor = System.Drawing.Color.Transparent;
            this.monthOfPaymentToolStripLabel.Name = "monthOfPaymentToolStripLabel";
            this.monthOfPaymentToolStripLabel.Size = new System.Drawing.Size(142, 22);
            this.monthOfPaymentToolStripLabel.Text = "          Month Of Payment:";
            // 
            // monthOfPaymentToolStripTextBox
            // 
            this.monthOfPaymentToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthOfPaymentToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monthOfPaymentToolStripTextBox.Name = "monthOfPaymentToolStripTextBox";
            this.monthOfPaymentToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.monthOfPaymentToolStripTextBox.TextChanged += new System.EventHandler(this.monthOfPaymentToolStripTextBox_TextChanged);
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
            this.detailsPanel.Controls.Add(this.paymentDueLabel);
            this.detailsPanel.Controls.Add(this.label7);
            this.detailsPanel.Controls.Add(this.remainingBalanceLabel);
            this.detailsPanel.Controls.Add(this.label5);
            this.detailsPanel.Controls.Add(this.paymentTypeLabel);
            this.detailsPanel.Controls.Add(this.label4);
            this.detailsPanel.Controls.Add(this.label3);
            this.detailsPanel.Controls.Add(this.deleteProofOfPaymentButton);
            this.detailsPanel.Controls.Add(paymentReceiptLabel);
            this.detailsPanel.Controls.Add(this.paymentReceiptTextBox);
            this.detailsPanel.Controls.Add(this.proofOfPaymentLabel);
            this.detailsPanel.Controls.Add(this.paymentCodeComboBox);
            this.detailsPanel.Controls.Add(this.paymentMethodComboBox);
            this.detailsPanel.Controls.Add(this.monthOfPaymentComboBox);
            this.detailsPanel.Controls.Add(paymentStatusLabel1);
            this.detailsPanel.Controls.Add(this.paymentStatusComboBox);
            this.detailsPanel.Controls.Add(paymentCodeLabel);
            this.detailsPanel.Controls.Add(paymentMethodLabel);
            this.detailsPanel.Controls.Add(studentNumberLabel);
            this.detailsPanel.Controls.Add(this.studentNumberTextBox);
            this.detailsPanel.Controls.Add(monthOfPaymentLabel);
            this.detailsPanel.Controls.Add(this.label1);
            this.detailsPanel.Controls.Add(this.viewProofOfPaymentButton);
            this.detailsPanel.Controls.Add(this.proofOfPaymentTextBox);
            this.detailsPanel.Controls.Add(this.uploadProofOfPaymentButton);
            this.detailsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.detailsPanel.Location = new System.Drawing.Point(0, 144);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(361, 615);
            this.detailsPanel.TabIndex = 14;
            // 
            // deleteProofOfPaymentButton
            // 
            this.deleteProofOfPaymentButton.Location = new System.Drawing.Point(277, 239);
            this.deleteProofOfPaymentButton.Name = "deleteProofOfPaymentButton";
            this.deleteProofOfPaymentButton.Size = new System.Drawing.Size(33, 23);
            this.deleteProofOfPaymentButton.TabIndex = 78;
            this.deleteProofOfPaymentButton.Text = "Del";
            this.deleteProofOfPaymentButton.UseVisualStyleBackColor = true;
            this.deleteProofOfPaymentButton.Visible = false;
            this.deleteProofOfPaymentButton.Click += new System.EventHandler(this.deleteProofOfPaymentButton_Click);
            // 
            // paymentReceiptTextBox
            // 
            this.paymentReceiptTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentPaymentBindingSource, "PaymentReceipt", true));
            this.paymentReceiptTextBox.Location = new System.Drawing.Point(173, 213);
            this.paymentReceiptTextBox.Name = "paymentReceiptTextBox";
            this.paymentReceiptTextBox.Size = new System.Drawing.Size(100, 20);
            this.paymentReceiptTextBox.TabIndex = 64;
            this.paymentReceiptTextBox.Visible = false;
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
            // proofOfPaymentLabel
            // 
            this.proofOfPaymentLabel.AutoSize = true;
            this.proofOfPaymentLabel.Location = new System.Drawing.Point(61, 243);
            this.proofOfPaymentLabel.Name = "proofOfPaymentLabel";
            this.proofOfPaymentLabel.Size = new System.Drawing.Size(93, 13);
            this.proofOfPaymentLabel.TabIndex = 62;
            this.proofOfPaymentLabel.Text = "Proof Of Payment:";
            // 
            // paymentCodeComboBox
            // 
            this.paymentCodeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentPaymentBindingSource, "PaymentCode", true));
            this.paymentCodeComboBox.FormattingEnabled = true;
            this.paymentCodeComboBox.Items.AddRange(new object[] {
            "MG7",
            "FG7"});
            this.paymentCodeComboBox.Location = new System.Drawing.Point(173, 81);
            this.paymentCodeComboBox.Name = "paymentCodeComboBox";
            this.paymentCodeComboBox.Size = new System.Drawing.Size(100, 21);
            this.paymentCodeComboBox.TabIndex = 62;
            // 
            // paymentMethodComboBox
            // 
            this.paymentMethodComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentPaymentBindingSource, "PaymentMethod", true));
            this.paymentMethodComboBox.FormattingEnabled = true;
            this.paymentMethodComboBox.Items.AddRange(new object[] {
            "CASH",
            "GCASH",
            "BANK TRANSFER"});
            this.paymentMethodComboBox.Location = new System.Drawing.Point(173, 108);
            this.paymentMethodComboBox.Name = "paymentMethodComboBox";
            this.paymentMethodComboBox.Size = new System.Drawing.Size(100, 21);
            this.paymentMethodComboBox.TabIndex = 61;
            this.paymentMethodComboBox.TextChanged += new System.EventHandler(this.paymentMethodComboBox_TextChanged);
            // 
            // monthOfPaymentComboBox
            // 
            this.monthOfPaymentComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentPaymentBindingSource, "MonthOfPayment", true));
            this.monthOfPaymentComboBox.FormattingEnabled = true;
            this.monthOfPaymentComboBox.Items.AddRange(new object[] {
            "August",
            "September",
            "October",
            "November",
            "December",
            "January",
            "February",
            "March",
            "April",
            "May"});
            this.monthOfPaymentComboBox.Location = new System.Drawing.Point(173, 159);
            this.monthOfPaymentComboBox.Name = "monthOfPaymentComboBox";
            this.monthOfPaymentComboBox.Size = new System.Drawing.Size(100, 21);
            this.monthOfPaymentComboBox.TabIndex = 60;
            // 
            // paymentStatusComboBox
            // 
            this.paymentStatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentPaymentBindingSource, "PaymentStatus", true));
            this.paymentStatusComboBox.FormattingEnabled = true;
            this.paymentStatusComboBox.Items.AddRange(new object[] {
            "Paid",
            "Pending"});
            this.paymentStatusComboBox.Location = new System.Drawing.Point(173, 186);
            this.paymentStatusComboBox.Name = "paymentStatusComboBox";
            this.paymentStatusComboBox.Size = new System.Drawing.Size(100, 21);
            this.paymentStatusComboBox.TabIndex = 59;
            // 
            // studentNumberTextBox
            // 
            this.studentNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentPaymentBindingSource, "StudentNumber", true));
            this.studentNumberTextBox.Location = new System.Drawing.Point(173, 134);
            this.studentNumberTextBox.Name = "studentNumberTextBox";
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
            this.label1.Text = "Student Payment\'s Information";
            // 
            // viewProofOfPaymentButton
            // 
            this.viewProofOfPaymentButton.Location = new System.Drawing.Point(173, 239);
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
            this.proofOfPaymentTextBox.Location = new System.Drawing.Point(173, 241);
            this.proofOfPaymentTextBox.Name = "proofOfPaymentTextBox";
            this.proofOfPaymentTextBox.Size = new System.Drawing.Size(100, 20);
            this.proofOfPaymentTextBox.TabIndex = 63;
            this.proofOfPaymentTextBox.Visible = false;
            // 
            // uploadProofOfPaymentButton
            // 
            this.uploadProofOfPaymentButton.Location = new System.Drawing.Point(173, 239);
            this.uploadProofOfPaymentButton.Name = "uploadProofOfPaymentButton";
            this.uploadProofOfPaymentButton.Size = new System.Drawing.Size(100, 23);
            this.uploadProofOfPaymentButton.TabIndex = 79;
            this.uploadProofOfPaymentButton.Text = "Upload File";
            this.uploadProofOfPaymentButton.UseVisualStyleBackColor = true;
            this.uploadProofOfPaymentButton.Visible = false;
            this.uploadProofOfPaymentButton.Click += new System.EventHandler(this.uploadProofOfPaymentButton_Click);
            // 
            // studentPaymentTableAdapter
            // 
            this.studentPaymentTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.SectionsTableAdapter = null;
            this.tableAdapterManager.StudentPaymentTableAdapter = this.studentPaymentTableAdapter;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.SubjectsTableAdapter = null;
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = STUEnrollmentSystem.STU_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
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
            this.bindingNavigatorRefreshItem});
            this.studentPaymentBindingNavigator.Location = new System.Drawing.Point(361, 144);
            this.studentPaymentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentPaymentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentPaymentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentPaymentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentPaymentBindingNavigator.Name = "studentPaymentBindingNavigator";
            this.studentPaymentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentPaymentBindingNavigator.Size = new System.Drawing.Size(903, 25);
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
            this.studentPaymentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentPaymentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentPaymentBindingNavigatorSaveItem.Image")));
            this.studentPaymentBindingNavigatorSaveItem.Name = "studentPaymentBindingNavigatorSaveItem";
            this.studentPaymentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.studentPaymentBindingNavigatorSaveItem.Text = "Save Data";
            this.studentPaymentBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentPaymentBindingNavigatorSaveItem_Click);
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
            // studentPaymentDataGridView
            // 
            this.studentPaymentDataGridView.AutoGenerateColumns = false;
            this.studentPaymentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentPaymentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentPaymentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewImageColumn1,
            this.dataGridViewImageColumn2});
            this.studentPaymentDataGridView.DataSource = this.studentPaymentBindingSource;
            this.studentPaymentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentPaymentDataGridView.Location = new System.Drawing.Point(361, 169);
            this.studentPaymentDataGridView.Name = "studentPaymentDataGridView";
            this.studentPaymentDataGridView.Size = new System.Drawing.Size(903, 590);
            this.studentPaymentDataGridView.TabIndex = 15;
            this.studentPaymentDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentPaymentDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PaymentCode";
            this.dataGridViewTextBoxColumn1.HeaderText = "PaymentCode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PaymentMethod";
            this.dataGridViewTextBoxColumn2.HeaderText = "PaymentMethod";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StudentNumber";
            this.dataGridViewTextBoxColumn3.HeaderText = "StudentNumber";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MonthOfPayment";
            this.dataGridViewTextBoxColumn4.HeaderText = "MonthOfPayment";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PaymentStatus";
            this.dataGridViewTextBoxColumn5.HeaderText = "PaymentStatus";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "ProofOfPayment";
            this.dataGridViewImageColumn1.HeaderText = "ProofOfPayment";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "PaymentReceipt";
            this.dataGridViewImageColumn2.HeaderText = "PaymentReceipt";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 81;
            this.label3.Text = "Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 82;
            this.label4.Text = "Payment Type:";
            // 
            // paymentTypeLabel
            // 
            this.paymentTypeLabel.AutoSize = true;
            this.paymentTypeLabel.Location = new System.Drawing.Point(170, 317);
            this.paymentTypeLabel.Name = "paymentTypeLabel";
            this.paymentTypeLabel.Size = new System.Drawing.Size(109, 13);
            this.paymentTypeLabel.TabIndex = 83;
            this.paymentTypeLabel.Text = "----------------------------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 84;
            this.label5.Text = "Remaining Balance:";
            // 
            // remainingBalanceLabel
            // 
            this.remainingBalanceLabel.AutoSize = true;
            this.remainingBalanceLabel.Location = new System.Drawing.Point(170, 346);
            this.remainingBalanceLabel.Name = "remainingBalanceLabel";
            this.remainingBalanceLabel.Size = new System.Drawing.Size(109, 13);
            this.remainingBalanceLabel.TabIndex = 85;
            this.remainingBalanceLabel.Text = "----------------------------------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 86;
            this.label7.Text = "Payment due:";
            // 
            // paymentDueLabel
            // 
            this.paymentDueLabel.AutoSize = true;
            this.paymentDueLabel.Location = new System.Drawing.Point(170, 374);
            this.paymentDueLabel.Name = "paymentDueLabel";
            this.paymentDueLabel.Size = new System.Drawing.Size(109, 13);
            this.paymentDueLabel.TabIndex = 87;
            this.paymentDueLabel.Text = "----------------------------------";
            // 
            // frmStudentPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 759);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewImageColumn2;
        private System.Windows.Forms.TextBox studentNumberTextBox;
        private System.Windows.Forms.ComboBox paymentStatusComboBox;
        private System.Windows.Forms.ComboBox monthOfPaymentComboBox;
        private System.Windows.Forms.ComboBox paymentMethodComboBox;
        private System.Windows.Forms.ComboBox paymentCodeComboBox;
        private System.Windows.Forms.TextBox proofOfPaymentTextBox;
        private System.Windows.Forms.TextBox paymentReceiptTextBox;
        private System.Windows.Forms.Button deleteProofOfPaymentButton;
        private System.Windows.Forms.Button uploadProofOfPaymentButton;
        private System.Windows.Forms.Button viewProofOfPaymentButton;
        private System.Windows.Forms.ToolStripButton bindingNavigatorRefreshItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label proofOfPaymentLabel;
        private System.Windows.Forms.ToolStrip searchToolStrip;
        private System.Windows.Forms.ToolStripLabel paymentCodeToolStripLabel;
        private System.Windows.Forms.ToolStripLabel studentNumberToolStripLabel;
        private System.Windows.Forms.ToolStripLabel monthOfPaymentToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox monthOfPaymentToolStripTextBox;
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
    }
}