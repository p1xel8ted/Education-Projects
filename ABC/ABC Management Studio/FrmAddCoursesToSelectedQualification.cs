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
    internal partial class FrmAddCoursesToSelectedQualification : Form
    {
        private readonly Qualification _qualification;

        internal FrmAddCoursesToSelectedQualification(Qualification qualification)
        {
            _qualification = qualification;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //iterates through each checked item in the course checklist.
            //for each checked, it makes a new Qualification_Course object
            //and inserts it into the database if its not already there.
            //If the record already exists, it just skips over it.
            try
            {
                foreach (
                    var newEntry in
                        clbCourses.CheckedItems.Cast<Course>().Select(item => new Qualification_Course
                        {
                            CID = item.CID,
                            QCode = _qualification.QCode
                        }).Where(newEntry => !Util.Db.Qualification_Courses.Contains(newEntry)))
                {
                    Util.Db.Qualification_Courses.InsertOnSubmit(newEntry);
                }
                Util.Db.SubmitChanges();
                Util.Db.Refresh(RefreshMode.OverwriteCurrentValues, Util.Db.Qualification_Courses);
                Messages.AddedSelectedCoursesToQualification(_qualification);
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

        private void FrmAddCoursesToSelectedQualification_Load(object sender, EventArgs e)
        {
            ttTip.SetToolTip(btnAdd, @"Add selected courses to " + _qualification.QName + @".");
            clbCourses.DataSource = Util.GetCourses();
            clbCourses.DisplayMember = "CName";
            clbCourses.ValueMember = "CID";
        }
    }
}