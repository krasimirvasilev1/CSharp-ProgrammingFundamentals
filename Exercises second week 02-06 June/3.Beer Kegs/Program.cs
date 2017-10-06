using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double maximumValue = double.MinValue;
            String nameOfBiggerKeg = "";
            for (int i = 1; i <= num ; i++)
            {
                
                var name = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double sum = Math.PI * Math.Pow(radius,2) * height;
                if (sum > maximumValue)
                {
                    nameOfBiggerKeg = "";
                    maximumValue = sum;
                    nameOfBiggerKeg += name;
                }
            }
            Console.WriteLine("{0}",nameOfBiggerKeg);    
        }
    }
}
