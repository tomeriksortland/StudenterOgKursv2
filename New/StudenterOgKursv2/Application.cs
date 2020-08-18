using System;
using System.Collections.Generic;
using System.Text;

namespace StudenterOgKursv2
{
    public class Application
    {

        public bool Run()
        {
            var student1 = new Student("Terje", "Terje@getacademy.no");
            var student2 = new Student("Tom Erik", "TomErik@getacademy.no");
            var student3 = new Student("Torfin", "Even@getacademy.no");
            var course1 = new Course("StartIT");
            var course2 = new Course("GetIT");
            var course3 = new Course("ABAX");
            var studentList = new StudentList();
            var courseList = new CourseList();
            
            var addStudent1 = studentList.AddStudent(student1);
            var addStudent2 = studentList.AddStudent(student2);
            var addCourse1 = courseList.AddCourse(course1);
            var addCourse2 = courseList.AddCourse(course2);


            var removeStudent = studentList.RemoveStudent(student2);
            var removeCourse = courseList.RemoveCourse(course2);

            
            var signUpStudentForCourse = courseList.AddStudentToCourse(student3, course3);
            var test  = studentList.AddCourseToStudent(course3, student3);

            return true;
        }
    }
}
