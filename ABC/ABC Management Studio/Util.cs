/*
* Author: Ben Logan
* Student ID: 30013164
*/

using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;

namespace ABC_Management_Studio
{
    /// <summary>
    ///     Utilities class. All the methods that are used throughout the program multiple times can be
    ///     found here.
    /// </summary>
    internal static class Util
    {
        internal static readonly LINQDataClassesDataContext Db = new LINQDataClassesDataContext();

        /// <summary>
        ///     Checks if a person exists based on thier id.
        /// </summary>
        /// <param name="id">The id of the person.</param>
        /// <returns>True/False</returns>
        public static bool DoesPersonExist(int id)
        {
            return (from c in Db.Persons where c.ID == id select c).Any();
        }

        /// <summary>
        ///     Checks if a course exists using the course id.
        /// </summary>
        /// <param name="cid">The course id.</param>
        /// <returns></returns>
        internal static bool DoesCourseExist(int cid)
        {
            return (from c in Db.Courses where c.CID == cid select c).Any();
        }

        /// <summary>
        ///     Checks if a student exists.
        /// </summary>
        /// <param name="id">The ID of the student.</param>
        /// <returns>True/False</returns>
        internal static bool DoesStudentExist(int id)
        {
            return (from c in Db.Persons where c.ID == id && c.Type == "Student" select c).Any();
        }

        /// <summary>
        ///     Checks if a teacher exists based on thier teacher id.
        /// </summary>
        /// <param name="tid">The teachers id.</param>
        /// <returns></returns>
        internal static bool DoesTeacherExist(int tid)
        {
            return (from c in Db.TeacherViews where c.TID == tid select c).Any();
        }

        /// <summary>
        ///     Get a list of students that are enrolled in a particular course using the course id.
        /// </summary>
        /// <param name="cid">The cid.</param>
        /// <returns></returns>
        internal static List<Student_Course> FillByCourseId(int cid)
        {
            return (from s in Db.Student_Courses where s.CID == cid orderby s.CID select s).ToList();
        }

        /// <summary>
        ///     Gets a list of courses a particular student is on using thier student id.
        /// </summary>
        /// <param name="sid">The students id.</param>
        /// <returns></returns>
        internal static List<Student_Course> FillByStudentId(int sid)
        {
            return (from s in Db.Student_Courses where s.SID == sid orderby s.SID select s).ToList();
        }

        /// <summary>
        ///     Gets all the admin details
        /// </summary>
        /// <returns></returns>
        internal static List<Administration> GetAdminExtras()
        {
            return (from a in Db.Administrations orderby a.AID select a).ToList();
        }

        /// <summary>
        ///     Gets all the people listed as admins
        /// </summary>
        /// <returns></returns>
        internal static List<Person> GetAdmins()
        {
            return (from s in Db.Persons where s.Type == "Administrator" orderby s.ID select s).ToList();
        }

        /// <summary>
        ///     Gets the course object by course id.
        /// </summary>
        /// <param name="cid">The cid.</param>
        /// <returns></returns>
        internal static Course GetCourseByCid(int cid)
        {
            return (from c in Db.Courses where c.CID == cid select c).First();
        }

        /// <summary>
        ///     Gets the name of the specified course.
        /// </summary>
        /// <param name="cid">The course id.</param>
        /// <returns></returns>
        internal static string GetCourseNameByCourseId(int cid)
        {
            return (from c in Db.Courses where c.CID == cid select c.CName).First();
        }

        /// <summary>
        ///     Gets a list of qualifications that contain the specified course.
        /// </summary>
        /// <param name="cid">The cid.</param>
        /// <returns>List</returns>
        internal static List<Qualification> GetCourseQualifications(int cid)
        {
            var quals = new List<Qualification>();
            foreach (var record in Db.Qualification_Courses.Where(record => record.CID == cid))
            {
                var quali = (from s in Db.Qualifications where s.QCode == record.QCode orderby s.QCode select s).First();
                quals.Add(quali);
            }
            return quals;
        }

