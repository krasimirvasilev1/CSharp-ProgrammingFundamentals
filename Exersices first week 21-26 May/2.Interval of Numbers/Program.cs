using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num1 = int.Parse(Console.ReadLine());
            int min = Math.Min(num,num1);
            int max = Math.Max(num,num1);
            for (int i = min; i <= max; i++)
            {
                Console.WriteLine(i);
            }
            {

            }
        }
    }
}
