using System;
using System.Collections;
using System.Collections.Generic;

namespace StudenterOgKurs
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentInfo = new App();
            var s1 = new Student(1,"Tom Erik", "tomerik@getacademy.no");
            var s2 = new Student(2,"Torfin", "torfin@getacademy.no");
            var s3 = new Student(3,"Even", "even@getacademy.no");

            studentInfo.AddDefaultStudentToList(s1,s2,s3);
            

            while (true)
            {
                studentInfo.Welcome();
                var userInteraction = Console.ReadLine();
                studentInfo.CheckAndDoSomething(userInteraction);

            }
            




        }

    }
}
