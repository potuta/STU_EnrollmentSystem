namespace STUEnrollmentSystem
{
    partial class frmSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.schoolYearButton = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.systemLogsButton = new System.Windows.Forms.Button();
            this.userProfileButton = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Subway", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Settings";
            // 
            // schoolYearButton
            // 
            this.schoolYearButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.schoolYearButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.schoolYearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.schoolYearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolYearButton.Location = new System.Drawing.Point(187, 0);
            this.schoolYearButton.Name = "schoolYearButton";
            this.schoolYearButton.Size = new System.Drawing.Size(133, 53);
            this.schoolYearButton.TabIndex = 7;
            this.schoolYearButton.Text = "School Year";
            this.schoolYearButton.UseVisualStyleBackColor = false;
            this.schoolYearButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.userProfileButton);
            this.panelHeader.Controls.Add(this.systemLogsButton);
            this.panelHeader.Controls.Add(this.schoolYearButton);
            this.panelHeader.Controls.Add(this.settingsPanel);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 53);
            this.panelHeader.TabIndex = 8;
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.label1);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.settingsPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(187, 53);
            this.settingsPanel.TabIndex = 9;
            // 
            // systemLogsButton
            // 
            this.systemLogsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.systemLogsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.systemLogsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.systemLogsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemLogsButton.Location = new System.Drawing.Point(320, 0);
            this.systemLogsButton.Name = "systemLogsButton";
            this.systemLogsButton.Size = new System.Drawing.Size(133, 53);
            this.systemLogsButton.TabIndex = 10;
            this.systemLogsButton.Text = "System Logs";
            this.systemLogsButton.UseVisualStyleBackColor = false;
            this.systemLogsButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // userProfileButton
            // 
            this.userProfileButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userProfileButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.userProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userProfileButton.Location = new System.Drawing.Point(453, 0);
            this.userProfileButton.Name = "userProfileButton";
            this.userProfileButton.Size = new System.Drawing.Size(133, 53);
            this.userProfileButton.TabIndex = 11;
            this.userProfileButton.Text = "User Profile";
            this.userProfileButton.UseVisualStyleBackColor = false;
            this.userProfileButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 53);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 397);
            this.panelMain.TabIndex = 9;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.panelHeader.ResumeLayout(false);
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button schoolYearButton;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Button systemLogsButton;
        private System.Windows.Forms.Button userProfileButton;
        private System.Windows.Forms.Panel panelMain;
    }
}