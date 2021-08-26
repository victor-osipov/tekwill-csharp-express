using System;

namespace lesson3
{
    class Program
    {
        static void Main()
        {

            string first = "stroka ghgh uiui oioi";

            string stroka2 = "2nd";

            char ch1 = 'a';

            int second = 1010;

            //empty object
            Knopka k1 = new Knopka { };
            Knopka k1same = new Knopka();

            Knopka kConstr = new Knopka("square", 'Q', "plastic");
            kConstr.Material = "metal";

            //filled object
            Knopka k2 = new Knopka
            {
                Forma = "square",
                Label = 'Q',
                //Material = "plastic"
            };

            k2.Material = "metal";

            Console.WriteLine(k2);
            Console.WriteLine(k2.Forma);
            Console.WriteLine(k2.Material);
            Console.WriteLine(k2.Label);

            k2.Label = 'W';

            Console.WriteLine(k2);
            Console.WriteLine(k2.Forma);
            Console.WriteLine(k2.Material);
            Console.WriteLine(k2.Label);



        }

    }


    class Knopka
    {
        public string Forma;

        public char Label;

        public string Material;

        private string Brand;

        public Knopka(string forma, char label, string material)
        {
            this.Forma = forma;
            Label = label;
            Material = material;
        }

        public Knopka()
        {

        }

        // ...
    }
}
