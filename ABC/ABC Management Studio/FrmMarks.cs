/*
* Author: Ben Logan
* Student ID: 30013164
*/

using System;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;

namespace ABC_Management_Studio
{
    internal partial class FrmMarks : Form
    {
        internal FrmMarks()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     This method is for adding new marks to the database.
        /// </summary>
        /// <param name="mark">The mark to add</param>
        private void AddMark(Student_Course mark)
        {
            //checks if student already has a mark for that course
            if (Util.StudentIsOnCourse(mark.SID, mark.CID))
            {
                var result = MessageBox.Show(this,
                    Util.GetPersonName(mark.SID) + @" already has a mark for " + Util.GetCourseNameByCourseId(mark.CID) +
                    @". Update?",
                    @"Update?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //if user accepts, get the old mark for updating
                    var oldMark =
                        Util.GetStudentCourseMark(mark.SID, mark.CID);
                    oldMark.Mark = mark.Mark;
                }
                else
                {
                    //if user denies, exit method
                    return;
                }
            }
            else
            {
                //if no existing mark
                Util.Db.Student_Courses.InsertOnSubmit(mark);
            }
            //finally, submit any changes and refresh
            Util.Db.SubmitChanges();
            Util.Db.Refresh(RefreshMode.OverwriteCurrentValues, Util.Db.Student_Courses);
            if (Util.Db.Student_Courses.Contains(mark))
            {
                FillByStudentId();
                FillByCourseId();
            }
            else
            {
                Messages.GenericProblem();
            }
        }

        private void btnAddMarkByStudentId_Click(object sender, EventArgs e)
        {
            var sid = cmbStudent.Text;
            var cid = cmbMarksByStudentCourseID.Text;
            var mark = txtMarksByStudent.Text;
            //check the input is valid first
            if (!Util.ValidInput(cid, sid, mark)) return;
            //check if the course exists
            if (!Util.DoesCourseExist(Util.Int(cid)))
            {
                Messages.NoCourseFound();
                return;
            }
            //check if the student exists
            if (!Util.DoesStudentExist(Util.Int(sid)))
            {
                Messages.NoStudentFound();
                return;
            }
            //check if the student is enrolled in a qualification
            if (!Util.IsStudentEnrolled(Util.Int(sid)))
            {
                Messages.StudentIsntEnrolled(Util.Int(sid));
                return;
            }
            //create the new mark
            var newMark = new Student_Course
            {
                SID = Util.Int(sid),
                CID = Util.Int(cid),
                Mark = Util.Int(mark)
            };
            //add newly created mark
            AddMark(newMark);
        }

        private void btnAddMarksByCourse_Click(object sender, EventArgs e)
        {
            var sid = cmbMarksByCourseStudentID.Text;
            var cid = cmbCourseID.Text;
            var mark = txtMarksByCourse.Text;
            //check the input is valid first
            if (!Util.ValidInput(cid, sid, mark)) return;
            //check if the course exists
            if (!Util.DoesCourseExist(Util.Int(cid)))
            {
                Messages.NoCourseFound();
                return;
            }
            //check if the student exists
            if (!Util.DoesStudentExist(Util.Int(sid)))
            {
                Messages.NoStudentFound();
                return;
            }
            //check if the student is enrolled in a qualification
            if (!Util.IsStudentEnrolled(Util.Int(sid)))
            {
                Messages.StudentIsntEnrolled(Util.Int(sid));
                return;
            }
            //create the new mark
            var newMark = new Student_Course
            {
                SID = Util.Int(sid),
                CID = Util.Int(cid),
                Mark = Util.Int(mark)
            };
            //add newly created mark
            AddMark(newMark);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbCourseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allows user to press enter in the Course combo box
            if (e.KeyChar == (char) Keys.Return | e.KeyChar == (char) Keys.Enter)
            {
                FillByCourseId();
            }
        }

        private void cmbCourseID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillByCourseId();
        }

