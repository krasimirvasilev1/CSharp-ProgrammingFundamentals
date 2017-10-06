using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Intersection_of_Circles
{
    //class Circle
    //{
    //    public List<int> center { get; set; }
    //    public int radius { get; set; }

    //}
    //class Point
    //{
    //    public int X { get; set; }
    //    public int Y { get; set; }
    //}


    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[]
            {
                1,2,3,4,5,6,7,8,9,10
            };

            var newarray = array.Reverse().ToArray();
            array = newarray;
            Console.WriteLine(string.Join(" ",array));
        //    List<int> firstCircleProperties = Console.ReadLine().Split().Select(int.Parse).ToList();
        //    List<int> secondCircleProperties = Console.ReadLine().Split().Select(int.Parse).ToList();

        //    Circle firstCircle = new Circle
        //    {

        //        center = new List<int>()
        //        {
        //            firstCircleProperties[0],
        //            firstCircleProperties[1]
        //        },
        //        radius = firstCircleProperties[2]
        //    };

        //    Circle secondCircle = new Circle
        //    {
        //        center = new List<int>()
        //        {
        //            secondCircleProperties[0],
        //            secondCircleProperties[1]
        //        },
        //        radius = secondCircleProperties[2]
        //    };

        //    Point firstCircleXAndY = new Point
        //    {
        //        X = firstCircle.center[0],
        //        Y = firstCircle.center[1]
        //    };

        //    Point secondCircleXAndY = new Point
        //    {
        //        X = secondCircle.center[0],
        //        Y = secondCircle.center[1]
        //    };
        //    var horizontalDistance = firstCircleXAndY.X - secondCircleXAndY.X;
        //    var verticalDistance = firstCircleXAndY.Y = secondCircleXAndY.Y;
        //    var absoluteDistance = Math.Sqrt(Math.Pow(horizontalDistance, 2) + Math.Pow(verticalDistance, 2));


        //    bool IsItInside = Intersect(absoluteDistance, firstCircle.radius, secondCircle.radius);
        //    if (IsItInside)
        //    {
        //        Console.WriteLine("Yes");
        //    }
        //    else
        //    {
        //        Console.WriteLine("No");
        //    }
            
        //}
        //public static bool Intersect (double absoluteDistance , int radiusFirstCircle ,int radiusSecondCircle)
        //{
        //    if (absoluteDistance <= radiusFirstCircle + radiusSecondCircle )
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        }

    }

    
}
