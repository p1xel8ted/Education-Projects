namespace ABC_Management_Studio
{
    internal partial class FrmPeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPeople));
            this.tabPeople = new System.Windows.Forms.TabControl();
            this.tabAdmins = new System.Windows.Forms.TabPage();
            this.dgvAdminExtras = new System.Windows.Forms.DataGridView();
            this.dgvRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbAdminSelect = new System.Windows.Forms.ComboBox();
            this.dgvAdmins = new System.Windows.Forms.DataGridView();
            this.chAdminID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chAdminFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chAdminLName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chAdminDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chAdminPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chAdminAddressOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chAdminAddressTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chAdminSuburb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chAdminState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagePeopleContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ManagePeopleContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabTeachers = new System.Windows.Forms.TabPage();
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTeacherExtras = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbTeacherSelect = new System.Windows.Forms.ComboBox();
            this.tabStudents = new System.Windows.Forms.TabPage();
            this.cmbStudentSelect = new System.Windows.Forms.ComboBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.chStudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chStudentFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chStudentLName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chStudentDob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chStudentPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chStudentAdd1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chStudentAdd2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chStudentSuburb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chStudentPostcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chStudentState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAdd1 = new System.Windows.Forms.TextBox();
            this.txtAdd2 = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtRego = new System.Windows.Forms.TextBox();
            this.chkVerified = new System.Windows.Forms.CheckBox();
            this.cmbQualification = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.appIcons = new System.Windows.Forms.ImageList(this.components);
            this.ttTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabPeople.SuspendLayout();
            this.tabAdmins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminExtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).BeginInit();
            this.ManagePeopleContext.SuspendLayout();
            this.tabTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherExtras)).BeginInit();
            this.tabStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPeople
            // 
            this.tabPeople.Controls.Add(this.tabAdmins);
            this.tabPeople.Controls.Add(this.tabTeachers);
            this.tabPeople.Controls.Add(this.tabStudents);
            this.tabPeople.Location = new System.Drawing.Point(12, 27);
            this.tabPeople.Name = "tabPeople";
            this.tabPeople.SelectedIndex = 0;
            this.tabPeople.Size = new System.Drawing.Size(972, 302);
            this.tabPeople.TabIndex = 0;
            this.tabPeople.SelectedIndexChanged += new System.EventHandler(this.tabPeople_SelectedIndexChanged);
            // 
            // tabAdmins
            // 
            this.tabAdmins.Controls.Add(this.dgvAdminExtras);
            this.tabAdmins.Controls.Add(this.cmbAdminSelect);
            this.tabAdmins.Controls.Add(this.dgvAdmins);
            this.tabAdmins.Location = new System.Drawing.Point(4, 22);
            this.tabAdmins.Name = "tabAdmins";
            this.tabAdmins.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdmins.Size = new System.Drawing.Size(964, 276);
            this.tabAdmins.TabIndex = 0;
            this.tabAdmins.Text = "Administrators";
            this.tabAdmins.UseVisualStyleBackColor = true;
            // 
            // dgvAdminExtras
            // 
            this.dgvAdminExtras.AllowUserToAddRows = false;
            this.dgvAdminExtras.AllowUserToResizeColumns = false;
            this.dgvAdminExtras.AllowUserToResizeRows = false;
            this.dgvAdminExtras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdminExtras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAdminExtras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminExtras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvRole,
            this.dgvPass});
            this.dgvAdminExtras.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvAdminExtras.Location = new System.Drawing.Point(799, 34);
            this.dgvAdminExtras.MultiSelect = false;
            this.dgvAdminExtras.Name = "dgvAdminExtras";
            this.dgvAdminExtras.RowHeadersVisible = false;
            this.dgvAdminExtras.Size = new System.Drawing.Size(162, 242);
            this.dgvAdminExtras.TabIndex = 2;
            this.dgvAdminExtras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdminExtras_CellClick);
            this.dgvAdminExtras.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdminExtras_CellEndEdit);
            this.dgvAdminExtras.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAdminExtras_CellMouseUp);
            // 
            // dgvRole
            // 
            this.dgvRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvRole.DataPropertyName = "Role";
            this.dgvRole.FillWeight = 75F;
            this.dgvRole.HeaderText = "Role";
            this.dgvRole.Name = "dgvRole";
            // 
            // dgvPass
            // 
            this.dgvPass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvPass.DataPropertyName = "Password";
            this.dgvPass.FillWeight = 75F;
            this.dgvPass.HeaderText = "Password";
            this.dgvPass.Name = "dgvPass";
            // 
            // cmbAdminSelect
            // 
            this.cmbAdminSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAdminSelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAdminSelect.FormattingEnabled = true;
            this.cmbAdminSelect.Location = new System.Drawing.Point(3, 7);
            this.cmbAdminSelect.Name = "cmbAdminSelect";
            this.cmbAdminSelect.Size = new System.Drawing.Size(100, 21);
            this.cmbAdminSelect.TabIndex = 1;
            this.cmbAdminSelect.SelectedIndexChanged += new System.EventHandler(this.cmbAdminSelect_SelectedIndexChanged);
            // 
            // dgvAdmins
            // 
            this.dgvAdmins.AllowUserToAddRows = false;
            this.dgvAdmins.AllowUserToResizeColumns = false;
            this.dgvAdmins.AllowUserToResizeRows = false;
            this.dgvAdmins.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdmins.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAdmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chAdminID,
            this.chAdminFName,
            this.chAdminLName,
            this.chAdminDOB,
            this.chAdminPhone,
            this.chAdminAddressOne,
            this.chAdminAddressTwo,
            this.chAdminSuburb,
            this.chAdminState});
            this.dgvAdmins.ContextMenuStrip = this.ManagePeopleContext;
            this.dgvAdmins.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvAdmins.Location = new System.Drawing.Point(3, 34);
            this.dgvAdmins.MultiSelect = false;
            this.dgvAdmins.Name = "dgvAdmins";
            this.dgvAdmins.RowHeadersVisible = false;
            this.dgvAdmins.Size = new System.Drawing.Size(795, 242);
            this.dgvAdmins.TabIndex = 0;
            this.dgvAdmins.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmins_CellClick);
            this.dgvAdmins.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmins_CellEndEdit);
            this.dgvAdmins.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAdmins_CellMouseUp);
            // 
            // chAdminID
            // 
            this.chAdminID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chAdminID.DataPropertyName = "ID";
            this.chAdminID.FillWeight = 50F;
            this.chAdminID.HeaderText = "ID";
            this.chAdminID.Name = "chAdminID";
            this.chAdminID.ReadOnly = true;
            this.chAdminID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // chAdminFName
            // 
            this.chAdminFName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chAdminFName.DataPropertyName = "FName";
            this.chAdminFName.FillWeight = 120F;
            this.chAdminFName.HeaderText = "First Name";
            this.chAdminFName.Name = "chAdminFName";
            // 
            // chAdminLName
            // 
            this.chAdminLName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chAdminLName.DataPropertyName = "LName";
            this.chAdminLName.FillWeight = 120F;
            this.chAdminLName.HeaderText = "Last Name";
            this.chAdminLName.Name = "chAdminLName";
            // 
            // chAdminDOB
            // 
            this.chAdminDOB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chAdminDOB.DataPropertyName = "DOB";
            this.chAdminDOB.HeaderText = "D.O.B";
            this.chAdminDOB.Name = "chAdminDOB";
            // 
            // chAdminPhone
            // 
            this.chAdminPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chAdminPhone.DataPropertyName = "Phone";
            this.chAdminPhone.HeaderText = "Phone";
            this.chAdminPhone.Name = "chAdminPhone";
            // 
            // chAdminAddressOne
            // 
            this.chAdminAddressOne.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chAdminAddressOne.DataPropertyName = "Add1";
            this.chAdminAddressOne.HeaderText = "Unit/House";
            this.chAdminAddressOne.Name = "chAdminAddressOne";
            // 
            // chAdminAddressTwo
            // 
            this.chAdminAddressTwo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chAdminAddressTwo.DataPropertyName = "Add2";
            this.chAdminAddressTwo.FillWeight = 200F;
            this.chAdminAddressTwo.HeaderText = "Street/Road";
            this.chAdminAddressTwo.Name = "chAdminAddressTwo";
            // 
            // chAdminSuburb
            // 
            this.chAdminSuburb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chAdminSuburb.DataPropertyName = "Suburb";
            this.chAdminSuburb.FillWeight = 75F;
            this.chAdminSuburb.HeaderText = "Suburb";
            this.chAdminSuburb.Name = "chAdminSuburb";
            // 
            // chAdminState
            // 
            this.chAdminState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chAdminState.DataPropertyName = "State";
            this.chAdminState.FillWeight = 75F;
            this.chAdminState.HeaderText = "State";
            this.chAdminState.Name = "chAdminState";
            // 
            // ManagePeopleContext
            // 
            this.ManagePeopleContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManagePeopleContextItem});
            this.ManagePeopleContext.Name = "MaintainCoursesContext";
            this.ManagePeopleContext.Size = new System.Drawing.Size(157, 26);
            // 
            // ManagePeopleContextItem
            // 
            this.ManagePeopleContextItem.Image = global::ABC_Management_Studio.Properties.Resources.edit_remove;
            this.ManagePeopleContextItem.Name = "ManagePeopleContextItem";
            this.ManagePeopleContextItem.Size = new System.Drawing.Size(156, 22);
            this.ManagePeopleContextItem.Text = "&Remove Person";
            this.ManagePeopleContextItem.Click += new System.EventHandler(this.ManagePeopleContextItem_Click);
            // 
            // tabTeachers
            // 
            this.tabTeachers.Controls.Add(this.dgvTeachers);
            this.tabTeachers.Controls.Add(this.dgvTeacherExtras);
            this.tabTeachers.Controls.Add(this.cmbTeacherSelect);
            this.tabTeachers.Location = new System.Drawing.Point(4, 22);
            this.tabTeachers.Name = "tabTeachers";
            this.tabTeachers.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeachers.Size = new System.Drawing.Size(964, 276);
            this.tabTeachers.TabIndex = 1;
            this.tabTeachers.Text = "Teachers";
            this.tabTeachers.UseVisualStyleBackColor = true;
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.AllowUserToAddRows = false;
            this.dgvTeachers.AllowUserToResizeColumns = false;
            this.dgvTeachers.AllowUserToResizeRows = false;
            this.dgvTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeachers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dgvTeachers.ContextMenuStrip = this.ManagePeopleContext;
            this.dgvTeachers.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvTeachers.Location = new System.Drawing.Point(3, 34);
            this.dgvTeachers.MultiSelect = false;
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.RowHeadersVisible = false;
            this.dgvTeachers.Size = new System.Drawing.Size(795, 242);
            this.dgvTeachers.TabIndex = 4;
            this.dgvTeachers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeachers_CellClick);
            this.dgvTeachers.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTeachers_CellMouseUp);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn3.FillWeight = 50F;
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FName";
            this.dataGridViewTextBoxColumn4.FillWeight = 120F;
            this.dataGridViewTextBoxColumn4.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LName";
            this.dataGridViewTextBoxColumn5.FillWeight = 120F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DOB";
            this.dataGridViewTextBoxColumn6.HeaderText = "D.O.B";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn7.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Add1";
            this.dataGridViewTextBoxColumn8.HeaderText = "Unit/House";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Add2";
            this.dataGridViewTextBoxColumn9.FillWeight = 200F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Street/Road";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Suburb";
            this.dataGridViewTextBoxColumn10.FillWeight = 75F;
            this.dataGridViewTextBoxColumn10.HeaderText = "Suburb";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn11.FillWeight = 75F;
            this.dataGridViewTextBoxColumn11.HeaderText = "State";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dgvTeacherExtras
            // 
            this.dgvTeacherExtras.AllowUserToAddRows = false;
            this.dgvTeacherExtras.AllowUserToResizeColumns = false;
            this.dgvTeacherExtras.AllowUserToResizeRows = false;
            this.dgvTeacherExtras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeacherExtras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTeacherExtras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherExtras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvTeacherExtras.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvTeacherExtras.Location = new System.Drawing.Point(799, 34);
            this.dgvTeacherExtras.MultiSelect = false;
            this.dgvTeacherExtras.Name = "dgvTeacherExtras";
            this.dgvTeacherExtras.RowHeadersVisible = false;
            this.dgvTeacherExtras.Size = new System.Drawing.Size(162, 242);
            this.dgvTeacherExtras.TabIndex = 3;
            this.dgvTeacherExtras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeacherExtras_CellClick);
            this.dgvTeacherExtras.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeacherExtras_CellEndEdit);
            this.dgvTeacherExtras.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTeacherExtras_CellMouseUp);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RegNo";
            this.dataGridViewTextBoxColumn1.FillWeight = 75F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Rego #";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn2.FillWeight = 75F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Password";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // cmbTeacherSelect
            // 
            this.cmbTeacherSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTeacherSelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTeacherSelect.FormattingEnabled = true;
            this.cmbTeacherSelect.Location = new System.Drawing.Point(3, 7);
            this.cmbTeacherSelect.Name = "cmbTeacherSelect";
            this.cmbTeacherSelect.Size = new System.Drawing.Size(100, 21);
            this.cmbTeacherSelect.TabIndex = 2;
            this.cmbTeacherSelect.SelectedIndexChanged += new System.EventHandler(this.cmbTeacherSelect_SelectedIndexChanged);
            // 
            // tabStudents
            // 
            this.tabStudents.Controls.Add(this.cmbStudentSelect);
            this.tabStudents.Controls.Add(this.dgvStudents);
            this.tabStudents.Location = new System.Drawing.Point(4, 22);
            this.tabStudents.Name = "tabStudents";
            this.tabStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudents.Size = new System.Drawing.Size(964, 276);
            this.tabStudents.TabIndex = 2;
            this.tabStudents.Text = "Students";
            this.tabStudents.UseVisualStyleBackColor = true;
            // 
            // cmbStudentSelect
            // 
            this.cmbStudentSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStudentSelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStudentSelect.FormattingEnabled = true;
            this.cmbStudentSelect.Location = new System.Drawing.Point(3, 7);
            this.cmbStudentSelect.Name = "cmbStudentSelect";
            this.cmbStudentSelect.Size = new System.Drawing.Size(100, 21);
            this.cmbStudentSelect.TabIndex = 3;
            this.cmbStudentSelect.SelectedIndexChanged += new System.EventHandler(this.cmbStudentSelect_SelectedIndexChanged);
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToResizeColumns = false;
            this.dgvStudents.AllowUserToResizeRows = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chStudentId,
            this.chStudentFName,
            this.chStudentLName,
            this.chStudentDob,
            this.chStudentPhone,
            this.chStudentAdd1,
            this.chStudentAdd2,
            this.chStudentSuburb,
            this.chStudentPostcode,
            this.chStudentState});
            this.dgvStudents.ContextMenuStrip = this.ManagePeopleContext;
            this.dgvStudents.Location = new System.Drawing.Point(3, 34);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.Size = new System.Drawing.Size(958, 242);
            this.dgvStudents.TabIndex = 2;
            this.dgvStudents.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStudents_CellMouseUp);
            // 
            // chStudentId
            // 
            this.chStudentId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chStudentId.DataPropertyName = "ID";
            this.chStudentId.FillWeight = 50F;
            this.chStudentId.HeaderText = "ID";
            this.chStudentId.Name = "chStudentId";
            this.chStudentId.ReadOnly = true;
            this.chStudentId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // chStudentFName
            // 
            this.chStudentFName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chStudentFName.DataPropertyName = "FName";
            this.chStudentFName.FillWeight = 120F;
            this.chStudentFName.HeaderText = "First Name";
            this.chStudentFName.Name = "chStudentFName";
            // 
            // chStudentLName
            // 
            this.chStudentLName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chStudentLName.DataPropertyName = "LName";
            this.chStudentLName.FillWeight = 120F;
            this.chStudentLName.HeaderText = "Last Name";
            this.chStudentLName.Name = "chStudentLName";
            // 
            // chStudentDob
            // 
            this.chStudentDob.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chStudentDob.DataPropertyName = "DOB";
            this.chStudentDob.HeaderText = "D.O.B";
            this.chStudentDob.Name = "chStudentDob";
            // 
            // chStudentPhone
            // 
            this.chStudentPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chStudentPhone.DataPropertyName = "Phone";
            this.chStudentPhone.HeaderText = "Phone";
            this.chStudentPhone.Name = "chStudentPhone";
            // 
            // chStudentAdd1
            // 
            this.chStudentAdd1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chStudentAdd1.DataPropertyName = "Add1";
            this.chStudentAdd1.FillWeight = 75F;
            this.chStudentAdd1.HeaderText = "Unit/House";
            this.chStudentAdd1.Name = "chStudentAdd1";
            // 
            // chStudentAdd2
            // 
            this.chStudentAdd2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chStudentAdd2.DataPropertyName = "Add2";
            this.chStudentAdd2.FillWeight = 200F;
            this.chStudentAdd2.HeaderText = "Street/Road";
            this.chStudentAdd2.Name = "chStudentAdd2";
            // 
            // chStudentSuburb
            // 
            this.chStudentSuburb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chStudentSuburb.DataPropertyName = "Suburb";
            this.chStudentSuburb.HeaderText = "Suburb";
            this.chStudentSuburb.Name = "chStudentSuburb";
            // 
            // chStudentPostcode
            // 
            this.chStudentPostcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chStudentPostcode.DataPropertyName = "Postcode";
            this.chStudentPostcode.HeaderText = "Post Code";
            this.chStudentPostcode.Name = "chStudentPostcode";
            // 
            // chStudentState
            // 
            this.chStudentState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chStudentState.DataPropertyName = "State";
            this.chStudentState.FillWeight = 75F;
            this.chStudentState.HeaderText = "State";
            this.chStudentState.Name = "chStudentState";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLbl});
            this.statusStrip.Location = new System.Drawing.Point(0, 397);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(993, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 1;
            // 
            // statusStripLbl
            // 
            this.statusStripLbl.Name = "statusStripLbl";
            this.statusStripLbl.Size = new System.Drawing.Size(0, 17);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(12, 335);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(134, 20);
            this.txtFName.TabIndex = 3;
            this.txtFName.Text = "First Name";
            this.txtFName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFName_KeyUp);
            this.txtFName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFName_Validating);
            this.txtFName.Validated += new System.EventHandler(this.txtFName_Validated);
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(152, 335);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(153, 20);
            this.txtLName.TabIndex = 4;
            this.txtLName.Text = "Last Name";
            this.txtLName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLName_KeyUp);
            this.txtLName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLName_Validating);
            this.txtLName.Validated += new System.EventHandler(this.txtLName_Validated);
            // 
            // dobPicker
            // 
            this.dobPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobPicker.Location = new System.Drawing.Point(311, 335);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(93, 20);
            this.dobPicker.TabIndex = 5;
            this.dobPicker.Value = new System.DateTime(2015, 10, 25, 0, 0, 0, 0);
            this.dobPicker.Validating += new System.ComponentModel.CancelEventHandler(this.dobPicker_Validating);
            this.dobPicker.Validated += new System.EventHandler(this.dobPicker_Validated);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(410, 335);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(89, 20);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.Text = "Phone";
            this.ttTip.SetToolTip(this.txtPhone, "Mobiles or Landlines (Please include area code)");
            this.txtPhone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPhone_KeyUp);
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            this.txtPhone.Validated += new System.EventHandler(this.txtPhone_Validated);
            // 
            // txtAdd1
            // 
            this.txtAdd1.Location = new System.Drawing.Point(505, 335);
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.Size = new System.Drawing.Size(72, 20);
            this.txtAdd1.TabIndex = 7;
            this.txtAdd1.Text = "Unit/House";
            this.txtAdd1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAdd1_KeyUp);
            this.txtAdd1.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdd1_Validating);
            this.txtAdd1.Validated += new System.EventHandler(this.txtAdd1_Validated);
            // 
            // txtAdd2
            // 
            this.txtAdd2.Location = new System.Drawing.Point(583, 335);
            this.txtAdd2.Name = "txtAdd2";
            this.txtAdd2.Size = new System.Drawing.Size(158, 20);
            this.txtAdd2.TabIndex = 8;
            this.txtAdd2.Text = "Street/Road";
            this.txtAdd2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAdd2_KeyUp);
            this.txtAdd2.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdd2_Validating);
            this.txtAdd2.Validated += new System.EventHandler(this.txtAdd2_Validated);
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(747, 335);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(97, 20);
            this.txtSuburb.TabIndex = 9;
            this.txtSuburb.Text = "Suburb";
            this.txtSuburb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSuburb_KeyUp);
            this.txtSuburb.Validating += new System.ComponentModel.CancelEventHandler(this.txtSuburb_Validating);
            this.txtSuburb.Validated += new System.EventHandler(this.txtSuburb_Validated);
            // 
            // cmbState
            // 
            this.cmbState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "VIC",
            "NSW",
            "ACT",
            "QLD",
            "SA",
            "TAS",
            "WA",
            "NT"});
            this.cmbState.Location = new System.Drawing.Point(850, 335);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(55, 21);
            this.cmbState.TabIndex = 10;
            this.cmbState.Text = "State";
            this.cmbState.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbState_KeyUp);
            this.cmbState.Validating += new System.ComponentModel.CancelEventHandler(this.cmbState_Validating);
            this.cmbState.Validated += new System.EventHandler(this.cmbState_Validated);
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(911, 335);
            this.txtPostCode.MaxLength = 4;
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(72, 20);
            this.txtPostCode.TabIndex = 11;
            this.txtPostCode.Text = "Post Code";
            this.txtPostCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPostCode_KeyUp);
            this.txtPostCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtPostCode_Validating);
            this.txtPostCode.Validated += new System.EventHandler(this.txtPostCode_Validated);
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(12, 362);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(115, 20);
            this.txtRole.TabIndex = 12;
            this.txtRole.Text = "Role";
            this.txtRole.Visible = false;
            this.txtRole.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRole_KeyUp);
            this.txtRole.Validating += new System.ComponentModel.CancelEventHandler(this.txtRole_Validating);
            this.txtRole.Validated += new System.EventHandler(this.txtRole_Validated);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(133, 362);
            this.txtPass.MaxLength = 7;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(115, 20);
            this.txtPass.TabIndex = 13;
            this.txtPass.Text = "Pass";
            this.txtPass.Visible = false;
            this.txtPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyUp);
            this.txtPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtPass_Validating);
            this.txtPass.Validated += new System.EventHandler(this.txtPass_Validated);
            // 
            // txtRego
            // 
            this.txtRego.Location = new System.Drawing.Point(12, 362);
            this.txtRego.Name = "txtRego";
            this.txtRego.Size = new System.Drawing.Size(115, 20);
            this.txtRego.TabIndex = 12;
            this.txtRego.Text = "Rego";
            this.txtRego.Visible = false;
            this.txtRego.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRego_KeyUp);
            this.txtRego.Validating += new System.ComponentModel.CancelEventHandler(this.txtRego_Validating);
            this.txtRego.Validated += new System.EventHandler(this.txtRego_Validated);
            // 
            // chkVerified
            // 
            this.chkVerified.AutoSize = true;
            this.chkVerified.Location = new System.Drawing.Point(558, 366);
            this.chkVerified.Name = "chkVerified";
            this.chkVerified.Size = new System.Drawing.Size(286, 17);
            this.chkVerified.TabIndex = 15;
            this.chkVerified.Text = "I have verified the information I have entered is correct.";
            this.chkVerified.UseVisualStyleBackColor = true;
            this.chkVerified.CheckedChanged += new System.EventHandler(this.chkVerified_CheckedChanged);
            // 
            // cmbQualification
            // 
            this.cmbQualification.DisplayMember = "QName";
            this.cmbQualification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQualification.FormattingEnabled = true;
            this.cmbQualification.Location = new System.Drawing.Point(12, 362);
            this.cmbQualification.Name = "cmbQualification";
            this.cmbQualification.Size = new System.Drawing.Size(188, 21);
            this.cmbQualification.TabIndex = 14;
            this.cmbQualification.ValueMember = "QCode";
            this.cmbQualification.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(993, 24);
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
            // btnAddPerson
            // 
            this.btnAddPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddPerson.ImageIndex = 2;
            this.btnAddPerson.ImageList = this.appIcons;
            this.btnAddPerson.Location = new System.Drawing.Point(850, 362);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnAddPerson.Size = new System.Drawing.Size(133, 23);
            this.btnAddPerson.TabIndex = 21;
            this.btnAddPerson.Text = "&Add Administrator";
            this.btnAddPerson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
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
            // ttTip
            // 
            this.ttTip.AutoPopDelay = 5000;
            this.ttTip.InitialDelay = 250;
            this.ttTip.ReshowDelay = 100;
            this.ttTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttTip.ToolTipTitle = "Info";
            // 
            // FrmPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 419);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cmbQualification);
            this.Controls.Add(this.chkVerified);
            this.Controls.Add(this.txtRego);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtPostCode);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.txtAdd2);
            this.Controls.Add(this.txtAdd1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.dobPicker);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabPeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPeople";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "People Management";
            this.Load += new System.EventHandler(this.FrmPeople_Load);
            this.tabPeople.ResumeLayout(false);
            this.tabAdmins.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminExtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).EndInit();
            this.ManagePeopleContext.ResumeLayout(false);
            this.tabTeachers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherExtras)).EndInit();
            this.tabStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabPeople;
        private System.Windows.Forms.TabPage tabAdmins;
        private System.Windows.Forms.DataGridView dgvAdmins;
        private System.Windows.Forms.TabPage tabTeachers;
        private System.Windows.Forms.TabPage tabStudents;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLbl;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAdd1;
        private System.Windows.Forms.TextBox txtAdd2;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtRego;
        private System.Windows.Forms.CheckBox chkVerified;
        private System.Windows.Forms.DataGridViewTextBoxColumn chStudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn chStudentFName;
        private System.Windows.Forms.DataGridViewTextBoxColumn chStudentLName;
        private System.Windows.Forms.DataGridViewTextBoxColumn chStudentDob;
        private System.Windows.Forms.DataGridViewTextBoxColumn chStudentPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn chStudentAdd1;
        private System.Windows.Forms.DataGridViewTextBoxColumn chStudentAdd2;
        private System.Windows.Forms.DataGridViewTextBoxColumn chStudentSuburb;
        private System.Windows.Forms.DataGridViewTextBoxColumn chStudentPostcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn chStudentState;
        private System.Windows.Forms.ComboBox cmbQualification;
        private System.Windows.Forms.ComboBox cmbAdminSelect;
        private System.Windows.Forms.ComboBox cmbTeacherSelect;
        private System.Windows.Forms.ComboBox cmbStudentSelect;
        private System.Windows.Forms.ContextMenuStrip ManagePeopleContext;
        private System.Windows.Forms.ToolStripMenuItem ManagePeopleContextItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn chAdminID;
        private System.Windows.Forms.DataGridViewTextBoxColumn chAdminFName;
        private System.Windows.Forms.DataGridViewTextBoxColumn chAdminLName;
        private System.Windows.Forms.DataGridViewTextBoxColumn chAdminDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn chAdminPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn chAdminAddressOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn chAdminAddressTwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn chAdminSuburb;
        private System.Windows.Forms.DataGridViewTextBoxColumn chAdminState;
        private System.Windows.Forms.DataGridView dgvAdminExtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPass;
        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridView dgvTeacherExtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.ImageList appIcons;
        private System.Windows.Forms.ToolTip ttTip;
    }
}