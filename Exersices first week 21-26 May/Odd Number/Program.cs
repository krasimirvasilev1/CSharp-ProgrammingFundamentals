using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i--)
            {
                int a = int.Parse(Console.ReadLine());
                a = Math.Abs(a);
                if (a % 2 == 1)
                {
                    Console.WriteLine($"The number is: {a}");
                    break;
                }
                else
                {

                }
                {
                    Console.WriteLine("Please write an odd number.");
                }

            }
        }
    }
}
