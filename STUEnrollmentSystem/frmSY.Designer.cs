namespace STUEnrollmentSystem
{
    partial class frmSY
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
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.currentYearRadioButton = new System.Windows.Forms.RadioButton();
            this.addSchoolYearButton = new System.Windows.Forms.Button();
            this.deleteSchoolYearButton = new System.Windows.Forms.Button();
            this.selectSchoolYearButton = new System.Windows.Forms.Button();
            this.schoolYearLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Subway", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage School Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "School year(s):";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.currentYearRadioButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(85, 142);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(627, 217);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // currentYearRadioButton
            // 
            this.currentYearRadioButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.currentYearRadioButton.FlatAppearance.BorderSize = 0;
            this.currentYearRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentYearRadioButton.ForeColor = System.Drawing.SystemColors.Window;
            this.currentYearRadioButton.Location = new System.Drawing.Point(3, 3);
            this.currentYearRadioButton.Name = "currentYearRadioButton";
            this.currentYearRadioButton.Size = new System.Drawing.Size(124, 34);
            this.currentYearRadioButton.TabIndex = 8;
            this.currentYearRadioButton.TabStop = true;
            this.currentYearRadioButton.Text = "Current year";
            this.currentYearRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.currentYearRadioButton.UseVisualStyleBackColor = false;
            this.currentYearRadioButton.Visible = false;
            // 
            // addSchoolYearButton
            // 
            this.addSchoolYearButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addSchoolYearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addSchoolYearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSchoolYearButton.Location = new System.Drawing.Point(537, 113);
            this.addSchoolYearButton.Name = "addSchoolYearButton";
            this.addSchoolYearButton.Size = new System.Drawing.Size(75, 23);
            this.addSchoolYearButton.TabIndex = 4;
            this.addSchoolYearButton.Text = "Add S.Y.";
            this.addSchoolYearButton.UseVisualStyleBackColor = false;
            this.addSchoolYearButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // deleteSchoolYearButton
            // 
            this.deleteSchoolYearButton.BackColor = System.Drawing.Color.LightCoral;
            this.deleteSchoolYearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteSchoolYearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSchoolYearButton.Location = new System.Drawing.Point(628, 113);
            this.deleteSchoolYearButton.Name = "deleteSchoolYearButton";
            this.deleteSchoolYearButton.Size = new System.Drawing.Size(84, 23);
            this.deleteSchoolYearButton.TabIndex = 5;
            this.deleteSchoolYearButton.Text = "Delete S.Y.";
            this.deleteSchoolYearButton.UseVisualStyleBackColor = false;
            this.deleteSchoolYearButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // selectSchoolYearButton
            // 
            this.selectSchoolYearButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.selectSchoolYearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectSchoolYearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectSchoolYearButton.Location = new System.Drawing.Point(333, 386);
            this.selectSchoolYearButton.Name = "selectSchoolYearButton";
            this.selectSchoolYearButton.Size = new System.Drawing.Size(118, 40);
            this.selectSchoolYearButton.TabIndex = 6;
            this.selectSchoolYearButton.Text = "Select S.Y.";
            this.selectSchoolYearButton.UseVisualStyleBackColor = false;
            this.selectSchoolYearButton.Click += new System.EventHandler(this.OnButtonClicked);
            // 
            // schoolYearLabel
            // 
            this.schoolYearLabel.AutoSize = true;
            this.schoolYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolYearLabel.Location = new System.Drawing.Point(212, 116);
            this.schoolYearLabel.Name = "schoolYearLabel";
            this.schoolYearLabel.Size = new System.Drawing.Size(188, 18);
            this.schoolYearLabel.TabIndex = 7;
            this.schoolYearLabel.Text = "------------------------------";
            // 
            // frmSY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.schoolYearLabel);
            this.Controls.Add(this.selectSchoolYearButton);
            this.Controls.Add(this.deleteSchoolYearButton);
            this.Controls.Add(this.addSchoolYearButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Name = "frmSY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSY";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addSchoolYearButton;
        private System.Windows.Forms.Button deleteSchoolYearButton;
        private System.Windows.Forms.Button selectSchoolYearButton;
        private System.Windows.Forms.RadioButton currentYearRadioButton;
        private System.Windows.Forms.Label schoolYearLabel;
    }
}