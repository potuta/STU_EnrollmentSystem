namespace STUEnrollmentSystem
{
    partial class frmGradeLevel_Subjects
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
            this.subjectsButton = new System.Windows.Forms.Button();
            this.gradeLevelButton = new System.Windows.Forms.Button();
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
            this.panelMain.TabIndex = 13;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelHeader.Controls.Add(this.subjectsButton);
            this.panelHeader.Controls.Add(this.gradeLevelButton);
            this.panelHeader.Controls.Add(this.section_SchedulePanel);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1264, 47);
            this.panelHeader.TabIndex = 12;
            // 
            // subjectsButton
            // 
            this.subjectsButton.BackColor = System.Drawing.Color.MintCream;
            this.subjectsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.subjectsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subjectsButton.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectsButton.Location = new System.Drawing.Point(332, 0);
            this.subjectsButton.Name = "subjectsButton";
            this.subjectsButton.Size = new System.Drawing.Size(133, 47);
            this.subjectsButton.TabIndex = 10;
            this.subjectsButton.Text = "Subjects";
            this.subjectsButton.UseVisualStyleBackColor = false;
            this.subjectsButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // gradeLevelButton
            // 
            this.gradeLevelButton.BackColor = System.Drawing.Color.MintCream;
            this.gradeLevelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradeLevelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gradeLevelButton.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeLevelButton.Location = new System.Drawing.Point(199, 0);
            this.gradeLevelButton.Name = "gradeLevelButton";
            this.gradeLevelButton.Size = new System.Drawing.Size(133, 47);
            this.gradeLevelButton.TabIndex = 7;
            this.gradeLevelButton.Text = "Grade Level";
            this.gradeLevelButton.UseVisualStyleBackColor = false;
            this.gradeLevelButton.Click += new System.EventHandler(this.OnButtonClicked);
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
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Level and Subjects";
            // 
            // frmGradeLevel_Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 759);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "frmGradeLevel_Subjects";
            this.Text = "frmGradeLevel_Subjects";
            this.panelHeader.ResumeLayout(false);
            this.section_SchedulePanel.ResumeLayout(false);
            this.section_SchedulePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button subjectsButton;
        private System.Windows.Forms.Button gradeLevelButton;
        private System.Windows.Forms.Panel section_SchedulePanel;
        private System.Windows.Forms.Label label1;
    }
}