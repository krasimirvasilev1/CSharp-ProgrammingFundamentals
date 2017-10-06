using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int theBiggestNum = int.MinValue;
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            theBiggestNum = BiggestNumFromTwo(num1 , num2);
            if (num3>theBiggestNum)
            {
                theBiggestNum = num3;
                Console.WriteLine(theBiggestNum);
            }
            else
            {
                Console.WriteLine(theBiggestNum);
            }
        }
        public static int BiggestNumFromTwo (int num1 , int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
    }
}
