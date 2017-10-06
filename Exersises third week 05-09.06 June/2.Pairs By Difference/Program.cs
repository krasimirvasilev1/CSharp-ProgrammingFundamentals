using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Pairs_By_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int differenceByPairs = int.Parse(Console.ReadLine());

            int length = numbers.Length;
            int counter = 0;
            for (int i = 0; i <= length-1; i++)
            {
                for (int j = 0; j <= length-1; j++)
                {
                    if (numbers[i] - numbers[j] == Math.Abs(differenceByPairs))
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
