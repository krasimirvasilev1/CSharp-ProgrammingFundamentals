using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n  = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int stopnumber = int.Parse(Console.ReadLine());
            int sum = 0;
            int combinations = 0;
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    combinations++;
                    sum += 3 * (i * j);
                    if (sum >= stopnumber)
                    {
                        Console.WriteLine($"{combinations} combinations");
                        Console.WriteLine($"Sum: {sum} >= {stopnumber}");
                        break;
                    }

                }
                if (sum >= stopnumber)
                {
                    break;
                }
            }
                if (stopnumber > sum)
                {
                    Console.WriteLine($"{combinations} combinations");
                    Console.WriteLine($"Sum: {sum}");
                }

        }
    }
}
