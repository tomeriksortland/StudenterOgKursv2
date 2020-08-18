using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace StudenterOgKurs
{
    public class App
    {
        public List<Student> listOfStudents;
        

        public void AddDefaultStudentToList(Student s1, Student s2, Student s3)
        {
            listOfStudents = new List<Student> {s1, s2, s3};
        }


        public void CheckAndDoSomething(string userInteraction)
        {
            userInteraction.ToLower();
            if (userInteraction == "studenter")
            {
                var students  = PrintAllStudents();
                Console.WriteLine(students);
            }

            if (userInteraction == "ny student")
            {
                MakeNewStudent();
            }

            if (userInteraction == "søk")
            {
                SearchForStudentById();
            }

            if (userInteraction == "slett")
            {
                DeleteStudentById();
            }

            else
            {
                Console.WriteLine("Fant ingen kommando, prøv på nytt.");
                Thread.Sleep(1500);
                return;
            }
        }

        private void DeleteStudentById()
        {
            Console.Clear();
            Console.WriteLine("Du kan nå slette en student, angi en ID.");
            var userResponse = Console.ReadLine();
            const string whatMethod = "DeleteStudent";
            var parsedResponse = ParseUserResponse(userResponse, whatMethod);

        }

        private void SearchForStudentById()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Skriv inn studenten sin Id.");
                var userResponse = Console.ReadLine();
                string whatMethod = "SearchForStudent";
                var parsedResponse = ParseUserResponse(userResponse, whatMethod);
                
                var search = SearchForID(parsedResponse);
                if (search != "Finner ikke student, prøv igjen.")
                {
                    Console.Clear();
                    Console.WriteLine("Her er det som ble funnet på ditt ID søk:\n");
                    Console.WriteLine(search);
                    Console.WriteLine();
                    while (true)
                    {
                        Console.WriteLine("For nytt søk skriv inn en ny ID, eller Exit for å komme tilbake til menyen.");
                        var userResponse2 = Console.ReadLine();
                        userResponse2.ToLower();
                        if (userResponse2 == "exit")
                        {
                            Console.Clear();
                            return;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Finner ikke student, prøv igjen.");
                    Thread.Sleep(2000);
                    continue;
                }
            }
        }

        private int ParseUserResponse(string userResponse, string method)
        {
            
            if (int.TryParse(userResponse, out var parsedResponse) == false)
            {
                if (method == "SearchForStudent")
                {
                    SearchForStudentById();
                }

                if (method == "DeleteStudent")
                {
                    DeleteStudentById();
                }
            }

            return parsedResponse;
        }

        private void MakeNewStudent() { 
                var id = 3;
            id++;
            Console.Clear();
            Console.WriteLine("Lage ny student");
            Console.Write("Navn: ");
            var name = Console.ReadLine();
            Console.Write("Epost: ");
            var email = Console.ReadLine();

            var newStudent = new Student(id, $"{name}", $"{email}");
            listOfStudents.Add(newStudent);

            Console.WriteLine("Student er lagt til!");
            Thread.Sleep(1000);
            Console.Clear();
            Welcome();
        }

        private string PrintAllStudents()
        {
            var students = "";
            foreach (var student in listOfStudents)
            {
                 students += $"- ({student.Id})" + student.Name + "\n";
            }

            return students;
        }

        private string SearchForID(int idForSearch)
        {
            foreach (var student in listOfStudents.Where(student => idForSearch == student.Id))
            {
                return (student.Id + " " + student.Name + " " + student.Email);
            }


            return "Finner ikke student, prøv igjen.";
        }

        public void Welcome()
        {
            Console.WriteLine(
                "Hei og velkommen. Dette er et konsoll program for oversikt over kurs og studenter." +
                "Her er kommandoene du kan bruke.\n" +
                "   - Studenter   - Oversikt over alle studenter. \n" +
                "   - Ny student  - Her kan du lage en ny student. \n" +
                "   - Søk         - Her kan du søke etter student ved hjelp av ID \n");
        }
    }
}
