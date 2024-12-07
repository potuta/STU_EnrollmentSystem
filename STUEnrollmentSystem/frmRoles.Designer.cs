namespace STUEnrollmentSystem
{
    partial class frmRoles
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.users_RolesCheckBox = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.teachersCheckBox = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.level_SubjectsCheckBox = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.section_ScheduleCheckBox = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.paymentTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.feesCheckBox = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.academicCheckBox = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.billingReportCheckBox = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.managePaymentsCheckBox = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pendingRequirementsCheckBox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.manageStudentsCheckBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.approvedStudentsCheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.registrationCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.facultyCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.billingCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.studentRecordsCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.enrollmentCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 62);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Roles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Role ID: ";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Admission",
            "Cashier",
            "Registrar"});
            this.comboBox1.Location = new System.Drawing.Point(90, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.saveChangesButton);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 999);
            this.panel3.TabIndex = 18;
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.saveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveChangesButton.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesButton.Location = new System.Drawing.Point(68, 85);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(90, 27);
            this.saveChangesButton.TabIndex = 18;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.users_RolesCheckBox);
            this.mainPanel.Controls.Add(this.label18);
            this.mainPanel.Controls.Add(this.teachersCheckBox);
            this.mainPanel.Controls.Add(this.label19);
            this.mainPanel.Controls.Add(this.level_SubjectsCheckBox);
            this.mainPanel.Controls.Add(this.label17);
            this.mainPanel.Controls.Add(this.section_ScheduleCheckBox);
            this.mainPanel.Controls.Add(this.label16);
            this.mainPanel.Controls.Add(this.paymentTypeCheckBox);
            this.mainPanel.Controls.Add(this.label14);
            this.mainPanel.Controls.Add(this.feesCheckBox);
            this.mainPanel.Controls.Add(this.label15);
            this.mainPanel.Controls.Add(this.academicCheckBox);
            this.mainPanel.Controls.Add(this.label13);
            this.mainPanel.Controls.Add(this.billingReportCheckBox);
            this.mainPanel.Controls.Add(this.label11);
            this.mainPanel.Controls.Add(this.managePaymentsCheckBox);
            this.mainPanel.Controls.Add(this.label12);
            this.mainPanel.Controls.Add(this.pendingRequirementsCheckBox);
            this.mainPanel.Controls.Add(this.label10);
            this.mainPanel.Controls.Add(this.manageStudentsCheckBox);
            this.mainPanel.Controls.Add(this.label9);
            this.mainPanel.Controls.Add(this.approvedStudentsCheckBox);
            this.mainPanel.Controls.Add(this.label8);
            this.mainPanel.Controls.Add(this.registrationCheckBox);
            this.mainPanel.Controls.Add(this.label7);
            this.mainPanel.Controls.Add(this.facultyCheckBox);
            this.mainPanel.Controls.Add(this.label6);
            this.mainPanel.Controls.Add(this.billingCheckBox);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.studentRecordsCheckBox);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.enrollmentCheckBox);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(237, 62);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1027, 999);
            this.mainPanel.TabIndex = 20;
            // 
            // users_RolesCheckBox
            // 
            this.users_RolesCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.users_RolesCheckBox.AutoSize = true;
            this.users_RolesCheckBox.Location = new System.Drawing.Point(239, 745);
            this.users_RolesCheckBox.Name = "users_RolesCheckBox";
            this.users_RolesCheckBox.Size = new System.Drawing.Size(33, 23);
            this.users_RolesCheckBox.TabIndex = 39;
            this.users_RolesCheckBox.Text = "ON";
            this.users_RolesCheckBox.UseVisualStyleBackColor = true;
            this.users_RolesCheckBox.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(74, 745);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(159, 23);
            this.label18.TabIndex = 38;
            this.label18.Text = "↪ Users and Roles:";
            // 
            // teachersCheckBox
            // 
            this.teachersCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.teachersCheckBox.AutoSize = true;
            this.teachersCheckBox.Location = new System.Drawing.Point(190, 710);
            this.teachersCheckBox.Name = "teachersCheckBox";
            this.teachersCheckBox.Size = new System.Drawing.Size(33, 23);
            this.teachersCheckBox.TabIndex = 37;
            this.teachersCheckBox.Text = "ON";
            this.teachersCheckBox.UseVisualStyleBackColor = true;
            this.teachersCheckBox.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(74, 710);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(106, 23);
            this.label19.TabIndex = 36;
            this.label19.Text = "↪ Teachers:";
            // 
            // level_SubjectsCheckBox
            // 
            this.level_SubjectsCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.level_SubjectsCheckBox.AutoSize = true;
            this.level_SubjectsCheckBox.Location = new System.Drawing.Point(309, 611);
            this.level_SubjectsCheckBox.Name = "level_SubjectsCheckBox";
            this.level_SubjectsCheckBox.Size = new System.Drawing.Size(33, 23);
            this.level_SubjectsCheckBox.TabIndex = 35;
            this.level_SubjectsCheckBox.Text = "ON";
            this.level_SubjectsCheckBox.UseVisualStyleBackColor = true;
            this.level_SubjectsCheckBox.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(74, 608);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(229, 23);
            this.label17.TabIndex = 34;
            this.label17.Text = "↪ Grade Level and Subjects:";
            // 
            // section_ScheduleCheckBox
            // 
            this.section_ScheduleCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.section_ScheduleCheckBox.AutoSize = true;
            this.section_ScheduleCheckBox.Location = new System.Drawing.Point(289, 568);
            this.section_ScheduleCheckBox.Name = "section_ScheduleCheckBox";
            this.section_ScheduleCheckBox.Size = new System.Drawing.Size(33, 23);
            this.section_ScheduleCheckBox.TabIndex = 33;
            this.section_ScheduleCheckBox.Text = "ON";
            this.section_ScheduleCheckBox.UseVisualStyleBackColor = true;
            this.section_ScheduleCheckBox.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(74, 568);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(209, 23);
            this.label16.TabIndex = 32;
            this.label16.Text = "↪ Sections and Schedule:";
            // 
            // paymentTypeCheckBox
            // 
            this.paymentTypeCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.paymentTypeCheckBox.AutoSize = true;
            this.paymentTypeCheckBox.Location = new System.Drawing.Point(223, 528);
            this.paymentTypeCheckBox.Name = "paymentTypeCheckBox";
            this.paymentTypeCheckBox.Size = new System.Drawing.Size(33, 23);
            this.paymentTypeCheckBox.TabIndex = 31;
            this.paymentTypeCheckBox.Text = "ON";
            this.paymentTypeCheckBox.UseVisualStyleBackColor = true;
            this.paymentTypeCheckBox.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(74, 528);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 23);
            this.label14.TabIndex = 30;
            this.label14.Text = "↪ Payment Type:";
            // 
            // feesCheckBox
            // 
            this.feesCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.feesCheckBox.AutoSize = true;
            this.feesCheckBox.Location = new System.Drawing.Point(152, 493);
            this.feesCheckBox.Name = "feesCheckBox";
            this.feesCheckBox.Size = new System.Drawing.Size(33, 23);
            this.feesCheckBox.TabIndex = 29;
            this.feesCheckBox.Text = "ON";
            this.feesCheckBox.UseVisualStyleBackColor = true;
            this.feesCheckBox.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(74, 493);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 23);
            this.label15.TabIndex = 28;
            this.label15.Text = "↪ Fees:";
            // 
            // academicCheckBox
            // 
            this.academicCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.academicCheckBox.AutoSize = true;
            this.academicCheckBox.Location = new System.Drawing.Point(129, 445);
            this.academicCheckBox.Name = "academicCheckBox";
            this.academicCheckBox.Size = new System.Drawing.Size(33, 23);
            this.academicCheckBox.TabIndex = 27;
            this.academicCheckBox.Text = "ON";
            this.academicCheckBox.UseVisualStyleBackColor = true;
            this.academicCheckBox.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(24, 443);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 25);
            this.label13.TabIndex = 26;
            this.label13.Text = "Academic:";
            // 
            // billingReportCheckBox
            // 
            this.billingReportCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.billingReportCheckBox.AutoSize = true;
            this.billingReportCheckBox.Location = new System.Drawing.Point(217, 387);
            this.billingReportCheckBox.Name = "billingReportCheckBox";
            this.billingReportCheckBox.Size = new System.Drawing.Size(33, 23);
            this.billingReportCheckBox.TabIndex = 25;
            this.billingReportCheckBox.Text = "ON";
            this.billingReportCheckBox.UseVisualStyleBackColor = true;
            this.billingReportCheckBox.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(74, 387);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 23);
            this.label11.TabIndex = 24;
            this.label11.Text = "↪ Billing Report:";
            // 
            // managePaymentsCheckBox
            // 
            this.managePaymentsCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.managePaymentsCheckBox.AutoSize = true;
            this.managePaymentsCheckBox.Location = new System.Drawing.Point(254, 352);
            this.managePaymentsCheckBox.Name = "managePaymentsCheckBox";
            this.managePaymentsCheckBox.Size = new System.Drawing.Size(33, 23);
            this.managePaymentsCheckBox.TabIndex = 23;
            this.managePaymentsCheckBox.Text = "ON";
            this.managePaymentsCheckBox.UseVisualStyleBackColor = true;
            this.managePaymentsCheckBox.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(74, 352);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 23);
            this.label12.TabIndex = 22;
            this.label12.Text = "↪ Manage Payments:";
            // 
            // pendingRequirementsCheckBox
            // 
            this.pendingRequirementsCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.pendingRequirementsCheckBox.AutoSize = true;
            this.pendingRequirementsCheckBox.Location = new System.Drawing.Point(287, 247);
            this.pendingRequirementsCheckBox.Name = "pendingRequirementsCheckBox";
            this.pendingRequirementsCheckBox.Size = new System.Drawing.Size(33, 23);
            this.pendingRequirementsCheckBox.TabIndex = 21;
            this.pendingRequirementsCheckBox.Text = "ON";
            this.pendingRequirementsCheckBox.UseVisualStyleBackColor = true;
            this.pendingRequirementsCheckBox.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(73, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 23);
            this.label10.TabIndex = 20;
            this.label10.Text = "↪ Pending Requirements:";
            // 
            // manageStudentsCheckBox
            // 
            this.manageStudentsCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.manageStudentsCheckBox.AutoSize = true;
            this.manageStudentsCheckBox.Location = new System.Drawing.Point(246, 212);
            this.manageStudentsCheckBox.Name = "manageStudentsCheckBox";
            this.manageStudentsCheckBox.Size = new System.Drawing.Size(33, 23);
            this.manageStudentsCheckBox.TabIndex = 19;
            this.manageStudentsCheckBox.Text = "ON";
            this.manageStudentsCheckBox.UseVisualStyleBackColor = true;
            this.manageStudentsCheckBox.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(73, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "↪ Manage Students:";
            // 
            // approvedStudentsCheckBox
            // 
            this.approvedStudentsCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.approvedStudentsCheckBox.AutoSize = true;
            this.approvedStudentsCheckBox.Location = new System.Drawing.Point(262, 102);
            this.approvedStudentsCheckBox.Name = "approvedStudentsCheckBox";
            this.approvedStudentsCheckBox.Size = new System.Drawing.Size(33, 23);
            this.approvedStudentsCheckBox.TabIndex = 17;
            this.approvedStudentsCheckBox.Text = "ON";
            this.approvedStudentsCheckBox.UseVisualStyleBackColor = true;
            this.approvedStudentsCheckBox.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(74, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "↪ Approved Students:";
            // 
            // registrationCheckBox
            // 
            this.registrationCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.registrationCheckBox.AutoSize = true;
            this.registrationCheckBox.Location = new System.Drawing.Point(207, 67);
            this.registrationCheckBox.Name = "registrationCheckBox";
            this.registrationCheckBox.Size = new System.Drawing.Size(33, 23);
            this.registrationCheckBox.TabIndex = 15;
            this.registrationCheckBox.Text = "ON";
            this.registrationCheckBox.UseVisualStyleBackColor = true;
            this.registrationCheckBox.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "↪ Registration:";
            // 
            // facultyCheckBox
            // 
            this.facultyCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.facultyCheckBox.AutoSize = true;
            this.facultyCheckBox.Location = new System.Drawing.Point(113, 665);
            this.facultyCheckBox.Name = "facultyCheckBox";
            this.facultyCheckBox.Size = new System.Drawing.Size(33, 23);
            this.facultyCheckBox.TabIndex = 13;
            this.facultyCheckBox.Text = "ON";
            this.facultyCheckBox.UseVisualStyleBackColor = true;
            this.facultyCheckBox.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 663);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Faculty:";
            // 
            // billingCheckBox
            // 
            this.billingCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.billingCheckBox.AutoSize = true;
            this.billingCheckBox.Location = new System.Drawing.Point(101, 309);
            this.billingCheckBox.Name = "billingCheckBox";
            this.billingCheckBox.Size = new System.Drawing.Size(33, 23);
            this.billingCheckBox.TabIndex = 11;
            this.billingCheckBox.Text = "ON";
            this.billingCheckBox.UseVisualStyleBackColor = true;
            this.billingCheckBox.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Billing:";
            // 
            // studentRecordsCheckBox
            // 
            this.studentRecordsCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.studentRecordsCheckBox.AutoSize = true;
            this.studentRecordsCheckBox.Location = new System.Drawing.Point(189, 161);
            this.studentRecordsCheckBox.Name = "studentRecordsCheckBox";
            this.studentRecordsCheckBox.Size = new System.Drawing.Size(33, 23);
            this.studentRecordsCheckBox.TabIndex = 9;
            this.studentRecordsCheckBox.Text = "ON";
            this.studentRecordsCheckBox.UseVisualStyleBackColor = true;
            this.studentRecordsCheckBox.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Student Records:";
            // 
            // enrollmentCheckBox
            // 
            this.enrollmentCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.enrollmentCheckBox.AutoSize = true;
            this.enrollmentCheckBox.Location = new System.Drawing.Point(140, 27);
            this.enrollmentCheckBox.Name = "enrollmentCheckBox";
            this.enrollmentCheckBox.Size = new System.Drawing.Size(33, 23);
            this.enrollmentCheckBox.TabIndex = 7;
            this.enrollmentCheckBox.Text = "ON";
            this.enrollmentCheckBox.UseVisualStyleBackColor = true;
            this.enrollmentCheckBox.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enrollment:";
            // 
            // frmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 1061);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmRoles";
            this.Text = "frmRoles";
            this.Load += new System.EventHandler(this.frmRoles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.CheckBox enrollmentCheckBox;
        private System.Windows.Forms.CheckBox studentRecordsCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox billingCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox facultyCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox registrationCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox approvedStudentsCheckBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox manageStudentsCheckBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox pendingRequirementsCheckBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox billingReportCheckBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox managePaymentsCheckBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox academicCheckBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox paymentTypeCheckBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox feesCheckBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox section_ScheduleCheckBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox level_SubjectsCheckBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox users_RolesCheckBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox teachersCheckBox;
        private System.Windows.Forms.Label label19;
    }
}