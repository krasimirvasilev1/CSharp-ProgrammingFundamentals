using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Calculate_Triangle_Area
{
    class Program
    {
        public static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double areaTriangle = TriangleArea(width,height);
            Console.WriteLine(areaTriangle);
        }
        public static double TriangleArea (double width , double height)
        {
            return (width * height) / 2;
        }
    }
}
