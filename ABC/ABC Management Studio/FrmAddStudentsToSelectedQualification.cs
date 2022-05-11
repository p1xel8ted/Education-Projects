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
    ///     This form is used anywhere the Qualification DGV is avaible for clicking. It allows a user
    ///     to add students directly to the selected qualification. This menu is accessed through the
    ///     context menu.
    /// </summary>
    internal partial class FrmAddStudentsToSelectedQualification : Form
    {
        private readonly Qualification _qualification;

        internal FrmAddStudentsToSelectedQualification(Qualification qualification)
        {
            _qualification = qualification; //stores the passed Qualification into the global variable
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //iterates through each checked item in the student checklist
            //for each checked, it makes a new Student object
            //and inserts it into the database if its not already there.
            //If the record already exists, it just skips over it.
            try
            {
                foreach (var newEntry in clbStudents.CheckedItems.Cast<Person>().Select(item => new Student
                {
                    SID = item.ID,
                    Sdate = DateTime.Today.Date,
                    QCode = _qualification.QCode
                }).Where(newEntry => !Util.Db.Students.Contains(newEntry)))
                {
                    Util.Db.Students.InsertOnSubmit(newEntry);
                }
                Util.Db.SubmitChanges();
                Util.Db.Refresh(RefreshMode.OverwriteCurrentValues, Util.Db.Students);
                Messages.SuccessfullyAddedStudentsToQualifications(_qualification);
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
            //stops unecessary form reloads when exiting a form
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FrmAddStudentToQualification_Load(object sender, EventArgs e)
        {
            //iterates through the student list and gets their names as listviewitems
            clbStudents.DataSource = Util.GetStudents();
            clbStudents.DisplayMember = "ID";
            clbStudents.ValueMember = "ID";
            lvStudentNames.Items.Clear();
            foreach (
                var item in
                    Util.GetStudents().Select(person => new ListViewItem {Text = person.FName + @" " + person.LName}))
            {
                lvStudentNames.Items.Add(item);
            }
            ttTip.SetToolTip(btnAdd, "Add selected students to " + _qualification.QName + ".");
        }
    }
}