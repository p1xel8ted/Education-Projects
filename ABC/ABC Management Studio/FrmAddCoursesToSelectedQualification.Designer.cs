namespace ABC_Management_Studio
{
    partial class FrmAddCoursesToSelectedQualification
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddCoursesToSelectedQualification));
            this.btnAdd = new System.Windows.Forms.Button();
            this.appIcons = new System.Windows.Forms.ImageList(this.components);
            this.clbCourses = new System.Windows.Forms.CheckedListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ttTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.ImageIndex = 2;
            this.btnAdd.ImageList = this.appIcons;
            this.btnAdd.Location = new System.Drawing.Point(12, 262);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 51);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ttTip.SetToolTip(this.btnAdd, "Add Courses to Selected Qualification.");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // appIcons
            // 
            this.appIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("appIcons.ImageStream")));
            this.appIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.appIcons.Images.SetKeyName(0, "add.png");
            this.appIcons.Images.SetKeyName(1, "remove.png");
            this.appIcons.Images.SetKeyName(2, "apply.png");
            this.appIcons.Images.SetKeyName(3, "editdelete.png");
            // 
            // clbCourses
            // 
            this.clbCourses.CheckOnClick = true;
            this.clbCourses.FormattingEnabled = true;
            this.clbCourses.Location = new System.Drawing.Point(12, 12);
            this.clbCourses.Name = "clbCourses";
            this.clbCourses.Size = new System.Drawing.Size(206, 244);
            this.clbCourses.TabIndex = 0;
            this.ttTip.SetToolTip(this.clbCourses, "Currently available courses.");
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageIndex = 3;
            this.btnCancel.ImageList = this.appIcons;
            this.btnCancel.Location = new System.Drawing.Point(153, 262);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 51);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ttTip.SetToolTip(this.btnCancel, "Cancel");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ttTip
            // 
            this.ttTip.AutoPopDelay = 5000;
            this.ttTip.InitialDelay = 250;
            this.ttTip.ReshowDelay = 100;
            this.ttTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttTip.ToolTipTitle = "Info";
            // 
            // FrmAddCoursesToSelectedQualification
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(233, 324);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.clbCourses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAddCoursesToSelectedQualification";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Courses...";
            this.Load += new System.EventHandler(this.FrmAddCoursesToSelectedQualification_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckedListBox clbCourses;
        private System.Windows.Forms.ImageList appIcons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip ttTip;
    }
}