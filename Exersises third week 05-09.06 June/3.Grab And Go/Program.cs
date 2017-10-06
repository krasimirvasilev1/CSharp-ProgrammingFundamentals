using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Grab_And_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long givenNumber = long.Parse(Console.ReadLine());

            long sum = 0;
            long output = 0;

            bool match = false;
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if (arr[i] != givenNumber)
                {
                    sum += arr[i];
                }
                else if (arr[i] == givenNumber)
                {
                    match = true;
                    output = sum;
                    sum += arr[i];
                }
            }
            if (match)
            {
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
