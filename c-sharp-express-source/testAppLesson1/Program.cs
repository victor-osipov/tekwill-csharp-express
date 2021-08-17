using System;

namespace testAppLesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int count = 17;

            Console.WriteLine($"On course we have {count} participants");

            foreach (var item in args)
            {
                Console.WriteLine(item);
            }
        }
    }
}
