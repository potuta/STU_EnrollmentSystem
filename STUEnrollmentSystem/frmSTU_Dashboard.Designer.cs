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
            this.userInfoPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.adminSubPanel = new System.Windows.Forms.Panel();
            this.usersButton = new System.Windows.Forms.Button();
            this.subjectButton = new System.Windows.Forms.Button();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.sectionButton = new System.Windows.Forms.Button();
            this.teacherButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.cashierSubPanel = new System.Windows.Forms.Panel();
            this.pricesButton = new System.Windows.Forms.Button();
            this.paymentTypeButton = new System.Windows.Forms.Button();
            this.pendingButton = new System.Windows.Forms.Button();
            this.managePaymentButton = new System.Windows.Forms.Button();
            this.cashierButton = new System.Windows.Forms.Button();
            this.studentSubPanel = new System.Windows.Forms.Panel();
            this.pendingRequirementsButton = new System.Windows.Forms.Button();
            this.manageStudentButton = new System.Windows.Forms.Button();
            this.registrationButton = new System.Windows.Forms.Button();
            this.studentButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.sidePanel.SuspendLayout();
            this.userInfoPanel.SuspendLayout();
            this.adminSubPanel.SuspendLayout();
            this.cashierSubPanel.SuspendLayout();
            this.studentSubPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.AutoScroll = true;
            this.sidePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sidePanel.Controls.Add(this.userInfoPanel);
            this.sidePanel.Controls.Add(this.adminSubPanel);
            this.sidePanel.Controls.Add(this.adminButton);
            this.sidePanel.Controls.Add(this.cashierSubPanel);
            this.sidePanel.Controls.Add(this.cashierButton);
            this.sidePanel.Controls.Add(this.studentSubPanel);
            this.sidePanel.Controls.Add(this.studentButton);
            this.sidePanel.Controls.Add(this.logoPanel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(280, 681);
            this.sidePanel.TabIndex = 0;
            // 
            // userInfoPanel
            // 
            this.userInfoPanel.Controls.Add(this.label3);
            this.userInfoPanel.Controls.Add(this.roleLabel);
            this.userInfoPanel.Controls.Add(this.logoutButton);
            this.userInfoPanel.Controls.Add(this.userLabel);
            this.userInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userInfoPanel.Location = new System.Drawing.Point(0, 1021);
            this.userInfoPanel.Name = "userInfoPanel";
            this.userInfoPanel.Size = new System.Drawing.Size(263, 128);
            this.userInfoPanel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Subway", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Profile:";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Subway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.Location = new System.Drawing.Point(13, 90);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(113, 17);
            this.roleLabel.TabIndex = 8;
            this.roleLabel.Text = "Role: ----------";
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.logoutButton.FlatAppearance.BorderSize = 2;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Subway", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(177, 82);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(71, 25);
            this.logoutButton.TabIndex = 7;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Subway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(13, 59);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(113, 17);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "User: ----------";
            // 
            // adminSubPanel
            // 
            this.adminSubPanel.Controls.Add(this.usersButton);
            this.adminSubPanel.Controls.Add(this.subjectButton);
            this.adminSubPanel.Controls.Add(this.scheduleButton);
            this.adminSubPanel.Controls.Add(this.sectionButton);
            this.adminSubPanel.Controls.Add(this.teacherButton);
            this.adminSubPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminSubPanel.Location = new System.Drawing.Point(0, 745);
            this.adminSubPanel.Name = "adminSubPanel";
            this.adminSubPanel.Size = new System.Drawing.Size(263, 276);
            this.adminSubPanel.TabIndex = 2;
            // 
            // usersButton
            // 
            this.usersButton.BackColor = System.Drawing.Color.Silver;
            this.usersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.usersButton.FlatAppearance.BorderSize = 2;
            this.usersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersButton.Font = new System.Drawing.Font("Subway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersButton.Location = new System.Drawing.Point(0, 220);
            this.usersButton.Name = "usersButton";
            this.usersButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.usersButton.Size = new System.Drawing.Size(263, 56);
            this.usersButton.TabIndex = 6;
            this.usersButton.Text = "↪ Users";
            this.usersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersButton.UseVisualStyleBackColor = false;
            this.usersButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // subjectButton
            // 
            this.subjectButton.BackColor = System.Drawing.Color.Silver;
            this.subjectButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.subjectButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.subjectButton.FlatAppearance.BorderSize = 2;
            this.subjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjectButton.Font = new System.Drawing.Font("Subway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectButton.Location = new System.Drawing.Point(0, 165);
            this.subjectButton.Name = "subjectButton";
            this.subjectButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.subjectButton.Size = new System.Drawing.Size(263, 55);
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
            this.scheduleButton.Font = new System.Drawing.Font("Subway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleButton.Location = new System.Drawing.Point(0, 110);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.scheduleButton.Size = new System.Drawing.Size(263, 55);
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
            this.sectionButton.Font = new System.Drawing.Font("Subway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionButton.Location = new System.Drawing.Point(0, 55);
            this.sectionButton.Name = "sectionButton";
            this.sectionButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.sectionButton.Size = new System.Drawing.Size(263, 55);
            this.sectionButton.TabIndex = 2;
            this.sectionButton.Text = "↪ Section";
            this.sectionButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sectionButton.UseVisualStyleBackColor = false;
            this.sectionButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // teacherButton
            // 
            this.teacherButton.BackColor = System.Drawing.Color.Silver;
            this.teacherButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.teacherButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.teacherButton.FlatAppearance.BorderSize = 2;
            this.teacherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacherButton.Font = new System.Drawing.Font("Subway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherButton.Location = new System.Drawing.Point(0, 0);
            this.teacherButton.Name = "teacherButton";
            this.teacherButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.teacherButton.Size = new System.Drawing.Size(263, 55);
            this.teacherButton.TabIndex = 1;
            this.teacherButton.Text = "↪ Teacher";
            this.teacherButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.teacherButton.UseVisualStyleBackColor = false;
            this.teacherButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // adminButton
            // 
            this.adminButton.BackColor = System.Drawing.Color.AliceBlue;
            this.adminButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.adminButton.FlatAppearance.BorderSize = 2;
            this.adminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminButton.Font = new System.Drawing.Font("Subway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminButton.Location = new System.Drawing.Point(0, 690);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(263, 55);
            this.adminButton.TabIndex = 2;
            this.adminButton.Text = "Administrator";
            this.adminButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminButton.UseVisualStyleBackColor = false;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // cashierSubPanel
            // 
            this.cashierSubPanel.Controls.Add(this.pricesButton);
            this.cashierSubPanel.Controls.Add(this.paymentTypeButton);
            this.cashierSubPanel.Controls.Add(this.pendingButton);
            this.cashierSubPanel.Controls.Add(this.managePaymentButton);
            this.cashierSubPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cashierSubPanel.Location = new System.Drawing.Point(0, 470);
            this.cashierSubPanel.Name = "cashierSubPanel";
            this.cashierSubPanel.Size = new System.Drawing.Size(263, 220);
            this.cashierSubPanel.TabIndex = 1;
            // 
            // pricesButton
            // 
            this.pricesButton.BackColor = System.Drawing.Color.Silver;
            this.pricesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pricesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.pricesButton.FlatAppearance.BorderSize = 2;
            this.pricesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pricesButton.Font = new System.Drawing.Font("Subway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricesButton.Location = new System.Drawing.Point(0, 165);
            this.pricesButton.Name = "pricesButton";
            this.pricesButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.pricesButton.Size = new System.Drawing.Size(263, 55);
            this.pricesButton.TabIndex = 4;
            this.pricesButton.Text = "↪ Prices";
            this.pricesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pricesButton.UseVisualStyleBackColor = false;
            this.pricesButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // paymentTypeButton
            // 
            this.paymentTypeButton.BackColor = System.Drawing.Color.Silver;
            this.paymentTypeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.paymentTypeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.paymentTypeButton.FlatAppearance.BorderSize = 2;
            this.paymentTypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentTypeButton.Font = new System.Drawing.Font("Subway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTypeButton.Location = new System.Drawing.Point(0, 110);
            this.paymentTypeButton.Name = "paymentTypeButton";
            this.paymentTypeButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.paymentTypeButton.Size = new System.Drawing.Size(263, 55);
            this.paymentTypeButton.TabIndex = 3;
            this.paymentTypeButton.Text = "↪ Payment Type";
            this.paymentTypeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paymentTypeButton.UseVisualStyleBackColor = false;
            this.paymentTypeButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // pendingButton
            // 
            this.pendingButton.BackColor = System.Drawing.Color.Silver;
            this.pendingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pendingButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.pendingButton.FlatAppearance.BorderSize = 2;
            this.pendingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pendingButton.Font = new System.Drawing.Font("Subway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingButton.Location = new System.Drawing.Point(0, 55);
            this.pendingButton.Name = "pendingButton";
            this.pendingButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.pendingButton.Size = new System.Drawing.Size(263, 55);
            this.pendingButton.TabIndex = 2;
            this.pendingButton.Text = "↪ Pending New Students";
            this.pendingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pendingButton.UseVisualStyleBackColor = false;
            this.pendingButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // managePaymentButton
            // 
            this.managePaymentButton.BackColor = System.Drawing.Color.Silver;
            this.managePaymentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.managePaymentButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.managePaymentButton.FlatAppearance.BorderSize = 2;
            this.managePaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managePaymentButton.Font = new System.Drawing.Font("Subway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managePaymentButton.Location = new System.Drawing.Point(0, 0);
            this.managePaymentButton.Name = "managePaymentButton";
            this.managePaymentButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.managePaymentButton.Size = new System.Drawing.Size(263, 55);
            this.managePaymentButton.TabIndex = 1;
            this.managePaymentButton.Text = "↪ Manage Payments";
            this.managePaymentButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.managePaymentButton.UseVisualStyleBackColor = false;
            this.managePaymentButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // cashierButton
            // 
            this.cashierButton.BackColor = System.Drawing.Color.AliceBlue;
            this.cashierButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.cashierButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cashierButton.FlatAppearance.BorderSize = 2;
            this.cashierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierButton.Font = new System.Drawing.Font("Subway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierButton.Location = new System.Drawing.Point(0, 415);
            this.cashierButton.Name = "cashierButton";
            this.cashierButton.Size = new System.Drawing.Size(263, 55);
            this.cashierButton.TabIndex = 1;
            this.cashierButton.Text = "Cashier";
            this.cashierButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cashierButton.UseVisualStyleBackColor = false;
            this.cashierButton.Click += new System.EventHandler(this.cashierButton_Click);
            // 
            // studentSubPanel
            // 
            this.studentSubPanel.Controls.Add(this.pendingRequirementsButton);
            this.studentSubPanel.Controls.Add(this.manageStudentButton);
            this.studentSubPanel.Controls.Add(this.registrationButton);
            this.studentSubPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.studentSubPanel.Location = new System.Drawing.Point(0, 249);
            this.studentSubPanel.Name = "studentSubPanel";
            this.studentSubPanel.Size = new System.Drawing.Size(263, 166);
            this.studentSubPanel.TabIndex = 0;
            // 
            // pendingRequirementsButton
            // 
            this.pendingRequirementsButton.BackColor = System.Drawing.Color.Silver;
            this.pendingRequirementsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pendingRequirementsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.pendingRequirementsButton.FlatAppearance.BorderSize = 2;
            this.pendingRequirementsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pendingRequirementsButton.Font = new System.Drawing.Font("Subway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingRequirementsButton.Location = new System.Drawing.Point(0, 110);
            this.pendingRequirementsButton.Name = "pendingRequirementsButton";
            this.pendingRequirementsButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.pendingRequirementsButton.Size = new System.Drawing.Size(263, 55);
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
            this.manageStudentButton.Font = new System.Drawing.Font("Subway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageStudentButton.Location = new System.Drawing.Point(0, 55);
            this.manageStudentButton.Name = "manageStudentButton";
            this.manageStudentButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.manageStudentButton.Size = new System.Drawing.Size(263, 55);
            this.manageStudentButton.TabIndex = 2;
            this.manageStudentButton.Text = "↪ Manage Students";
            this.manageStudentButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageStudentButton.UseVisualStyleBackColor = false;
            this.manageStudentButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // registrationButton
            // 
            this.registrationButton.BackColor = System.Drawing.Color.Silver;
            this.registrationButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.registrationButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.registrationButton.FlatAppearance.BorderSize = 2;
            this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationButton.Font = new System.Drawing.Font("Subway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationButton.Location = new System.Drawing.Point(0, 0);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.registrationButton.Size = new System.Drawing.Size(263, 55);
            this.registrationButton.TabIndex = 1;
            this.registrationButton.Text = "↪ Registration";
            this.registrationButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // studentButton
            // 
            this.studentButton.BackColor = System.Drawing.Color.AliceBlue;
            this.studentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.studentButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.studentButton.FlatAppearance.BorderSize = 2;
            this.studentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentButton.Font = new System.Drawing.Font("Subway", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentButton.Location = new System.Drawing.Point(0, 194);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(263, 55);
            this.studentButton.TabIndex = 0;
            this.studentButton.Text = "Student";
            this.studentButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentButton.UseVisualStyleBackColor = false;
            this.studentButton.Click += new System.EventHandler(this.studentButton_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.Controls.Add(this.label2);
            this.logoPanel.Controls.Add(this.label1);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(263, 194);
            this.logoPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Subway", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "- Enrollment System -";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Subway", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "STU";
            // 
            // panel_main
            // 
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(280, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1084, 681);
            this.panel_main.TabIndex = 1;
            // 
            // frmSTU_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1364, 681);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.sidePanel);
            this.Name = "frmSTU_Dashboard";
            this.Text = "STU";
            this.Load += new System.EventHandler(this.STU_Dashboard_Load);
            this.sidePanel.ResumeLayout(false);
            this.userInfoPanel.ResumeLayout(false);
            this.userInfoPanel.PerformLayout();
            this.adminSubPanel.ResumeLayout(false);
            this.cashierSubPanel.ResumeLayout(false);
            this.studentSubPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
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
        private System.Windows.Forms.Button cashierButton;
        private System.Windows.Forms.Panel cashierSubPanel;
        private System.Windows.Forms.Button pendingButton;
        private System.Windows.Forms.Button managePaymentButton;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Panel adminSubPanel;
        private System.Windows.Forms.Button sectionButton;
        private System.Windows.Forms.Button teacherButton;
        private System.Windows.Forms.Button subjectButton;
        private System.Windows.Forms.Button scheduleButton;
        private System.Windows.Forms.Button pricesButton;
        private System.Windows.Forms.Button paymentTypeButton;
        private System.Windows.Forms.Button pendingRequirementsButton;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel userInfoPanel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label label3;
    }
}

