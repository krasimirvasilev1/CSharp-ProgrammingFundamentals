using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _2.Sum_Big_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger numberOne = BigInteger.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            BigInteger sum = numberOne * numberTwo;

            Console.WriteLine(sum);
        }
    }
}
