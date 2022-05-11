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
    internal partial class FrmQualifications : Form
    {
        internal FrmQualifications()
        {
            InitializeComponent();
        }

        private void addCoursesToQualificationToolStripMenuItem_Click(object sender, EventArgs e)
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
            //this stops unecessary form reloads if the user doesnt click ok/save/accept
            if (frmAddToQual.ShowDialog() == DialogResult.OK)
            {
                FrmQualifications_Load(null, null);
            }
        }

        private void addStudentsToQualificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //1. gets the cid of the selected Cell
            //2. gets a Course object based on that cid
            //3. Shows the Add Course to Qualification form
            //4. Reloads the form after the user closes the dialog to reflect changes
            if (dgvQuals.CurrentCell == null) return;
            var rowOfCell = dgvQuals.Rows[dgvQuals.CurrentCell.RowIndex];
            var code = rowOfCell.Cells[0].Value.ToString();
            var qualCode = Util.GetQualificationByQCode(code);
            var frmAddToQual = new FrmAddStudentsToSelectedQualification(qualCode);
            //as there is no changes that need to be displayed on this form, dont bother with dialog
            frmAddToQual.ShowDialog();
        }

        private void btnAddQualification_Click(object sender, EventArgs e)
        {
            //if name is empty or a number, exit
            if (string.IsNullOrEmpty(txtName.Text) || Util.ValidNumber(txtName.Text))
            {
                Messages.QualificationCantBeEmpty();
                txtName.SelectAll();
                txtName.Focus();
                return;
            }
            //search through qualifications for any names matching the entered name
            if (Enumerable.Any(Util.Db.Qualifications,
                qualification =>
                    string.Equals(qualification.QName, txtName.Text, StringComparison.InvariantCultureIgnoreCase)))
            {
                Messages.QualificationNameAlreadyExists();
                txtName.SelectAll();
                txtName.Focus();
                return;
            }
            //create new qualification
            var newQual = new Qualification
            {
                QCode = cmbCode.Text,
                QName = txtName.Text,
                Duration = cmbDuration.Text
            };
            //insert into database and reload form
            Util.Db.Qualifications.InsertOnSubmit(newQual);
            Util.Db.SubmitChanges();
            Util.Db.Refresh(RefreshMode.OverwriteCurrentValues, Util.Db.Qualifications);
            if (Util.Db.Qualifications.Contains(newQual))
            {
                FrmQualifications_Load(null, null);
            }
            else
            {
                Messages.GenericProblem();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteCourseItem_Click(object sender, EventArgs e)
        {
            if (dgvCourses.CurrentCell == null) return;
            //gets the selected cid
            var rowOfCourseCell = dgvCourses.Rows[dgvCourses.CurrentCell.RowIndex];
            var cid = Util.Int(rowOfCourseCell.Cells[0].Value);
            //gets the selected qcode
            var rowOfQualCell = dgvQuals.Rows[dgvQuals.CurrentCell.RowIndex];
            var qCode = rowOfQualCell.Cells[0].Value.ToString();
            //remove course, if successfull, reload the form
            if (Util.RemoveCourseFromQualification(cid, qCode))
            {
                FrmQualifications_Load(null, null);
            }
            else
            {
                Messages.GenericProblem();
            }
        }

        private void dgvCourses_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //clear error text and submit changes
            statusStripErrorLabel.Text = string.Empty;
            Util.Db.SubmitChanges();
            Util.Db.Refresh(RefreshMode.OverwriteCurrentValues, Util.Db.Courses);
        }

        private void dgvCourses_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            //selects the cell when a user right clicks
            if (e.Button != MouseButtons.Right) return;
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            dgvCourses.ClearSelection();
            dgvCourses.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
            //dynamically updates Right Click menu entries
            var courseText = dgvCourses.Rows[dgvCourses.CurrentCell.RowIndex].Cells[1].FormattedValue;
            var qualText = dgvQuals.Rows[dgvQuals.CurrentCell.RowIndex].Cells[1].FormattedValue;
            RemoveCourseFromAbcItem.Text = @"Remove " + courseText + @" from ABC";
            RemoveCourseFromQualificationItem.Text = @"Remove " + courseText + @" from " + qualText;
        }

        private void dgvCourses_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var cellValue = e.FormattedValue.ToString();
            //this gets the maximum years available for a particular course. i.e if its not in any 4 year qualifications, 4 wont be available as an option
            var rowOfCell = dgvCourses.Rows[e.RowIndex];
            var cid = Util.Int(rowOfCell.Cells[0].Value);
            var yearList =
                Util.GetCourseQualifications(cid)
                    .Select(item => (int) Util.GetQualificationLengthByName(item.QName))
                    .ToList();
            if (yearList.Capacity <= 0) return; //was throwing errors after removing a course
            var maxYear = yearList.Max();
            if (string.IsNullOrEmpty(cellValue))
            {
                statusStripErrorLabel.Text = Messages.CellsEmptyText;
                e.Cancel = true;
            }
            switch (e.ColumnIndex)
            {
                case 2: //Year:
                    //check year is a number
                    if (!Util.ValidNumber(cellValue))
                    {
                        statusStripErrorLabel.Text = Messages.InvalidMarkIdText;
                        e.Cancel = true;
                        break;
                    }
                    //check year is valid
                    if (Util.Int(cellValue) < 1 || Util.Int(cellValue) > maxYear)
                    {
                        statusStripErrorLabel.Text = Messages.MinMaxYearText;
                        e.Cancel = true;
                    }
                    break;

                case 3: //Semester:
                    //check if a number
                    if (!Util.ValidNumber(cellValue))
                    {
                        statusStripErrorLabel.Text = Messages.InvalidMarkIdText;
                        e.Cancel = true;
                        break;
                    }
                    //check semester is valid
                    if (Util.Int(cellValue) < 1 || Util.Int(cellValue) > Settings.Default.Semesters)
                    {
                        statusStripErrorLabel.Text = Messages.MinMaxSemesterText;
                        e.Cancel = true;
                    }
                    break;

                case 4: //Teacher:
                    //check if a number
                    if (!Util.ValidNumber(cellValue))
                    {
                        statusStripErrorLabel.Text = Messages.InvalidMarkIdText;
                        e.Cancel = true;
                        break;
                    }
                    //check if teacher exists
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
            statusStripErrorLabel.Text = Messages.InvalidDataText;
            dgvCourses.CancelEdit();
        }

        private void dgvQuals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //gets the qCode of the selected cell and loads that qualifications courses into the DGV
            if (dgvQuals.CurrentCell == null) return;
            if (dgvQuals.RowCount <= 0) return;
            var rowOfCell = dgvQuals.Rows[dgvQuals.CurrentCell.RowIndex];
            var qCode = rowOfCell.Cells[0].Value.ToString();
            dgvCourses.DataSource = Util.GetQualificationCourses(qCode);
        }

        private void dgvQuals_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (dgvQuals.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Contains("m"))
                {
                    //stops months appending endlessly if user doesnt change anything in the cell
                   return;
                }
                dgvQuals.Rows[e.RowIndex].Cells[e.ColumnIndex].Value += " months";
            }
            //clear error text and submit changes
            statusStripErrorLabel.Text = string.Empty;
            Util.Db.SubmitChanges();
            Util.Db.Refresh(RefreshMode.OverwriteCurrentValues, Util.Db.Qualifications);
        }

        private void dgvQuals_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            //enables course data to be loaded for right clicks on the cells
            if (e.Button != MouseButtons.Right) return;
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            dgvQuals.ClearSelection();
            dgvQuals.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
            dgvQuals_CellClick(null, null);
            //dynamically updates context menu items
            var qualText = dgvQuals.Rows[dgvQuals.CurrentCell.RowIndex].Cells[1].FormattedValue;
            MaintainQualsItem.Text = @"Remove " + qualText + @" from ABC";
            addStudentsToQualificationToolStripMenuItem.Text = @"Add Student(s) to " + qualText;
            addCoursesToQualificationToolStripMenuItem.Text = @"Add Course(s) to " + qualText;
        }

        private void dgvQuals_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //if any cell is empty, exit
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                statusStripErrorLabel.Text = Messages.CellsEmptyText;
                e.Cancel = true;
                return;
            }
            //if error doesnt originate from the year column, exit
            if (e.ColumnIndex != 2) return;
            //if year cell isnt a number, error. Prevents users entering things like 24months or 2 years.
            //we add "months" to the value during submission
            if (!dgvQuals.Rows[e.RowIndex].Cells[e.ColumnIndex].IsInEditMode) return;
            if (Util.ValidNumber(e.FormattedValue.ToString())) return;
            Messages.YearNumbersOnly();
            e.Cancel = true;
        }

        private void dgvQuals_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            statusStripErrorLabel.Text = Messages.InvalidDataText;
            dgvQuals.CancelEdit();
        }

        private void dgvQuals_KeyUp(object sender, KeyEventArgs e)
        {
            //performs a cell click when the user uses UP/DOWN keys to navigate the DGV
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                dgvQuals_CellClick(null, null);
            }
        }

        private void FrmQualifications_Load(object sender, EventArgs e)
        {
            dgvCourses.AutoGenerateColumns = false;
            dgvQuals.AutoGenerateColumns = false;
            dgvQuals.DataSource = Util.GetQualifications();
            //only load the course data if there is data in the qualification dgv
            if (dgvQuals.RowCount > 0)
            {
                dgvCourses.DataSource = Util.GetCourses();
                //forces data to load for the selected cell
                dgvQuals_CellClick(null, null);
            }

            //generates a new set of course numbers
            var newQualCodes = new List<int>();
            var qualCount = Util.GetQualifications().Count;
            newQualCodes.Clear();
            newQualCodes.AddRange(Enumerable.Range(1, qualCount + 5));

            //appends the newly generated numbers to ICA
            var finalCodes = new List<string>();
            finalCodes.Clear();
            finalCodes.AddRange(newQualCodes.Select(tCode => "ICA" + string.Format("{0:00000}", tCode)));
            //removes any duplicates
            foreach (var code in Util.Db.Qualifications.Where(qual => finalCodes.Contains(qual.QCode)))
            {
                finalCodes.Remove(code.QCode);
            }
            //sorts the codes, then populates the fields
            finalCodes.Sort();
            cmbCode.DataSource = finalCodes;
            cmbDuration.SelectedIndex = 1;
            dgvQuals_CellClick(null, null);
        }

        private void MaintainQualsItem_Click(object sender, EventArgs e)
        {
            //gets the qCode of the selected cell/row
            if (dgvQuals.CurrentCell == null) return;
            var rowOfQualCell = dgvQuals.Rows[dgvQuals.CurrentCell.RowIndex];
            var qCode = rowOfQualCell.Cells[0].Value.ToString();
            //if qualification was removed, reload form
            if (Util.RemoveQualificationFromAbc(qCode))
            {
                FrmQualifications_Load(null, null);
            }
        }

        private void removeCourseFromABCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //gets the course id of the selected cell/row
            if (dgvCourses.CurrentCell == null) return;
            var rowOfCell = dgvCourses.Rows[dgvCourses.CurrentCell.RowIndex];
            var cid = Util.Int(rowOfCell.Cells[0].Value);
            //if course was removed, reload form
            if (Util.RemoveCourseFromAbc(cid))
            {
                FrmQualifications_Load(null, null);
            }
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape || !string.IsNullOrEmpty(txtName.Text)) return;
            txtName.Text = @"Qualification Name";
        }

        private void txtName_Validated(object sender, EventArgs e)
        {
            statusStripErrorLabel.Text = string.Empty;
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text)) return;
            statusStripErrorLabel.Text = Messages.QualificationNameCantBeEmpty;
            e.Cancel = true;
        }
    }
}