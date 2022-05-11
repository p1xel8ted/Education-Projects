/*
* Author: Ben Logan
* Student ID: 30013164
*/

using System.Linq;
using System.Windows.Forms;
using ABC_Management_Studio.Properties;

namespace ABC_Management_Studio
{
    internal static class Messages
    {
        internal static string CellsEmptyText = "Cells cannot be empty!";
        internal static string InvalidDataText = "Invalid data detected, please check your input.";
        internal static string InvalidMarkIdText = "Invalid field. Must consist of numbers only.";

        internal static string MinMaxSemesterText = "Min Semesters: 1, Max Semesters: " +
                                                    Settings.Default.Semesters;

        internal static string MinMaxYearText = "Min Years: 1, Max Years: " +
                                                Util.GetQualificationLengthsAsYears().Max();

        internal static string TeacherNotFound = "Teacher you entered does not exist. Possible options: " +
                                                 Util.GetTeacherIds();

        public static string QualificationNameCantBeEmpty = "Qualification name can't be empty.";

        private static void ShowMessage(string message, MessageBoxIcon icon)
        {
            MessageBox.Show(message, @"ABC", MessageBoxButtons.OK, icon);
        }

        internal static void AddedCourseToSelectedQualifications(Course course)
        {
            ShowMessage("Successfully added " + course.CName + " to selected qualification.", MessageBoxIcon.Information);
        }

        internal static void AddedPersonSuccess(Person p)
        {
            ShowMessage("Successfully added " + p.FName + " to the system. ID code is: " + p.ID,
                MessageBoxIcon.Information);
        }

        internal static void AddedSelectedCoursesToQualification(Qualification qual)
        {
            ShowMessage("Successfully added selected courses to " + qual.QName + ".", MessageBoxIcon.Information);
        }

        internal static void CheckBoxValidationMessage()
        {
            ShowMessage("Please ensure details are correct and tick the check box.", MessageBoxIcon.Information);
        }

        internal static void CourseAlreadyInQualification()
        {
            ShowMessage("That qualification already contains that course.", MessageBoxIcon.Exclamation);
        }

        internal static void CourseNameNoNumbers()
        {
            ShowMessage("Course name can't be blank or be a number.", MessageBoxIcon.Information);
        }

        internal static void GenericProblem()
        {
            ShowMessage("An unkown error occurred. Please try again. If the problem persists, please contact IT.",
                MessageBoxIcon.Error);
        }

        internal static void InvalidId()
        {
            ShowMessage("ID is made up of numbers only.", MessageBoxIcon.Exclamation);
        }

        internal static void InvalidLogin()
        {
            ShowMessage("Those login details are incorrect. Please try again or contact IT.",
                MessageBoxIcon.Exclamation);
        }

        internal static void InvalidMark()
        {
            ShowMessage("The mark you have entered is invalid.", MessageBoxIcon.Information);
        }

        internal static void NoCourseFound()
        {
            ShowMessage("The course you have requested does not exist.", MessageBoxIcon.Information);
        }

        internal static void NoStudentAccess()
        {
            ShowMessage("Students are not allowed access to this resource.", MessageBoxIcon.Exclamation);
        }

        internal static void NoStudentFound()
        {
            ShowMessage("The student you have requested does not exist.", MessageBoxIcon.Information);
        }

        internal static void NoUser()
        {
            ShowMessage("The user you have entered does not exist.", MessageBoxIcon.Information);
        }

        internal static void QualificationCantBeEmpty()
        {
            ShowMessage("Qualification name can't be blank or be a number.", MessageBoxIcon.Information);
        }

        internal static void QualificationNameAlreadyExists()
        {
            ShowMessage("A qualification with that name already exists.", MessageBoxIcon.Information);
        }

        internal static void StudentIsntEnrolled(int sid)
        {
            ShowMessage(Util.GetPersonName(sid) + " isn't enrolled in any qualifications yet.",
                MessageBoxIcon.Information);
        }

        internal static void StudentsOnCourse(int cid)
        {
            var studentCount = Util.GetStudentsOnCourseCount(cid);
            ShowMessage(
                studentCount + " student(s) still enrolled in this course. Please remove them before continuing.",
                MessageBoxIcon.Exclamation);
        }

        internal static void SuccessfullyAddedStudentsToQualifications(Qualification qual)
        {
            ShowMessage("Successfully added selected students to " + qual.QName, MessageBoxIcon.Information);
        }

        internal static void UnkownLogin()
        {
            ShowMessage("You are not authorised to use this system. IT has been notified.", MessageBoxIcon.Exclamation);
        }

        internal static void YearNumbersOnly()
        {
            ShowMessage("Please enter numbers only, in months. i.e. 24, 48.", MessageBoxIcon.Exclamation);
        }
    }
}