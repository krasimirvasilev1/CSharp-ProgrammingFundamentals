using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Odd_Numbers
{
    class Program
    {

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;

            /*      for (int i = 1; i < n*2; i+=2)
                  {
                      Console.WriteLine(i);
                      sum += i;
                  } */
            Console.WriteLine("Sum: {0},{1}", sum, n);
            Console.WriteLine(n.ToString("D8"));
        }
    }
}
