using System;
using System.Collections.Generic;

using lesson5._1.Model;
using lesson5._1.Services;

namespace lesson5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestBox();

            var service = new StudentService();

            for (; ; )
            {
                string input = PrintMenuAndRead();

                switch (input)
                {
                    case "1":
                        service.AddNewStudent();
                        break;

                    case "2":
                        service.PrintAllStudents();
                        break;

                    case "3":
                        service.RemoveStudentByName();
                        break;

                    case "4":
                        service.WriteStudentsToFile();
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine("Done! Terminating");
        }

        private static void TestBox()
        {
            var listBox = new List<IBox>();

            var b1 = new RedBox();

            var b2 = new GreenBox();

            listBox.Add(b1);
            listBox.Add(b2);
        }

        private static string PrintMenuAndRead()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - add new student");
            Console.WriteLine("2 - print all student to console");
            Console.WriteLine("3 - remove user by name");
            Console.WriteLine("4 - write all to file!");
            var input = Console.ReadLine();
            return input;
        }

    }
}
