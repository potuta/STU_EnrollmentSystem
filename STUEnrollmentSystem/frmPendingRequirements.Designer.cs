namespace STUEnrollmentSystem
{
    partial class frmPendingRequirements
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
            System.Windows.Forms.Label sectionLabel;
            System.Windows.Forms.Label studentNumberLabel;
            System.Windows.Forms.Label transferCertificateLabel;
            System.Windows.Forms.Label goodMoralLabel;
            System.Windows.Forms.Label birthCertificateLabel;
            System.Windows.Forms.Label studForm137Label;
            System.Windows.Forms.Label enrollmentStatusLabel;
            System.Windows.Forms.Label studFirstNameLabel;
            System.Windows.Forms.Label studMidNameLabel;
            System.Windows.Forms.Label studLastNameLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label birthDateLabel;
            System.Windows.Forms.Label civilStatusLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label contactNumLabel;
            System.Windows.Forms.Label enrollmentTypeLabel;
            System.Windows.Forms.Label installmentTypeLabel;
            System.Windows.Forms.Label motherFirstNameLabel;
            System.Windows.Forms.Label motherLastNameLabel;
            System.Windows.Forms.Label motherOccupationLabel;
            System.Windows.Forms.Label fatherFirstNameLabel;
            System.Windows.Forms.Label fatherLastNameLabel;
            System.Windows.Forms.Label fatherOccupationLabel;
            System.Windows.Forms.Label lRNLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPendingRequirements));
            System.Windows.Forms.Label personalEmailLabel;
            System.Windows.Forms.Label guardianEmailLabel;
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTU_DBDataSet = new STUEnrollmentSystem.STU_DBDataSet();
            this.sectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentNumberTextBox = new System.Windows.Forms.TextBox();
            this.deleteTransferCertButton = new System.Windows.Forms.Button();
            this.deleteGoodMoralButton = new System.Windows.Forms.Button();
            this.deleteBirthCertButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.studFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.studMidNameTextBox = new System.Windows.Forms.TextBox();
            this.studLastNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.contactNumTextBox = new System.Windows.Forms.TextBox();
            this.sectionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new STUEnrollmentSystem.STU_DBDataSetTableAdapters.StudentsTableAdapter();
            this.sectionsTableAdapter = new STUEnrollmentSystem.STU_DBDataSetTableAdapters.SectionsTableAdapter();
            this.motherFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.motherLastNameTextBox = new System.Windows.Forms.TextBox();
            this.motherOccupationTextBox = new System.Windows.Forms.TextBox();
            this.fatherFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.fatherLastNameTextBox = new System.Windows.Forms.TextBox();
            this.fatherOccupationTextBox = new System.Windows.Forms.TextBox();
            this.lRNTextBox = new System.Windows.Forms.TextBox();
            this.deleteFrm137Button = new System.Windows.Forms.Button();
            this.genStudNumTextBox = new System.Windows.Forms.TextBox();
            this.uploadBirthCertButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uploadTransferCertButton = new System.Windows.Forms.Button();
            this.studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.studentsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.studentsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorRefreshItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorUpdateRequirementsItem = new System.Windows.Forms.ToolStripButton();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.sectionTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.enrollmentStatusTextBox = new System.Windows.Forms.TextBox();
            this.civilStatusTextBox = new System.Windows.Forms.TextBox();
            this.enrollmentTypeTextBox = new System.Windows.Forms.TextBox();
            this.paymentTypeTextBox = new System.Windows.Forms.TextBox();
            this.birthDateTextBox = new System.Windows.Forms.TextBox();
            this.uploadFrm137Button = new System.Windows.Forms.Button();
            this.viewFrm137Button = new System.Windows.Forms.Button();
            this.studForm137TextBox = new System.Windows.Forms.TextBox();
            this.birthCertificateTextBox = new System.Windows.Forms.TextBox();
            this.viewBirthCertButton = new System.Windows.Forms.Button();
            this.uploadGoodMoralButton = new System.Windows.Forms.Button();
            this.viewGoodMoralButton = new System.Windows.Forms.Button();
            this.goodMoralTextBox = new System.Windows.Forms.TextBox();
            this.transferCertificateTextBox = new System.Windows.Forms.TextBox();
            this.viewTransferCertButton = new System.Windows.Forms.Button();
            this.showSearchButton = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.studentNumberToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.studentNumberToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.studFirstNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.studFirstNameToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.studMidNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.studMidNameToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.studLastNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.studLastNameToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new STUEnrollmentSystem.STU_DBDataSetTableAdapters.TableAdapterManager();
            this.personalEmailTextBox = new System.Windows.Forms.TextBox();
            this.guardianEmailTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonalEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuardianEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PaymentType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sectionLabel = new System.Windows.Forms.Label();
            studentNumberLabel = new System.Windows.Forms.Label();
            transferCertificateLabel = new System.Windows.Forms.Label();
            goodMoralLabel = new System.Windows.Forms.Label();
            birthCertificateLabel = new System.Windows.Forms.Label();
            studForm137Label = new System.Windows.Forms.Label();
            enrollmentStatusLabel = new System.Windows.Forms.Label();
            studFirstNameLabel = new System.Windows.Forms.Label();
            studMidNameLabel = new System.Windows.Forms.Label();
            studLastNameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            civilStatusLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            contactNumLabel = new System.Windows.Forms.Label();
            enrollmentTypeLabel = new System.Windows.Forms.Label();
            installmentTypeLabel = new System.Windows.Forms.Label();
            motherFirstNameLabel = new System.Windows.Forms.Label();
            motherLastNameLabel = new System.Windows.Forms.Label();
            motherOccupationLabel = new System.Windows.Forms.Label();
            fatherFirstNameLabel = new System.Windows.Forms.Label();
            fatherLastNameLabel = new System.Windows.Forms.Label();
            fatherOccupationLabel = new System.Windows.Forms.Label();
            lRNLabel = new System.Windows.Forms.Label();
            personalEmailLabel = new System.Windows.Forms.Label();
            guardianEmailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTU_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingNavigator)).BeginInit();
            this.studentsBindingNavigator.SuspendLayout();
            this.detailsPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.fillBy1ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // sectionLabel
            // 
            sectionLabel.AutoSize = true;
            sectionLabel.Location = new System.Drawing.Point(13, 223);
            sectionLabel.Name = "sectionLabel";
            sectionLabel.Size = new System.Drawing.Size(46, 13);
            sectionLabel.TabIndex = 66;
            sectionLabel.Text = "Section:";
            // 
            // studentNumberLabel
            // 
            studentNumberLabel.AutoSize = true;
            studentNumberLabel.Location = new System.Drawing.Point(13, 67);
            studentNumberLabel.Name = "studentNumberLabel";
            studentNumberLabel.Size = new System.Drawing.Size(87, 13);
            studentNumberLabel.TabIndex = 63;
            studentNumberLabel.Text = "Student Number:";
            // 
            // transferCertificateLabel
            // 
            transferCertificateLabel.AutoSize = true;
            transferCertificateLabel.Location = new System.Drawing.Point(777, 171);
            transferCertificateLabel.Name = "transferCertificateLabel";
            transferCertificateLabel.Size = new System.Drawing.Size(99, 13);
            transferCertificateLabel.TabIndex = 46;
            transferCertificateLabel.Text = "Transfer Certificate:";
            // 
            // goodMoralLabel
            // 
            goodMoralLabel.AutoSize = true;
            goodMoralLabel.Location = new System.Drawing.Point(777, 145);
            goodMoralLabel.Name = "goodMoralLabel";
            goodMoralLabel.Size = new System.Drawing.Size(65, 13);
            goodMoralLabel.TabIndex = 45;
            goodMoralLabel.Text = "Good Moral:";
            // 
            // birthCertificateLabel
            // 
            birthCertificateLabel.AutoSize = true;
            birthCertificateLabel.Location = new System.Drawing.Point(777, 119);
            birthCertificateLabel.Name = "birthCertificateLabel";
            birthCertificateLabel.Size = new System.Drawing.Size(81, 13);
            birthCertificateLabel.TabIndex = 44;
            birthCertificateLabel.Text = "Birth Certificate:";
            // 
            // studForm137Label
            // 
            studForm137Label.AutoSize = true;
            studForm137Label.Location = new System.Drawing.Point(777, 93);
            studForm137Label.Name = "studForm137Label";
            studForm137Label.Size = new System.Drawing.Size(76, 13);
            studForm137Label.TabIndex = 43;
            studForm137Label.Text = "Stud Form137:";
            // 
            // enrollmentStatusLabel
            // 
            enrollmentStatusLabel.AutoSize = true;
            enrollmentStatusLabel.Location = new System.Drawing.Point(13, 92);
            enrollmentStatusLabel.Name = "enrollmentStatusLabel";
            enrollmentStatusLabel.Size = new System.Drawing.Size(92, 13);
            enrollmentStatusLabel.TabIndex = 3;
            enrollmentStatusLabel.Text = "Enrollment Status:";
            // 
            // studFirstNameLabel
            // 
            studFirstNameLabel.AutoSize = true;
            studFirstNameLabel.Location = new System.Drawing.Point(13, 118);
            studFirstNameLabel.Name = "studFirstNameLabel";
            studFirstNameLabel.Size = new System.Drawing.Size(85, 13);
            studFirstNameLabel.TabIndex = 5;
            studFirstNameLabel.Text = "Stud First Name:";
            // 
            // studMidNameLabel
            // 
            studMidNameLabel.AutoSize = true;
            studMidNameLabel.Location = new System.Drawing.Point(13, 144);
            studMidNameLabel.Name = "studMidNameLabel";
            studMidNameLabel.Size = new System.Drawing.Size(83, 13);
            studMidNameLabel.TabIndex = 7;
            studMidNameLabel.Text = "Stud Mid Name:";
            // 
            // studLastNameLabel
            // 
            studLastNameLabel.AutoSize = true;
            studLastNameLabel.Location = new System.Drawing.Point(13, 170);
            studLastNameLabel.Name = "studLastNameLabel";
            studLastNameLabel.Size = new System.Drawing.Size(86, 13);
            studLastNameLabel.TabIndex = 9;
            studLastNameLabel.Text = "Stud Last Name:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(13, 196);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(45, 13);
            genderLabel.TabIndex = 11;
            genderLabel.Text = "Gender:";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new System.Drawing.Point(13, 246);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(57, 13);
            birthDateLabel.TabIndex = 13;
            birthDateLabel.Text = "Birth Date:";
            // 
            // civilStatusLabel
            // 
            civilStatusLabel.AutoSize = true;
            civilStatusLabel.Location = new System.Drawing.Point(268, 65);
            civilStatusLabel.Name = "civilStatusLabel";
            civilStatusLabel.Size = new System.Drawing.Size(62, 13);
            civilStatusLabel.TabIndex = 15;
            civilStatusLabel.Text = "Civil Status:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(268, 91);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 17;
            addressLabel.Text = "Address:";
            // 
            // contactNumLabel
            // 
            contactNumLabel.AutoSize = true;
            contactNumLabel.Location = new System.Drawing.Point(268, 117);
            contactNumLabel.Name = "contactNumLabel";
            contactNumLabel.Size = new System.Drawing.Size(72, 13);
            contactNumLabel.TabIndex = 19;
            contactNumLabel.Text = "Contact Num:";
            // 
            // enrollmentTypeLabel
            // 
            enrollmentTypeLabel.AutoSize = true;
            enrollmentTypeLabel.Location = new System.Drawing.Point(268, 200);
            enrollmentTypeLabel.Name = "enrollmentTypeLabel";
            enrollmentTypeLabel.Size = new System.Drawing.Size(86, 13);
            enrollmentTypeLabel.TabIndex = 21;
            enrollmentTypeLabel.Text = "Enrollment Type:";
            // 
            // installmentTypeLabel
            // 
            installmentTypeLabel.AutoSize = true;
            installmentTypeLabel.Location = new System.Drawing.Point(268, 227);
            installmentTypeLabel.Name = "installmentTypeLabel";
            installmentTypeLabel.Size = new System.Drawing.Size(78, 13);
            installmentTypeLabel.TabIndex = 23;
            installmentTypeLabel.Text = "Payment Type:";
            // 
            // motherFirstNameLabel
            // 
            motherFirstNameLabel.AutoSize = true;
            motherFirstNameLabel.Location = new System.Drawing.Point(521, 67);
            motherFirstNameLabel.Name = "motherFirstNameLabel";
            motherFirstNameLabel.Size = new System.Drawing.Size(96, 13);
            motherFirstNameLabel.TabIndex = 25;
            motherFirstNameLabel.Text = "Mother First Name:";
            // 
            // motherLastNameLabel
            // 
            motherLastNameLabel.AutoSize = true;
            motherLastNameLabel.Location = new System.Drawing.Point(521, 93);
            motherLastNameLabel.Name = "motherLastNameLabel";
            motherLastNameLabel.Size = new System.Drawing.Size(97, 13);
            motherLastNameLabel.TabIndex = 27;
            motherLastNameLabel.Text = "Mother Last Name:";
            // 
            // motherOccupationLabel
            // 
            motherOccupationLabel.AutoSize = true;
            motherOccupationLabel.Location = new System.Drawing.Point(521, 119);
            motherOccupationLabel.Name = "motherOccupationLabel";
            motherOccupationLabel.Size = new System.Drawing.Size(101, 13);
            motherOccupationLabel.TabIndex = 29;
            motherOccupationLabel.Text = "Mother Occupation:";
            // 
            // fatherFirstNameLabel
            // 
            fatherFirstNameLabel.AutoSize = true;
            fatherFirstNameLabel.Location = new System.Drawing.Point(521, 145);
            fatherFirstNameLabel.Name = "fatherFirstNameLabel";
            fatherFirstNameLabel.Size = new System.Drawing.Size(93, 13);
            fatherFirstNameLabel.TabIndex = 31;
            fatherFirstNameLabel.Text = "Father First Name:";
            // 
            // fatherLastNameLabel
            // 
            fatherLastNameLabel.AutoSize = true;
            fatherLastNameLabel.Location = new System.Drawing.Point(521, 171);
            fatherLastNameLabel.Name = "fatherLastNameLabel";
            fatherLastNameLabel.Size = new System.Drawing.Size(94, 13);
            fatherLastNameLabel.TabIndex = 33;
            fatherLastNameLabel.Text = "Father Last Name:";
            // 
            // fatherOccupationLabel
            // 
            fatherOccupationLabel.AutoSize = true;
            fatherOccupationLabel.Location = new System.Drawing.Point(521, 197);
            fatherOccupationLabel.Name = "fatherOccupationLabel";
            fatherOccupationLabel.Size = new System.Drawing.Size(98, 13);
            fatherOccupationLabel.TabIndex = 35;
            fatherOccupationLabel.Text = "Father Occupation:";
            // 
            // lRNLabel
            // 
            lRNLabel.AutoSize = true;
            lRNLabel.Location = new System.Drawing.Point(777, 67);
            lRNLabel.Name = "lRNLabel";
            lRNLabel.Size = new System.Drawing.Size(32, 13);
            lRNLabel.TabIndex = 37;
            lRNLabel.Text = "LRN:";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.sTU_DBDataSet;
            // 
            // sTU_DBDataSet
            // 
            this.sTU_DBDataSet.DataSetName = "STU_DBDataSet";
            this.sTU_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sectionsBindingSource
            // 
            this.sectionsBindingSource.DataMember = "Sections";
            this.sectionsBindingSource.DataSource = this.sTU_DBDataSet;
            // 
            // studentNumberTextBox
            // 
            this.studentNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "StudentNumber", true));
            this.studentNumberTextBox.Location = new System.Drawing.Point(120, 64);
            this.studentNumberTextBox.Name = "studentNumberTextBox";
            this.studentNumberTextBox.ReadOnly = true;
            this.studentNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentNumberTextBox.TabIndex = 64;
            // 
            // deleteTransferCertButton
            // 
            this.deleteTransferCertButton.Location = new System.Drawing.Point(985, 165);
            this.deleteTransferCertButton.Name = "deleteTransferCertButton";
            this.deleteTransferCertButton.Size = new System.Drawing.Size(33, 23);
            this.deleteTransferCertButton.TabIndex = 60;
            this.deleteTransferCertButton.Text = "Del";
            this.deleteTransferCertButton.UseVisualStyleBackColor = true;
            this.deleteTransferCertButton.Click += new System.EventHandler(this.deleteTransferCertButton_Click);
            // 
            // deleteGoodMoralButton
            // 
            this.deleteGoodMoralButton.Location = new System.Drawing.Point(985, 141);
            this.deleteGoodMoralButton.Name = "deleteGoodMoralButton";
            this.deleteGoodMoralButton.Size = new System.Drawing.Size(33, 23);
            this.deleteGoodMoralButton.TabIndex = 58;
            this.deleteGoodMoralButton.Text = "Del";
            this.deleteGoodMoralButton.UseVisualStyleBackColor = true;
            this.deleteGoodMoralButton.Click += new System.EventHandler(this.deleteGoodMoralButton_Click);
            // 
            // deleteBirthCertButton
            // 
            this.deleteBirthCertButton.Location = new System.Drawing.Point(985, 115);
            this.deleteBirthCertButton.Name = "deleteBirthCertButton";
            this.deleteBirthCertButton.Size = new System.Drawing.Size(33, 23);
            this.deleteBirthCertButton.TabIndex = 56;
            this.deleteBirthCertButton.Text = "Del";
            this.deleteBirthCertButton.UseVisualStyleBackColor = true;
            this.deleteBirthCertButton.Click += new System.EventHandler(this.deleteBirthCertButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(777, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 49;
            this.label4.Text = "Requirements:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(521, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 18);
            this.label3.TabIndex = 48;
            this.label3.Text = "Parent\'s Information";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // studFirstNameTextBox
            // 
            this.studFirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "StudFirstName", true));
            this.studFirstNameTextBox.Location = new System.Drawing.Point(120, 115);
            this.studFirstNameTextBox.Name = "studFirstNameTextBox";
            this.studFirstNameTextBox.ReadOnly = true;
            this.studFirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.studFirstNameTextBox.TabIndex = 6;
            // 
            // studMidNameTextBox
            // 
            this.studMidNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studMidNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "StudMidName", true));
            this.studMidNameTextBox.Location = new System.Drawing.Point(120, 141);
            this.studMidNameTextBox.Name = "studMidNameTextBox";
            this.studMidNameTextBox.ReadOnly = true;
            this.studMidNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.studMidNameTextBox.TabIndex = 8;
            // 
            // studLastNameTextBox
            // 
            this.studLastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studLastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "StudLastName", true));
            this.studLastNameTextBox.Location = new System.Drawing.Point(120, 167);
            this.studLastNameTextBox.Name = "studLastNameTextBox";
            this.studLastNameTextBox.ReadOnly = true;
            this.studLastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.studLastNameTextBox.TabIndex = 10;
            // 
            // addressTextBox
            // 
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(375, 92);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 18;
            // 
            // contactNumTextBox
            // 
            this.contactNumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "ContactNum", true));
            this.contactNumTextBox.Location = new System.Drawing.Point(375, 118);
            this.contactNumTextBox.Name = "contactNumTextBox";
            this.contactNumTextBox.ReadOnly = true;
            this.contactNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactNumTextBox.TabIndex = 20;
            // 
            // sectionsBindingSource1
            // 
            this.sectionsBindingSource1.DataMember = "Sections";
            this.sectionsBindingSource1.DataSource = this.sTU_DBDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // sectionsTableAdapter
            // 
            this.sectionsTableAdapter.ClearBeforeFill = true;
            // 
            // motherFirstNameTextBox
            // 
            this.motherFirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.motherFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "MotherFirstName", true));
            this.motherFirstNameTextBox.Location = new System.Drawing.Point(625, 67);
            this.motherFirstNameTextBox.Name = "motherFirstNameTextBox";
            this.motherFirstNameTextBox.ReadOnly = true;
            this.motherFirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.motherFirstNameTextBox.TabIndex = 26;
            // 
            // motherLastNameTextBox
            // 
            this.motherLastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.motherLastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "MotherLastName", true));
            this.motherLastNameTextBox.Location = new System.Drawing.Point(625, 93);
            this.motherLastNameTextBox.Name = "motherLastNameTextBox";
            this.motherLastNameTextBox.ReadOnly = true;
            this.motherLastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.motherLastNameTextBox.TabIndex = 28;
            // 
            // motherOccupationTextBox
            // 
            this.motherOccupationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.motherOccupationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "MotherOccupation", true));
            this.motherOccupationTextBox.Location = new System.Drawing.Point(625, 119);
            this.motherOccupationTextBox.Name = "motherOccupationTextBox";
            this.motherOccupationTextBox.ReadOnly = true;
            this.motherOccupationTextBox.Size = new System.Drawing.Size(100, 20);
            this.motherOccupationTextBox.TabIndex = 30;
            // 
            // fatherFirstNameTextBox
            // 
            this.fatherFirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fatherFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "FatherFirstName", true));
            this.fatherFirstNameTextBox.Location = new System.Drawing.Point(625, 145);
            this.fatherFirstNameTextBox.Name = "fatherFirstNameTextBox";
            this.fatherFirstNameTextBox.ReadOnly = true;
            this.fatherFirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.fatherFirstNameTextBox.TabIndex = 32;
            // 
            // fatherLastNameTextBox
            // 
            this.fatherLastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fatherLastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "FatherLastName", true));
            this.fatherLastNameTextBox.Location = new System.Drawing.Point(625, 171);
            this.fatherLastNameTextBox.Name = "fatherLastNameTextBox";
            this.fatherLastNameTextBox.ReadOnly = true;
            this.fatherLastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.fatherLastNameTextBox.TabIndex = 34;
            // 
            // fatherOccupationTextBox
            // 
            this.fatherOccupationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fatherOccupationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "FatherOccupation", true));
            this.fatherOccupationTextBox.Location = new System.Drawing.Point(625, 197);
            this.fatherOccupationTextBox.Name = "fatherOccupationTextBox";
            this.fatherOccupationTextBox.ReadOnly = true;
            this.fatherOccupationTextBox.Size = new System.Drawing.Size(100, 20);
            this.fatherOccupationTextBox.TabIndex = 36;
            // 
            // lRNTextBox
            // 
            this.lRNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "LRN", true));
            this.lRNTextBox.Location = new System.Drawing.Point(884, 64);
            this.lRNTextBox.Name = "lRNTextBox";
            this.lRNTextBox.Size = new System.Drawing.Size(100, 20);
            this.lRNTextBox.TabIndex = 38;
            // 
            // deleteFrm137Button
            // 
            this.deleteFrm137Button.Location = new System.Drawing.Point(985, 88);
            this.deleteFrm137Button.Name = "deleteFrm137Button";
            this.deleteFrm137Button.Size = new System.Drawing.Size(33, 23);
            this.deleteFrm137Button.TabIndex = 52;
            this.deleteFrm137Button.Text = "Del";
            this.deleteFrm137Button.UseVisualStyleBackColor = true;
            this.deleteFrm137Button.Click += new System.EventHandler(this.deleteFrm137Button_Click);
            // 
            // genStudNumTextBox
            // 
            this.genStudNumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.genStudNumTextBox.Location = new System.Drawing.Point(120, 64);
            this.genStudNumTextBox.Name = "genStudNumTextBox";
            this.genStudNumTextBox.ReadOnly = true;
            this.genStudNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.genStudNumTextBox.TabIndex = 66;
            // 
            // uploadBirthCertButton
            // 
            this.uploadBirthCertButton.Location = new System.Drawing.Point(884, 116);
            this.uploadBirthCertButton.Name = "uploadBirthCertButton";
            this.uploadBirthCertButton.Size = new System.Drawing.Size(100, 23);
            this.uploadBirthCertButton.TabIndex = 54;
            this.uploadBirthCertButton.Text = "Upload File";
            this.uploadBirthCertButton.UseVisualStyleBackColor = true;
            this.uploadBirthCertButton.Click += new System.EventHandler(this.uploadBirthCertButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student\'s Information";
            // 
            // uploadTransferCertButton
            // 
            this.uploadTransferCertButton.Location = new System.Drawing.Point(884, 166);
            this.uploadTransferCertButton.Name = "uploadTransferCertButton";
            this.uploadTransferCertButton.Size = new System.Drawing.Size(100, 23);
            this.uploadTransferCertButton.TabIndex = 61;
            this.uploadTransferCertButton.Text = "Upload File";
            this.uploadTransferCertButton.UseVisualStyleBackColor = true;
            this.uploadTransferCertButton.Click += new System.EventHandler(this.uploadTransferCertButton_Click);
            // 
            // studentsDataGridView
            // 
            this.studentsDataGridView.AutoGenerateColumns = false;
            this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Section,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.PersonalEmail,
            this.GuardianEmail,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.PaymentType,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewImageColumn2,
            this.dataGridViewImageColumn3,
            this.dataGridViewImageColumn4});
            this.studentsDataGridView.DataSource = this.studentsBindingSource;
            this.studentsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentsDataGridView.Location = new System.Drawing.Point(0, 447);
            this.studentsDataGridView.Name = "studentsDataGridView";
            this.studentsDataGridView.Size = new System.Drawing.Size(1298, 382);
            this.studentsDataGridView.TabIndex = 14;
            this.studentsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentsDataGridView_CellClick);
            // 
            // studentsBindingNavigator
            // 
            this.studentsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentsBindingNavigator.BindingSource = this.studentsBindingSource;
            this.studentsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.studentsBindingNavigatorSaveItem,
            this.bindingNavigatorRefreshItem,
            this.bindingNavigatorUpdateRequirementsItem});
            this.studentsBindingNavigator.Location = new System.Drawing.Point(0, 422);
            this.studentsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentsBindingNavigator.Name = "studentsBindingNavigator";
            this.studentsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentsBindingNavigator.Size = new System.Drawing.Size(1298, 25);
            this.studentsBindingNavigator.TabIndex = 15;
            this.studentsBindingNavigator.Text = "bindingNavigator1";
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
            // studentsBindingNavigatorSaveItem
            // 
            this.studentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentsBindingNavigatorSaveItem.Image")));
            this.studentsBindingNavigatorSaveItem.Name = "studentsBindingNavigatorSaveItem";
            this.studentsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.studentsBindingNavigatorSaveItem.Text = "Save Data";
            this.studentsBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentsBindingNavigatorSaveItem_Click);
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
            // bindingNavigatorUpdateRequirementsItem
            // 
            this.bindingNavigatorUpdateRequirementsItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorUpdateRequirementsItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorUpdateRequirementsItem.Image")));
            this.bindingNavigatorUpdateRequirementsItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorUpdateRequirementsItem.Name = "bindingNavigatorUpdateRequirementsItem";
            this.bindingNavigatorUpdateRequirementsItem.Size = new System.Drawing.Size(169, 22);
            this.bindingNavigatorUpdateRequirementsItem.Text = "Update Student Requirements";
            this.bindingNavigatorUpdateRequirementsItem.Click += new System.EventHandler(this.bindingNavigatorUpdateRequirementsItem_Click);
            // 
            // detailsPanel
            // 
            this.detailsPanel.AutoScroll = true;
            this.detailsPanel.Controls.Add(guardianEmailLabel);
            this.detailsPanel.Controls.Add(this.guardianEmailTextBox);
            this.detailsPanel.Controls.Add(personalEmailLabel);
            this.detailsPanel.Controls.Add(this.personalEmailTextBox);
            this.detailsPanel.Controls.Add(this.sectionTextBox);
            this.detailsPanel.Controls.Add(this.genderTextBox);
            this.detailsPanel.Controls.Add(this.enrollmentStatusTextBox);
            this.detailsPanel.Controls.Add(this.civilStatusTextBox);
            this.detailsPanel.Controls.Add(this.enrollmentTypeTextBox);
            this.detailsPanel.Controls.Add(this.paymentTypeTextBox);
            this.detailsPanel.Controls.Add(sectionLabel);
            this.detailsPanel.Controls.Add(studentNumberLabel);
            this.detailsPanel.Controls.Add(this.studentNumberTextBox);
            this.detailsPanel.Controls.Add(this.deleteTransferCertButton);
            this.detailsPanel.Controls.Add(this.deleteGoodMoralButton);
            this.detailsPanel.Controls.Add(this.deleteBirthCertButton);
            this.detailsPanel.Controls.Add(this.label4);
            this.detailsPanel.Controls.Add(this.label3);
            this.detailsPanel.Controls.Add(transferCertificateLabel);
            this.detailsPanel.Controls.Add(goodMoralLabel);
            this.detailsPanel.Controls.Add(birthCertificateLabel);
            this.detailsPanel.Controls.Add(studForm137Label);
            this.detailsPanel.Controls.Add(enrollmentStatusLabel);
            this.detailsPanel.Controls.Add(studFirstNameLabel);
            this.detailsPanel.Controls.Add(this.studFirstNameTextBox);
            this.detailsPanel.Controls.Add(studMidNameLabel);
            this.detailsPanel.Controls.Add(this.studMidNameTextBox);
            this.detailsPanel.Controls.Add(studLastNameLabel);
            this.detailsPanel.Controls.Add(this.studLastNameTextBox);
            this.detailsPanel.Controls.Add(genderLabel);
            this.detailsPanel.Controls.Add(birthDateLabel);
            this.detailsPanel.Controls.Add(civilStatusLabel);
            this.detailsPanel.Controls.Add(addressLabel);
            this.detailsPanel.Controls.Add(this.addressTextBox);
            this.detailsPanel.Controls.Add(contactNumLabel);
            this.detailsPanel.Controls.Add(this.contactNumTextBox);
            this.detailsPanel.Controls.Add(enrollmentTypeLabel);
            this.detailsPanel.Controls.Add(installmentTypeLabel);
            this.detailsPanel.Controls.Add(motherFirstNameLabel);
            this.detailsPanel.Controls.Add(this.motherFirstNameTextBox);
            this.detailsPanel.Controls.Add(motherLastNameLabel);
            this.detailsPanel.Controls.Add(this.motherLastNameTextBox);
            this.detailsPanel.Controls.Add(motherOccupationLabel);
            this.detailsPanel.Controls.Add(this.motherOccupationTextBox);
            this.detailsPanel.Controls.Add(fatherFirstNameLabel);
            this.detailsPanel.Controls.Add(this.fatherFirstNameTextBox);
            this.detailsPanel.Controls.Add(fatherLastNameLabel);
            this.detailsPanel.Controls.Add(this.fatherLastNameTextBox);
            this.detailsPanel.Controls.Add(fatherOccupationLabel);
            this.detailsPanel.Controls.Add(this.fatherOccupationTextBox);
            this.detailsPanel.Controls.Add(lRNLabel);
            this.detailsPanel.Controls.Add(this.lRNTextBox);
            this.detailsPanel.Controls.Add(this.label1);
            this.detailsPanel.Controls.Add(this.deleteFrm137Button);
            this.detailsPanel.Controls.Add(this.genStudNumTextBox);
            this.detailsPanel.Controls.Add(this.birthDateTextBox);
            this.detailsPanel.Controls.Add(this.uploadFrm137Button);
            this.detailsPanel.Controls.Add(this.viewFrm137Button);
            this.detailsPanel.Controls.Add(this.studForm137TextBox);
            this.detailsPanel.Controls.Add(this.uploadBirthCertButton);
            this.detailsPanel.Controls.Add(this.birthCertificateTextBox);
            this.detailsPanel.Controls.Add(this.viewBirthCertButton);
            this.detailsPanel.Controls.Add(this.uploadGoodMoralButton);
            this.detailsPanel.Controls.Add(this.viewGoodMoralButton);
            this.detailsPanel.Controls.Add(this.goodMoralTextBox);
            this.detailsPanel.Controls.Add(this.uploadTransferCertButton);
            this.detailsPanel.Controls.Add(this.transferCertificateTextBox);
            this.detailsPanel.Controls.Add(this.viewTransferCertButton);
            this.detailsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.detailsPanel.Location = new System.Drawing.Point(0, 123);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(1298, 299);
            this.detailsPanel.TabIndex = 13;
            // 
            // sectionTextBox
            // 
            this.sectionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sectionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Section", true));
            this.sectionTextBox.Location = new System.Drawing.Point(120, 220);
            this.sectionTextBox.Name = "sectionTextBox";
            this.sectionTextBox.ReadOnly = true;
            this.sectionTextBox.Size = new System.Drawing.Size(100, 20);
            this.sectionTextBox.TabIndex = 74;
            // 
            // genderTextBox
            // 
            this.genderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(120, 193);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.ReadOnly = true;
            this.genderTextBox.Size = new System.Drawing.Size(100, 20);
            this.genderTextBox.TabIndex = 73;
            // 
            // enrollmentStatusTextBox
            // 
            this.enrollmentStatusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enrollmentStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "EnrollmentStatus", true));
            this.enrollmentStatusTextBox.Location = new System.Drawing.Point(120, 89);
            this.enrollmentStatusTextBox.Name = "enrollmentStatusTextBox";
            this.enrollmentStatusTextBox.ReadOnly = true;
            this.enrollmentStatusTextBox.Size = new System.Drawing.Size(100, 20);
            this.enrollmentStatusTextBox.TabIndex = 72;
            // 
            // civilStatusTextBox
            // 
            this.civilStatusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.civilStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "CivilStatus", true));
            this.civilStatusTextBox.Location = new System.Drawing.Point(375, 65);
            this.civilStatusTextBox.Name = "civilStatusTextBox";
            this.civilStatusTextBox.ReadOnly = true;
            this.civilStatusTextBox.Size = new System.Drawing.Size(100, 20);
            this.civilStatusTextBox.TabIndex = 71;
            // 
            // enrollmentTypeTextBox
            // 
            this.enrollmentTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enrollmentTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "EnrollmentType", true));
            this.enrollmentTypeTextBox.Location = new System.Drawing.Point(375, 197);
            this.enrollmentTypeTextBox.Name = "enrollmentTypeTextBox";
            this.enrollmentTypeTextBox.ReadOnly = true;
            this.enrollmentTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.enrollmentTypeTextBox.TabIndex = 70;
            // 
            // paymentTypeTextBox
            // 
            this.paymentTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paymentTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "PaymentType", true));
            this.paymentTypeTextBox.Location = new System.Drawing.Point(375, 223);
            this.paymentTypeTextBox.Name = "paymentTypeTextBox";
            this.paymentTypeTextBox.ReadOnly = true;
            this.paymentTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.paymentTypeTextBox.TabIndex = 69;
            // 
            // birthDateTextBox
            // 
            this.birthDateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.birthDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "BirthDate", true));
            this.birthDateTextBox.Location = new System.Drawing.Point(120, 246);
            this.birthDateTextBox.Name = "birthDateTextBox";
            this.birthDateTextBox.ReadOnly = true;
            this.birthDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.birthDateTextBox.TabIndex = 14;
            // 
            // uploadFrm137Button
            // 
            this.uploadFrm137Button.Location = new System.Drawing.Point(884, 88);
            this.uploadFrm137Button.Name = "uploadFrm137Button";
            this.uploadFrm137Button.Size = new System.Drawing.Size(100, 23);
            this.uploadFrm137Button.TabIndex = 53;
            this.uploadFrm137Button.Text = "Upload File";
            this.uploadFrm137Button.UseVisualStyleBackColor = true;
            this.uploadFrm137Button.Click += new System.EventHandler(this.uploadFrm137Button_Click);
            // 
            // viewFrm137Button
            // 
            this.viewFrm137Button.Location = new System.Drawing.Point(884, 88);
            this.viewFrm137Button.Name = "viewFrm137Button";
            this.viewFrm137Button.Size = new System.Drawing.Size(100, 23);
            this.viewFrm137Button.TabIndex = 51;
            this.viewFrm137Button.Text = "View File";
            this.viewFrm137Button.UseVisualStyleBackColor = true;
            this.viewFrm137Button.Click += new System.EventHandler(this.viewFrm137Button_Click);
            // 
            // studForm137TextBox
            // 
            this.studForm137TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "StudForm137", true));
            this.studForm137TextBox.Location = new System.Drawing.Point(884, 90);
            this.studForm137TextBox.Name = "studForm137TextBox";
            this.studForm137TextBox.Size = new System.Drawing.Size(100, 20);
            this.studForm137TextBox.TabIndex = 44;
            this.studForm137TextBox.Visible = false;
            // 
            // birthCertificateTextBox
            // 
            this.birthCertificateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "BirthCertificate", true));
            this.birthCertificateTextBox.Location = new System.Drawing.Point(884, 116);
            this.birthCertificateTextBox.Name = "birthCertificateTextBox";
            this.birthCertificateTextBox.Size = new System.Drawing.Size(100, 20);
            this.birthCertificateTextBox.TabIndex = 45;
            this.birthCertificateTextBox.Visible = false;
            // 
            // viewBirthCertButton
            // 
            this.viewBirthCertButton.Location = new System.Drawing.Point(884, 116);
            this.viewBirthCertButton.Name = "viewBirthCertButton";
            this.viewBirthCertButton.Size = new System.Drawing.Size(100, 23);
            this.viewBirthCertButton.TabIndex = 55;
            this.viewBirthCertButton.Text = "View File";
            this.viewBirthCertButton.UseVisualStyleBackColor = true;
            this.viewBirthCertButton.Click += new System.EventHandler(this.viewBirthCertButton_Click);
            // 
            // uploadGoodMoralButton
            // 
            this.uploadGoodMoralButton.Location = new System.Drawing.Point(884, 142);
            this.uploadGoodMoralButton.Name = "uploadGoodMoralButton";
            this.uploadGoodMoralButton.Size = new System.Drawing.Size(100, 23);
            this.uploadGoodMoralButton.TabIndex = 59;
            this.uploadGoodMoralButton.Text = "Upload File";
            this.uploadGoodMoralButton.UseVisualStyleBackColor = true;
            this.uploadGoodMoralButton.Click += new System.EventHandler(this.uploadGoodMoralButton_Click);
            // 
            // viewGoodMoralButton
            // 
            this.viewGoodMoralButton.Location = new System.Drawing.Point(884, 142);
            this.viewGoodMoralButton.Name = "viewGoodMoralButton";
            this.viewGoodMoralButton.Size = new System.Drawing.Size(100, 23);
            this.viewGoodMoralButton.TabIndex = 57;
            this.viewGoodMoralButton.Text = "View File";
            this.viewGoodMoralButton.UseVisualStyleBackColor = true;
            this.viewGoodMoralButton.Click += new System.EventHandler(this.viewGoodMoralButton_Click);
            // 
            // goodMoralTextBox
            // 
            this.goodMoralTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "GoodMoral", true));
            this.goodMoralTextBox.Location = new System.Drawing.Point(884, 142);
            this.goodMoralTextBox.Name = "goodMoralTextBox";
            this.goodMoralTextBox.Size = new System.Drawing.Size(100, 20);
            this.goodMoralTextBox.TabIndex = 46;
            this.goodMoralTextBox.Visible = false;
            // 
            // transferCertificateTextBox
            // 
            this.transferCertificateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "TransferCertificate", true));
            this.transferCertificateTextBox.Location = new System.Drawing.Point(884, 167);
            this.transferCertificateTextBox.Name = "transferCertificateTextBox";
            this.transferCertificateTextBox.Size = new System.Drawing.Size(100, 20);
            this.transferCertificateTextBox.TabIndex = 47;
            this.transferCertificateTextBox.Visible = false;
            // 
            // viewTransferCertButton
            // 
            this.viewTransferCertButton.Location = new System.Drawing.Point(884, 166);
            this.viewTransferCertButton.Name = "viewTransferCertButton";
            this.viewTransferCertButton.Size = new System.Drawing.Size(100, 23);
            this.viewTransferCertButton.TabIndex = 62;
            this.viewTransferCertButton.Text = "View File";
            this.viewTransferCertButton.UseVisualStyleBackColor = true;
            this.viewTransferCertButton.Click += new System.EventHandler(this.viewTransferCertButton_Click);
            // 
            // showSearchButton
            // 
            this.showSearchButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.showSearchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.showSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showSearchButton.Font = new System.Drawing.Font("Subway", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSearchButton.Location = new System.Drawing.Point(0, 96);
            this.showSearchButton.Name = "showSearchButton";
            this.showSearchButton.Size = new System.Drawing.Size(1298, 27);
            this.showSearchButton.TabIndex = 12;
            this.showSearchButton.Text = "Search ▼";
            this.showSearchButton.UseVisualStyleBackColor = false;
            this.showSearchButton.Click += new System.EventHandler(this.showSearchButton_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.AutoScroll = true;
            this.searchPanel.Controls.Add(this.fillBy1ToolStrip);
            this.searchPanel.Controls.Add(this.label2);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel.Location = new System.Drawing.Point(0, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1298, 96);
            this.searchPanel.TabIndex = 11;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillBy1ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentNumberToolStripLabel,
            this.studentNumberToolStripComboBox,
            this.studFirstNameToolStripLabel,
            this.studFirstNameToolStripComboBox,
            this.studMidNameToolStripLabel,
            this.studMidNameToolStripComboBox,
            this.studLastNameToolStripLabel,
            this.studLastNameToolStripComboBox,
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(84, 41);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(822, 25);
            this.fillBy1ToolStrip.TabIndex = 14;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            // 
            // studentNumberToolStripLabel
            // 
            this.studentNumberToolStripLabel.Name = "studentNumberToolStripLabel";
            this.studentNumberToolStripLabel.Size = new System.Drawing.Size(98, 22);
            this.studentNumberToolStripLabel.Text = "Student Number:";
            // 
            // studentNumberToolStripComboBox
            // 
            this.studentNumberToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.studentNumberToolStripComboBox.Name = "studentNumberToolStripComboBox";
            this.studentNumberToolStripComboBox.Size = new System.Drawing.Size(100, 25);
            this.studentNumberToolStripComboBox.TextChanged += new System.EventHandler(this.OnSearchToolStripTextChanged);
            // 
            // studFirstNameToolStripLabel
            // 
            this.studFirstNameToolStripLabel.Name = "studFirstNameToolStripLabel";
            this.studFirstNameToolStripLabel.Size = new System.Drawing.Size(82, 22);
            this.studFirstNameToolStripLabel.Text = "     First Name:";
            // 
            // studFirstNameToolStripComboBox
            // 
            this.studFirstNameToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.studFirstNameToolStripComboBox.Name = "studFirstNameToolStripComboBox";
            this.studFirstNameToolStripComboBox.Size = new System.Drawing.Size(100, 25);
            this.studFirstNameToolStripComboBox.TextChanged += new System.EventHandler(this.OnSearchToolStripTextChanged);
            // 
            // studMidNameToolStripLabel
            // 
            this.studMidNameToolStripLabel.Name = "studMidNameToolStripLabel";
            this.studMidNameToolStripLabel.Size = new System.Drawing.Size(104, 22);
            this.studMidNameToolStripLabel.Text = "     Midddle Name:";
            // 
            // studMidNameToolStripComboBox
            // 
            this.studMidNameToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.studMidNameToolStripComboBox.Name = "studMidNameToolStripComboBox";
            this.studMidNameToolStripComboBox.Size = new System.Drawing.Size(100, 25);
            this.studMidNameToolStripComboBox.TextChanged += new System.EventHandler(this.OnSearchToolStripTextChanged);
            // 
            // studLastNameToolStripLabel
            // 
            this.studLastNameToolStripLabel.Name = "studLastNameToolStripLabel";
            this.studLastNameToolStripLabel.Size = new System.Drawing.Size(81, 22);
            this.studLastNameToolStripLabel.Text = "     Last Name:";
            // 
            // studLastNameToolStripComboBox
            // 
            this.studLastNameToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.studLastNameToolStripComboBox.Name = "studLastNameToolStripComboBox";
            this.studLastNameToolStripComboBox.Size = new System.Drawing.Size(100, 25);
            this.studLastNameToolStripComboBox.TextChanged += new System.EventHandler(this.OnSearchToolStripTextChanged);
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.fillBy1ToolStripButton.Text = "Search";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
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
            this.tableAdapterManager.StudentPaymentTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.SubjectsTableAdapter = null;
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = STUEnrollmentSystem.STU_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // personalEmailLabel
            // 
            personalEmailLabel.AutoSize = true;
            personalEmailLabel.Location = new System.Drawing.Point(268, 147);
            personalEmailLabel.Name = "personalEmailLabel";
            personalEmailLabel.Size = new System.Drawing.Size(79, 13);
            personalEmailLabel.TabIndex = 74;
            personalEmailLabel.Text = "Personal Email:";
            // 
            // personalEmailTextBox
            // 
            this.personalEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.personalEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "PersonalEmail", true));
            this.personalEmailTextBox.Location = new System.Drawing.Point(375, 144);
            this.personalEmailTextBox.Name = "personalEmailTextBox";
            this.personalEmailTextBox.ReadOnly = true;
            this.personalEmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.personalEmailTextBox.TabIndex = 75;
            // 
            // guardianEmailLabel
            // 
            guardianEmailLabel.AutoSize = true;
            guardianEmailLabel.Location = new System.Drawing.Point(268, 173);
            guardianEmailLabel.Name = "guardianEmailLabel";
            guardianEmailLabel.Size = new System.Drawing.Size(81, 13);
            guardianEmailLabel.TabIndex = 75;
            guardianEmailLabel.Text = "Guardian Email:";
            // 
            // guardianEmailTextBox
            // 
            this.guardianEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guardianEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "GuardianEmail", true));
            this.guardianEmailTextBox.Location = new System.Drawing.Point(375, 170);
            this.guardianEmailTextBox.Name = "guardianEmailTextBox";
            this.guardianEmailTextBox.ReadOnly = true;
            this.guardianEmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.guardianEmailTextBox.TabIndex = 76;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StudentNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "StudentNumber";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StudFirstName";
            this.dataGridViewTextBoxColumn3.HeaderText = "StudFirstName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StudMidName";
            this.dataGridViewTextBoxColumn4.HeaderText = "StudMidName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StudLastName";
            this.dataGridViewTextBoxColumn5.HeaderText = "StudLastName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn6.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn6.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "BirthDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "BirthDate";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Section
            // 
            this.Section.DataPropertyName = "Section";
            this.Section.HeaderText = "Section";
            this.Section.Name = "Section";
            this.Section.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Section.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CivilStatus";
            this.dataGridViewTextBoxColumn8.HeaderText = "CivilStatus";
            this.dataGridViewTextBoxColumn8.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Separated",
            "Divorced",
            "Widowed"});
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn9.HeaderText = "Address";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ContactNum";
            this.dataGridViewTextBoxColumn10.HeaderText = "ContactNum";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // PersonalEmail
            // 
            this.PersonalEmail.DataPropertyName = "PersonalEmail";
            this.PersonalEmail.HeaderText = "PersonalEmail";
            this.PersonalEmail.Name = "PersonalEmail";
            // 
            // GuardianEmail
            // 
            this.GuardianEmail.DataPropertyName = "GuardianEmail";
            this.GuardianEmail.HeaderText = "GuardianEmail";
            this.GuardianEmail.Name = "GuardianEmail";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "EnrollmentStatus";
            this.dataGridViewTextBoxColumn11.HeaderText = "EnrollmentStatus";
            this.dataGridViewTextBoxColumn11.Items.AddRange(new object[] {
            "OLD",
            "NEW",
            "TRANSFEREE"});
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "EnrollmentType";
            this.dataGridViewTextBoxColumn12.HeaderText = "EnrollmentType";
            this.dataGridViewTextBoxColumn12.Items.AddRange(new object[] {
            "Grade 7",
            "Grade 8",
            "Grade 9",
            "Grade 10"});
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PaymentType
            // 
            this.PaymentType.DataPropertyName = "PaymentType";
            this.PaymentType.HeaderText = "PaymentType";
            this.PaymentType.Items.AddRange(new object[] {
            "Monthly",
            "Full"});
            this.PaymentType.Name = "PaymentType";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "MotherFirstName";
            this.dataGridViewTextBoxColumn14.HeaderText = "MotherFirstName";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "MotherLastName";
            this.dataGridViewTextBoxColumn15.HeaderText = "MotherLastName";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "MotherOccupation";
            this.dataGridViewTextBoxColumn16.HeaderText = "MotherOccupation";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "FatherFirstName";
            this.dataGridViewTextBoxColumn17.HeaderText = "FatherFirstName";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "FatherLastName";
            this.dataGridViewTextBoxColumn18.HeaderText = "FatherLastName";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "FatherOccupation";
            this.dataGridViewTextBoxColumn19.HeaderText = "FatherOccupation";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "StudForm137";
            this.dataGridViewImageColumn1.HeaderText = "StudForm137";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "LRN";
            this.dataGridViewTextBoxColumn20.HeaderText = "LRN";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "BirthCertificate";
            this.dataGridViewImageColumn2.HeaderText = "BirthCertificate";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.DataPropertyName = "GoodMoral";
            this.dataGridViewImageColumn3.HeaderText = "GoodMoral";
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.DataPropertyName = "TransferCertificate";
            this.dataGridViewImageColumn4.HeaderText = "TransferCertificate";
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmPendingRequirements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1298, 829);
            this.Controls.Add(this.studentsDataGridView);
            this.Controls.Add(this.studentsBindingNavigator);
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.showSearchButton);
            this.Controls.Add(this.searchPanel);
            this.Name = "frmPendingRequirements";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PendingRequirements";
            this.Load += new System.EventHandler(this.PendingRequirements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTU_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingNavigator)).EndInit();
            this.studentsBindingNavigator.ResumeLayout(false);
            this.studentsBindingNavigator.PerformLayout();
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private STU_DBDataSet sTU_DBDataSet;
        private System.Windows.Forms.TextBox studentNumberTextBox;
        private System.Windows.Forms.Button deleteTransferCertButton;
        private System.Windows.Forms.Button deleteGoodMoralButton;
        private System.Windows.Forms.Button deleteBirthCertButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox studFirstNameTextBox;
        private System.Windows.Forms.TextBox studMidNameTextBox;
        private System.Windows.Forms.TextBox studLastNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox contactNumTextBox;
        private System.Windows.Forms.BindingSource sectionsBindingSource;
        private System.Windows.Forms.BindingSource sectionsBindingSource1;
        private STU_DBDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private STU_DBDataSetTableAdapters.SectionsTableAdapter sectionsTableAdapter;
        private System.Windows.Forms.TextBox motherFirstNameTextBox;
        private System.Windows.Forms.TextBox motherLastNameTextBox;
        private System.Windows.Forms.TextBox motherOccupationTextBox;
        private System.Windows.Forms.TextBox fatherFirstNameTextBox;
        private System.Windows.Forms.TextBox fatherLastNameTextBox;
        private System.Windows.Forms.TextBox fatherOccupationTextBox;
        private System.Windows.Forms.TextBox lRNTextBox;
        private System.Windows.Forms.Button deleteFrm137Button;
        private System.Windows.Forms.TextBox genStudNumTextBox;
        private System.Windows.Forms.Button uploadBirthCertButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uploadTransferCertButton;
        private System.Windows.Forms.DataGridView studentsDataGridView;
        private System.Windows.Forms.BindingNavigator studentsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton studentsBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorRefreshItem;
        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.TextBox birthCertificateTextBox;
        private System.Windows.Forms.TextBox transferCertificateTextBox;
        private System.Windows.Forms.Button uploadFrm137Button;
        private System.Windows.Forms.Button viewFrm137Button;
        private System.Windows.Forms.TextBox studForm137TextBox;
        private System.Windows.Forms.Button viewBirthCertButton;
        private System.Windows.Forms.Button uploadGoodMoralButton;
        private System.Windows.Forms.Button viewTransferCertButton;
        private System.Windows.Forms.Button viewGoodMoralButton;
        private System.Windows.Forms.TextBox goodMoralTextBox;
        private System.Windows.Forms.TextBox birthDateTextBox;
        private System.Windows.Forms.Button showSearchButton;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label label2;
        private STU_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton bindingNavigatorUpdateRequirementsItem;
        private System.Windows.Forms.TextBox civilStatusTextBox;
        private System.Windows.Forms.TextBox enrollmentTypeTextBox;
        private System.Windows.Forms.TextBox paymentTypeTextBox;
        private System.Windows.Forms.TextBox sectionTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox enrollmentStatusTextBox;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripLabel studentNumberToolStripLabel;
        private System.Windows.Forms.ToolStripComboBox studentNumberToolStripComboBox;
        private System.Windows.Forms.ToolStripLabel studFirstNameToolStripLabel;
        private System.Windows.Forms.ToolStripComboBox studFirstNameToolStripComboBox;
        private System.Windows.Forms.ToolStripLabel studMidNameToolStripLabel;
        private System.Windows.Forms.ToolStripComboBox studMidNameToolStripComboBox;
        private System.Windows.Forms.ToolStripLabel studLastNameToolStripLabel;
        private System.Windows.Forms.ToolStripComboBox studLastNameToolStripComboBox;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
        private System.Windows.Forms.TextBox guardianEmailTextBox;
        private System.Windows.Forms.TextBox personalEmailTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonalEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuardianEmail;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewComboBoxColumn PaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewImageColumn4;
    }
}