        /// <summary>
        ///     Gets all the courses offered.
        /// </summary>
        /// <returns></returns>
        internal static List<Course> GetCourses()
        {
            return (from c in Db.Courses orderby c.CID select c).ToList();
        }

        /// <summary>
        ///     Gets a person based on thier id.
        /// </summary>
        /// <param name="id">The id of the person.</param>
        /// <returns>Person</returns>
        internal static Person GetPerson(int id)
        {
            return (from p in Db.Persons where p.ID == id select p).First();
        }

        /// <summary>
        ///     Gets the full name of the person using thier id.
        /// </summary>
        /// <param name="id">The person id.</param>
        /// <returns></returns>
        internal static string GetPersonName(int id)
        {
            var faculty = (from c in Db.Persons where c.ID == id select c).First();
            var fName = faculty.FName.Trim();
            var lName = faculty.LName.Trim();
            return fName + " " + lName;
        }

        /// <summary>
        ///     Gets the role of a person. i.e. admin/teacher
        /// </summary>
        /// <param name="id">The id of the person.</param>
        /// <returns></returns>
        internal static string GetPersonRole(int id)
        {
            return (from p in Db.Persons where p.ID == id select p).First().Type.ToLower().Trim();
        }

        /// <summary>
        ///     Gets the qualification as an object.
        /// </summary>
        /// <param name="qCode">The qualification code.</param>
        /// <returns></returns>
        internal static Qualification GetQualificationByQCode(string qCode)
        {
            return (from q in Db.Qualifications where q.QCode == qCode select q).First();
        }

        /// <summary>
        ///     Gets the name of the qualification qCode by using the qualification name.
        /// </summary>
        /// <param name="qName">Name of the qualification</param>
        /// <returns></returns>
        internal static string GetQualificationCodeByName(string qName)
        {
            return (from s in Db.Qualifications where s.QName == qName select s.QCode).First();
        }

        /// <summary>
        ///     Gets a list of courses contained in a qualification.
        /// </summary>
        /// <param name="qCode">The qualification qCode.</param>
        /// <returns>List of Courses</returns>
        internal static List<Course> GetQualificationCourses(string qCode)
        {
            var course = new List<Course>();
            foreach (var record in Db.Qualification_Courses.Where(record => record.QCode == qCode))
            {
                var tCourse = (from s in Db.Courses where s.CID == record.CID select s).First();
                course.Add(tCourse);
            }
            return course;
        }

        /// <summary>
        ///     Gets duration of a particular qualification in years. Rounds UP to nearest year.
        /// </summary>
        /// <param name="qName">Name of the qualification.</param>
        /// <returns></returns>
        internal static decimal GetQualificationLengthByName(string qName)
        {
            var number = (from s in Db.Qualifications where s.QName == qName select s.Duration).First().Split();
            var value = Convert.ToDecimal(number[0])/12;
            var num = Math.Ceiling(value);
            return num;
        }

        /// <summary>
        ///     Gets the duration of all qualifications in years. Rounds UP to nearest year.
        /// </summary>
        /// <returns></returns>
        internal static List<decimal> GetQualificationLengthsAsYears()
        {
            var yearsList = new List<decimal>();
            foreach (var year in Db.Qualifications)
            {
                var number = year.Duration.Split();
                var value = Convert.ToDecimal(number[0])/12;
                var num = Math.Ceiling(value);
                if (yearsList.Contains(num)) continue;
                yearsList.Add(num);
            }
            yearsList.Sort();

            return yearsList;
        }

        /// <summary>
        ///     Gets all the qualifications offered.
        /// </summary>
        /// <returns></returns>
        internal static List<Qualification> GetQualifications()
        {
            return (from q in Db.Qualifications orderby q.QCode select q).ToList();
        }

