/*
* Author: Ben Logan
* Student ID: 30013164
*/

using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;

namespace ABC_Management_Studio
{
    internal partial class FrmPeople : Form
    {
        private string _startWindow; //used for forcing a tab to be displayed

        internal FrmPeople(string startWindow)
        {
            InitializeComponent();
            _startWindow = startWindow;
        }

        /// <summary>
        ///     Used for creating and adding a new administrator.
        /// </summary>
        private void AddAdmin()
        {
            var newPerson = new Person
            {
                Add1 = txtAdd1.Text,
                Add2 = txtAdd2.Text,
                DOB = dobPicker.Value.Date,
                FName = txtFName.Text,
                LName = txtLName.Text,
                Phone = txtPhone.Text,
                Postcode = txtPostCode.Text,
                State = cmbState.Text,
                Suburb = txtSuburb.Text,
                Type = "Administrator"
            };
            var newAdmin = new Administration
            {
                Person = newPerson,
                AID = newPerson.ID,
                Password = txtPass.Text,
                Role = txtRole.Text
            };

            Util.Db.Administrations.InsertOnSubmit(newAdmin);
            Util.Db.SubmitChanges();
            Util.Db.Refresh(RefreshMode.OverwriteCurrentValues, Util.Db.Administrations);
            _startWindow = "a"; //makes sure the tab stays on admin when we reload the form
            if (Util.DoesPersonExist(newPerson.ID))
            {
                //if person was added successfully, show a message with ID and reload form, highlighting new user
                Messages.AddedPersonSuccess(newPerson);
                FrmPeople_Load(null, null);
                cmbAdminSelect.SelectedValue = newPerson.ID;
            }
            else
            {
                Messages.GenericProblem();
            }
        }

        /// <summary>
        ///     Used for creating and adding a new student.
        /// </summary>
        private void AddStudent()
        {
            var newPerson = new Person
            {
                ID = 55,
                Add1 = txtAdd1.Text,
                Add2 = txtAdd2.Text,
                DOB = dobPicker.Value.Date,
                FName = txtFName.Text,
                LName = txtLName.Text,
                Phone = txtPhone.Text,
                Postcode = txtPostCode.Text,
                State = cmbState.Text,
                Suburb = txtSuburb.Text,
                Type = "Student"
            };
            var newStudent = new Student
            {
                Person = newPerson,
                Sdate = DateTime.Today.Date,
                QCode = cmbQualification.SelectedValue.ToString()
            };
            Util.Db.Students.InsertOnSubmit(newStudent);
            Util.Db.SubmitChanges();
            Util.Db.Refresh(RefreshMode.OverwriteCurrentValues, Util.Db.Students);
            _startWindow = "s"; //makes sure the tab stays on student when we reload the form
            if (Util.DoesPersonExist(newPerson.ID))
            {
                //if person was added successfully, show a message with ID and reload form, highlighting new user
                Messages.AddedPersonSuccess(newPerson);
                FrmPeople_Load(null, null);
                cmbAdminSelect.SelectedValue = newPerson.ID;
            }
            else
            {
                Messages.GenericProblem();
            }
        }

