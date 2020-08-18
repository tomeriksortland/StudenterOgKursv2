#nullable enable
using System;
using System.Collections.Generic;
using System.Text;

namespace StudenterOgKursv2
{
    public class Student : BaseEntity
    {
        public string Name;
        public string Email;
        public List<Course> _activeCourses = new List<Course>();

        public Student(string name, string email, Guid? id = null) : base(id)
        {
            Name = name;
            Email = email;
        }
    }
}