        /// <summary>
        ///     Gets mark for a course for a particular student.
        /// </summary>
        /// <param name="sid">The student id.</param>
        /// <param name="cid">The course id.</param>
        /// <returns></returns>
        internal static Student_Course GetStudentCourseMark(int sid, int cid)
        {
            return (from m in Db.Student_Courses where m.SID == sid && m.CID == cid select m).First();
        }

        /// <summary>
        ///     Gets all the students (enrolled or not).
        /// </summary>
        /// <returns></returns>
        internal static List<Person> GetStudents()
        {
            return (from s in Db.Persons where s.Type == "Student" orderby s.ID select s).ToList();
        }

        /// <summary>
        ///     Gets the amount of students on a particular course.
        /// </summary>
        /// <param name="cid">The course id.</param>
        /// <returns></returns>
        internal static int GetStudentsOnCourseCount(int cid)
        {
            return (from s in Db.Student_Courses where s.CID == cid select s).Count();
        }

        /// <summary>
        ///     Gets all the teacher details
        /// </summary>
        /// <returns></returns>
        internal static List<Teacher> GetTeacherExtras()
        {
            return (from t in Db.Teachers orderby t.TID select t).ToList();
        }

        /// <summary>
        ///     Gets the teacher ids in string form i.e 1, 2, 3, 4, 5
        /// </summary>
        /// <returns></returns>
        internal static string GetTeacherIds()
        {
            var message = (from s in Db.TeacherViews select s.TID).ToList()
                .Aggregate("", (current, value) => current + (value + ", "));
            return message.Substring(0, message.Length - 2);
        }

        /// <summary>
        ///     Gets all the people listed as teachers.
        /// </summary>
        /// <returns></returns>
        internal static List<Person> GetTeachers()
        {
            return (from s in Db.Persons where s.Type == "Teacher" orderby s.ID select s).ToList();
        }

        /// <summary>
        ///     Returns the object value as int.
        /// </summary>
        /// <param name="toConvert">To convert.</param>
        /// <returns></returns>
        internal static int Int(object toConvert)
        {
            return Convert.ToInt32(toConvert);
        }

        /// <summary>
        ///     Determines whether a student is enrolled in any qualifications.
        /// </summary>
        /// <param name="sid">The id of the student to check.</param>
        /// <returns></returns>
        internal static bool IsStudentEnrolled(int sid)
        {
            return (from s in Db.Students where s.SID == sid select s.QCode).Any();
        }

