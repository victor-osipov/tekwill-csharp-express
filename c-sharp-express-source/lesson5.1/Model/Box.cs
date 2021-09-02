using System;
namespace lesson5._1.Model
{
    public interface IBox
    {
        string Color { get; set; }

        string GetColor();
    }

    class RedBox : IBox
    {
        public string Color { get; set; }

        public int Length { get; set; }
        public int Height { get; set; }

        public string GetColor()
        {
            return "red";
        }
    }

    class GreenBox : IBox
    {
        public string Color { get; set; }

        public string GetColor()
        {
            var x = 100;
            // ...
            return "green";
        }

        void PutInBox(string text)
        {
            // ...
        }
    }
}
