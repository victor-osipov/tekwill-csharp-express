using System;
//using System.Linq;
using System.Collections.Generic;
using System.Linq;

namespace lesson6
{
    /// <summary>
    /// in this app we will play with LINQ extension methods
    /// on very simple examples!
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            numbers.Add(7);
            numbers.Add(5);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(9);

            // count example
            var total = numbers.Count();

            // first and last example
            var n1 = numbers.First();

            var n2 = numbers.Last();

            var max = numbers.Max();

            numbers.Sort();

            // where example
            //var greaterThenFive = numbers.Where(x => x >= 5);

            var greaterThenFive = numbers.GreaterThenFive();
        }

    }
}
