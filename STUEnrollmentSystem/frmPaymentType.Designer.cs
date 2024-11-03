namespace STUEnrollmentSystem
{
    partial class frmPaymentType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaymentType));
            System.Windows.Forms.Label paymentTypeLabel;
            System.Windows.Forms.Label paymentCodeLabel;
            System.Windows.Forms.Label pricesCodeLabel;
            System.Windows.Forms.Label paymentAmountLabel;
            System.Windows.Forms.Label monthLabel;
            System.Windows.Forms.Label schoolYearLabel;
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.showSearchButton = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.sTU_DBDataSet = new STUEnrollmentSystem.STU_DBDataSet();
            this.paymentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTypeTableAdapter = new STUEnrollmentSystem.STU_DBDataSetTableAdapters.PaymentTypeTableAdapter();
            this.tableAdapterManager = new STUEnrollmentSystem.STU_DBDataSetTableAdapters.TableAdapterManager();
            this.paymentTypeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.paymentTypeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.paymentTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorRefreshItem = new System.Windows.Forms.ToolStripButton();
            this.paymentTypeTextBox = new System.Windows.Forms.TextBox();
            this.paymentCodeTextBox = new System.Windows.Forms.TextBox();
            this.pricesCodeTextBox = new System.Windows.Forms.TextBox();
            this.paymentAmountTextBox = new System.Windows.Forms.TextBox();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.schoolYearTextBox = new System.Windows.Forms.TextBox();
            paymentTypeLabel = new System.Windows.Forms.Label();
            paymentCodeLabel = new System.Windows.Forms.Label();
            pricesCodeLabel = new System.Windows.Forms.Label();
            paymentAmountLabel = new System.Windows.Forms.Label();
            monthLabel = new System.Windows.Forms.Label();
            schoolYearLabel = new System.Windows.Forms.Label();
            this.detailsPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sTU_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeBindingNavigator)).BeginInit();
            this.paymentTypeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // detailsPanel
            // 
            this.detailsPanel.AutoScroll = true;
            this.detailsPanel.Controls.Add(paymentTypeLabel);
            this.detailsPanel.Controls.Add(this.paymentTypeTextBox);
            this.detailsPanel.Controls.Add(paymentCodeLabel);
            this.detailsPanel.Controls.Add(this.paymentCodeTextBox);
            this.detailsPanel.Controls.Add(pricesCodeLabel);
            this.detailsPanel.Controls.Add(this.pricesCodeTextBox);
            this.detailsPanel.Controls.Add(paymentAmountLabel);
            this.detailsPanel.Controls.Add(this.paymentAmountTextBox);
            this.detailsPanel.Controls.Add(monthLabel);
            this.detailsPanel.Controls.Add(this.monthTextBox);
            this.detailsPanel.Controls.Add(schoolYearLabel);
            this.detailsPanel.Controls.Add(this.schoolYearTextBox);
            this.detailsPanel.Controls.Add(this.label1);
            this.detailsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.detailsPanel.Location = new System.Drawing.Point(0, 144);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(306, 615);
            this.detailsPanel.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Type Information";
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
            this.showSearchButton.TabIndex = 19;
            this.showSearchButton.Text = "Search ▼";
            this.showSearchButton.UseVisualStyleBackColor = false;
            this.showSearchButton.Click += new System.EventHandler(this.showSearchButton_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.AutoScroll = true;
            this.searchPanel.Controls.Add(this.label2);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel.Location = new System.Drawing.Point(0, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1264, 117);
            this.searchPanel.TabIndex = 18;
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
            // sTU_DBDataSet
            // 
            this.sTU_DBDataSet.DataSetName = "STU_DBDataSet";
            this.sTU_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentTypeBindingSource
            // 
            this.paymentTypeBindingSource.DataMember = "PaymentType";
            this.paymentTypeBindingSource.DataSource = this.sTU_DBDataSet;
            // 
            // paymentTypeTableAdapter
            // 
            this.paymentTypeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GradeLevelTableAdapter = null;
            this.tableAdapterManager.PaymentTypeTableAdapter = this.paymentTypeTableAdapter;
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
            // paymentTypeBindingNavigator
            // 
            this.paymentTypeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.paymentTypeBindingNavigator.BindingSource = this.paymentTypeBindingSource;
            this.paymentTypeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.paymentTypeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.paymentTypeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.paymentTypeBindingNavigatorSaveItem,
            this.bindingNavigatorRefreshItem});
            this.paymentTypeBindingNavigator.Location = new System.Drawing.Point(306, 144);
            this.paymentTypeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.paymentTypeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.paymentTypeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.paymentTypeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.paymentTypeBindingNavigator.Name = "paymentTypeBindingNavigator";
            this.paymentTypeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.paymentTypeBindingNavigator.Size = new System.Drawing.Size(958, 25);
            this.paymentTypeBindingNavigator.TabIndex = 21;
            this.paymentTypeBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // paymentTypeBindingNavigatorSaveItem
            // 
            this.paymentTypeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.paymentTypeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("paymentTypeBindingNavigatorSaveItem.Image")));
            this.paymentTypeBindingNavigatorSaveItem.Name = "paymentTypeBindingNavigatorSaveItem";
            this.paymentTypeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.paymentTypeBindingNavigatorSaveItem.Text = "Save Data";
            this.paymentTypeBindingNavigatorSaveItem.Click += new System.EventHandler(this.paymentTypeBindingNavigatorSaveItem_Click);
            // 
            // paymentTypeDataGridView
            // 
            this.paymentTypeDataGridView.AutoGenerateColumns = false;
            this.paymentTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentTypeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.paymentTypeDataGridView.DataSource = this.paymentTypeBindingSource;
            this.paymentTypeDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.paymentTypeDataGridView.Location = new System.Drawing.Point(306, 169);
            this.paymentTypeDataGridView.Name = "paymentTypeDataGridView";
            this.paymentTypeDataGridView.Size = new System.Drawing.Size(958, 590);
            this.paymentTypeDataGridView.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PaymentType";
            this.dataGridViewTextBoxColumn1.HeaderText = "PaymentType";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PaymentCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "PaymentCode";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PricesCode";
            this.dataGridViewTextBoxColumn3.HeaderText = "PricesCode";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PaymentAmount";
            this.dataGridViewTextBoxColumn4.HeaderText = "PaymentAmount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Month";
            this.dataGridViewTextBoxColumn5.HeaderText = "Month";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SchoolYear";
            this.dataGridViewTextBoxColumn6.HeaderText = "SchoolYear";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
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
            // paymentTypeLabel
            // 
            paymentTypeLabel.AutoSize = true;
            paymentTypeLabel.Location = new System.Drawing.Point(52, 98);
            paymentTypeLabel.Name = "paymentTypeLabel";
            paymentTypeLabel.Size = new System.Drawing.Size(78, 13);
            paymentTypeLabel.TabIndex = 1;
            paymentTypeLabel.Text = "Payment Type:";
            // 
            // paymentTypeTextBox
            // 
            this.paymentTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentTypeBindingSource, "PaymentType", true));
            this.paymentTypeTextBox.Location = new System.Drawing.Point(148, 95);
            this.paymentTypeTextBox.Name = "paymentTypeTextBox";
            this.paymentTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.paymentTypeTextBox.TabIndex = 2;
            // 
            // paymentCodeLabel
            // 
            paymentCodeLabel.AutoSize = true;
            paymentCodeLabel.Location = new System.Drawing.Point(52, 124);
            paymentCodeLabel.Name = "paymentCodeLabel";
            paymentCodeLabel.Size = new System.Drawing.Size(79, 13);
            paymentCodeLabel.TabIndex = 3;
            paymentCodeLabel.Text = "Payment Code:";
            // 
            // paymentCodeTextBox
            // 
            this.paymentCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentTypeBindingSource, "PaymentCode", true));
            this.paymentCodeTextBox.Location = new System.Drawing.Point(148, 121);
            this.paymentCodeTextBox.Name = "paymentCodeTextBox";
            this.paymentCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.paymentCodeTextBox.TabIndex = 4;
            // 
            // pricesCodeLabel
            // 
            pricesCodeLabel.AutoSize = true;
            pricesCodeLabel.Location = new System.Drawing.Point(52, 150);
            pricesCodeLabel.Name = "pricesCodeLabel";
            pricesCodeLabel.Size = new System.Drawing.Size(67, 13);
            pricesCodeLabel.TabIndex = 5;
            pricesCodeLabel.Text = "Prices Code:";
            // 
            // pricesCodeTextBox
            // 
            this.pricesCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentTypeBindingSource, "PricesCode", true));
            this.pricesCodeTextBox.Location = new System.Drawing.Point(148, 147);
            this.pricesCodeTextBox.Name = "pricesCodeTextBox";
            this.pricesCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.pricesCodeTextBox.TabIndex = 6;
            // 
            // paymentAmountLabel
            // 
            paymentAmountLabel.AutoSize = true;
            paymentAmountLabel.Location = new System.Drawing.Point(52, 176);
            paymentAmountLabel.Name = "paymentAmountLabel";
            paymentAmountLabel.Size = new System.Drawing.Size(90, 13);
            paymentAmountLabel.TabIndex = 7;
            paymentAmountLabel.Text = "Payment Amount:";
            // 
            // paymentAmountTextBox
            // 
            this.paymentAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentTypeBindingSource, "PaymentAmount", true));
            this.paymentAmountTextBox.Location = new System.Drawing.Point(148, 173);
            this.paymentAmountTextBox.Name = "paymentAmountTextBox";
            this.paymentAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.paymentAmountTextBox.TabIndex = 8;
            // 
            // monthLabel
            // 
            monthLabel.AutoSize = true;
            monthLabel.Location = new System.Drawing.Point(52, 202);
            monthLabel.Name = "monthLabel";
            monthLabel.Size = new System.Drawing.Size(40, 13);
            monthLabel.TabIndex = 9;
            monthLabel.Text = "Month:";
            // 
            // monthTextBox
            // 
            this.monthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentTypeBindingSource, "Month", true));
            this.monthTextBox.Location = new System.Drawing.Point(148, 199);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthTextBox.TabIndex = 10;
            // 
            // schoolYearLabel
            // 
            schoolYearLabel.AutoSize = true;
            schoolYearLabel.Location = new System.Drawing.Point(52, 228);
            schoolYearLabel.Name = "schoolYearLabel";
            schoolYearLabel.Size = new System.Drawing.Size(68, 13);
            schoolYearLabel.TabIndex = 11;
            schoolYearLabel.Text = "School Year:";
            // 
            // schoolYearTextBox
            // 
            this.schoolYearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentTypeBindingSource, "SchoolYear", true));
            this.schoolYearTextBox.Location = new System.Drawing.Point(148, 225);
            this.schoolYearTextBox.Name = "schoolYearTextBox";
            this.schoolYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.schoolYearTextBox.TabIndex = 12;
            // 
            // frmPaymentType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 759);
            this.Controls.Add(this.paymentTypeDataGridView);
            this.Controls.Add(this.paymentTypeBindingNavigator);
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.showSearchButton);
            this.Controls.Add(this.searchPanel);
            this.Name = "frmPaymentType";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmPaymentType_Load);
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sTU_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeBindingNavigator)).EndInit();
            this.paymentTypeBindingNavigator.ResumeLayout(false);
            this.paymentTypeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeDataGridView)).EndInit();
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
        private System.Windows.Forms.BindingSource paymentTypeBindingSource;
        private STU_DBDataSetTableAdapters.PaymentTypeTableAdapter paymentTypeTableAdapter;
        private STU_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator paymentTypeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton paymentTypeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox paymentTypeTextBox;
        private System.Windows.Forms.TextBox paymentCodeTextBox;
        private System.Windows.Forms.TextBox pricesCodeTextBox;
        private System.Windows.Forms.TextBox paymentAmountTextBox;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.TextBox schoolYearTextBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorRefreshItem;
        private System.Windows.Forms.DataGridView paymentTypeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}