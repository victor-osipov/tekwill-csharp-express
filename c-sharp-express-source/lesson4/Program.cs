using System;
using System.Collections.Generic;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! lesson 4");

            bool condition = true;
            bool otherCondition = false;

            var condition3 = true;

            var c1 = 100;
            var c2 = 100.25;

            string text1 = "some text";
            var text2 = "some other text";

            // error - unknown type
            //var pp;

            // arrays
            string[] colors = { "red", "blue", "green" };

            // see blue
            Console.WriteLine(colors[1]);
            colors[2] = "yellow";

            // error! outside the range [0 1 2]
            //colors[3] = "error";

            // collecton itteration with foreach
            Console.WriteLine("Array items:");
            foreach (string color in colors)
            {
                Console.WriteLine(color);
                // .. other logic with EACH element
            }

            // collecton itteration with for
            // only for 0 and 2 items
            Console.WriteLine("Array items with for:");
            for (int i = 0; (i < 3); i++)
            {
                if (i == 0 || i == 2)
                {
                    Console.WriteLine(colors[i]);
                }
                // .. other logic
            }

            // work with List<T> collection
            var names = new List<string> { "Elena", "Slava", "Boss" };

            foreach (string name in names)
            {
                Console.WriteLine($"Hello {name}!");
            }

            names.Add("Vasea");
            names.Add("petea");
            names.Add("Gus");

            foreach (string name in names)
            {
                Console.WriteLine($"Hello {name}!");
            }

        }
    }
}
