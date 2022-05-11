/*
* Author: Ben Logan
* Student ID: 30013164
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ABC_Management_Studio
{
    internal partial class FrmLogin : Form
    {
        private readonly List<string> _roles = new List<string>(new[]
        {
            "administrator",
            "student",
            "teacher"
        });

        private int _userId; //used for storing the entered user id

        internal FrmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //simple null string validation of user and pass text boxes
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show(@"Some details are missing. Please try again.", @"ABC", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtUser.Focus();
                return;
            }
            PerformLogin();
        }

        private void PerformLogin()
        {
            try
            {
                _userId = Util.Int(txtUser.Text); //stores the userid after convering it to an integer
                var pass = txtPassword.Text; //stores the password as text
                if (!Util.DoesPersonExist(_userId)) //checks if the user id exists
                {
                    Messages.NoUser(); //general no such user message box
                    return;
                }
                var role = Util.GetPersonRole(_userId); //gets the role of the person i.e. admin/student etc
                if (role == "administrator")
                {
                    var adminId =
                        (from u in Util.Db.AdminViews where u.AID == _userId && u.Password == pass select u).Any();
                    if (adminId == false)
                    {
                        //throw general exception if password is incorrect
                        throw new Exception();
                    }
                }
                if (role == "teacher")
                {
                    var teachId =
                        (from u in Util.Db.TeacherViews where u.TID == _userId && u.Password == pass select u).Any();
                    if (teachId == false)
                    {
                        //throw general exception if password is incorrect
                        throw new Exception();
                    }
                }
                if (role == "student")
                {
                    //pops if the person trying to login is classified as a student
                    Messages.NoStudentAccess();
                    return;
                }
                if (!_roles.Contains(role.ToLower())) //code should never get reached, but just in case
                {
                    Messages.UnkownLogin();
                    return;
                }
                // Close();
                var name = Util.GetPersonName(_userId); //gets the name of the person
                var frmTask = new FrmTask(name, role); //passes the name and role of the person to the Task form.
                frmTask.Show();
                Hide();
            }
            catch (Exception)
            {
                Messages.InvalidLogin(); //General invalid login message
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.SelectAll(); //quality of life, selects all text (if any) upon entering the control
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allows the user to press Enter/Return on the password field to initiate login
            if (e.KeyChar == (char) Keys.Return | e.KeyChar == (char) Keys.Enter)
            {
                PerformLogin();
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            txtUser.SelectAll(); //quality of life, selects all text (if any) upon entering the control
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allows the user to press Enter/Return on the user id field to initiate login
            if (e.KeyChar == (char) Keys.Return | e.KeyChar == (char) Keys.Enter)
            {
                PerformLogin();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUser.Focus(); //sets username to focus
        }
    }
}