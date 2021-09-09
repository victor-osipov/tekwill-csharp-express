using System;

using Students.Domain.Repository;
using Students.Domain.Service;

namespace Students.Console3
{
    class Program
    {
        /// <summary>
        /// main method, entry point
        /// </summary>
        static void Main(string[] args)
        {
            var repository = new FileStudentsRepository("students.txt");

            var service = new StudentService(repository);

            for (; ; )
            {
                PrintMenu();
                var input = Console.ReadLine();

                if (input == "1")
                {
                    service.CreateStudent();
                }
                if (input == "2")
                {
                    service.PrintAllStudents();
                }
                if (input == "x")
                {
                    break;
                }
            }

        }

        /// <summary>
        /// method for printing app menu -> console
        /// </summary>
        static void PrintMenu()
        {
            Console.WriteLine("1 - create new student");
            Console.WriteLine("2 - print all to console");
            Console.WriteLine("x - exit");
            Console.WriteLine(">>");
        }
    }
}
