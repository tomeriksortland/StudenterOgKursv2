using System;
using NUnit.Framework;
using StudenterOgKursv2;

namespace StudenterOgKursTest
{
    public class Tests
    {
        [Test]
        public void TestAddStudent()
        {
          var student = new Student("Tom Erik", "TomErik@getacademy.no");
          var studentList = new StudentList();
          var result = studentList.AddStudent(student);

          Assert.AreEqual(true, result);
        }

        [Test]
        public void TestRemoveStudent()
        {
            var student = new Student("Tom Erik", "TomErik@getacademy.no");
            var studentList = new StudentList();
            studentList.AddStudent(student);
            var result = studentList.RemoveStudent(student);

            Assert.AreEqual(true, result);
        }

        [Test]
        public void TestRemoveStudentFail()
        {
            var student = new Student("Tom Erik", "TomErik@getacademy.no");
            var student2 = new Student("Torfin", "Torfin@getacademy.no");
            var studentList = new StudentList();
            studentList.AddStudent(student);
            var result = studentList.RemoveStudent(student2);

            Assert.AreEqual(false, result);
        }

        [Test]
        public void TestAddCourseToStudent()
        {
            var student1 = new Student("Tom Erik", "tomerik@getacademy.no");
            var course1 = new Course("StartIT");
            var courseList = new CourseList();
            var studentList = new StudentList();
            var addStudent = studentList.AddStudent(student1);
            courseList.AddCourse(course1);

            var result = studentList.AddCourseToStudent(course1, student1);

            Assert.AreEqual(true, result);

        }


    }
}