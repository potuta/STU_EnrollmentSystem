namespace STUEnrollmentSystem
{
    partial class frmUsers_Roles
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.rolesButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.section_SchedulePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.section_SchedulePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.MintCream;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 47);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1264, 712);
            this.panelMain.TabIndex = 15;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelHeader.Controls.Add(this.rolesButton);
            this.panelHeader.Controls.Add(this.usersButton);
            this.panelHeader.Controls.Add(this.section_SchedulePanel);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1264, 47);
            this.panelHeader.TabIndex = 14;
            // 
            // rolesButton
            // 
            this.rolesButton.BackColor = System.Drawing.Color.MintCream;
            this.rolesButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.rolesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rolesButton.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolesButton.Location = new System.Drawing.Point(332, 0);
            this.rolesButton.Name = "rolesButton";
            this.rolesButton.Size = new System.Drawing.Size(133, 47);
            this.rolesButton.TabIndex = 10;
            this.rolesButton.Text = "Roles";
            this.rolesButton.UseVisualStyleBackColor = false;
            this.rolesButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // usersButton
            // 
            this.usersButton.BackColor = System.Drawing.Color.MintCream;
            this.usersButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.usersButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.usersButton.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersButton.Location = new System.Drawing.Point(199, 0);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(133, 47);
            this.usersButton.TabIndex = 7;
            this.usersButton.Text = "Users";
            this.usersButton.UseVisualStyleBackColor = false;
            this.usersButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // section_SchedulePanel
            // 
            this.section_SchedulePanel.Controls.Add(this.label1);
            this.section_SchedulePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.section_SchedulePanel.Location = new System.Drawing.Point(0, 0);
            this.section_SchedulePanel.Name = "section_SchedulePanel";
            this.section_SchedulePanel.Size = new System.Drawing.Size(199, 47);
            this.section_SchedulePanel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Users and Roles";
            // 
            // frmUsers_Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 759);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "frmUsers_Roles";
            this.Text = "frmUsers_Roles";
            this.panelHeader.ResumeLayout(false);
            this.section_SchedulePanel.ResumeLayout(false);
            this.section_SchedulePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button rolesButton;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Panel section_SchedulePanel;
        private System.Windows.Forms.Label label1;
    }
}