        /// <summary>
        ///     Removes the specified course from the system completely.
        /// </summary>
        /// <param name="cid">The course id.</param>
        /// <returns></returns>
        internal static bool RemoveCourseFromAbc(int cid)
        {
            //checks if there are any students enrolled in the course
            if (AnyStudentsOnCourse(cid))
            {
                Messages.StudentsOnCourse(cid);
                return false;
            }

            //shows a message confirming the users actions
            var result = MessageBox.Show(
                @"This will remove " + GetCourseNameByCourseId(cid) + @" from ABC. Continue?", @"Remove Course",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return false;
            //only continue if user clicks yes
            //1. gets course to delete
            //2. iterates through the qualifications removing the course from them
            //3. removes the course from ABC systems
            var course = (from c in Db.Courses where c.CID == cid select c).First();
            Db.Courses.DeleteOnSubmit(course);
            foreach (var qCourse in Db.Qualification_Courses.Where(qCourse => qCourse.CID == cid))
            {
                Db.Qualification_Courses.DeleteOnSubmit(qCourse);
            }
            Db.SubmitChanges();
            Db.Refresh(RefreshMode.OverwriteCurrentValues, Db.Courses);
            Db.Refresh(RefreshMode.OverwriteCurrentValues, Db.Qualification_Courses);
            return true;
        }

        /// <summary>
        ///     Removes the specified course from the specified qualification.
        /// </summary>
        /// <param name="cid">The course id.</param>
        /// <param name="qCode">The qualification code.</param>
        /// <returns></returns>
        internal static bool RemoveCourseFromQualification(int cid, string qCode)
        {
            if (AnyStudentsOnCourse(cid))
            {
                Messages.StudentsOnCourse(cid);
                return false;
            }
            var result = MessageBox.Show(
                @"This will remove the " + GetCourseNameByCourseId(cid) + @" course from the " +
                GetQualificationNameByQCode(qCode) + @" qualification. Continue?", @"Remove Course",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return false;
            //only continue if user clicks yes
            //1. gets course to delete
            //2. removes the course from ABC systems
            var record = (from c in Db.Qualification_Courses where c.CID == cid && c.QCode == qCode select c).First();
            Db.Qualification_Courses.DeleteOnSubmit(record);
            Db.SubmitChanges();
            Db.Refresh(RefreshMode.OverwriteCurrentValues, Db.Qualification_Courses);
            return true;
        }

        /// <summary>
        ///     Removes the specified qualificaton from the system completely.
        /// </summary>
        /// <param name="qCode">The qualification qCode.</param>
        /// <returns></returns>
        internal static bool RemoveQualificationFromAbc(string qCode)
        {
            var result = MessageBox.Show(
                @"This will remove " + GetQualificationNameByQCode(qCode) + @" from ABC. Continue?",
                @"Remove Qualification",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return false;
            var qual = (from q in Db.Qualifications where q.QCode == qCode select q).First();
            foreach (var item in Db.Qualification_Courses.Where(item => item.QCode == qCode))
            {
                Db.Qualification_Courses.DeleteOnSubmit(item);
            }
            Db.Qualifications.DeleteOnSubmit(qual);
            Db.SubmitChanges();
            Db.Refresh(RefreshMode.OverwriteCurrentValues, Db.Qualification_Courses);
            Db.Refresh(RefreshMode.OverwriteCurrentValues, Db.Qualifications);
            return true;
        }

        /// <summary>
        ///     Checks if a student is on a course using thier id and the course id.
        /// </summary>
        /// <param name="sid">The stjudent id.</param>
        /// <param name="cid">The course id.</param>
        /// <returns>True/False</returns>
        internal static bool StudentIsOnCourse(int sid, int cid)
        {
            return (from s in Db.Student_Courses where s.SID == sid && s.CID == cid select s).Any();
        }

        /// <summary>
        ///     Used for validating a new student mark. Checks if all the fields are numbers.
        /// </summary>
        /// <param name="cid">The cid.</param>
        /// <param name="sid">The sid.</param>
        /// <param name="mark">The mark.</param>
        /// <returns>True/False</returns>
        internal static bool ValidInput(string cid, string sid, string mark)
        {
            if (!ValidNumber(cid))
            {
                Messages.InvalidId();
                return false;
            }
            if (!ValidNumber(sid))
            {
                Messages.InvalidId();
                return false;
            }
            if (!ValidNumber(mark))
            {
                Messages.InvalidMark();
                return false;
            }
            return true;
        }

        /// <summary>
        ///     Checks if a string is a number.
        /// </summary>
        /// <param name="textNumber">The string to check.</param>
        /// <returns>True/False</returns>
        internal static bool ValidNumber(string textNumber)
        {
            int tMark;
            return int.TryParse(textNumber, out tMark);
        }

        /// <summary>
        ///     Checks of there are any students on particular course.
        /// </summary>
        /// <param name="cid">The course id.</param>
        /// <returns></returns>
        private static bool AnyStudentsOnCourse(int cid)
        {
            return (from s in Db.Student_Courses where s.CID == cid select s).Any();
        }

        /// <summary>
        ///     Gets the qualification name by using the qualification qCode
        /// </summary>
        /// <param name="qCode">The qualification qCode.</param>
        /// <returns></returns>
        private static string GetQualificationNameByQCode(string qCode)
        {
            return (from c in Db.Qualifications where c.QCode == qCode select c.QName).First();
        }
    }
}