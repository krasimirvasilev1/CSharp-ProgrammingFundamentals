using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Most_Friquent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] text = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int length = text.Length;

            var maxCombinations = 0;
            var theBiggestElement = 0;

            var currentClosestToZeroArray = 0;


            for (int i = ushort.MinValue; i <= ushort.MaxValue; i++)
            {
                var combinations = 0;
                var closestToTheZeroArray = length - 1;
                for (int j = 0; j <= length-1; j++)
                {
                    var element = i;

                    if (i == text[j])
                    {
                        combinations++;
                    }
                    if (combinations > maxCombinations)
                    {
                        maxCombinations = combinations;
                        theBiggestElement = element;
                        currentClosestToZeroArray = j;
                    }
                    else if (combinations == maxCombinations && currentClosestToZeroArray < closestToTheZeroArray)
                    {
                        maxCombinations = combinations;
                        theBiggestElement = element;
                    }
                    closestToTheZeroArray--;
                }
            }
            Console.WriteLine(theBiggestElement);
        }
    }
}
