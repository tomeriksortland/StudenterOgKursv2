using System;
using System.Collections.Generic;
using System.Text;

namespace StudenterOgKursv2
{
    public class Course : BaseEntity
    {
        public string Name;
        public List<Student> _activeStudents = new List<Student>();

        public Course(string name, Guid? id = null) : base(id)
        {
            Name = name;
        }
    }
}
