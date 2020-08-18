using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace StudenterOgKursv2
{
    public class StudentList
    {
        private readonly List<Student> _students = new List<Student>();

        public bool AddStudent(Student student)
        {
            _students.Add(student);
            return true;
        }

        public bool RemoveStudent(Student student)
        {
            if (!_students.Contains(student)) return false;
            _students.Remove(student);
            return true;
        }

        public bool AddCourseToStudent(Course course, Student student)
        {
            if (student._activeCourses.Contains(course)) return false;
            student._activeCourses.Add(course);
            return true;
        }
        
    }
}
