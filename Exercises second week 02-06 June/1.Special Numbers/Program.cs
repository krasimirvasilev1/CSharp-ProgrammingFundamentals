using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine()); 
            for (int i = 1; i <= num; i++)
            {
                int sum = 0;
                sum += i % 10;
                sum += i / 10;
                bool match = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {match}");
            }
          
        }
    }
}
