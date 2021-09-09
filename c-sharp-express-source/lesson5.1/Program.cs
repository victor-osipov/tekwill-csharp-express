using System;

using lesson5._1.Services;

namespace lesson5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            IStudentService service = new FileStudentService();

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