        /// <summary>
        ///     Used for creating and adding a new teacher.
        /// </summary>
        private void AddTeacher()
        {
            var newPerson = new Person
            {
                Add1 = txtAdd1.Text,
                Add2 = txtAdd2.Text,
                DOB = dobPicker.Value.Date,
                FName = txtFName.Text,
                LName = txtLName.Text,
                Phone = txtPhone.Text,
                Postcode = txtPostCode.Text,
                State = cmbState.Text,
                Suburb = txtSuburb.Text,
                Type = "Teacher"
            };
            var newTeacher = new Teacher
            {
                Person = newPerson,
                Password = txtPass.Text,
                RegNo = txtRego.Text
            };

            Util.Db.Teachers.InsertOnSubmit(newTeacher);
            Util.Db.SubmitChanges();
            Util.Db.Refresh(RefreshMode.OverwriteCurrentValues, Util.Db.Teachers);
            _startWindow = "t"; //makes sure the tab stays on teacher when we reload the form
            if (Util.DoesPersonExist(newPerson.ID))
            {
                //if person was added successfully, show a message with ID and reload form, highlighting new user
                Messages.AddedPersonSuccess(newPerson);
                FrmPeople_Load(null, null);
                cmbAdminSelect.SelectedValue = newPerson.ID;
            }
            else
            {
                Messages.GenericProblem();
            }
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            if (chkVerified.Checked)
            {
                if (tabPeople.SelectedTab == tabAdmins)
                {
                    AddAdmin();
                    return;
                }
                if (tabPeople.SelectedTab == tabStudents)
                {
                    AddStudent();
                    return;
                }
                if (tabPeople.SelectedTab == tabTeachers)
                {
                    AddTeacher();
                }
            }
            else
            {
                Messages.CheckBoxValidationMessage();
            }
        }

        private void ClearAdminSelection()
        {
            //clears any selected cells on admin tab
            dgvAdmins.ClearSelection();
            dgvAdminExtras.ClearSelection();
        }

        private void ClearSelections()
        {
            ClearAdminSelection();
            ClearTeacherSelection();
            ClearStudentSelection();
        }

        private void ClearStudentSelection()
        {
            dgvStudents.ClearSelection();
        }

        private void ClearTeacherSelection()
        {
            dgvTeachers.ClearSelection();
            dgvTeacherExtras.ClearSelection();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbAdminSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selects the entire row of the person selected in the combo box
            dgvAdmins.ClearSelection();
            foreach (
                var row in
                    dgvAdmins.Rows.Cast<DataGridViewRow>()
                        .Where(row => row.Cells[0].Value.ToString() == cmbAdminSelect.Text))
            {
                dgvAdmins.Rows[row.Index].Selected = true;
                dgvAdminExtras.Rows[row.Index].Selected = true;
            }
        }

