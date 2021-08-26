using System;

namespace lesson3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you age:");

            var line = Console.ReadLine();

            var age = int.Parse(line);

            bool condition = (age > 18);

            if (condition)
            {
                Console.WriteLine("Access granted");
            }
            else
            {
                Console.WriteLine("Access failed");
            }

            Console.WriteLine("done");

        }
    }
}
