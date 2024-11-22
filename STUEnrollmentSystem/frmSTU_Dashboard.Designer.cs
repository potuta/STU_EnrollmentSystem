namespace STUEnrollmentSystem
{
    partial class frmSTU_Dashboard
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
            this.sidePanel = new System.Windows.Forms.Panel();
            this.academicSubPanel = new System.Windows.Forms.Panel();
            this.gradeLevelButton = new System.Windows.Forms.Button();
            this.subjectButton = new System.Windows.Forms.Button();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.sectionButton = new System.Windows.Forms.Button();
            this.paymentTypeButton = new System.Windows.Forms.Button();
            this.feesButton = new System.Windows.Forms.Button();
            this.facultyButton = new System.Windows.Forms.Button();
            this.academicButton = new System.Windows.Forms.Button();
            this.billingSubPanel = new System.Windows.Forms.Panel();
            this.billingReportButton = new System.Windows.Forms.Button();
            this.managePaymentButton = new System.Windows.Forms.Button();
            this.billingButton = new System.Windows.Forms.Button();
            this.studentSubPanel = new System.Windows.Forms.Panel();
            this.pendingRequirementsButton = new System.Windows.Forms.Button();
            this.manageStudentButton = new System.Windows.Forms.Button();
            this.studentButton = new System.Windows.Forms.Button();
            this.enrollmentSubPanel = new System.Windows.Forms.Panel();
            this.pendingButton = new System.Windows.Forms.Button();
            this.registrationButton = new System.Windows.Forms.Button();
            this.enrollmentButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.schoolYearLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logoLabel = new System.Windows.Forms.Label();
            this.userInfoPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.facultySubPanel = new System.Windows.Forms.Panel();
            this.usersButton = new System.Windows.Forms.Button();
            this.teacherButton = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.homeButton = new System.Windows.Forms.Button();
            this.sidePanel.SuspendLayout();
            this.academicSubPanel.SuspendLayout();
            this.billingSubPanel.SuspendLayout();
            this.studentSubPanel.SuspendLayout();
            this.enrollmentSubPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.userInfoPanel.SuspendLayout();
            this.facultySubPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.AutoScroll = true;
            this.sidePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sidePanel.Controls.Add(this.userInfoPanel);
            this.sidePanel.Controls.Add(this.facultySubPanel);
            this.sidePanel.Controls.Add(this.facultyButton);
            this.sidePanel.Controls.Add(this.academicSubPanel);
            this.sidePanel.Controls.Add(this.academicButton);
            this.sidePanel.Controls.Add(this.billingSubPanel);
            this.sidePanel.Controls.Add(this.billingButton);
            this.sidePanel.Controls.Add(this.studentSubPanel);
            this.sidePanel.Controls.Add(this.studentButton);
            this.sidePanel.Controls.Add(this.enrollmentSubPanel);
            this.sidePanel.Controls.Add(this.enrollmentButton);
            this.sidePanel.Controls.Add(this.logoPanel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(280, 558);
            this.sidePanel.TabIndex = 0;
            // 
            // academicSubPanel
            // 
            this.academicSubPanel.Controls.Add(this.gradeLevelButton);
            this.academicSubPanel.Controls.Add(this.subjectButton);
            this.academicSubPanel.Controls.Add(this.scheduleButton);
            this.academicSubPanel.Controls.Add(this.sectionButton);
            this.academicSubPanel.Controls.Add(this.paymentTypeButton);
            this.academicSubPanel.Controls.Add(this.feesButton);
            this.academicSubPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.academicSubPanel.Location = new System.Drawing.Point(0, 559);
            this.academicSubPanel.Name = "academicSubPanel";
            this.academicSubPanel.Size = new System.Drawing.Size(263, 235);
            this.academicSubPanel.TabIndex = 6;
            this.academicSubPanel.Visible = false;
            // 
            // gradeLevelButton
            // 
            this.gradeLevelButton.BackColor = System.Drawing.Color.Silver;
            this.gradeLevelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradeLevelButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.gradeLevelButton.FlatAppearance.BorderSize = 2;
            this.gradeLevelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradeLevelButton.Font = new System.Drawing.Font("Subway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeLevelButton.Location = new System.Drawing.Point(0, 195);
            this.gradeLevelButton.Name = "gradeLevelButton";
            this.gradeLevelButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.gradeLevelButton.Size = new System.Drawing.Size(263, 39);
            this.gradeLevelButton.TabIndex = 6;
            this.gradeLevelButton.Text = "↪ Grade Level";
            this.gradeLevelButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gradeLevelButton.UseVisualStyleBackColor = false;
            this.gradeLevelButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // subjectButton
            // 
            this.subjectButton.BackColor = System.Drawing.Color.Silver;
            this.subjectButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.subjectButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.subjectButton.FlatAppearance.BorderSize = 2;
            this.subjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjectButton.Font = new System.Drawing.Font("Subway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectButton.Location = new System.Drawing.Point(0, 156);
            this.subjectButton.Name = "subjectButton";
            this.subjectButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.subjectButton.Size = new System.Drawing.Size(263, 39);
            this.subjectButton.TabIndex = 5;
            this.subjectButton.Text = "↪ Subject";
            this.subjectButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subjectButton.UseVisualStyleBackColor = false;
            this.subjectButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // scheduleButton
            // 
            this.scheduleButton.BackColor = System.Drawing.Color.Silver;
            this.scheduleButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.scheduleButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.scheduleButton.FlatAppearance.BorderSize = 2;
            this.scheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scheduleButton.Font = new System.Drawing.Font("Subway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleButton.Location = new System.Drawing.Point(0, 117);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.scheduleButton.Size = new System.Drawing.Size(263, 39);
            this.scheduleButton.TabIndex = 3;
            this.scheduleButton.Text = "↪ Schedule";
            this.scheduleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scheduleButton.UseVisualStyleBackColor = false;
            this.scheduleButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // sectionButton
            // 
            this.sectionButton.BackColor = System.Drawing.Color.Silver;
            this.sectionButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.sectionButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sectionButton.FlatAppearance.BorderSize = 2;
            this.sectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sectionButton.Font = new System.Drawing.Font("Subway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionButton.Location = new System.Drawing.Point(0, 78);
            this.sectionButton.Name = "sectionButton";
            this.sectionButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.sectionButton.Size = new System.Drawing.Size(263, 39);
            this.sectionButton.TabIndex = 2;
            this.sectionButton.Text = "↪ Section";
            this.sectionButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sectionButton.UseVisualStyleBackColor = false;
            this.sectionButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // paymentTypeButton
            // 
            this.paymentTypeButton.BackColor = System.Drawing.Color.Silver;
            this.paymentTypeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.paymentTypeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.paymentTypeButton.FlatAppearance.BorderSize = 2;
            this.paymentTypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentTypeButton.Font = new System.Drawing.Font("Subway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTypeButton.Location = new System.Drawing.Point(0, 39);
            this.paymentTypeButton.Name = "paymentTypeButton";
            this.paymentTypeButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.paymentTypeButton.Size = new System.Drawing.Size(263, 39);
            this.paymentTypeButton.TabIndex = 3;
            this.paymentTypeButton.Text = "↪ Payment Type";
            this.paymentTypeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paymentTypeButton.UseVisualStyleBackColor = false;
            this.paymentTypeButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // feesButton
            // 
            this.feesButton.BackColor = System.Drawing.Color.Silver;
            this.feesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.feesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.feesButton.FlatAppearance.BorderSize = 2;
            this.feesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feesButton.Font = new System.Drawing.Font("Subway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesButton.Location = new System.Drawing.Point(0, 0);
            this.feesButton.Name = "feesButton";
            this.feesButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.feesButton.Size = new System.Drawing.Size(263, 39);
            this.feesButton.TabIndex = 4;
            this.feesButton.Text = "↪ Fees";
            this.feesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.feesButton.UseVisualStyleBackColor = false;
            this.feesButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // facultyButton
            // 
            this.facultyButton.BackColor = System.Drawing.Color.AliceBlue;
            this.facultyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.facultyButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.facultyButton.FlatAppearance.BorderSize = 2;
            this.facultyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.facultyButton.Font = new System.Drawing.Font("Subway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultyButton.Location = new System.Drawing.Point(0, 794);
            this.facultyButton.Name = "facultyButton";
            this.facultyButton.Size = new System.Drawing.Size(263, 39);
            this.facultyButton.TabIndex = 2;
            this.facultyButton.Text = "Faculty";
            this.facultyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.facultyButton.UseVisualStyleBackColor = false;
            this.facultyButton.Click += new System.EventHandler(this.facultyButton_Click);
            // 
            // academicButton
            // 
            this.academicButton.BackColor = System.Drawing.Color.AliceBlue;
            this.academicButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.academicButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.academicButton.FlatAppearance.BorderSize = 2;
            this.academicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.academicButton.Font = new System.Drawing.Font("Subway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.academicButton.Location = new System.Drawing.Point(0, 520);
            this.academicButton.Name = "academicButton";
            this.academicButton.Size = new System.Drawing.Size(263, 39);
            this.academicButton.TabIndex = 5;
            this.academicButton.Text = "Academic";
            this.academicButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.academicButton.UseVisualStyleBackColor = false;
            this.academicButton.Click += new System.EventHandler(this.academicButton_Click);
            // 
            // billingSubPanel
            // 
            this.billingSubPanel.Controls.Add(this.billingReportButton);
            this.billingSubPanel.Controls.Add(this.managePaymentButton);
            this.billingSubPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.billingSubPanel.Location = new System.Drawing.Point(0, 443);
            this.billingSubPanel.Name = "billingSubPanel";
            this.billingSubPanel.Size = new System.Drawing.Size(263, 77);
            this.billingSubPanel.TabIndex = 1;
            this.billingSubPanel.Visible = false;
            // 
            // billingReportButton
            // 
            this.billingReportButton.BackColor = System.Drawing.Color.Silver;
            this.billingReportButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.billingReportButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.billingReportButton.FlatAppearance.BorderSize = 2;
            this.billingReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billingReportButton.Font = new System.Drawing.Font("Subway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingReportButton.Location = new System.Drawing.Point(0, 39);
            this.billingReportButton.Name = "billingReportButton";
            this.billingReportButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.billingReportButton.Size = new System.Drawing.Size(263, 39);
            this.billingReportButton.TabIndex = 5;
            this.billingReportButton.Text = "↪ Billing Report";
            this.billingReportButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.billingReportButton.UseVisualStyleBackColor = false;
            this.billingReportButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // managePaymentButton
            // 
            this.managePaymentButton.BackColor = System.Drawing.Color.Silver;
            this.managePaymentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.managePaymentButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.managePaymentButton.FlatAppearance.BorderSize = 2;
            this.managePaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managePaymentButton.Font = new System.Drawing.Font("Subway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managePaymentButton.Location = new System.Drawing.Point(0, 0);
            this.managePaymentButton.Name = "managePaymentButton";
            this.managePaymentButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.managePaymentButton.Size = new System.Drawing.Size(263, 39);
            this.managePaymentButton.TabIndex = 1;
            this.managePaymentButton.Text = "↪ Manage Payments";
            this.managePaymentButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.managePaymentButton.UseVisualStyleBackColor = false;
            this.managePaymentButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // billingButton
            // 
            this.billingButton.BackColor = System.Drawing.Color.AliceBlue;
            this.billingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.billingButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.billingButton.FlatAppearance.BorderSize = 2;
            this.billingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billingButton.Font = new System.Drawing.Font("Subway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingButton.Location = new System.Drawing.Point(0, 404);
            this.billingButton.Name = "billingButton";
            this.billingButton.Size = new System.Drawing.Size(263, 39);
            this.billingButton.TabIndex = 1;
            this.billingButton.Text = "Billing ";
            this.billingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.billingButton.UseVisualStyleBackColor = false;
            this.billingButton.Click += new System.EventHandler(this.billingButton_Click);
            // 
            // studentSubPanel
            // 
            this.studentSubPanel.Controls.Add(this.pendingRequirementsButton);
            this.studentSubPanel.Controls.Add(this.manageStudentButton);
            this.studentSubPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.studentSubPanel.Location = new System.Drawing.Point(0, 327);
            this.studentSubPanel.Name = "studentSubPanel";
            this.studentSubPanel.Size = new System.Drawing.Size(263, 77);
            this.studentSubPanel.TabIndex = 0;
            this.studentSubPanel.Visible = false;
            // 
            // pendingRequirementsButton
            // 
            this.pendingRequirementsButton.BackColor = System.Drawing.Color.Silver;
            this.pendingRequirementsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pendingRequirementsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.pendingRequirementsButton.FlatAppearance.BorderSize = 2;
            this.pendingRequirementsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pendingRequirementsButton.Font = new System.Drawing.Font("Subway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingRequirementsButton.Location = new System.Drawing.Point(0, 39);
            this.pendingRequirementsButton.Name = "pendingRequirementsButton";
            this.pendingRequirementsButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.pendingRequirementsButton.Size = new System.Drawing.Size(263, 39);
            this.pendingRequirementsButton.TabIndex = 3;
            this.pendingRequirementsButton.Text = "↪ Pending Requirements";
            this.pendingRequirementsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pendingRequirementsButton.UseVisualStyleBackColor = false;
            this.pendingRequirementsButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // manageStudentButton
            // 
            this.manageStudentButton.BackColor = System.Drawing.Color.Silver;
            this.manageStudentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.manageStudentButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.manageStudentButton.FlatAppearance.BorderSize = 2;
            this.manageStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageStudentButton.Font = new System.Drawing.Font("Subway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageStudentButton.Location = new System.Drawing.Point(0, 0);
            this.manageStudentButton.Name = "manageStudentButton";
            this.manageStudentButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.manageStudentButton.Size = new System.Drawing.Size(263, 39);
            this.manageStudentButton.TabIndex = 2;
            this.manageStudentButton.Text = "↪ Manage Students";
            this.manageStudentButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageStudentButton.UseVisualStyleBackColor = false;
            this.manageStudentButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // studentButton
            // 
            this.studentButton.BackColor = System.Drawing.Color.AliceBlue;
            this.studentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.studentButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.studentButton.FlatAppearance.BorderSize = 2;
            this.studentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentButton.Font = new System.Drawing.Font("Subway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentButton.Location = new System.Drawing.Point(0, 288);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(263, 39);
            this.studentButton.TabIndex = 0;
            this.studentButton.Text = "Student Records";
            this.studentButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentButton.UseVisualStyleBackColor = false;
            this.studentButton.Click += new System.EventHandler(this.studentButton_Click);
            // 
            // enrollmentSubPanel
            // 
            this.enrollmentSubPanel.Controls.Add(this.pendingButton);
            this.enrollmentSubPanel.Controls.Add(this.registrationButton);
            this.enrollmentSubPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.enrollmentSubPanel.Location = new System.Drawing.Point(0, 211);
            this.enrollmentSubPanel.Name = "enrollmentSubPanel";
            this.enrollmentSubPanel.Size = new System.Drawing.Size(263, 77);
            this.enrollmentSubPanel.TabIndex = 2;
            this.enrollmentSubPanel.Visible = false;
            // 
            // pendingButton
            // 
            this.pendingButton.BackColor = System.Drawing.Color.Silver;
            this.pendingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pendingButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.pendingButton.FlatAppearance.BorderSize = 2;
            this.pendingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pendingButton.Font = new System.Drawing.Font("Subway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingButton.Location = new System.Drawing.Point(0, 39);
            this.pendingButton.Name = "pendingButton";
            this.pendingButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.pendingButton.Size = new System.Drawing.Size(263, 39);
            this.pendingButton.TabIndex = 2;
            this.pendingButton.Text = "↪ Pending New Students";
            this.pendingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pendingButton.UseVisualStyleBackColor = false;
            this.pendingButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // registrationButton
            // 
            this.registrationButton.BackColor = System.Drawing.Color.Silver;
            this.registrationButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.registrationButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.registrationButton.FlatAppearance.BorderSize = 2;
            this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationButton.Font = new System.Drawing.Font("Subway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationButton.Location = new System.Drawing.Point(0, 0);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.registrationButton.Size = new System.Drawing.Size(263, 39);
            this.registrationButton.TabIndex = 1;
            this.registrationButton.Text = "↪ Registration";
            this.registrationButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // enrollmentButton
            // 
            this.enrollmentButton.BackColor = System.Drawing.Color.AliceBlue;
            this.enrollmentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.enrollmentButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.enrollmentButton.FlatAppearance.BorderSize = 2;
            this.enrollmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enrollmentButton.Font = new System.Drawing.Font("Subway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollmentButton.Location = new System.Drawing.Point(0, 172);
            this.enrollmentButton.Name = "enrollmentButton";
            this.enrollmentButton.Size = new System.Drawing.Size(263, 39);
            this.enrollmentButton.TabIndex = 2;
            this.enrollmentButton.Text = "Enrollment";
            this.enrollmentButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.enrollmentButton.UseVisualStyleBackColor = false;
            this.enrollmentButton.Click += new System.EventHandler(this.enrollmentButton_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.Controls.Add(this.homeButton);
            this.logoPanel.Controls.Add(this.settingsButton);
            this.logoPanel.Controls.Add(this.schoolYearLabel);
            this.logoPanel.Controls.Add(this.label2);
            this.logoPanel.Controls.Add(this.logoLabel);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(263, 172);
            this.logoPanel.TabIndex = 0;
            // 
            // settingsButton
            // 
            this.settingsButton.BackgroundImage = global::STUEnrollmentSystem.Properties.Resources.settings_982x1024;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Location = new System.Drawing.Point(246, 146);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(17, 16);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // schoolYearLabel
            // 
            this.schoolYearLabel.AutoSize = true;
            this.schoolYearLabel.Font = new System.Drawing.Font("Subway", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolYearLabel.Location = new System.Drawing.Point(6, 150);
            this.schoolYearLabel.Name = "schoolYearLabel";
            this.schoolYearLabel.Size = new System.Drawing.Size(32, 13);
            this.schoolYearLabel.TabIndex = 2;
            this.schoolYearLabel.Text = "S.Y.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Subway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "- Enrollment System -";
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Subway", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.Location = new System.Drawing.Point(70, 40);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(126, 54);
            this.logoLabel.TabIndex = 0;
            this.logoLabel.Text = "STU";
            this.logoLabel.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // userInfoPanel
            // 
            this.userInfoPanel.Controls.Add(this.label3);
            this.userInfoPanel.Controls.Add(this.roleLabel);
            this.userInfoPanel.Controls.Add(this.logoutButton);
            this.userInfoPanel.Controls.Add(this.userLabel);
            this.userInfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userInfoPanel.Location = new System.Drawing.Point(0, 913);
            this.userInfoPanel.Name = "userInfoPanel";
            this.userInfoPanel.Size = new System.Drawing.Size(263, 97);
            this.userInfoPanel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Subway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Profile:";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Subway", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.Location = new System.Drawing.Point(14, 72);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(79, 12);
            this.roleLabel.TabIndex = 8;
            this.roleLabel.Text = "Role: ----------";
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.logoutButton.FlatAppearance.BorderSize = 2;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Subway", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(178, 61);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(71, 23);
            this.logoutButton.TabIndex = 7;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Subway", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(14, 47);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(78, 12);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "User: ----------";
            // 
            // facultySubPanel
            // 
            this.facultySubPanel.Controls.Add(this.usersButton);
            this.facultySubPanel.Controls.Add(this.teacherButton);
            this.facultySubPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.facultySubPanel.Location = new System.Drawing.Point(0, 833);
            this.facultySubPanel.Name = "facultySubPanel";
            this.facultySubPanel.Size = new System.Drawing.Size(263, 80);
            this.facultySubPanel.TabIndex = 2;
            this.facultySubPanel.Visible = false;
            // 
            // usersButton
            // 
            this.usersButton.BackColor = System.Drawing.Color.Silver;
            this.usersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.usersButton.FlatAppearance.BorderSize = 2;
            this.usersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersButton.Font = new System.Drawing.Font("Subway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersButton.Location = new System.Drawing.Point(0, 39);
            this.usersButton.Name = "usersButton";
            this.usersButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.usersButton.Size = new System.Drawing.Size(263, 40);
            this.usersButton.TabIndex = 6;
            this.usersButton.Text = "↪ Users";
            this.usersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersButton.UseVisualStyleBackColor = false;
            this.usersButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // teacherButton
            // 
            this.teacherButton.BackColor = System.Drawing.Color.Silver;
            this.teacherButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.teacherButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.teacherButton.FlatAppearance.BorderSize = 2;
            this.teacherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacherButton.Font = new System.Drawing.Font("Subway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherButton.Location = new System.Drawing.Point(0, 0);
            this.teacherButton.Name = "teacherButton";
            this.teacherButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.teacherButton.Size = new System.Drawing.Size(263, 39);
            this.teacherButton.TabIndex = 1;
            this.teacherButton.Text = "↪ Teachers";
            this.teacherButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.teacherButton.UseVisualStyleBackColor = false;
            this.teacherButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // panel_main
            // 
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(280, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1084, 558);
            this.panel_main.TabIndex = 1;
            // 
            // homeButton
            // 
            this.homeButton.BackgroundImage = global::STUEnrollmentSystem.Properties.Resources.settings_982x1024;
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Location = new System.Drawing.Point(223, 146);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(17, 16);
            this.homeButton.TabIndex = 4;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // frmSTU_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1364, 558);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.sidePanel);
            this.Name = "frmSTU_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STU";
            this.Load += new System.EventHandler(this.STU_Dashboard_Load);
            this.sidePanel.ResumeLayout(false);
            this.academicSubPanel.ResumeLayout(false);
            this.billingSubPanel.ResumeLayout(false);
            this.studentSubPanel.ResumeLayout(false);
            this.enrollmentSubPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.userInfoPanel.ResumeLayout(false);
            this.userInfoPanel.PerformLayout();
            this.facultySubPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button studentButton;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel studentSubPanel;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Button manageStudentButton;
        private System.Windows.Forms.Button billingButton;
        private System.Windows.Forms.Panel billingSubPanel;
        private System.Windows.Forms.Button pendingButton;
        private System.Windows.Forms.Button managePaymentButton;
        private System.Windows.Forms.Button facultyButton;
        private System.Windows.Forms.Panel facultySubPanel;
        private System.Windows.Forms.Button sectionButton;
        private System.Windows.Forms.Button teacherButton;
        private System.Windows.Forms.Button subjectButton;
        private System.Windows.Forms.Button scheduleButton;
        private System.Windows.Forms.Button feesButton;
        private System.Windows.Forms.Button paymentTypeButton;
        private System.Windows.Forms.Button pendingRequirementsButton;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel userInfoPanel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label schoolYearLabel;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button enrollmentButton;
        private System.Windows.Forms.Panel enrollmentSubPanel;
        private System.Windows.Forms.Button billingReportButton;
        private System.Windows.Forms.Panel academicSubPanel;
        private System.Windows.Forms.Button academicButton;
        private System.Windows.Forms.Button gradeLevelButton;
        private System.Windows.Forms.Button homeButton;
    }
}

