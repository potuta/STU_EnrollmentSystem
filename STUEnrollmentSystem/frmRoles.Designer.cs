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
            this.rolesComboBox = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.UsersRoles_SubModule = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Teachers_SubModule = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.GradeLevelSubjects_SubModule = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.SectionsSchedule_SubModule = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.PaymentType_SubModule = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Fees_SubModule = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Academic_Module = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.BillingReport_SubModule = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ManagePayments_SubModule = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PendingRequirements_SubModule = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ManageStudents_SubModule = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ApprovedStudents_SubModule = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Registration_SubModule = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Faculty_Module = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Billing_Module = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StudentRecords_Module = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Enrollment_Module = new System.Windows.Forms.CheckBox();
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
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Roles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Roles:";
            // 
            // rolesComboBox
            // 
            this.rolesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rolesComboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolesComboBox.FormattingEnabled = true;
            this.rolesComboBox.Location = new System.Drawing.Point(84, 26);
            this.rolesComboBox.Name = "rolesComboBox";
            this.rolesComboBox.Size = new System.Drawing.Size(121, 28);
            this.rolesComboBox.TabIndex = 17;
            this.rolesComboBox.TextChanged += new System.EventHandler(this.rolesComboBox_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.saveChangesButton);
            this.panel3.Controls.Add(this.rolesComboBox);
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
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Controls.Add(this.UsersRoles_SubModule);
            this.mainPanel.Controls.Add(this.label18);
            this.mainPanel.Controls.Add(this.Teachers_SubModule);
            this.mainPanel.Controls.Add(this.label19);
            this.mainPanel.Controls.Add(this.GradeLevelSubjects_SubModule);
            this.mainPanel.Controls.Add(this.label17);
            this.mainPanel.Controls.Add(this.SectionsSchedule_SubModule);
            this.mainPanel.Controls.Add(this.label16);
            this.mainPanel.Controls.Add(this.PaymentType_SubModule);
            this.mainPanel.Controls.Add(this.label14);
            this.mainPanel.Controls.Add(this.Fees_SubModule);
            this.mainPanel.Controls.Add(this.label15);
            this.mainPanel.Controls.Add(this.Academic_Module);
            this.mainPanel.Controls.Add(this.label13);
            this.mainPanel.Controls.Add(this.BillingReport_SubModule);
            this.mainPanel.Controls.Add(this.label11);
            this.mainPanel.Controls.Add(this.ManagePayments_SubModule);
            this.mainPanel.Controls.Add(this.label12);
            this.mainPanel.Controls.Add(this.PendingRequirements_SubModule);
            this.mainPanel.Controls.Add(this.label10);
            this.mainPanel.Controls.Add(this.ManageStudents_SubModule);
            this.mainPanel.Controls.Add(this.label9);
            this.mainPanel.Controls.Add(this.ApprovedStudents_SubModule);
            this.mainPanel.Controls.Add(this.label8);
            this.mainPanel.Controls.Add(this.Registration_SubModule);
            this.mainPanel.Controls.Add(this.label7);
            this.mainPanel.Controls.Add(this.Faculty_Module);
            this.mainPanel.Controls.Add(this.label6);
            this.mainPanel.Controls.Add(this.Billing_Module);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.StudentRecords_Module);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.Enrollment_Module);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(237, 62);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1027, 999);
            this.mainPanel.TabIndex = 20;
            // 
            // UsersRoles_SubModule
            // 
            this.UsersRoles_SubModule.Appearance = System.Windows.Forms.Appearance.Button;
            this.UsersRoles_SubModule.AutoSize = true;
            this.UsersRoles_SubModule.Location = new System.Drawing.Point(239, 745);
            this.UsersRoles_SubModule.Name = "UsersRoles_SubModule";
            this.UsersRoles_SubModule.Size = new System.Drawing.Size(33, 23);
            this.UsersRoles_SubModule.TabIndex = 39;
            this.UsersRoles_SubModule.Text = "ON";
            this.UsersRoles_SubModule.UseVisualStyleBackColor = true;
            this.UsersRoles_SubModule.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
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
            // Teachers_SubModule
            // 
            this.Teachers_SubModule.Appearance = System.Windows.Forms.Appearance.Button;
            this.Teachers_SubModule.AutoSize = true;
            this.Teachers_SubModule.Location = new System.Drawing.Point(190, 710);
            this.Teachers_SubModule.Name = "Teachers_SubModule";
            this.Teachers_SubModule.Size = new System.Drawing.Size(33, 23);
            this.Teachers_SubModule.TabIndex = 37;
            this.Teachers_SubModule.Text = "ON";
            this.Teachers_SubModule.UseVisualStyleBackColor = true;
            this.Teachers_SubModule.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
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
            // GradeLevelSubjects_SubModule
            // 
            this.GradeLevelSubjects_SubModule.Appearance = System.Windows.Forms.Appearance.Button;
            this.GradeLevelSubjects_SubModule.AutoSize = true;
            this.GradeLevelSubjects_SubModule.Location = new System.Drawing.Point(309, 611);
            this.GradeLevelSubjects_SubModule.Name = "GradeLevelSubjects_SubModule";
            this.GradeLevelSubjects_SubModule.Size = new System.Drawing.Size(33, 23);
            this.GradeLevelSubjects_SubModule.TabIndex = 35;
            this.GradeLevelSubjects_SubModule.Text = "ON";
            this.GradeLevelSubjects_SubModule.UseVisualStyleBackColor = true;
            this.GradeLevelSubjects_SubModule.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
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
            // SectionsSchedule_SubModule
            // 
            this.SectionsSchedule_SubModule.Appearance = System.Windows.Forms.Appearance.Button;
            this.SectionsSchedule_SubModule.AutoSize = true;
            this.SectionsSchedule_SubModule.Location = new System.Drawing.Point(289, 568);
            this.SectionsSchedule_SubModule.Name = "SectionsSchedule_SubModule";
            this.SectionsSchedule_SubModule.Size = new System.Drawing.Size(33, 23);
            this.SectionsSchedule_SubModule.TabIndex = 33;
            this.SectionsSchedule_SubModule.Text = "ON";
            this.SectionsSchedule_SubModule.UseVisualStyleBackColor = true;
            this.SectionsSchedule_SubModule.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
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
            // PaymentType_SubModule
            // 
            this.PaymentType_SubModule.Appearance = System.Windows.Forms.Appearance.Button;
            this.PaymentType_SubModule.AutoSize = true;
            this.PaymentType_SubModule.Location = new System.Drawing.Point(223, 528);
            this.PaymentType_SubModule.Name = "PaymentType_SubModule";
            this.PaymentType_SubModule.Size = new System.Drawing.Size(33, 23);
            this.PaymentType_SubModule.TabIndex = 31;
            this.PaymentType_SubModule.Text = "ON";
            this.PaymentType_SubModule.UseVisualStyleBackColor = true;
            this.PaymentType_SubModule.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
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
            // Fees_SubModule
            // 
            this.Fees_SubModule.Appearance = System.Windows.Forms.Appearance.Button;
            this.Fees_SubModule.AutoSize = true;
            this.Fees_SubModule.Location = new System.Drawing.Point(152, 493);
            this.Fees_SubModule.Name = "Fees_SubModule";
            this.Fees_SubModule.Size = new System.Drawing.Size(33, 23);
            this.Fees_SubModule.TabIndex = 29;
            this.Fees_SubModule.Text = "ON";
            this.Fees_SubModule.UseVisualStyleBackColor = true;
            this.Fees_SubModule.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
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
            // Academic_Module
            // 
            this.Academic_Module.Appearance = System.Windows.Forms.Appearance.Button;
            this.Academic_Module.AutoSize = true;
            this.Academic_Module.Location = new System.Drawing.Point(129, 445);
            this.Academic_Module.Name = "Academic_Module";
            this.Academic_Module.Size = new System.Drawing.Size(33, 23);
            this.Academic_Module.TabIndex = 27;
            this.Academic_Module.Text = "ON";
            this.Academic_Module.UseVisualStyleBackColor = true;
            this.Academic_Module.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
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
            // BillingReport_SubModule
            // 
            this.BillingReport_SubModule.Appearance = System.Windows.Forms.Appearance.Button;
            this.BillingReport_SubModule.AutoSize = true;
            this.BillingReport_SubModule.Location = new System.Drawing.Point(217, 387);
            this.BillingReport_SubModule.Name = "BillingReport_SubModule";
            this.BillingReport_SubModule.Size = new System.Drawing.Size(33, 23);
            this.BillingReport_SubModule.TabIndex = 25;
            this.BillingReport_SubModule.Text = "ON";
            this.BillingReport_SubModule.UseVisualStyleBackColor = true;
            this.BillingReport_SubModule.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
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
            // ManagePayments_SubModule
            // 
            this.ManagePayments_SubModule.Appearance = System.Windows.Forms.Appearance.Button;
            this.ManagePayments_SubModule.AutoSize = true;
            this.ManagePayments_SubModule.Location = new System.Drawing.Point(254, 352);
            this.ManagePayments_SubModule.Name = "ManagePayments_SubModule";
            this.ManagePayments_SubModule.Size = new System.Drawing.Size(33, 23);
            this.ManagePayments_SubModule.TabIndex = 23;
            this.ManagePayments_SubModule.Text = "ON";
            this.ManagePayments_SubModule.UseVisualStyleBackColor = true;
            this.ManagePayments_SubModule.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
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
            // PendingRequirements_SubModule
            // 
            this.PendingRequirements_SubModule.Appearance = System.Windows.Forms.Appearance.Button;
            this.PendingRequirements_SubModule.AutoSize = true;
            this.PendingRequirements_SubModule.Location = new System.Drawing.Point(287, 247);
            this.PendingRequirements_SubModule.Name = "PendingRequirements_SubModule";
            this.PendingRequirements_SubModule.Size = new System.Drawing.Size(33, 23);
            this.PendingRequirements_SubModule.TabIndex = 21;
            this.PendingRequirements_SubModule.Text = "ON";
            this.PendingRequirements_SubModule.UseVisualStyleBackColor = true;
            this.PendingRequirements_SubModule.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
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
            // ManageStudents_SubModule
            // 
            this.ManageStudents_SubModule.Appearance = System.Windows.Forms.Appearance.Button;
            this.ManageStudents_SubModule.AutoSize = true;
            this.ManageStudents_SubModule.Location = new System.Drawing.Point(246, 212);
            this.ManageStudents_SubModule.Name = "ManageStudents_SubModule";
            this.ManageStudents_SubModule.Size = new System.Drawing.Size(33, 23);
            this.ManageStudents_SubModule.TabIndex = 19;
            this.ManageStudents_SubModule.Text = "ON";
            this.ManageStudents_SubModule.UseVisualStyleBackColor = true;
            this.ManageStudents_SubModule.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
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
            // ApprovedStudents_SubModule
            // 
            this.ApprovedStudents_SubModule.Appearance = System.Windows.Forms.Appearance.Button;
            this.ApprovedStudents_SubModule.AutoSize = true;
            this.ApprovedStudents_SubModule.Location = new System.Drawing.Point(262, 102);
            this.ApprovedStudents_SubModule.Name = "ApprovedStudents_SubModule";
            this.ApprovedStudents_SubModule.Size = new System.Drawing.Size(33, 23);
            this.ApprovedStudents_SubModule.TabIndex = 17;
            this.ApprovedStudents_SubModule.Text = "ON";
            this.ApprovedStudents_SubModule.UseVisualStyleBackColor = true;
            this.ApprovedStudents_SubModule.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
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
            // Registration_SubModule
            // 
            this.Registration_SubModule.Appearance = System.Windows.Forms.Appearance.Button;
            this.Registration_SubModule.AutoSize = true;
            this.Registration_SubModule.Location = new System.Drawing.Point(207, 67);
            this.Registration_SubModule.Name = "Registration_SubModule";
            this.Registration_SubModule.Size = new System.Drawing.Size(33, 23);
            this.Registration_SubModule.TabIndex = 15;
            this.Registration_SubModule.Text = "ON";
            this.Registration_SubModule.UseVisualStyleBackColor = true;
            this.Registration_SubModule.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
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
            // Faculty_Module
            // 
            this.Faculty_Module.Appearance = System.Windows.Forms.Appearance.Button;
            this.Faculty_Module.AutoSize = true;
            this.Faculty_Module.Location = new System.Drawing.Point(113, 665);
            this.Faculty_Module.Name = "Faculty_Module";
            this.Faculty_Module.Size = new System.Drawing.Size(33, 23);
            this.Faculty_Module.TabIndex = 13;
            this.Faculty_Module.Text = "ON";
            this.Faculty_Module.UseVisualStyleBackColor = true;
            this.Faculty_Module.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
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
            // Billing_Module
            // 
            this.Billing_Module.Appearance = System.Windows.Forms.Appearance.Button;
            this.Billing_Module.AutoSize = true;
            this.Billing_Module.Location = new System.Drawing.Point(101, 309);
            this.Billing_Module.Name = "Billing_Module";
            this.Billing_Module.Size = new System.Drawing.Size(33, 23);
            this.Billing_Module.TabIndex = 11;
            this.Billing_Module.Text = "ON";
            this.Billing_Module.UseVisualStyleBackColor = true;
            this.Billing_Module.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
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
            // StudentRecords_Module
            // 
            this.StudentRecords_Module.Appearance = System.Windows.Forms.Appearance.Button;
            this.StudentRecords_Module.AutoSize = true;
            this.StudentRecords_Module.Location = new System.Drawing.Point(189, 161);
            this.StudentRecords_Module.Name = "StudentRecords_Module";
            this.StudentRecords_Module.Size = new System.Drawing.Size(33, 23);
            this.StudentRecords_Module.TabIndex = 9;
            this.StudentRecords_Module.Text = "ON";
            this.StudentRecords_Module.UseVisualStyleBackColor = true;
            this.StudentRecords_Module.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
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
            // Enrollment_Module
            // 
            this.Enrollment_Module.Appearance = System.Windows.Forms.Appearance.Button;
            this.Enrollment_Module.AutoSize = true;
            this.Enrollment_Module.Location = new System.Drawing.Point(140, 27);
            this.Enrollment_Module.Name = "Enrollment_Module";
            this.Enrollment_Module.Size = new System.Drawing.Size(33, 23);
            this.Enrollment_Module.TabIndex = 7;
            this.Enrollment_Module.Text = "ON";
            this.Enrollment_Module.UseVisualStyleBackColor = true;
            this.Enrollment_Module.CheckedChanged += new System.EventHandler(this.checkBox_Toggle_CheckedChanged);
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
        private System.Windows.Forms.ComboBox rolesComboBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.CheckBox Enrollment_Module;
        private System.Windows.Forms.CheckBox StudentRecords_Module;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Billing_Module;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Faculty_Module;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox Registration_SubModule;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ApprovedStudents_SubModule;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ManageStudents_SubModule;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox PendingRequirements_SubModule;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox BillingReport_SubModule;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox ManagePayments_SubModule;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox Academic_Module;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox PaymentType_SubModule;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox Fees_SubModule;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox SectionsSchedule_SubModule;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox GradeLevelSubjects_SubModule;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox UsersRoles_SubModule;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox Teachers_SubModule;
        private System.Windows.Forms.Label label19;
    }
}