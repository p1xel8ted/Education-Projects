namespace ABC_Management_Studio
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.cmbSemesters = new System.Windows.Forms.ComboBox();
            this.lblSemesters = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbSemesters
            // 
            this.cmbSemesters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemesters.FormattingEnabled = true;
            this.cmbSemesters.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbSemesters.Location = new System.Drawing.Point(12, 25);
            this.cmbSemesters.Name = "cmbSemesters";
            this.cmbSemesters.Size = new System.Drawing.Size(121, 21);
            this.cmbSemesters.TabIndex = 1;
            // 
            // lblSemesters
            // 
            this.lblSemesters.AutoSize = true;
            this.lblSemesters.Location = new System.Drawing.Point(9, 9);
            this.lblSemesters.Name = "lblSemesters";
            this.lblSemesters.Size = new System.Drawing.Size(100, 13);
            this.lblSemesters.TabIndex = 0;
            this.lblSemesters.Text = "Semesters per year:";
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(153, 62);
            this.Controls.Add(this.lblSemesters);
            this.Controls.Add(this.cmbSemesters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSettings_FormClosing);
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSemesters;
        private System.Windows.Forms.Label lblSemesters;
    }
}