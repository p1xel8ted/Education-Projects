namespace ABC_Management_Studio
{
    partial class FrmMarks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarks));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.dgvMarksByCourseMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CourseIdContext = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMarksByStudent = new System.Windows.Forms.TabPage();
            this.btnAddMarkByStudentId = new System.Windows.Forms.Button();
            this.appIcons = new System.Windows.Forms.ImageList(this.components);
            this.dgvMarksByStudent = new System.Windows.Forms.DataGridView();
            this.chSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chCourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMarksByStudentMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StudentIdContext = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarksByStudent = new System.Windows.Forms.TextBox();
            this.cmbMarksByStudentCourseID = new System.Windows.Forms.ComboBox();
            this.lblSelStudent = new System.Windows.Forms.Label();
            this.lblSelectedStudent = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.tabMarksByCourse = new System.Windows.Forms.TabPage();
            this.dgvMarksByCourse = new System.Windows.Forms.DataGridView();
            this.chSID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chMark2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddMarksByCourse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarksByCourse = new System.Windows.Forms.TextBox();
            this.cmbMarksByCourseStudentID = new System.Windows.Forms.ComboBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblSelectCourse = new System.Windows.Forms.Label();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.cmbCourseID = new System.Windows.Forms.ComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripErrorLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ttTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl.SuspendLayout();
            this.dgvMarksByCourseMenu.SuspendLayout();
            this.tabMarksByStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarksByStudent)).BeginInit();
            this.dgvMarksByStudentMenu.SuspendLayout();
            this.tabMarksByCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarksByCourse)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.ContextMenuStrip = this.dgvMarksByCourseMenu;
            this.tabControl.Controls.Add(this.tabMarksByStudent);
            this.tabControl.Controls.Add(this.tabMarksByCourse);
            this.tabControl.Location = new System.Drawing.Point(12, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(393, 510);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // dgvMarksByCourseMenu
            // 
            this.dgvMarksByCourseMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CourseIdContext});
            this.dgvMarksByCourseMenu.Name = "StudentContextMenu";
            this.dgvMarksByCourseMenu.Size = new System.Drawing.Size(148, 26);
            // 
            // CourseIdContext
            // 
            this.CourseIdContext.Image = ((System.Drawing.Image)(resources.GetObject("CourseIdContext.Image")));
            this.CourseIdContext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CourseIdContext.Name = "CourseIdContext";
            this.CourseIdContext.Size = new System.Drawing.Size(147, 22);
            this.CourseIdContext.Text = "&Delete Record";
            this.CourseIdContext.Click += new System.EventHandler(this.CourseIdContext_Click);
            // 
            // tabMarksByStudent
            // 
            this.tabMarksByStudent.Controls.Add(this.btnAddMarkByStudentId);
            this.tabMarksByStudent.Controls.Add(this.dgvMarksByStudent);
            this.tabMarksByStudent.Controls.Add(this.label4);
            this.tabMarksByStudent.Controls.Add(this.label3);
            this.tabMarksByStudent.Controls.Add(this.txtMarksByStudent);
            this.tabMarksByStudent.Controls.Add(this.cmbMarksByStudentCourseID);
            this.tabMarksByStudent.Controls.Add(this.lblSelStudent);
            this.tabMarksByStudent.Controls.Add(this.lblSelectedStudent);
            this.tabMarksByStudent.Controls.Add(this.lblStudent);
            this.tabMarksByStudent.Controls.Add(this.cmbStudent);
            this.tabMarksByStudent.Location = new System.Drawing.Point(4, 22);
            this.tabMarksByStudent.Name = "tabMarksByStudent";
            this.tabMarksByStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabMarksByStudent.Size = new System.Drawing.Size(385, 484);
            this.tabMarksByStudent.TabIndex = 0;
            this.tabMarksByStudent.Text = "View Marks by Student";
            this.tabMarksByStudent.UseVisualStyleBackColor = true;
            // 
            // btnAddMarkByStudentId
            // 
            this.btnAddMarkByStudentId.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMarkByStudentId.ImageIndex = 0;
            this.btnAddMarkByStudentId.ImageList = this.appIcons;
            this.btnAddMarkByStudentId.Location = new System.Drawing.Point(209, 445);
            this.btnAddMarkByStudentId.Name = "btnAddMarkByStudentId";
            this.btnAddMarkByStudentId.Size = new System.Drawing.Size(170, 30);
            this.btnAddMarkByStudentId.TabIndex = 20;
            this.btnAddMarkByStudentId.Text = "Ad&d Mark";
            this.btnAddMarkByStudentId.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddMarkByStudentId.UseVisualStyleBackColor = true;
            this.btnAddMarkByStudentId.Click += new System.EventHandler(this.btnAddMarkByStudentId_Click);
            // 
            // appIcons
            // 
            this.appIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("appIcons.ImageStream")));
            this.appIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.appIcons.Images.SetKeyName(0, "add.png");
            this.appIcons.Images.SetKeyName(1, "remove.png");
            // 
            // dgvMarksByStudent
            // 
            this.dgvMarksByStudent.AllowUserToAddRows = false;
            this.dgvMarksByStudent.AllowUserToResizeColumns = false;
            this.dgvMarksByStudent.AllowUserToResizeRows = false;
            this.dgvMarksByStudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMarksByStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarksByStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chSID,
            this.chCourseName,
            this.chMark});
            this.dgvMarksByStudent.ContextMenuStrip = this.dgvMarksByStudentMenu;
            this.dgvMarksByStudent.Location = new System.Drawing.Point(6, 69);
            this.dgvMarksByStudent.MultiSelect = false;
            this.dgvMarksByStudent.Name = "dgvMarksByStudent";
            this.dgvMarksByStudent.RowHeadersVisible = false;
            this.dgvMarksByStudent.Size = new System.Drawing.Size(373, 367);
            this.dgvMarksByStudent.TabIndex = 15;
            this.dgvMarksByStudent.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarksByStudent_CellEndEdit);
            this.dgvMarksByStudent.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMarksByStudent_CellMouseUp);
            this.dgvMarksByStudent.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvMarksByStudent_DataError);
            // 
            // chSID
            // 
            this.chSID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chSID.DataPropertyName = "CID";
            this.chSID.HeaderText = "Course ID";
            this.chSID.Name = "chSID";
            this.chSID.ReadOnly = true;
            this.chSID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // chCourseName
            // 
            this.chCourseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chCourseName.HeaderText = "Course Name";
            this.chCourseName.Name = "chCourseName";
            this.chCourseName.ReadOnly = true;
            // 
            // chMark
            // 
            this.chMark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chMark.DataPropertyName = "Mark";
            this.chMark.HeaderText = "Mark";
            this.chMark.Name = "chMark";
            // 
            // dgvMarksByStudentMenu
            // 
            this.dgvMarksByStudentMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StudentIdContext});
            this.dgvMarksByStudentMenu.Name = "StudentContextMenu";
            this.dgvMarksByStudentMenu.Size = new System.Drawing.Size(148, 26);
            // 
            // StudentIdContext
            // 
            this.StudentIdContext.Image = ((System.Drawing.Image)(resources.GetObject("StudentIdContext.Image")));
            this.StudentIdContext.Name = "StudentIdContext";
            this.StudentIdContext.Size = new System.Drawing.Size(147, 22);
            this.StudentIdContext.Text = "&Delete Record";
            this.StudentIdContext.Click += new System.EventHandler(this.StudentIdContext_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mark";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Course ID";
            // 
            // txtMarksByStudent
            // 
            this.txtMarksByStudent.Location = new System.Drawing.Point(116, 455);
            this.txtMarksByStudent.Name = "txtMarksByStudent";
            this.txtMarksByStudent.Size = new System.Drawing.Size(75, 20);
            this.txtMarksByStudent.TabIndex = 11;
            this.txtMarksByStudent.Text = "0";
            this.txtMarksByStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarksByStudent_KeyPress);
            // 
            // cmbMarksByStudentCourseID
            // 
            this.cmbMarksByStudentCourseID.DisplayMember = "CID";
            this.cmbMarksByStudentCourseID.FormattingEnabled = true;
            this.cmbMarksByStudentCourseID.Location = new System.Drawing.Point(6, 455);
            this.cmbMarksByStudentCourseID.Name = "cmbMarksByStudentCourseID";
            this.cmbMarksByStudentCourseID.Size = new System.Drawing.Size(101, 21);
            this.cmbMarksByStudentCourseID.TabIndex = 10;
            this.cmbMarksByStudentCourseID.ValueMember = "CID";
            this.cmbMarksByStudentCourseID.SelectedIndexChanged += new System.EventHandler(this.cmbMarksByStudentCourseID_SelectedIndexChanged);
            // 
            // lblSelStudent
            // 
            this.lblSelStudent.AutoSize = true;
            this.lblSelStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelStudent.Location = new System.Drawing.Point(113, 19);
            this.lblSelStudent.Name = "lblSelStudent";
            this.lblSelStudent.Size = new System.Drawing.Size(129, 18);
            this.lblSelStudent.TabIndex = 8;
            this.lblSelStudent.Text = "<student name>";
            // 
            // lblSelectedStudent
            // 
            this.lblSelectedStudent.AutoSize = true;
            this.lblSelectedStudent.Location = new System.Drawing.Point(3, 53);
            this.lblSelectedStudent.Name = "lblSelectedStudent";
            this.lblSelectedStudent.Size = new System.Drawing.Size(176, 13);
            this.lblSelectedStudent.TabIndex = 3;
            this.lblSelectedStudent.Text = "Please select a student from above.";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(3, 4);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(44, 13);
            this.lblStudent.TabIndex = 2;
            this.lblStudent.Text = "Student";
            // 
            // cmbStudent
            // 
            this.cmbStudent.DisplayMember = "ID";
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(6, 20);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(101, 21);
            this.cmbStudent.TabIndex = 1;
            this.cmbStudent.ValueMember = "ID";
            this.cmbStudent.SelectedIndexChanged += new System.EventHandler(this.cmbStudent_SelectedIndexChanged);
            this.cmbStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbStudent_KeyPress);
            // 
            // tabMarksByCourse
            // 
            this.tabMarksByCourse.Controls.Add(this.dgvMarksByCourse);
            this.tabMarksByCourse.Controls.Add(this.btnAddMarksByCourse);
            this.tabMarksByCourse.Controls.Add(this.label2);
            this.tabMarksByCourse.Controls.Add(this.label1);
            this.tabMarksByCourse.Controls.Add(this.txtMarksByCourse);
            this.tabMarksByCourse.Controls.Add(this.cmbMarksByCourseStudentID);
            this.tabMarksByCourse.Controls.Add(this.lblCourseName);
            this.tabMarksByCourse.Controls.Add(this.lblSelectCourse);
            this.tabMarksByCourse.Controls.Add(this.lblCourseID);
            this.tabMarksByCourse.Controls.Add(this.cmbCourseID);
            this.tabMarksByCourse.Location = new System.Drawing.Point(4, 22);
            this.tabMarksByCourse.Name = "tabMarksByCourse";
            this.tabMarksByCourse.Padding = new System.Windows.Forms.Padding(3);
            this.tabMarksByCourse.Size = new System.Drawing.Size(385, 484);
            this.tabMarksByCourse.TabIndex = 1;
            this.tabMarksByCourse.Text = "View Marks by Course";
            this.tabMarksByCourse.UseVisualStyleBackColor = true;
            // 
            // dgvMarksByCourse
            // 
            this.dgvMarksByCourse.AllowUserToAddRows = false;
            this.dgvMarksByCourse.AllowUserToResizeColumns = false;
            this.dgvMarksByCourse.AllowUserToResizeRows = false;
            this.dgvMarksByCourse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMarksByCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarksByCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chSID2,
            this.chName,
            this.chMark2});
            this.dgvMarksByCourse.Location = new System.Drawing.Point(6, 69);
            this.dgvMarksByCourse.Name = "dgvMarksByCourse";
            this.dgvMarksByCourse.RowHeadersVisible = false;
            this.dgvMarksByCourse.Size = new System.Drawing.Size(373, 367);
            this.dgvMarksByCourse.TabIndex = 20;
            this.dgvMarksByCourse.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarksByCourse_CellEndEdit);
            this.dgvMarksByCourse.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMarksByCourse_CellMouseUp);
            this.dgvMarksByCourse.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvMarksByCourse_DataError);
            // 
            // chSID2
            // 
            this.chSID2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chSID2.DataPropertyName = "SID";
            this.chSID2.HeaderText = "Student ID";
            this.chSID2.Name = "chSID2";
            this.chSID2.ReadOnly = true;
            // 
            // chName
            // 
            this.chName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chName.HeaderText = "Student Name";
            this.chName.Name = "chName";
            this.chName.ReadOnly = true;
            this.chName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // chMark2
            // 
            this.chMark2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chMark2.DataPropertyName = "Mark";
            this.chMark2.HeaderText = "Mark";
            this.chMark2.Name = "chMark2";
            // 
            // btnAddMarksByCourse
            // 
            this.btnAddMarksByCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMarksByCourse.ImageKey = "add.png";
            this.btnAddMarksByCourse.ImageList = this.appIcons;
            this.btnAddMarksByCourse.Location = new System.Drawing.Point(209, 445);
            this.btnAddMarksByCourse.Name = "btnAddMarksByCourse";
            this.btnAddMarksByCourse.Size = new System.Drawing.Size(170, 30);
            this.btnAddMarksByCourse.TabIndex = 19;
            this.btnAddMarksByCourse.Text = "Ad&d Mark";
            this.btnAddMarksByCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddMarksByCourse.UseVisualStyleBackColor = true;
            this.btnAddMarksByCourse.Click += new System.EventHandler(this.btnAddMarksByCourse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mark";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Student ID";
            // 
            // txtMarksByCourse
            // 
            this.txtMarksByCourse.Location = new System.Drawing.Point(116, 455);
            this.txtMarksByCourse.Name = "txtMarksByCourse";
            this.txtMarksByCourse.Size = new System.Drawing.Size(75, 20);
            this.txtMarksByCourse.TabIndex = 16;
            this.txtMarksByCourse.Text = "0";
            // 
            // cmbMarksByCourseStudentID
            // 
            this.cmbMarksByCourseStudentID.DisplayMember = "ID";
            this.cmbMarksByCourseStudentID.FormattingEnabled = true;
            this.cmbMarksByCourseStudentID.Location = new System.Drawing.Point(6, 455);
            this.cmbMarksByCourseStudentID.Name = "cmbMarksByCourseStudentID";
            this.cmbMarksByCourseStudentID.Size = new System.Drawing.Size(101, 21);
            this.cmbMarksByCourseStudentID.TabIndex = 15;
            this.cmbMarksByCourseStudentID.ValueMember = "ID";
            this.cmbMarksByCourseStudentID.SelectedIndexChanged += new System.EventHandler(this.cmbMarksByCourseStudentID_SelectedIndexChanged);
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(113, 19);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(126, 18);
            this.lblCourseName.TabIndex = 13;
            this.lblCourseName.Text = "<course name>";
            // 
            // lblSelectCourse
            // 
            this.lblSelectCourse.AutoSize = true;
            this.lblSelectCourse.Location = new System.Drawing.Point(3, 53);
            this.lblSelectCourse.Name = "lblSelectCourse";
            this.lblSelectCourse.Size = new System.Drawing.Size(173, 13);
            this.lblSelectCourse.TabIndex = 12;
            this.lblSelectCourse.Text = "Please select a course from above.";
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Location = new System.Drawing.Point(3, 4);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(54, 13);
            this.lblCourseID.TabIndex = 11;
            this.lblCourseID.Text = "Course ID";
            // 
            // cmbCourseID
            // 
            this.cmbCourseID.DisplayMember = "CID";
            this.cmbCourseID.FormattingEnabled = true;
            this.cmbCourseID.Location = new System.Drawing.Point(6, 20);
            this.cmbCourseID.Name = "cmbCourseID";
            this.cmbCourseID.Size = new System.Drawing.Size(101, 21);
            this.cmbCourseID.TabIndex = 10;
            this.cmbCourseID.ValueMember = "CID";
            this.cmbCourseID.SelectedIndexChanged += new System.EventHandler(this.cmbCourseID_SelectedIndexChanged);
            this.cmbCourseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCourseID_KeyPress);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripErrorLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 545);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(417, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusStripErrorLabel
            // 
            this.statusStripErrorLabel.Name = "statusStripErrorLabel";
            this.statusStripErrorLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(417, 24);
            this.menuStrip1.TabIndex = 20;
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
            // FrmMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 567);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMarks";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marks Management";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabControl.ResumeLayout(false);
            this.dgvMarksByCourseMenu.ResumeLayout(false);
            this.tabMarksByStudent.ResumeLayout(false);
            this.tabMarksByStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarksByStudent)).EndInit();
            this.dgvMarksByStudentMenu.ResumeLayout(false);
            this.tabMarksByCourse.ResumeLayout(false);
            this.tabMarksByCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarksByCourse)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMarksByStudent;
        private System.Windows.Forms.TabPage tabMarksByCourse;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.Label lblSelectedStudent;
        private System.Windows.Forms.Label lblSelStudent;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblSelectCourse;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.ComboBox cmbCourseID;
        private System.Windows.Forms.ComboBox cmbMarksByStudentCourseID;
        private System.Windows.Forms.ComboBox cmbMarksByCourseStudentID;
        private System.Windows.Forms.TextBox txtMarksByStudent;
        private System.Windows.Forms.TextBox txtMarksByCourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddMarksByCourse;
        private System.Windows.Forms.DataGridView dgvMarksByStudent;

        private System.Windows.Forms.DataGridView dgvMarksByCourse;
        private System.Windows.Forms.ContextMenuStrip dgvMarksByCourseMenu;
        private System.Windows.Forms.ToolStripMenuItem CourseIdContext;
        private System.Windows.Forms.ContextMenuStrip dgvMarksByStudentMenu;
        private System.Windows.Forms.ToolStripMenuItem StudentIdContext;
        private System.Windows.Forms.Button btnAddMarkByStudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn chSID;
        private System.Windows.Forms.DataGridViewTextBoxColumn chCourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn chMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn chSID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn chName;
        private System.Windows.Forms.DataGridViewTextBoxColumn chMark2;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusStripErrorLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ImageList appIcons;
        private System.Windows.Forms.ToolTip ttTip;
    }
}