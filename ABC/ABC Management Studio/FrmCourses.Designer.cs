namespace ABC_Management_Studio
{
    partial class FrmCourses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCourses));
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.chCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chCourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chSemester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoursesContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteCourseItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseToQualificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCurrentCourses = new System.Windows.Forms.Label();
            this.lblCourseQuals = new System.Windows.Forms.Label();
            this.cmbCID = new System.Windows.Forms.ComboBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.cmbTeacher = new System.Windows.Forms.ComboBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.CourseImages = new System.Windows.Forms.ImageList(this.components);
            this.cmbQual = new System.Windows.Forms.ComboBox();
            this.dgvQuals = new System.Windows.Forms.DataGridView();
            this.chQCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chQName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chQDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QualificationContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeQualificatonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentsToQualificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCoursesToSelectedQualificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CoursesStatusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripErrorLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CoursesTopMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CourseToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.CoursesContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuals)).BeginInit();
            this.QualificationContextMenu.SuspendLayout();
            this.CoursesStatusStrip.SuspendLayout();
            this.CoursesTopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCourses
            // 
            this.dgvCourses.AllowUserToResizeColumns = false;
            this.dgvCourses.AllowUserToResizeRows = false;
            this.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chCID,
            this.chCourseName,
            this.chYear,
            this.chSemester,
            this.chTID});
            this.dgvCourses.ContextMenuStrip = this.CoursesContextMenu;
            this.dgvCourses.Location = new System.Drawing.Point(12, 27);
            this.dgvCourses.MultiSelect = false;
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.RowHeadersVisible = false;
            this.dgvCourses.Size = new System.Drawing.Size(743, 198);
            this.dgvCourses.TabIndex = 0;
            this.dgvCourses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourses_CellClick);
            this.dgvCourses.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourses_CellEndEdit);
            this.dgvCourses.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCourses_CellMouseUp);
            this.dgvCourses.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvCourses_CellValidating);
            this.dgvCourses.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvCourses_DataError);
            this.dgvCourses.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvCourses_KeyUp);
            // 
            // chCID
            // 
            this.chCID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chCID.DataPropertyName = "CID";
            this.chCID.HeaderText = "Code";
            this.chCID.Name = "chCID";
            this.chCID.ReadOnly = true;
            this.chCID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // chCourseName
            // 
            this.chCourseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chCourseName.DataPropertyName = "CName";
            this.chCourseName.HeaderText = "Name";
            this.chCourseName.Name = "chCourseName";
            this.chCourseName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // chYear
            // 
            this.chYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chYear.DataPropertyName = "Year";
            this.chYear.HeaderText = "Year";
            this.chYear.Name = "chYear";
            this.chYear.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // chSemester
            // 
            this.chSemester.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chSemester.DataPropertyName = "Semester";
            this.chSemester.HeaderText = "Semester";
            this.chSemester.Name = "chSemester";
            this.chSemester.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // chTID
            // 
            this.chTID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chTID.DataPropertyName = "TID";
            this.chTID.HeaderText = "Teacher ID";
            this.chTID.Name = "chTID";
            this.chTID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CoursesContextMenu
            // 
            this.CoursesContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteCourseItem,
            this.addCourseToQualificationToolStripMenuItem});
            this.CoursesContextMenu.Name = "MaintainCoursesContext";
            this.CoursesContextMenu.Size = new System.Drawing.Size(235, 48);
            // 
            // deleteCourseItem
            // 
            this.deleteCourseItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteCourseItem.Image")));
            this.deleteCourseItem.Name = "deleteCourseItem";
            this.deleteCourseItem.Size = new System.Drawing.Size(234, 22);
            this.deleteCourseItem.Text = "&Remove Course from ABC";
            this.deleteCourseItem.Click += new System.EventHandler(this.deleteRecordMenu_Click);
            // 
            // addCourseToQualificationToolStripMenuItem
            // 
            this.addCourseToQualificationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addCourseToQualificationToolStripMenuItem.Image")));
            this.addCourseToQualificationToolStripMenuItem.Name = "addCourseToQualificationToolStripMenuItem";
            this.addCourseToQualificationToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.addCourseToQualificationToolStripMenuItem.Text = "&Add Course to Qualification(s)";
            this.addCourseToQualificationToolStripMenuItem.Click += new System.EventHandler(this.addCourseToQualificationToolStripMenuItem_Click);
            // 
            // lblCurrentCourses
            // 
            this.lblCurrentCourses.AutoSize = true;
            this.lblCurrentCourses.Location = new System.Drawing.Point(9, 9);
            this.lblCurrentCourses.Name = "lblCurrentCourses";
            this.lblCurrentCourses.Size = new System.Drawing.Size(82, 13);
            this.lblCurrentCourses.TabIndex = 2;
            this.lblCurrentCourses.Text = "Current Courses";
            // 
            // lblCourseQuals
            // 
            this.lblCourseQuals.AutoSize = true;
            this.lblCourseQuals.Location = new System.Drawing.Point(9, 265);
            this.lblCourseQuals.Name = "lblCourseQuals";
            this.lblCourseQuals.Size = new System.Drawing.Size(201, 13);
            this.lblCourseQuals.TabIndex = 3;
            this.lblCourseQuals.Text = "Qualifcations containing selected course:";
            // 
            // cmbCID
            // 
            this.cmbCID.DisplayMember = "CID";
            this.cmbCID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCID.FormattingEnabled = true;
            this.cmbCID.Location = new System.Drawing.Point(13, 230);
            this.cmbCID.Name = "cmbCID";
            this.cmbCID.Size = new System.Drawing.Size(51, 21);
            this.cmbCID.TabIndex = 5;
            this.CourseToolTip.SetToolTip(this.cmbCID, "Course ID");
            this.cmbCID.ValueMember = "CID";
            this.cmbCID.SelectedIndexChanged += new System.EventHandler(this.cmbCID_SelectedIndexChanged);
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(70, 230);
            this.txtCourseName.MaxLength = 50;
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(129, 20);
            this.txtCourseName.TabIndex = 6;
            this.txtCourseName.Text = "Course Name";
            this.CourseToolTip.SetToolTip(this.txtCourseName, "Course Name");
            this.txtCourseName.Enter += new System.EventHandler(this.txtCourseName_Enter);
            this.txtCourseName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCourseName_KeyUp);
            this.txtCourseName.Validating += new System.ComponentModel.CancelEventHandler(this.txtCourseName_Validating);
            this.txtCourseName.Validated += new System.EventHandler(this.txtCourseName_Validated);
            // 
            // cmbYear
            // 
            this.cmbYear.DisplayMember = "Year";
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(356, 230);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(73, 21);
            this.cmbYear.TabIndex = 7;
            this.CourseToolTip.SetToolTip(this.cmbYear, "Year");
            this.cmbYear.ValueMember = "Year";
            // 
            // cmbSemester
            // 
            this.cmbSemester.DisplayMember = "Semester";
            this.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Location = new System.Drawing.Point(435, 230);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(73, 21);
            this.cmbSemester.TabIndex = 8;
            this.CourseToolTip.SetToolTip(this.cmbSemester, "Semester");
            this.cmbSemester.ValueMember = "Semester";
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.DisplayMember = "TID";
            this.cmbTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Location = new System.Drawing.Point(514, 230);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(111, 21);
            this.cmbTeacher.TabIndex = 9;
            this.CourseToolTip.SetToolTip(this.cmbTeacher, "Teacher");
            this.cmbTeacher.ValueMember = "TID";
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCourse.ImageIndex = 2;
            this.btnAddCourse.ImageList = this.CourseImages;
            this.btnAddCourse.Location = new System.Drawing.Point(631, 228);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnAddCourse.Size = new System.Drawing.Size(124, 23);
            this.btnAddCourse.TabIndex = 10;
            this.btnAddCourse.Text = "&Add Course";
            this.btnAddCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CourseToolTip.SetToolTip(this.btnAddCourse, "Save course.");
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // CourseImages
            // 
            this.CourseImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("CourseImages.ImageStream")));
            this.CourseImages.TransparentColor = System.Drawing.Color.Transparent;
            this.CourseImages.Images.SetKeyName(0, "add.png");
            this.CourseImages.Images.SetKeyName(1, "remove.png");
            this.CourseImages.Images.SetKeyName(2, "apply.png");
            this.CourseImages.Images.SetKeyName(3, "editdelete.png");
            // 
            // cmbQual
            // 
            this.cmbQual.DisplayMember = "QName";
            this.cmbQual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQual.FormattingEnabled = true;
            this.cmbQual.Location = new System.Drawing.Point(205, 230);
            this.cmbQual.Name = "cmbQual";
            this.cmbQual.Size = new System.Drawing.Size(145, 21);
            this.cmbQual.TabIndex = 11;
            this.CourseToolTip.SetToolTip(this.cmbQual, "Qualification");
            this.cmbQual.ValueMember = "QName";
            this.cmbQual.SelectedValueChanged += new System.EventHandler(this.cmbQual_SelectedValueChanged);
            // 
            // dgvQuals
            // 
            this.dgvQuals.AllowUserToAddRows = false;
            this.dgvQuals.AllowUserToResizeColumns = false;
            this.dgvQuals.AllowUserToResizeRows = false;
            this.dgvQuals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuals.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvQuals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chQCode,
            this.chQName,
            this.chQDuration});
            this.dgvQuals.ContextMenuStrip = this.QualificationContextMenu;
            this.dgvQuals.Location = new System.Drawing.Point(12, 281);
            this.dgvQuals.MultiSelect = false;
            this.dgvQuals.Name = "dgvQuals";
            this.dgvQuals.RowHeadersVisible = false;
            this.dgvQuals.Size = new System.Drawing.Size(743, 142);
            this.dgvQuals.TabIndex = 12;
            this.dgvQuals.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuals_CellEndEdit);
            this.dgvQuals.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvQuals_CellMouseUp);
            this.dgvQuals.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvQuals_CellValidating);
            this.dgvQuals.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvQuals_DataError);
            // 
            // chQCode
            // 
            this.chQCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chQCode.DataPropertyName = "QCode";
            this.chQCode.HeaderText = "Qualification Code";
            this.chQCode.Name = "chQCode";
            this.chQCode.ReadOnly = true;
            this.chQCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // chQName
            // 
            this.chQName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chQName.DataPropertyName = "QName";
            this.chQName.HeaderText = "Qualification Name";
            this.chQName.Name = "chQName";
            this.chQName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // chQDuration
            // 
            this.chQDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chQDuration.DataPropertyName = "Duration";
            this.chQDuration.HeaderText = "Qualification Duration";
            this.chQDuration.Name = "chQDuration";
            // 
            // QualificationContextMenu
            // 
            this.QualificationContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeQualificatonToolStripMenuItem,
            this.addStudentsToQualificationToolStripMenuItem,
            this.addCoursesToSelectedQualificationToolStripMenuItem});
            this.QualificationContextMenu.Name = "ContextQualification";
            this.QualificationContextMenu.Size = new System.Drawing.Size(286, 70);
            // 
            // removeQualificatonToolStripMenuItem
            // 
            this.removeQualificatonToolStripMenuItem.Image = global::ABC_Management_Studio.Properties.Resources.edit_remove;
            this.removeQualificatonToolStripMenuItem.Name = "removeQualificatonToolStripMenuItem";
            this.removeQualificatonToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.removeQualificatonToolStripMenuItem.Text = "Remove Qualificaton from ABC";
            this.removeQualificatonToolStripMenuItem.Click += new System.EventHandler(this.removeQualificatonToolStripMenuItem_Click);
            // 
            // addStudentsToQualificationToolStripMenuItem
            // 
            this.addStudentsToQualificationToolStripMenuItem.Image = global::ABC_Management_Studio.Properties.Resources.edit_add;
            this.addStudentsToQualificationToolStripMenuItem.Name = "addStudentsToQualificationToolStripMenuItem";
            this.addStudentsToQualificationToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.addStudentsToQualificationToolStripMenuItem.Text = "&Add Student(s) to Selected Qualification";
            this.addStudentsToQualificationToolStripMenuItem.Click += new System.EventHandler(this.addStudentsToQualificationToolStripMenuItem_Click);
            // 
            // addCoursesToSelectedQualificationToolStripMenuItem
            // 
            this.addCoursesToSelectedQualificationToolStripMenuItem.Image = global::ABC_Management_Studio.Properties.Resources.edit_add;
            this.addCoursesToSelectedQualificationToolStripMenuItem.Name = "addCoursesToSelectedQualificationToolStripMenuItem";
            this.addCoursesToSelectedQualificationToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.addCoursesToSelectedQualificationToolStripMenuItem.Text = "Add Course(s) to Selected Qualification";
            this.addCoursesToSelectedQualificationToolStripMenuItem.Click += new System.EventHandler(this.addCoursesToSelectedQualificationToolStripMenuItem_Click);
            // 
            // CoursesStatusStrip
            // 
            this.CoursesStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripErrorLabel});
            this.CoursesStatusStrip.Location = new System.Drawing.Point(0, 442);
            this.CoursesStatusStrip.Name = "CoursesStatusStrip";
            this.CoursesStatusStrip.Size = new System.Drawing.Size(770, 22);
            this.CoursesStatusStrip.SizingGrip = false;
            this.CoursesStatusStrip.TabIndex = 13;
            this.CoursesStatusStrip.Text = "statusStrip1";
            // 
            // statusStripErrorLabel
            // 
            this.statusStripErrorLabel.Name = "statusStripErrorLabel";
            this.statusStripErrorLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // CoursesTopMenu
            // 
            this.CoursesTopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.CoursesTopMenu.Location = new System.Drawing.Point(0, 0);
            this.CoursesTopMenu.Name = "CoursesTopMenu";
            this.CoursesTopMenu.Size = new System.Drawing.Size(770, 24);
            this.CoursesTopMenu.TabIndex = 20;
            this.CoursesTopMenu.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("closeToolStripMenuItem.Image")));
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // CourseToolTip
            // 
            this.CourseToolTip.AutoPopDelay = 5000;
            this.CourseToolTip.InitialDelay = 250;
            this.CourseToolTip.ReshowDelay = 100;
            this.CourseToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.CourseToolTip.ToolTipTitle = "Info";
            // 
            // FrmCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 464);
            this.Controls.Add(this.CoursesTopMenu);
            this.Controls.Add(this.CoursesStatusStrip);
            this.Controls.Add(this.dgvQuals);
            this.Controls.Add(this.cmbQual);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.cmbTeacher);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.cmbCID);
            this.Controls.Add(this.lblCourseQuals);
            this.Controls.Add(this.lblCurrentCourses);
            this.Controls.Add(this.dgvCourses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCourses";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Course Management";
            this.Load += new System.EventHandler(this.FrmCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.CoursesContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuals)).EndInit();
            this.QualificationContextMenu.ResumeLayout(false);
            this.CoursesStatusStrip.ResumeLayout(false);
            this.CoursesStatusStrip.PerformLayout();
            this.CoursesTopMenu.ResumeLayout(false);
            this.CoursesTopMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.ContextMenuStrip CoursesContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteCourseItem;
        private System.Windows.Forms.Label lblCurrentCourses;
        private System.Windows.Forms.Label lblCourseQuals;
        private System.Windows.Forms.ComboBox cmbCID;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.ComboBox cmbQual;
        private System.Windows.Forms.DataGridView dgvQuals;
        private System.Windows.Forms.DataGridViewTextBoxColumn chQCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn chQName;
        private System.Windows.Forms.DataGridViewTextBoxColumn chQDuration;
        private System.Windows.Forms.StatusStrip CoursesStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusStripErrorLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn chCID;
        private System.Windows.Forms.DataGridViewTextBoxColumn chCourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn chYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn chSemester;
        private System.Windows.Forms.DataGridViewTextBoxColumn chTID;
        private System.Windows.Forms.ToolStripMenuItem addCourseToQualificationToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip QualificationContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addStudentsToQualificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCoursesToSelectedQualificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeQualificatonToolStripMenuItem;
        private System.Windows.Forms.MenuStrip CoursesTopMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ImageList CourseImages;
        private System.Windows.Forms.ToolTip CourseToolTip;
    }
}