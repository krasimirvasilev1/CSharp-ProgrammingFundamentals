using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Array_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var length = numbers.Length;
            var sum = 0;
            var minimumValue = int.MaxValue;
            var maximumValue = int.MinValue;

            for (int i = 0; i <= length - 1; i++)
            {
                sum += numbers[i];

                if (numbers[i] < minimumValue)
                {
                    minimumValue = numbers[i];
                }

                if (numbers[i] > maximumValue)
                {
                    maximumValue = numbers[i];
                }
            }

            var average = (double)sum / length;
            Console.WriteLine($"Min = {minimumValue}");
            Console.WriteLine($"Max = {maximumValue}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");

        }
    }
}
