﻿using System;
using System.Collections.Generic;
using System.IO;

using lesson5._1.Model;

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
    public class StudentService : IStudentService
    {
        private List<Student> list = new List<Student>();

        public StudentService()
        {
        }

        public void PrintAllStudents()
        {
            foreach (var student in list)
            {
                Console.WriteLine(student.GetFullName());
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
                Registered = DateTime.Now
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
