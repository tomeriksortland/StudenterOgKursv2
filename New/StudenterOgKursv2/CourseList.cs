using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudenterOgKursv2
{
    public class CourseList
    {
        private readonly List<Course> _courses = new List<Course>();
        

        public bool AddCourse(Course course)
        {
            _courses.Add(course);
            return true;
        }

        public bool RemoveCourse(Course course)
        {
            if (!_courses.Contains(course)) return false;
            _courses.Remove(course);
            return true;
        }

        public bool AddStudentToCourse(Student student, Course course)
        {
            if (course._activeStudents.Contains(student)) return false;
            course._activeStudents.Add(student);
            return true;

        }
    }

    
}
