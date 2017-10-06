using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Fibonaci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
          
            long n = long .Parse(Console.ReadLine());
            long firstNum = 0;
            long secondNum = 1;
            long thirdNum = 1;
            for (int i = 0; i < n; i++)
            {
                thirdNum = secondNum;
                secondNum = firstNum + secondNum;
                firstNum = thirdNum;
            }

            Console.WriteLine(secondNum);


        }

    }
}