        private void cmbMarksByCourseStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbStudent.Text = cmbMarksByCourseStudentID.Text;
        }

        private void cmbMarksByStudentCourseID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCourseID.Text = cmbMarksByStudentCourseID.Text;
        }

        private void cmbStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allows user to press enter in the Student combo box
            if (e.KeyChar == (char) Keys.Return | e.KeyChar == (char) Keys.Enter)
            {
                FillByStudentId();
            }
        }

        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillByStudentId();
        }

        private void CourseIdContext_Click(object sender, EventArgs e)
        {
            //if we're not clicking a cell, dont do anything, otherwise delete
            if (dgvMarksByCourse.CurrentCell == null) return;
            DeleteRecord(CourseIdContext);
        }

        /// <summary>
        ///     This deletes the record. Will only function if its the Student or Course context menu
        ///     calling it.
        /// </summary>
        /// <param name="sender">The sender (StudentIdContext/CourseIdContext)</param>
        private void DeleteRecord(object sender)
        {
            DataGridViewRow rowOfCell;
            int cid;
            int sid;
            if (sender.Equals(StudentIdContext))
            {
                //get the current row and cell select and extracts the student id and course id
                rowOfCell = dgvMarksByStudent.Rows[dgvMarksByStudent.CurrentCell.RowIndex];
                var tCid = rowOfCell.Cells[0].Value.ToString();
                var tSid = cmbStudent.Text;
                //if the strings are numbers, convert them to ints and set the cid/sid
                if (Util.ValidNumber(tCid) && Util.ValidNumber(tSid))
                {
                    cid = Util.Int(rowOfCell.Cells[0].Value);
                    sid = Util.Int(cmbStudent.Text);
                }
                else
                {
                    Messages.InvalidId();
                    return;
                }
            }
            else
            {
                //get the current row and cell select and extracts the student id and course id
                rowOfCell = dgvMarksByCourse.Rows[dgvMarksByCourse.CurrentCell.RowIndex];
                var tCid = rowOfCell.Cells[0].Value.ToString();
                var tSid = cmbCourseID.Text;
                //if the strings are numbers, convert them to ints and set the cid/sid
                if (Util.ValidNumber(tCid) && Util.ValidNumber(tSid))
                {
                    sid = Util.Int(rowOfCell.Cells[0].Value);
                    cid = Util.Int(cmbCourseID.Text);
                }
                else
                {
                    Messages.InvalidId();
                    return;
                }
            }
            //confirm with the user that we want to delete the record
            var result = MessageBox.Show(this,
                @"Delete " + Util.GetPersonName(sid) + @"'s " + Util.GetCourseNameByCourseId(cid) + @" record?",
                @"Delete?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;
            //if user accepts, remove the mark and refresh the form
            Util.Db.Student_Courses.DeleteOnSubmit(Util.GetStudentCourseMark(sid, cid));
            Util.Db.SubmitChanges();
            Util.Db.Refresh(RefreshMode.OverwriteCurrentValues, Util.Db.Student_Courses);
            FillByCourseId();
            FillByStudentId();
        }

        private void dgvMarksByCourse_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //submit changes once we've finished editing and passed validation
            statusStripErrorLabel.Text = string.Empty;
            Util.Db.SubmitChanges();
            Util.Db.Refresh(RefreshMode.OverwriteCurrentValues, Util.Db.Student_Courses);
        }

        private void dgvMarksByCourse_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            //selects the cell when we right click the DGV
            if (e.Button != MouseButtons.Right) return;
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            dgvMarksByCourse.ClearSelection();
            dgvMarksByCourse.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
            //dynamically updates Right Click menu entries
            var nameText = dgvMarksByCourse.Rows[dgvMarksByCourse.CurrentCell.RowIndex].Cells[1].FormattedValue;
            CourseIdContext.Text = @"Remove " + nameText + @"'s mark from " + lblCourseName.Text;
        }

        private void dgvMarksByCourse_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            statusStripErrorLabel.Text = Messages.InvalidMarkIdText;
            dgvMarksByCourse.CancelEdit();
        }

        private void dgvMarksByStudent_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            statusStripErrorLabel.Text = string.Empty;
            Util.Db.SubmitChanges();
            Util.Db.Refresh(RefreshMode.OverwriteCurrentValues, Util.Db.Student_Courses);
        }

        private void dgvMarksByStudent_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            //selects the cell when we right click the DGV
            if (e.Button != MouseButtons.Right) return;
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            dgvMarksByStudent.ClearSelection();
            dgvMarksByStudent.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
            //dynamically updates Right Click menu entries
            var courseText = dgvMarksByStudent.Rows[dgvMarksByStudent.CurrentCell.RowIndex].Cells[1].FormattedValue;
            StudentIdContext.Text = @"Remove " + lblSelStudent.Text + @"'s mark from " + courseText;
        }

        private void dgvMarksByStudent_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            statusStripErrorLabel.Text = Messages.InvalidMarkIdText;
            dgvMarksByStudent.CancelEdit();
        }

        private void FillByCourseId()
        {
            //if course id isnt a number, alert user and exit method
            if (!Util.ValidNumber(cmbCourseID.Text))
            {
                Messages.InvalidId();
                cmbCourseID.SelectAll();
                cmbCourseID.Focus();
                return;
            }
            //if course doesnt exist, alert user and exit method
            if (!Util.DoesCourseExist(Util.Int(cmbCourseID.Text)))
            {
                Messages.NoCourseFound();
                cmbCourseID.SelectAll();
                cmbCourseID.Focus();
                return;
            }
            cmbMarksByStudentCourseID.Text = cmbCourseID.Text;

            var cid = Util.Int(cmbCourseID.Text);

            dgvMarksByCourse.DataSource = Util.FillByCourseId(cid);
            //populates the DGV with student names instead of just the student ids
            foreach (DataGridViewRow row in dgvMarksByCourse.Rows)
            {
                dgvMarksByCourse.Rows[row.Index].Cells[1].Value =
                    Util.GetPersonName(Util.Int(dgvMarksByCourse.Rows[row.Index].Cells[0].Value));
            }
            lblCourseName.Text = Util.GetCourseNameByCourseId(cid);
        }

        private void FillByStudentId()
        {
            //if student id isnt a number, alert user and exit method
            if (!Util.ValidNumber(cmbStudent.Text))
            {
                Messages.InvalidId();
                cmbStudent.SelectAll();
                cmbStudent.Focus();
                return;
            }
            //if student doesnt exist, alert user and exit method
            if (!Util.DoesStudentExist(Util.Int(cmbStudent.Text)))
            {
                Messages.NoStudentFound();
                cmbStudent.SelectAll();
                cmbStudent.Focus();
                return;
            }
            cmbMarksByCourseStudentID.Text = cmbStudent.Text;
            var sid = Util.Int(cmbStudent.Text);
            dgvMarksByStudent.DataSource = Util.FillByStudentId(sid);
            //populates the DGV with course names instead of just the course ids
            foreach (DataGridViewRow row in dgvMarksByStudent.Rows)
            {
                dgvMarksByStudent.Rows[row.Index].Cells[1].Value =
                    Util.GetCourseNameByCourseId(Util.Int(dgvMarksByStudent.Rows[row.Index].Cells[0].Value));
            }
            lblSelStudent.Text = Util.GetPersonName(sid);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            dgvMarksByStudent.AutoGenerateColumns = false;
            dgvMarksByCourse.AutoGenerateColumns = false;
            cmbStudent.DataSource = Util.GetStudents();
            cmbCourseID.DataSource = Util.GetCourses();
            cmbMarksByCourseStudentID.DataSource = Util.GetStudents();
            cmbMarksByStudentCourseID.DataSource = Util.GetCourses();

            FillByStudentId();

            FillByCourseId();
        }

        private void StudentIdContext_Click(object sender, EventArgs e)
        {
            //dont do anything if the current cell is nothing
            if (dgvMarksByStudent.CurrentCell == null) return;
            DeleteRecord(StudentIdContext);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //force a reload when user switches tabs
            FillByStudentId();
            FillByCourseId();
        }

        private void txtMarksByStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Return | e.KeyChar == (char) Keys.Enter)
            {
                btnAddMarkByStudentId_Click(txtMarksByStudent, null);
            }
        }
    }
}