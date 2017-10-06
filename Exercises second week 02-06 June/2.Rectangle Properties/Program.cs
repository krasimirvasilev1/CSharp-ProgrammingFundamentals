using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double perimeterRectangle = width * 2 + height * 2;
            double areaRectangle = width * height;
            double diagonalRectangle = Math.Sqrt(Math.Pow(width,2) + Math.Pow(height,2));
            Console.WriteLine(perimeterRectangle);
            Console.WriteLine(areaRectangle);
            Console.WriteLine(diagonalRectangle);
        }
    }
}
