using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            byte maxliters = 0;
            maxliters += byte.MaxValue;
            int currentcapacity = 0;
            for (int i = 1; i <= number; i++)
            {
                int additionalwater = int.Parse(Console.ReadLine());
                currentcapacity += additionalwater;
                if(currentcapacity > maxliters)
                {
                    Console.WriteLine("Insufficient capacity!");
                    currentcapacity -= additionalwater;
                }
            }
            Console.WriteLine($"{currentcapacity}");
        }
    }
}
