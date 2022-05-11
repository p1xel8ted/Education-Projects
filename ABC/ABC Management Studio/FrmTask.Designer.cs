namespace ABC_Management_Studio
{
    partial class FrmTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTask));
            this.btnStudentMarks = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnQualifications = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnManageStudents = new System.Windows.Forms.Button();
            this.btnManageAdministrators = new System.Windows.Forms.Button();
            this.btnManageTeachers = new System.Windows.Forms.Button();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStudentMarks
            // 
            this.btnStudentMarks.Enabled = false;
            this.btnStudentMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentMarks.ImageIndex = 0;
            this.btnStudentMarks.ImageList = this.imageList1;
            this.btnStudentMarks.Location = new System.Drawing.Point(12, 12);
            this.btnStudentMarks.Name = "btnStudentMarks";
            this.btnStudentMarks.Size = new System.Drawing.Size(186, 65);
            this.btnStudentMarks.TabIndex = 1;
            this.btnStudentMarks.Text = "Student Marks";
            this.btnStudentMarks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnStudentMarks, "Add, update or remove marks to/from student records.");
            this.btnStudentMarks.UseVisualStyleBackColor = true;
            this.btnStudentMarks.Click += new System.EventHandler(this.btnStudentMarks_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "marks.png");
            this.imageList1.Images.SetKeyName(1, "people.png");
            this.imageList1.Images.SetKeyName(2, "teacher.png");
            this.imageList1.Images.SetKeyName(3, "admins.png");
            this.imageList1.Images.SetKeyName(4, "courses.png");
            this.imageList1.Images.SetKeyName(5, "quals.png");
            this.imageList1.Images.SetKeyName(6, "config.png");
            this.imageList1.Images.SetKeyName(7, "logout.png");
            // 
            // btnQualifications
            // 
            this.btnQualifications.Enabled = false;
            this.btnQualifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQualifications.ImageIndex = 5;
            this.btnQualifications.ImageList = this.imageList1;
            this.btnQualifications.Location = new System.Drawing.Point(204, 12);
            this.btnQualifications.Name = "btnQualifications";
            this.btnQualifications.Size = new System.Drawing.Size(186, 65);
            this.btnQualifications.TabIndex = 2;
            this.btnQualifications.Text = "Qualifications";
            this.btnQualifications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnQualifications, "Add, update or remove qualifications.");
            this.btnQualifications.UseVisualStyleBackColor = true;
            this.btnQualifications.Click += new System.EventHandler(this.btnQualifications_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.Enabled = false;
            this.btnCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourses.ImageKey = "courses.png";
            this.btnCourses.ImageList = this.imageList1;
            this.btnCourses.Location = new System.Drawing.Point(396, 12);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(186, 65);
            this.btnCourses.TabIndex = 3;
            this.btnCourses.Text = "Courses";
            this.btnCourses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnCourses, "Add, update or remove courses.");
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnManageStudents
            // 
            this.btnManageStudents.Enabled = false;
            this.btnManageStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStudents.ImageIndex = 1;
            this.btnManageStudents.ImageList = this.imageList1;
            this.btnManageStudents.Location = new System.Drawing.Point(396, 83);
            this.btnManageStudents.Name = "btnManageStudents";
            this.btnManageStudents.Size = new System.Drawing.Size(186, 65);
            this.btnManageStudents.TabIndex = 6;
            this.btnManageStudents.Text = "Manage Students";
            this.btnManageStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnManageStudents, "Add, update or remove Students.");
            this.btnManageStudents.UseVisualStyleBackColor = true;
            this.btnManageStudents.Click += new System.EventHandler(this.btnManageStudents_Click);
            // 
            // btnManageAdministrators
            // 
            this.btnManageAdministrators.Enabled = false;
            this.btnManageAdministrators.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAdministrators.ImageIndex = 3;
            this.btnManageAdministrators.ImageList = this.imageList1;
            this.btnManageAdministrators.Location = new System.Drawing.Point(12, 83);
            this.btnManageAdministrators.Name = "btnManageAdministrators";
            this.btnManageAdministrators.Size = new System.Drawing.Size(186, 65);
            this.btnManageAdministrators.TabIndex = 4;
            this.btnManageAdministrators.Text = "Manage Administrators";
            this.btnManageAdministrators.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnManageAdministrators, "Add, update or remove Administrators.");
            this.btnManageAdministrators.UseVisualStyleBackColor = true;
            this.btnManageAdministrators.Click += new System.EventHandler(this.btnManageAdministrators_Click);
            // 
            // btnManageTeachers
            // 
            this.btnManageTeachers.Enabled = false;
            this.btnManageTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageTeachers.ImageIndex = 2;
            this.btnManageTeachers.ImageList = this.imageList1;
            this.btnManageTeachers.Location = new System.Drawing.Point(204, 83);
            this.btnManageTeachers.Name = "btnManageTeachers";
            this.btnManageTeachers.Size = new System.Drawing.Size(186, 65);
            this.btnManageTeachers.TabIndex = 5;
            this.btnManageTeachers.Text = "Manage Teachers";
            this.btnManageTeachers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnManageTeachers, "Add, update or remove Teachers.");
            this.btnManageTeachers.UseVisualStyleBackColor = true;
            this.btnManageTeachers.Click += new System.EventHandler(this.btnManageTeachers_Click);
            // 
            // btnLogOff
            // 
            this.btnLogOff.ImageKey = "logout.png";
            this.btnLogOff.ImageList = this.imageList1;
            this.btnLogOff.Location = new System.Drawing.Point(492, 154);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(90, 54);
            this.btnLogOff.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnLogOff, "Log Out");
            this.btnLogOff.UseVisualStyleBackColor = true;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 250;
            this.toolTip1.ReshowDelay = 100;
            // 
            // btnSettings
            // 
            this.btnSettings.Enabled = false;
            this.btnSettings.ImageIndex = 6;
            this.btnSettings.ImageList = this.imageList1;
            this.btnSettings.Location = new System.Drawing.Point(396, 154);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(90, 54);
            this.btnSettings.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnSettings, "Settings");
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 163);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 16);
            this.lblWelcome.TabIndex = 0;
            // 
            // FrmTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 220);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnLogOff);
            this.Controls.Add(this.btnManageTeachers);
            this.Controls.Add(this.btnManageAdministrators);
            this.Controls.Add(this.btnManageStudents);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.btnQualifications);
            this.Controls.Add(this.btnStudentMarks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmTask";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tasks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTask_FormClosing);
            this.Load += new System.EventHandler(this.FrmTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStudentMarks;
        private System.Windows.Forms.Button btnQualifications;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnManageStudents;
        private System.Windows.Forms.Button btnManageAdministrators;
        private System.Windows.Forms.Button btnManageTeachers;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblWelcome;
    }
}