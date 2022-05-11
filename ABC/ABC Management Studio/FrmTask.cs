/*
* Author: Ben Logan
* Student ID: 30013164
*/

using System;
using System.Windows.Forms;

namespace ABC_Management_Studio
{
    internal partial class FrmTask : Form
    {
        private readonly FrmCourses _frmCourses = new FrmCourses();

        private readonly FrmLogin _frmLogin = new FrmLogin();

        private readonly FrmMarks _frmMarks = new FrmMarks();

        private readonly FrmQualifications _frmQualifications = new FrmQualifications();

        private readonly FrmSettings _frmSettings = new FrmSettings();

        private readonly string _userMode;

        private readonly string _userName;

        internal FrmTask(string userName, string userMode)
        {
            //stores the username and mode passed in from the login form
            _userMode = userMode;
            _userName = userName;
            InitializeComponent();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            _frmCourses.ShowDialog();
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            Hide();
            _frmLogin.Show();
        }

        private void btnManageAdministrators_Click(object sender, EventArgs e)
        {
            var frmPeople = new FrmPeople("a");
            frmPeople.ShowDialog();
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            var frmPeople = new FrmPeople("s");
            frmPeople.ShowDialog();
        }

        private void btnManageTeachers_Click(object sender, EventArgs e)
        {
            var frmPeople = new FrmPeople("t");
            frmPeople.ShowDialog();
        }

        private void btnQualifications_Click(object sender, EventArgs e)
        {
            _frmQualifications.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            _frmSettings.ShowDialog();
        }

        private void btnStudentMarks_Click(object sender, EventArgs e)
        {
            _frmMarks.ShowDialog();
        }

        private void FrmTask_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FrmTask_Load(object sender, EventArgs e)
        {
            //sets up the Form based on what kind of user they are and what they have and do not have access to
            switch (_userMode)
            {
                case "administrator":
                    //btnStudentMarks.Text = Messages.NotAvailable;
                    btnQualifications.Enabled = true;
                    btnCourses.Enabled = true;
                    btnManageStudents.Enabled = true;
                    btnManageTeachers.Enabled = true;
                    btnManageAdministrators.Enabled = true;
                    btnSettings.Enabled = true;
                    break;

                case "teacher":
                    btnStudentMarks.Enabled = true;
                    btnQualifications.Enabled = true;
                    btnCourses.Enabled = true;
                    break;

                case "student": //this code will likely never get reached, but just in case.
                    break;

                case "god": //developing purpose, saves having to login all the time
                    btnStudentMarks.Enabled = true;
                    btnQualifications.Enabled = true;
                    btnCourses.Enabled = true;
                    btnManageStudents.Enabled = true;
                    btnManageTeachers.Enabled = true;
                    btnManageAdministrators.Enabled = true;
                    btnSettings.Enabled = true;
                    break;
            }
            //sets the welcome text and title to username - mode
            //sets up the loading panel
            var user = _userName + " - " + _userMode.ToUpperInvariant();
            Text = user;
            lblWelcome.Text = @"Welcome " + _userName + Environment.NewLine + @"Mode: " + _userMode.ToUpperInvariant();
        }
    }
}