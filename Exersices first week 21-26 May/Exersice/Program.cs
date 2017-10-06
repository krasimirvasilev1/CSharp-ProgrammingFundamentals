using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int startnum = int.Parse(Console.ReadLine());
          
          
            while (startnum <= 10)
            {
                try {
                    if (startnum >= 1 && startnum <= 10)
                    {
                        Console.WriteLine($"{n} X {startnum} = {n * startnum}");
                        startnum++;
                    }
                }
                catch 
                {
                 
                        Console.WriteLine($"{n} X {startnum} = {n * startnum}");
                }
            }
        }
    }
}
