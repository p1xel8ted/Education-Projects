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
    /// <summary>
    ///     This form is used to add a course to one or more qualifications at once. It is available
    ///     through the context menu when there is a Course DGV on the screen.
    /// </summary>
    internal partial class FrmAddSelectedCourseToQualifications : Form
    {
        private readonly Course _course;

        internal FrmAddSelectedCourseToQualifications(Course course)
        {
            _course = course; //stores the passed Course into the global variable
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //iterates through each checked item in the qualificaton checklist.
            //for each checked, it makes a new Qualification_Course object
            //and inserts it into the database if its not already there.
            //If the record already exists, it just skips over it.
            try
            {
                foreach (
                    var newEntry in
                        clbQualifications.CheckedItems.Cast<Qualification>().Select(item => new Qualification_Course
                        {
                            CID = _course.CID,
                            QCode = item.QCode
                        }).Where(newEntry => !Util.Db.Qualification_Courses.Contains(newEntry)))
                {
                    Util.Db.Qualification_Courses.InsertOnSubmit(newEntry);
                }
                Util.Db.SubmitChanges();
                Util.Db.Refresh(RefreshMode.OverwriteCurrentValues, Util.Db.Qualification_Courses);
                Messages.AddedCourseToSelectedQualifications(_course);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception)
            {
                Messages.GenericProblem();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //sets dialog result to cancel so we dont do an unecessary form reload when we exit
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FrmAddCourseToQualification_Load(object sender, EventArgs e)
        {
            ttTip.SetToolTip(btnAdd, @"Add " + _course.CName + @" to selected qualifications?");
            clbQualifications.DataSource = Util.GetQualifications();
            clbQualifications.DisplayMember = "QName";
            clbQualifications.ValueMember = "QCode";
        }
    }
}