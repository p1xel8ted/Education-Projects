namespace ABC_Management_Studio
{
    partial class FrmQualifications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQualifications));
            this.lblCourseQuals = new System.Windows.Forms.Label();
            this.lblCurrentCourses = new System.Windows.Forms.Label();
            this.dgvQuals = new System.Windows.Forms.DataGridView();
            this.chQCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chQName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chQDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QualContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MaintainQualsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentsToQualificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCoursesToQualificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.chCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chCourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chSemester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RemoveCourseFromQualificationItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveCourseFromAbcItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripErrorLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmbCode = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbDuration = new System.Windows.Forms.ComboBox();
            this.btnAddQualification = new System.Windows.Forms.Button();
            this.appIcons = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ttTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuals)).BeginInit();
            this.QualContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.CourseContext.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCourseQuals
            // 
            this.lblCourseQuals.AutoSize = true;
            this.lblCourseQuals.Location = new System.Drawing.Point(12, 9);
            this.lblCourseQuals.Name = "lblCourseQuals";
            this.lblCourseQuals.Size = new System.Drawing.Size(107, 13);
            this.lblCourseQuals.TabIndex = 7;
            this.lblCourseQuals.Text = "Current Qualifications";
            // 
            // lblCurrentCourses
            // 
            this.lblCurrentCourses.AutoSize = true;
            this.lblCurrentCourses.Location = new System.Drawing.Point(9, 209);
            this.lblCurrentCourses.Name = "lblCurrentCourses";
            this.lblCurrentCourses.Size = new System.Drawing.Size(187, 13);
            this.lblCurrentCourses.TabIndex = 6;
            this.lblCurrentCourses.Text = "Courses contained within qualification.";
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
            this.dgvQuals.ContextMenuStrip = this.QualContext;
            this.dgvQuals.Location = new System.Drawing.Point(12, 27);
            this.dgvQuals.MultiSelect = false;
            this.dgvQuals.Name = "dgvQuals";
            this.dgvQuals.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvQuals.RowHeadersVisible = false;
            this.dgvQuals.Size = new System.Drawing.Size(743, 142);
            this.dgvQuals.TabIndex = 5;
            this.dgvQuals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuals_CellClick);
            this.dgvQuals.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuals_CellEndEdit);
            this.dgvQuals.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvQuals_CellMouseUp);
            this.dgvQuals.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvQuals_CellValidating);
            this.dgvQuals.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvQuals_DataError);
            this.dgvQuals.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvQuals_KeyUp);
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
            // QualContext
            // 
            this.QualContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MaintainQualsItem,
            this.addStudentsToQualificationToolStripMenuItem,
            this.addCoursesToQualificationToolStripMenuItem});
            this.QualContext.Name = "MaintainCoursesContext";
            this.QualContext.Size = new System.Drawing.Size(286, 70);
            // 
            // MaintainQualsItem
            // 
            this.MaintainQualsItem.Image = ((System.Drawing.Image)(resources.GetObject("MaintainQualsItem.Image")));
            this.MaintainQualsItem.Name = "MaintainQualsItem";
            this.MaintainQualsItem.Size = new System.Drawing.Size(285, 22);
            this.MaintainQualsItem.Text = "&Remove Qualification from ABC";
            this.MaintainQualsItem.Click += new System.EventHandler(this.MaintainQualsItem_Click);
            // 
            // addStudentsToQualificationToolStripMenuItem
            // 
            this.addStudentsToQualificationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addStudentsToQualificationToolStripMenuItem.Image")));
            this.addStudentsToQualificationToolStripMenuItem.Name = "addStudentsToQualificationToolStripMenuItem";
            this.addStudentsToQualificationToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.addStudentsToQualificationToolStripMenuItem.Text = "&Add Student(s) to Selected Qualification";
            this.addStudentsToQualificationToolStripMenuItem.Click += new System.EventHandler(this.addStudentsToQualificationToolStripMenuItem_Click);
            // 
            // addCoursesToQualificationToolStripMenuItem
            // 
            this.addCoursesToQualificationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addCoursesToQualificationToolStripMenuItem.Image")));
            this.addCoursesToQualificationToolStripMenuItem.Name = "addCoursesToQualificationToolStripMenuItem";
            this.addCoursesToQualificationToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.addCoursesToQualificationToolStripMenuItem.Text = "Add Course(s) to Selected Qualification";
            this.addCoursesToQualificationToolStripMenuItem.Click += new System.EventHandler(this.addCoursesToQualificationToolStripMenuItem_Click);
            // 
            // dgvCourses
            // 
            this.dgvCourses.AllowUserToAddRows = false;
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
            this.dgvCourses.ContextMenuStrip = this.CourseContext;
            this.dgvCourses.Location = new System.Drawing.Point(12, 225);
            this.dgvCourses.MultiSelect = false;
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.RowHeadersVisible = false;
            this.dgvCourses.Size = new System.Drawing.Size(743, 198);
            this.dgvCourses.TabIndex = 4;
            this.dgvCourses.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourses_CellEndEdit);
            this.dgvCourses.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCourses_CellMouseUp);
            this.dgvCourses.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvCourses_CellValidating);
            this.dgvCourses.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvCourses_DataError);
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
            // CourseContext
            // 
            this.CourseContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemoveCourseFromQualificationItem,
            this.RemoveCourseFromAbcItem});
            this.CourseContext.Name = "MaintainCoursesContext";
            this.CourseContext.Size = new System.Drawing.Size(260, 48);
            // 
            // RemoveCourseFromQualificationItem
            // 
            this.RemoveCourseFromQualificationItem.Image = ((System.Drawing.Image)(resources.GetObject("RemoveCourseFromQualificationItem.Image")));
            this.RemoveCourseFromQualificationItem.Name = "RemoveCourseFromQualificationItem";
            this.RemoveCourseFromQualificationItem.Size = new System.Drawing.Size(259, 22);
            this.RemoveCourseFromQualificationItem.Text = "&Remove Course From Qualification";
            this.RemoveCourseFromQualificationItem.Click += new System.EventHandler(this.deleteCourseItem_Click);
            // 
            // RemoveCourseFromAbcItem
            // 
            this.RemoveCourseFromAbcItem.Image = global::ABC_Management_Studio.Properties.Resources.edit_remove;
            this.RemoveCourseFromAbcItem.Name = "RemoveCourseFromAbcItem";
            this.RemoveCourseFromAbcItem.Size = new System.Drawing.Size(259, 22);
            this.RemoveCourseFromAbcItem.Text = "Remove Course From ABC";
            this.RemoveCourseFromAbcItem.Click += new System.EventHandler(this.removeCourseFromABCToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripErrorLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 434);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(771, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 14;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusStripErrorLabel
            // 
            this.statusStripErrorLabel.Name = "statusStripErrorLabel";
            this.statusStripErrorLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // cmbCode
            // 
            this.cmbCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCode.FormattingEnabled = true;
            this.cmbCode.Location = new System.Drawing.Point(12, 175);
            this.cmbCode.Name = "cmbCode";
            this.cmbCode.Size = new System.Drawing.Size(184, 21);
            this.cmbCode.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(202, 175);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 20);
            this.txtName.TabIndex = 16;
            this.txtName.Text = "Qualification Name";
            this.txtName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyUp);
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            this.txtName.Validated += new System.EventHandler(this.txtName_Validated);
            // 
            // cmbDuration
            // 
            this.cmbDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDuration.FormattingEnabled = true;
            this.cmbDuration.Items.AddRange(new object[] {
            "12 months",
            "24 months",
            "36 months",
            "48 months",
            "60 months",
            "72 months"});
            this.cmbDuration.Location = new System.Drawing.Point(399, 175);
            this.cmbDuration.Name = "cmbDuration";
            this.cmbDuration.Size = new System.Drawing.Size(197, 21);
            this.cmbDuration.TabIndex = 17;
            // 
            // btnAddQualification
            // 
            this.btnAddQualification.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddQualification.ImageIndex = 2;
            this.btnAddQualification.ImageList = this.appIcons;
            this.btnAddQualification.Location = new System.Drawing.Point(602, 173);
            this.btnAddQualification.Name = "btnAddQualification";
            this.btnAddQualification.Size = new System.Drawing.Size(153, 23);
            this.btnAddQualification.TabIndex = 18;
            this.btnAddQualification.Text = "&Add Qualification";
            this.btnAddQualification.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddQualification.UseVisualStyleBackColor = true;
            this.btnAddQualification.Click += new System.EventHandler(this.btnAddQualification_Click);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(771, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
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
            // ttTip
            // 
            this.ttTip.AutoPopDelay = 5000;
            this.ttTip.InitialDelay = 250;
            this.ttTip.ReshowDelay = 100;
            this.ttTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttTip.ToolTipTitle = "Info";
            // 
            // FrmQualifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 456);
            this.Controls.Add(this.btnAddQualification);
            this.Controls.Add(this.cmbDuration);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmbCode);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblCourseQuals);
            this.Controls.Add(this.lblCurrentCourses);
            this.Controls.Add(this.dgvQuals);
            this.Controls.Add(this.dgvCourses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmQualifications";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Qualification Management";
            this.Load += new System.EventHandler(this.FrmQualifications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuals)).EndInit();
            this.QualContext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.CourseContext.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseQuals;
        private System.Windows.Forms.Label lblCurrentCourses;
        private System.Windows.Forms.DataGridView dgvQuals;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.ContextMenuStrip CourseContext;
        private System.Windows.Forms.ToolStripMenuItem RemoveCourseFromQualificationItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusStripErrorLabel;
        private System.Windows.Forms.ComboBox cmbCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbDuration;
        private System.Windows.Forms.Button btnAddQualification;
        private System.Windows.Forms.ContextMenuStrip QualContext;
        private System.Windows.Forms.ToolStripMenuItem MaintainQualsItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentsToQualificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCoursesToQualificationToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn chQCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn chQName;
        private System.Windows.Forms.DataGridViewTextBoxColumn chQDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn chCID;
        private System.Windows.Forms.DataGridViewTextBoxColumn chCourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn chYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn chSemester;
        private System.Windows.Forms.DataGridViewTextBoxColumn chTID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ImageList appIcons;
        private System.Windows.Forms.ToolTip ttTip;
        private System.Windows.Forms.ToolStripMenuItem RemoveCourseFromAbcItem;
    }
}