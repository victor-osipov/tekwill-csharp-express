using System;
using System.Collections.Generic;
using System.IO;

using Students.Domain.Entity;

namespace lesson5._1.Services
{
    /// <summary>
    /// this service should:
    ///     store a list of students (in memory);
    ///     print all students to console;
    ///     add new student;
    ///     remove student;
    ///     write all student to file on disk;
    /// </summary>
    public class FileStudentService : IStudentService
    {
        private List<Student> list = new List<Student>();

        //todo
        // add student's repository and work with it

        public FileStudentService()
        {
        }

        public void PrintAllStudents()
        {
            var fileName = "students.txt";

            var linesFromFile = File.ReadAllLines(fileName);

            foreach (var name in linesFromFile)
            {
                Console.WriteLine(name);
            }
        }

        public void AddNewStudent()
        {
            Console.WriteLine("please enter first name:");
            var firstName = Console.ReadLine();

            Console.WriteLine("please enter last name:");
            var lastName = Console.ReadLine();

            var student1 = new Student
            {
                FirstName = firstName,
                LastName = lastName,
                BirthDay = DateTime.Now,
                Id = default
            };

            list.Add(student1);
        }

        public void RemoveStudentByName()
        {
            Console.WriteLine("please enter first name to remove:");
            var nameToRemove = Console.ReadLine();

            Student s1 = default;

            foreach (var student in list)
            {
                if (student.FirstName == nameToRemove)
                {
                    s1 = student;
                }
            }

            list.Remove(s1);
        }

        public void WriteStudentsToFile()
        {
            var fileName = "students.txt";

            var lines = new List<string>();

            foreach (var stud in list)
            {
                var name = stud.GetFullName();
                lines.Add(name);
            }

            File.WriteAllLines(fileName, lines);
        }
    }
}
