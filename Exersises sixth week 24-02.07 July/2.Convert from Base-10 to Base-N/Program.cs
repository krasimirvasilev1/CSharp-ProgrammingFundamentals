using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _2.Convert_from_Base_10_to_Base_N
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var input = Console.ReadLine().Split().ToList();
            var baseNumber = BigInteger.Parse(input[0]);
            var generalNumber = input[1];

            
            var indexToMultiplyTheGenNumber = 0;
            BigInteger Base10Number = 0;
            for (int i = generalNumber.Length-1; i >= 0; i--)
            {
                var genNumberToInt = BigInteger.Parse(generalNumber[i].ToString());
                var resultAfterEveryOperation = genNumberToInt * BigInteger.Pow(baseNumber, indexToMultiplyTheGenNumber);
                indexToMultiplyTheGenNumber++;
                Base10Number += resultAfterEveryOperation;
                
            }
            Console.WriteLine(Base10Number);
            
        }
    }
}
