using NUnit.Framework;
using StudenterOgKursv2;

namespace StudenterOgKursTest
{
    public class CourseListTest
    {
        [Test]
        public void TestAddCourse()
        {
            var course = new Course("GetIT");
            var courseList = new CourseList();
            var result = courseList.AddCourse(course);

            Assert.AreEqual(true, result);
        }


        [Test]
        public void TestRemoveCourse()
        {
            var course = new Course("GetIT");
            var courseList = new CourseList();
            courseList.AddCourse(course);
            var result = courseList.RemoveCourse(course);

            Assert.AreEqual(true, result);
        }

        [Test]
        public void TestRemoveCourseFail()
        {
            var course = new Course("GetIT");
            var course2 = new Course("StartIT");
            var courseList = new CourseList();
            courseList.AddCourse(course2);
            var result = courseList.RemoveCourse(course);

            Assert.AreEqual(false, result);
        }

        [Test]
        public void TestAddStudentToCourse()
        {
            var course1 = new Course("StartIT");
            var course2 = new Course("GetIT");
            var courseList = new CourseList();
            var student = new Student("Tom Erik", "tomerik@getacademy.no");
            courseList.AddCourse(course1);
            courseList.AddCourse(course2);

            var test = courseList.AddStudentToCourse(student, course2);


            Assert.AreEqual(true, test);

        }
    }
}
