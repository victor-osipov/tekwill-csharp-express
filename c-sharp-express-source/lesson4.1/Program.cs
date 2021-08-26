using System;
using System.Collections.Generic;

namespace lesson4._1
{
    /// <summary>
    /// program for working with List of students;
    ///     1 - add new name
    ///     2 - print all names to console
    ///     3 - remove user by name
    ///     4 - exit
    /// </summary>
    class Program
    {
        static void Main()
        {
            var list = new List<string>();

            for (; ; )
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - add new name");
                Console.WriteLine("2 - print all names to console");
                Console.WriteLine("3 - remove user by name");
                Console.WriteLine("4 - exit");
                var input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("please enter name:");
                    var name = Console.ReadLine();
                    list.Add(name);
                }

                if (input == "2")
                {
                    foreach (string name in list)
                    {
                        Console.WriteLine($"> {name}");
                    }
                }

                if (input == "3")
                {
                    Console.WriteLine("please enter name to remove:");
                    var name = Console.ReadLine();
                    list.Remove(name);
                }

                if (input == "4")
                {
                    break;
                }
            }

            Console.WriteLine("Done! Terminating");
        }
    }
}
