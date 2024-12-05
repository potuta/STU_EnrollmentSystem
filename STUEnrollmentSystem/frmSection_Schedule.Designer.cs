namespace STUEnrollmentSystem
{
    partial class frmSection_Schedule
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
            this.schedulesButton = new System.Windows.Forms.Button();
            this.sectionsButton = new System.Windows.Forms.Button();
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
            this.panelMain.TabIndex = 11;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelHeader.Controls.Add(this.schedulesButton);
            this.panelHeader.Controls.Add(this.sectionsButton);
            this.panelHeader.Controls.Add(this.section_SchedulePanel);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1264, 47);
            this.panelHeader.TabIndex = 10;
            // 
            // schedulesButton
            // 
            this.schedulesButton.BackColor = System.Drawing.Color.MintCream;
            this.schedulesButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.schedulesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.schedulesButton.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedulesButton.Location = new System.Drawing.Point(350, 0);
            this.schedulesButton.Name = "schedulesButton";
            this.schedulesButton.Size = new System.Drawing.Size(133, 47);
            this.schedulesButton.TabIndex = 10;
            this.schedulesButton.Text = "Schedules";
            this.schedulesButton.UseVisualStyleBackColor = false;
            this.schedulesButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // sectionsButton
            // 
            this.sectionsButton.BackColor = System.Drawing.Color.MintCream;
            this.sectionsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.sectionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sectionsButton.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionsButton.Location = new System.Drawing.Point(217, 0);
            this.sectionsButton.Name = "sectionsButton";
            this.sectionsButton.Size = new System.Drawing.Size(133, 47);
            this.sectionsButton.TabIndex = 7;
            this.sectionsButton.Text = "Sections";
            this.sectionsButton.UseVisualStyleBackColor = false;
            this.sectionsButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // section_SchedulePanel
            // 
            this.section_SchedulePanel.Controls.Add(this.label1);
            this.section_SchedulePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.section_SchedulePanel.Location = new System.Drawing.Point(0, 0);
            this.section_SchedulePanel.Name = "section_SchedulePanel";
            this.section_SchedulePanel.Size = new System.Drawing.Size(217, 47);
            this.section_SchedulePanel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Section and Schedule";
            // 
            // frmSection_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 759);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "frmSection_Schedule";
            this.Text = "frmSection_Schedule";
            this.panelHeader.ResumeLayout(false);
            this.section_SchedulePanel.ResumeLayout(false);
            this.section_SchedulePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button schedulesButton;
        private System.Windows.Forms.Button sectionsButton;
        private System.Windows.Forms.Panel section_SchedulePanel;
        private System.Windows.Forms.Label label1;
    }
}