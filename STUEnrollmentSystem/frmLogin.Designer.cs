namespace STUEnrollmentSystem
{
    partial class frmLogin
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
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.forgotPasswordButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.changePasswordPanel = new System.Windows.Forms.Panel();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.sendCodeButton = new System.Windows.Forms.Button();
            this.confirmUserIDTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            userIDLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.changePasswordPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.Location = new System.Drawing.Point(65, 277);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(101, 25);
            passwordLabel.TabIndex = 11;
            passwordLabel.Text = "Password:";
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userIDLabel.Location = new System.Drawing.Point(65, 227);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(79, 25);
            userIDLabel.TabIndex = 7;
            userIDLabel.Text = "User ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(36, 43);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(79, 25);
            label4.TabIndex = 16;
            label4.Text = "User ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(48, 120);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(62, 25);
            label5.TabIndex = 18;
            label5.Text = "Code:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(144, 30);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(141, 25);
            label6.TabIndex = 23;
            label6.Text = "New Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(206, 271);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(179, 31);
            this.passwordTextBox.TabIndex = 12;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDTextBox.Location = new System.Drawing.Point(206, 221);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(179, 31);
            this.userIDTextBox.TabIndex = 8;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.loginButton.FlatAppearance.BorderSize = 2;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(175, 352);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(95, 39);
            this.loginButton.TabIndex = 15;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // forgotPasswordButton
            // 
            this.forgotPasswordButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.forgotPasswordButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.forgotPasswordButton.FlatAppearance.BorderSize = 0;
            this.forgotPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgotPasswordButton.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPasswordButton.Location = new System.Drawing.Point(171, 396);
            this.forgotPasswordButton.Name = "forgotPasswordButton";
            this.forgotPasswordButton.Size = new System.Drawing.Size(105, 22);
            this.forgotPasswordButton.TabIndex = 16;
            this.forgotPasswordButton.Text = "Forgot password?";
            this.forgotPasswordButton.UseVisualStyleBackColor = false;
            this.forgotPasswordButton.Click += new System.EventHandler(this.forgotPasswordButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.emailTextBox);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.confirmButton);
            this.panel2.Controls.Add(this.changePasswordPanel);
            this.panel2.Controls.Add(this.codeTextBox);
            this.panel2.Controls.Add(this.sendCodeButton);
            this.panel2.Controls.Add(label5);
            this.panel2.Controls.Add(this.confirmUserIDTextBox);
            this.panel2.Controls.Add(label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 451);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 394);
            this.panel2.TabIndex = 22;
            this.panel2.Visible = false;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.MintCream;
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(266, 99);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(134, 13);
            this.emailTextBox.TabIndex = 26;
            this.emailTextBox.Text = "sample@gmail.com";
            this.emailTextBox.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MintCream;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(92, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 13);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "Please enter the code we sent to email: ";
            this.textBox1.Visible = false;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.confirmButton.Enabled = false;
            this.confirmButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.confirmButton.FlatAppearance.BorderSize = 2;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(320, 118);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(80, 30);
            this.confirmButton.TabIndex = 24;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // changePasswordPanel
            // 
            this.changePasswordPanel.BackColor = System.Drawing.Color.MintCream;
            this.changePasswordPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.changePasswordPanel.Controls.Add(this.saveChangesButton);
            this.changePasswordPanel.Controls.Add(this.showButton);
            this.changePasswordPanel.Controls.Add(label6);
            this.changePasswordPanel.Controls.Add(this.newPasswordTextBox);
            this.changePasswordPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.changePasswordPanel.Location = new System.Drawing.Point(0, 195);
            this.changePasswordPanel.Name = "changePasswordPanel";
            this.changePasswordPanel.Size = new System.Drawing.Size(439, 199);
            this.changePasswordPanel.TabIndex = 22;
            this.changePasswordPanel.Visible = false;
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.saveChangesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.saveChangesButton.FlatAppearance.BorderSize = 2;
            this.saveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveChangesButton.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesButton.Location = new System.Drawing.Point(165, 119);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(94, 30);
            this.saveChangesButton.TabIndex = 25;
            this.saveChangesButton.Text = "Save changes";
            this.saveChangesButton.UseVisualStyleBackColor = false;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.showButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.showButton.FlatAppearance.BorderSize = 2;
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.Location = new System.Drawing.Point(341, 75);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(50, 26);
            this.showButton.TabIndex = 23;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = false;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordTextBox.Location = new System.Drawing.Point(91, 72);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(235, 31);
            this.newPasswordTextBox.TabIndex = 21;
            this.newPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // codeTextBox
            // 
            this.codeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeTextBox.Location = new System.Drawing.Point(126, 118);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(179, 31);
            this.codeTextBox.TabIndex = 19;
            this.codeTextBox.TextChanged += new System.EventHandler(this.codeTextBox_TextChanged);
            // 
            // sendCodeButton
            // 
            this.sendCodeButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.sendCodeButton.Enabled = false;
            this.sendCodeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sendCodeButton.FlatAppearance.BorderSize = 2;
            this.sendCodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendCodeButton.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendCodeButton.Location = new System.Drawing.Point(320, 41);
            this.sendCodeButton.Name = "sendCodeButton";
            this.sendCodeButton.Size = new System.Drawing.Size(80, 30);
            this.sendCodeButton.TabIndex = 17;
            this.sendCodeButton.Text = "Send Code";
            this.sendCodeButton.UseVisualStyleBackColor = false;
            this.sendCodeButton.Click += new System.EventHandler(this.sendCodeButton_Click);
            // 
            // confirmUserIDTextBox
            // 
            this.confirmUserIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmUserIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmUserIDTextBox.Location = new System.Drawing.Point(126, 41);
            this.confirmUserIDTextBox.Name = "confirmUserIDTextBox";
            this.confirmUserIDTextBox.Size = new System.Drawing.Size(179, 31);
            this.confirmUserIDTextBox.TabIndex = 17;
            this.confirmUserIDTextBox.TextChanged += new System.EventHandler(this.confirmUserIDTextBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.Controls.Add(this.logoButton);
            this.panel1.Controls.Add(this.forgotPasswordButton);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(passwordLabel);
            this.panel1.Controls.Add(userIDLabel);
            this.panel1.Controls.Add(this.userIDTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 451);
            this.panel1.TabIndex = 15;
            // 
            // logoButton
            // 
            this.logoButton.BackColor = System.Drawing.Color.Transparent;
            this.logoButton.BackgroundImage = global::STUEnrollmentSystem.Properties.Resources.STU_LOGO;
            this.logoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoButton.FlatAppearance.BorderSize = 0;
            this.logoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.logoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.logoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoButton.Font = new System.Drawing.Font("Subway", 36F, System.Drawing.FontStyle.Bold);
            this.logoButton.Location = new System.Drawing.Point(151, 15);
            this.logoButton.Name = "logoButton";
            this.logoButton.Size = new System.Drawing.Size(140, 123);
            this.logoButton.TabIndex = 17;
            this.logoButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Login";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STU Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.changePasswordPanel.ResumeLayout(false);
            this.changePasswordPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button forgotPasswordButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Panel changePasswordPanel;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Button sendCodeButton;
        private System.Windows.Forms.TextBox confirmUserIDTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoButton;
        private System.Windows.Forms.Label label2;
    }
}