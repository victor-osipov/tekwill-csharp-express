using System;
using System.Collections.Generic;

namespace lesson6
{
    public static class Extensions
    {
        public static List<int> GreaterThenFive(this List<int> list)
        {
            var newList = new List<int>();

            foreach (var item in list)
            {
                if (item >= 5)
                {
                    newList.Add(item);
                }
            }

            return newList;
        }
    }
}
