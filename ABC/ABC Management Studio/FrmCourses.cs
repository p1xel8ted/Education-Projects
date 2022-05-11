/*
* Author: Ben Logan
* Student ID: 30013164
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;
using ABC_Management_Studio.Properties;

namespace ABC_Management_Studio
{
    /// <summary>
    ///     This form is used for the management of Courses available at ABC. User can add/remove/edit
    ///     as well as add a course to a qualification, and add students to qualifications through this
    ///     screen also.
    /// </summary>
    internal partial class FrmCourses : Form
    {
        internal FrmCourses()
        {
            InitializeComponent();
        }

        private void addCoursesToSelectedQualificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //1. gets the cid of the selected Cell
            //2. gets a Course object based on that cid
            //3. Shows the Add Course to Qualification form
            //4. Reloads the form after the user closes the dialog to reflect changes
            if (dgvQuals.CurrentCell == null) return;
            var rowOfCell = dgvQuals.Rows[dgvQuals.CurrentCell.RowIndex];
            var qcode = rowOfCell.Cells[0].Value.ToString();
            var qual = Util.GetQualificationByQCode(qcode);
            var frmAddToQual = new FrmAddCoursesToSelectedQualification(qual);
            if (frmAddToQual.ShowDialog() == DialogResult.OK)
            {
                FrmCourses_Load(null, null);
            }
        }

        private void addCourseToQualificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //1. gets the cid of the selected Cell
            //2. gets a Course object based on that cid
            //3. Shows the Add Course to Qualification form
            //4. Reloads the form after the user closes the dialog to reflect changes
            if (dgvCourses.CurrentCell == null) return;
            var rowOfCell = dgvCourses.Rows[dgvCourses.CurrentCell.RowIndex];
            var cid = Util.Int(rowOfCell.Cells[0].Value);
            var course = Util.GetCourseByCid(cid);
            var frmAddToQual = new FrmAddSelectedCourseToQualifications(course);
            if (frmAddToQual.ShowDialog() == DialogResult.OK)
            {
                FrmCourses_Load(null, null);
            }
        }

        private void addStudentsToQualificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //1. gets the qCode of the selected Cell
            //2. gets a Qualification object based on that cid
            //3. Shows the Add Students to Qualification form
            if (dgvQuals.CurrentCell == null) return;
            var rowOfCell = dgvQuals.Rows[dgvQuals.CurrentCell.RowIndex];
            var code = rowOfCell.Cells[0].Value.ToString();
            var qualCode = Util.GetQualificationByQCode(code);
            var frmAddToQual = new FrmAddStudentsToSelectedQualification(qualCode);
            frmAddToQual.ShowDialog();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            //checks if coursename is empty or a number
            if (string.IsNullOrEmpty(txtCourseName.Text) || Util.ValidNumber(txtCourseName.Text))
            {
                Messages.CourseNameNoNumbers();
                txtCourseName.Focus();
                txtCourseName.SelectAll();
                return;
            }
            //creates a new Course object
            var newCourse = new Course
            {
                CID = Util.Int(cmbCID.Text),
                CName = txtCourseName.Text,
                Year = Util.Int(cmbYear.Text),
                Semester = cmbSemester.Text,
                TID = Util.Int(cmbTeacher.Text)
            };
            //creates a new Qualifcaton_Course object
            var newQualCourse = new Qualification_Course
            {
                CID = newCourse.CID,
                Course = newCourse,
                QCode = Util.GetQualificationCodeByName(cmbQual.Text)
            };

            //inserts newly created objects and reloads the form
            //also checks if it hasnt already been added
            if (!Util.Db.Qualification_Courses.Contains(newQualCourse))
            {
                Util.Db.Qualification_Courses.InsertOnSubmit(newQualCourse);
                Util.Db.SubmitChanges();
                Util.Db.Refresh(RefreshMode.OverwriteCurrentValues, Util.Db.Qualification_Courses);
                if (Util.Db.Qualification_Courses.Contains(newQualCourse))
                {
                    FrmCourses_Load(null, null);
                }
                else
                {
                    Messages.GenericProblem();
                }
            }
            else
            {
                Messages.CourseAlreadyInQualification();
                FrmCourses_Load(null, null); //reloads the form to see changes that have been made
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbQual_SelectedValueChanged(object sender, EventArgs e)
        {
            //Updates the Course Year combo box to only display years available within that Qualification.
            var maxYears = Util.GetQualificationLengthByName(cmbQual.Text);
            var newYears = new List<int>();
            newYears.Clear();
            newYears.AddRange(Enumerable.Range(1, (int) maxYears));
            cmbYear.DataSource = newYears;
        }

        private void deleteRecordMenu_Click(object sender, EventArgs e)
        {
            //Remove course from entire ABC system
            //gets the course id of the selected cell/row
            var rowOfCell = dgvCourses.Rows[dgvCourses.CurrentCell.RowIndex];
            var cid = Util.Int(rowOfCell.Cells[0].Value);

            //if user clicks Yes, submit the changes and reload the form
            var result = Util.RemoveCourseFromAbc(cid);
            if (result)
            {
                FrmCourses_Load(null, null);
            }
        }

        private void dgvCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //1. gets the row clicked
            //2. gets the cid of that row
            //3. gets the qualifications that countain that cid
            if (dgvCourses.CurrentCell == null) return;
            var rowOfCell = dgvCourses.Rows[dgvCourses.CurrentCell.RowIndex];
            var cid = Util.Int(rowOfCell.Cells[0].Value);
            dgvQuals.DataSource = Util.GetCourseQualifications(cid);
        }

        private void dgvCourses_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //clears any errors and submits changes to the DB
            statusStripErrorLabel.Text = string.Empty;
            Util.Db.SubmitChanges();
            Util.Db.Refresh(RefreshMode.OverwriteCurrentValues, Util.Db.Courses);
        }

        private void dgvCourses_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            //this code only runs if it was the Right click that initiated it.
            //wont execute if the right click was performed on a col/row header.
            //clears any selections, then selects the cell that was right clicked
            //and calls the cell click method
            if (e.Button != MouseButtons.Right) return;
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            dgvCourses.ClearSelection();
            dgvCourses.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
            dgvCourses_CellClick(null, null);
            var courseText = dgvCourses.Rows[dgvCourses.CurrentCell.RowIndex].Cells[1].FormattedValue;
            deleteCourseItem.Text = @"Remove " + courseText + @" from ABC";
            addCourseToQualificationToolStripMenuItem.Text = @"Add " + courseText + @" to Qualification(s)";
        }

        private void dgvCourses_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //gets the cell that needs validating
            var cellValue = e.FormattedValue.ToString();

            //this gets the maximum years available for a particular course. i.e if its not in any 4 year qualifications, 4 wont appear as an option
            var rowOfCell = dgvCourses.Rows[e.RowIndex];
            var cid = Util.Int(rowOfCell.Cells[0].Value);
            var yearList =
                Util.GetCourseQualifications(cid)
                    .Select(item => (int) Util.GetQualificationLengthByName(item.QName))
                    .ToList();
            if (yearList.Capacity <= 0) return; //was throwing errors after removing a course
            var maxYear = yearList.Max();

            //if cell is empty, exit
            if (string.IsNullOrEmpty(cellValue))
            {
                statusStripErrorLabel.Text = Messages.CellsEmptyText;
                e.Cancel = true;
            }
            switch (e.ColumnIndex)
            {
                case 2: //Year:
                    //if cell isnt a number, exit
                    if (!Util.ValidNumber(cellValue))
                    {
                        statusStripErrorLabel.Text = Messages.InvalidMarkIdText;
                        e.Cancel = true;
                        break;
                    }
                    //if cell is less than 1 or more than the max year available, exit
                    if (Util.Int(cellValue) < 1 || Util.Int(cellValue) > maxYear)
                    {
                        statusStripErrorLabel.Text = Messages.MinMaxYearText;
                        e.Cancel = true;
                    }
                    break;

                case 3: //Semester:
                    if (!Util.ValidNumber(cellValue))
                    {
                        statusStripErrorLabel.Text = Messages.InvalidMarkIdText;
                        e.Cancel = true;
                        break;
                    }
                    //if semester is less than 1 or more than the max allowed semesters set in Settings, exit
                    if (Util.Int(cellValue) < 1 || Util.Int(cellValue) > Settings.Default.Semesters)
                    {
                        statusStripErrorLabel.Text = Messages.MinMaxSemesterText;
                        e.Cancel = true;
                    }
                    break;

                case 4: //Teacher:
                    if (!Util.ValidNumber(cellValue))
                    {
                        statusStripErrorLabel.Text = Messages.InvalidMarkIdText;
                        e.Cancel = true;
                        break;
                    }
                    //if teacher doesnt exist, exit
                    if (!Util.DoesTeacherExist(Util.Int(cellValue)))
                    {
                        statusStripErrorLabel.Text = Messages.TeacherNotFound;
                        e.Cancel = true;
                    }
                    break;
            }
        }

        private void dgvCourses_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //executes if a cell in the Course DGV can't be validated
            statusStripErrorLabel.Text = Messages.InvalidDataText;
            dgvCourses.CancelEdit();
        }

        private void dgvCourses_KeyUp(object sender, KeyEventArgs e)
        {
            //updates the DGV's when a user presses the UP/DOWN arrow keys to navigate the grids
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                dgvCourses_CellClick(null, null);
            }
        }

        private void dgvQuals_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //clears any errors and submits changes to DB
            statusStripErrorLabel.Text = string.Empty;
            Util.Db.SubmitChanges();
            Util.Db.Refresh(RefreshMode.OverwriteCurrentValues, Util.Db.Qualifications);
            //this reloads the Year values after changing any data in the Qualification window
            cmbYear.DataSource = Util.GetQualificationLengthsAsYears();
            cmbQual.DataSource = Util.GetQualifications();
            cmbQual_SelectedValueChanged(null, null);
        }

        private void dgvQuals_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            //this code only runs if it was the Right click that initiated it.
            //wont execute if the right click was performed on a col/row header.
            //clears any selections, then selects the cell that was right clicked.
            //right click context menu then appears
            if (e.Button != MouseButtons.Right) return;
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            dgvQuals.ClearSelection();
            dgvQuals.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
            var qualText = dgvQuals.Rows[dgvQuals.CurrentCell.RowIndex].Cells[1].FormattedValue;
            removeQualificatonToolStripMenuItem.Text = @"Remove " + qualText + @" from ABC";
            addStudentsToQualificationToolStripMenuItem.Text = @"Add Student(s) to " + qualText;
            addCoursesToSelectedQualificationToolStripMenuItem.Text = @"Add Course(s) to " + qualText;
        }

        private void dgvQuals_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //if the Cell isn't empty, all is good. Otherwise it cancels the edit
            if (!string.IsNullOrEmpty(e.FormattedValue.ToString())) return;
            statusStripErrorLabel.Text = Messages.CellsEmptyText;
            e.Cancel = true;
        }

        private void dgvQuals_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //executes if a cell in the Qualifications DGV cant be validated
            statusStripErrorLabel.Text = Messages.InvalidDataText;
            dgvQuals.CancelEdit();
        }

        private void FrmCourses_Load(object sender, EventArgs e)
        {
            dgvCourses.AutoGenerateColumns = false;
            dgvCourses.DataSource = Util.GetCourses();

            dgvQuals.AutoGenerateColumns = false;
            if (dgvCourses.RowCount > 0)
            {
                //only fill the qualification table if there is information in the course table
                dgvQuals.DataSource = Util.GetQualifications();
                dgvCourses_CellClick(null, null);
            }

            //Generates new course ID's, then removes any ID's that
            //are already being used.
            var totalCourses = Util.GetCourses().Count;
            var newCids = new List<int>();
            newCids.Clear();
            newCids.AddRange(Enumerable.Range(1, totalCourses + 5));
            foreach (var course in Util.Db.Courses.Where(course => newCids.Contains(course.CID)))
            {
                newCids.Remove(course.CID);
            }
            newCids.Sort();
            //Adds semesters based on the amount of semesters set in the Config screen at login.
            var newSems = new List<int>();
            newSems.AddRange(Enumerable.Range(1, Settings.Default.Semesters));

            //setup the form combo boxes
            cmbSemester.DataSource = newSems;
            cmbCID.DataSource = newCids;
            cmbYear.DataSource = Util.GetQualificationLengthsAsYears();
            cmbQual.DataSource = Util.GetQualifications();
            cmbTeacher.DataSource = Util.GetTeacherExtras();

            //force the combo box to update
            cmbQual_SelectedValueChanged(null, null);
            dgvCourses_CellClick(null, null);
        }

        private void removeQualificatonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Remove qualification from entire ABC system
            if (dgvQuals.CurrentCell == null) return;
            var rowOfQualCell = dgvQuals.Rows[dgvQuals.CurrentCell.RowIndex];
            var qCode = rowOfQualCell.Cells[0].Value.ToString();
            if (Util.RemoveQualificationFromAbc(qCode))
            {
                FrmCourses_Load(null, null);
            }
        }

        private void txtCourseName_Enter(object sender, EventArgs e)
        {
            //upon entering the control, all the text is selected.
            txtCourseName.SelectAll();
        }

        private void txtCourseName_KeyUp(object sender, KeyEventArgs e)
        {
            //forces user to either fix the error or press Escape to reset.
            if (e.KeyCode != Keys.Escape || !string.IsNullOrEmpty(txtCourseName.Text)) return;
            txtCourseName.Text = @"Course Name";
        }

        private void txtCourseName_Validated(object sender, EventArgs e)
        {
            statusStripErrorLabel.Text = string.Empty;
        }

        private void txtCourseName_Validating(object sender, CancelEventArgs e)
        {
            //pops if the text is empty, and cancels the edit
            if (!string.IsNullOrEmpty(txtCourseName.Text)) return;
            statusStripErrorLabel.Text = @"Course name can't be empty.";
            e.Cancel = true;
        }

        private void cmbCID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}