using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Distance_Between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point()
            {
                xy1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList()
            };

            Point point2 = new Point()
            {
                xy2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList()
            };
            double result = CalcDistance(point1, point2);
            Console.WriteLine($"{result:F3}");
        }

        public static double CalcDistance(Point point1,  Point point2)
        {
            var distanceOneSide = Math.Abs(point1.xy1[0] - point2.xy2[0]);
            var distanceOtherSide = Math.Abs(point1.xy1[1] - point2.xy2[1]);

            double totalDistance = Math.Sqrt(Math.Pow(distanceOneSide, 2) + Math.Pow(distanceOtherSide, 2));

            return totalDistance;
        }

    }
}