        private void cmbState_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape || !string.IsNullOrEmpty(cmbState.Text)) return;
            cmbState.Text = @"State";
        }

        private void cmbState_Validated(object sender, EventArgs e)
        {
            statusStripLbl.Text = "";
        }

        private void cmbState_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbState.Text)) return;
            statusStripLbl.Text = @"State can't be empty.";
            e.Cancel = true;
        }

        private void cmbStudentSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selects the entire row of the person selected in the combo box
            dgvStudents.ClearSelection();
            foreach (
                var row in
                    dgvStudents.Rows.Cast<DataGridViewRow>()
                        .Where(row => row.Cells[0].Value.ToString() == cmbStudentSelect.Text))
            {
                dgvStudents.Rows[row.Index].Selected = true;
            }
        }

        private void cmbTeacherSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selects the entire row of the person selected in the combo box
            dgvTeachers.ClearSelection();
            foreach (
                var row in
                    dgvTeachers.Rows.Cast<DataGridViewRow>()
                        .Where(row => row.Cells[0].Value.ToString() == cmbTeacherSelect.Text))
            {
                dgvTeachers.Rows[row.Index].Selected = true;
                dgvTeacherExtras.Rows[row.Index].Selected = true;
            }
        }

        private void dgvAdminExtras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvAdmins.ClearSelection();
        }

        private void dgvAdminExtras_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Util.Db.SubmitChanges();
            Util.Db.Refresh(RefreshMode.OverwriteCurrentValues, Util.Db.Administrations);
        }

        private void dgvAdminExtras_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            ClearAdminSelection();
            dgvAdminExtras.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
        }

        private void dgvAdmins_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvAdminExtras.ClearSelection();
        }

        private void dgvAdmins_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Util.Db.SubmitChanges();
            Util.Db.Refresh(RefreshMode.OverwriteCurrentValues, Util.Db.Persons);
        }

        private void dgvAdmins_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            ClearAdminSelection();
            dgvAdmins.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
            var pName = dgvAdmins.Rows[e.RowIndex].Cells[1].FormattedValue + " " +
                        dgvAdmins.Rows[e.RowIndex].Cells[2].FormattedValue;
            ManagePeopleContextItem.Text = @"Remove " + pName + @" from ABC";
        }

        private void dgvStudents_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            ClearStudentSelection();
            dgvStudents.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
            var pName = dgvStudents.Rows[e.RowIndex].Cells[1].FormattedValue + " " +
                        dgvStudents.Rows[e.RowIndex].Cells[2].FormattedValue;
            ManagePeopleContextItem.Text = @"Remove " + pName + @" from ABC";
        }

        private void dgvTeacherExtras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvTeachers.ClearSelection();
        }

        private void dgvTeacherExtras_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Util.Db.SubmitChanges();
            Util.Db.Refresh(RefreshMode.OverwriteCurrentValues, Util.Db.Teachers);
        }

        private void dgvTeacherExtras_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            ClearTeacherSelection();
            dgvTeacherExtras.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
        }

        private void dgvTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvTeacherExtras.ClearSelection();
        }

        private void dgvTeachers_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            ClearTeacherSelection();
            dgvTeachers.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
            var pName = dgvTeachers.Rows[e.RowIndex].Cells[1].FormattedValue + " " +
                        dgvTeachers.Rows[e.RowIndex].Cells[2].FormattedValue;
            ManagePeopleContextItem.Text = @"Remove " + pName + @" from ABC";
        }

        private void dobPicker_Validated(object sender, EventArgs e)
        {
            statusStripLbl.Text = "";
        }

        private void dobPicker_Validating(object sender, CancelEventArgs e)
        {
            //if date hasnt been changed, exit
            if (dobPicker.Value != DateTime.Today.Date) return;
            e.Cancel = true;
            statusStripLbl.Text = @"Please select date of birth.";
        }

        private void FrmPeople_Load(object sender, EventArgs e)
        {
            dgvAdmins.AutoGenerateColumns = false;
            dgvAdmins.DataSource = Util.GetAdmins();
            dgvAdminExtras.AutoGenerateColumns = false;
            dgvAdminExtras.DataSource = Util.GetAdminExtras();
            cmbAdminSelect.DataSource = Util.GetAdmins();
            cmbAdminSelect.DisplayMember = "ID";
            cmbAdminSelect.ValueMember = "ID";

            dgvTeachers.AutoGenerateColumns = false;
            dgvTeachers.DataSource = Util.GetTeachers();
            dgvTeacherExtras.AutoGenerateColumns = false;
            dgvTeacherExtras.DataSource = Util.GetTeacherExtras();
            cmbTeacherSelect.DataSource = Util.GetTeachers();
            cmbTeacherSelect.DisplayMember = "ID";
            cmbTeacherSelect.ValueMember = "ID";

            dgvStudents.AutoGenerateColumns = false;
            dgvStudents.DataSource = Util.GetStudents();
            cmbStudentSelect.DataSource = Util.GetStudents();
            cmbStudentSelect.DisplayMember = "ID";
            cmbStudentSelect.ValueMember = "ID";

            cmbQualification.DataSource = Util.GetQualifications();

            //sets up the default view
            switch (_startWindow)
            {
                case "a":
                    tabPeople.SelectTab(tabAdmins);
                    break;

                case "s":
                    tabPeople.SelectTab(tabStudents);
                    break;

                case "t":
                    tabPeople.SelectTab(tabTeachers);
                    break;

                default:
                    tabPeople.SelectTab(tabAdmins);
                    break;
            }

            tabPeople_SelectedIndexChanged(null, null);
            ClearSelections(); //clear any selected cells
            chkVerified.Checked = false;

            ResetForm();
        }

        private void ResetForm()
        {
            //reset text boxes to default values
            txtFName.Text = @"First Name";
            txtLName.Text = @"Last Name";
            txtAdd1.Text = @"Unit/House";
            txtAdd2.Text = @"Street/Road";
            txtPass.Text = @"Pass";
            txtPhone.Text = @"Phone";
            txtPostCode.Text = @"Post Code";
            txtRego.Text = @"Rego";
            txtRole.Text = @"Role";
            txtSuburb.Text = @"Suburb";
            dobPicker.Value = DateTime.Today;
            cmbState.SelectedIndex = 0;
        }

        private void ManagePeopleContextItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow rowOfSelectedCell = null;
            if (tabPeople.SelectedTab == tabAdmins)
            {
                rowOfSelectedCell = dgvAdmins.Rows[dgvAdmins.CurrentCell.RowIndex];
                _startWindow = "a"; //forces the tabcontrol to stay on the admin tab when form reloads
            }
            if (tabPeople.SelectedTab == tabTeachers)
            {
                rowOfSelectedCell = dgvTeachers.Rows[dgvTeachers.CurrentCell.RowIndex];
                _startWindow = "t"; //forces the tabcontrol to stay on the teacher tab when form reloads
            }
            if (tabPeople.SelectedTab == tabStudents)
            {
                rowOfSelectedCell = dgvStudents.Rows[dgvStudents.CurrentCell.RowIndex];
                _startWindow = "s"; //forces the tabcontrol to stay on the student tab when form reloads
            }

            if (rowOfSelectedCell != null) //just incase the cell becomes null
            {
                //confirm with user before removing person
                var id = Util.Int(rowOfSelectedCell.Cells[0].Value.ToString());
                var result = MessageBox.Show(this,
                    @"This will remove " + Util.GetPersonName(id) + @". Continue?",
                    @"Remove?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes) return;
                Util.Db.Persons.DeleteOnSubmit(Util.GetPerson(id));
                Util.Db.SubmitChanges();
                Util.Db.Refresh(RefreshMode.OverwriteCurrentValues, Util.Db.Persons);
                if (!Util.DoesPersonExist(id))
                {
                    FrmPeople_Load(null, null);
                }
                else
                {
                    Messages.GenericProblem();
                }
            }
        }

        private void tabPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabPeople.SelectedTab == tabAdmins)
            {
                txtRego.Visible = false;
                txtRole.Visible = true;
                txtPass.Visible = true;
                cmbQualification.Visible = false;
                ManagePeopleContextItem.Text = @"Remove Administrator from ABC";
                btnAddPerson.Text = @"Add Administrator";
                return;
            }
            if (tabPeople.SelectedTab == tabTeachers)
            {
                txtRego.Visible = true;
                txtRole.Visible = false;
                txtPass.Visible = true;
                cmbQualification.Visible = false;
                ManagePeopleContextItem.Text = @"Remove Teacher from ABC";
                btnAddPerson.Text = @"Add Teacher";
                return;
            }
            if (tabPeople.SelectedTab == tabStudents)
            {
                txtRego.Visible = false;
                txtRole.Visible = false;
                txtPass.Visible = false;
                cmbQualification.Visible = true;
                ManagePeopleContextItem.Text = @"Remove Student from ABC";
                btnAddPerson.Text = @"Add Student";
                return;
            }
            btnAddPerson.Text = @"Add Person";
            ManagePeopleContextItem.Text = @"Remove Person from ABC";
        }

        private void txtAdd1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape || !string.IsNullOrEmpty(txtAdd1.Text)) return;
            txtAdd1.Text = @"Unit/House";
        }

        private void txtAdd1_Validated(object sender, EventArgs e)
        {
            statusStripLbl.Text = "";
        }

        private void txtAdd1_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAdd1.Text)) return;
            statusStripLbl.Text = @"Unit/house number can't be empty.";
            e.Cancel = true;
        }

        private void txtAdd2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape || !string.IsNullOrEmpty(txtAdd2.Text)) return;
            txtAdd2.Text = @"Street/Road";
        }

        private void txtAdd2_Validated(object sender, EventArgs e)
        {
            statusStripLbl.Text = "";
        }

        private void txtAdd2_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAdd2.Text)) return;
            statusStripLbl.Text = @"Street/road can't be empty.";
            e.Cancel = true;
        }

        private void txtFName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape || !string.IsNullOrEmpty(txtFName.Text)) return;
            txtFName.Text = @"First Name";
        }

        private void txtFName_Validated(object sender, EventArgs e)
        {
            statusStripLbl.Text = "";
        }

        private void txtFName_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFName.Text)) return;
            statusStripLbl.Text = @"First name can't be empty.";
            e.Cancel = true;
        }

        private void txtLName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape || !string.IsNullOrEmpty(txtLName.Text)) return;
            txtLName.Text = @"Last Name";
        }

        private void txtLName_Validated(object sender, EventArgs e)
        {
            statusStripLbl.Text = "";
        }

        private void txtLName_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLName.Text)) return;
            statusStripLbl.Text = @"Last name can't be empty.";
            e.Cancel = true;
        }

        private void txtPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape || !string.IsNullOrEmpty(txtPass.Text)) return;
            txtPass.Text = @"Pass";
        }

        private void txtPass_Validated(object sender, EventArgs e)
        {
            statusStripLbl.Text = "";
        }

        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPass.Text)) return;
            statusStripLbl.Text = @"Password can't be empty.";
            e.Cancel = true;
        }

        private void txtPhone_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape || (!string.IsNullOrEmpty(txtPhone.Text) && Util.ValidNumber(txtPhone.Text)))
                return;
            txtPhone.Text = @"Phone";
        }

        private void txtPhone_Validated(object sender, EventArgs e)
        {
            statusStripLbl.Text = "";
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPhone.Text) && Util.ValidNumber(txtPhone.Text)) return;
            statusStripLbl.Text = @"Phone can't be empty, and numbers only.";
            e.Cancel = true;
        }

        private void txtPostCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape || !string.IsNullOrEmpty(txtPostCode.Text)) return;
            txtPostCode.Text = @"Post Code";
        }

        private void txtPostCode_Validated(object sender, EventArgs e)
        {
            statusStripLbl.Text = "";
        }

        private void txtPostCode_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPostCode.Text) && Util.ValidNumber(txtPostCode.Text)) return;
            statusStripLbl.Text = @"Post code can't be empty, and numbers only.";
            e.Cancel = true;
        }

        private void txtRego_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape || !string.IsNullOrEmpty(txtRego.Text)) return;
            txtRego.Text = @"Rego";
        }

        private void txtRego_Validated(object sender, EventArgs e)
        {
            statusStripLbl.Text = "";
        }

        private void txtRego_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRego.Text)) return;
            statusStripLbl.Text = @"Rego can't be empty.";
            e.Cancel = true;
        }

        private void txtRole_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape || !string.IsNullOrEmpty(txtRole.Text)) return;
            txtRole.Text = @"Role";
        }

        private void txtRole_Validated(object sender, EventArgs e)
        {
            statusStripLbl.Text = "";
        }

        private void txtRole_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRole.Text)) return;
            statusStripLbl.Text = @"Rego can't be empty.";
            e.Cancel = true;
        }

        private void txtSuburb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape || !string.IsNullOrEmpty(txtSuburb.Text)) return;
            txtSuburb.Text = @"Suburb";
        }

        private void txtSuburb_Validated(object sender, EventArgs e)
        {
            statusStripLbl.Text = "";
        }

        private void txtSuburb_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSuburb.Text)) return;
            statusStripLbl.Text = @"Suburb can't be empty.";
            e.Cancel = true;
        }

        private void chkVerified_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}