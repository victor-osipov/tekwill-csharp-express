using System;

namespace lesson2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number");

            var line = Console.ReadLine();

            Console.WriteLine("You entered");
            Console.WriteLine(line);

            var line_double = double.Parse(line);

            var koren = Math.Sqrt(line_double);

            Console.WriteLine("SQRT:");
            Console.WriteLine(koren);

        }

        //static void Main()
        //{
        //    Console.WriteLine("Hello World 1!");

        //    int a, b, c;

        //    a = 7;

        //    b = a;

        //    c = b++;

        //    b = a + b * c;
        //    //c = a >= 100 ? b : c / 10;
        //    a = (int)Math.Sqrt(9);

        //    string s = "String stroka";

        //    //Student s1;

        //    char l = 'b';

        //    //var numbers = new List<int>(new[] { 1, 2, 3 });
        //    //b = numbers.FindLast(n => n > 1);
        //}
    }

    class Student { }

    class Mark { }

}
