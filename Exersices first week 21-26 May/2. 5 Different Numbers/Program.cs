using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            
            if (b - a < 5)
            {
                Console.WriteLine("No");
                return;
            }
            for (int c = a; c <= b; c++)
            {
                for (int d = a+1; d <= b; d++)
                {
                    for (int e = a+2; e <= b; e++)
                    {
                        for (int f = a+3; f <= b; f++)
                        {
                            for (int j = a+4; j <= b; j++)
                            {
                                if (a <= c && c < d && d < e && e < f && f < j && j <= b)
                                {
                                    Console.WriteLine($"{c} {d} {e} {f} {j}");
                                }
                            }

                        }
                    }
                }

            }
            

        }
    }
}
