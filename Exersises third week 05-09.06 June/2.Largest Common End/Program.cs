using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstString = Console.ReadLine().Split(' ').ToArray();
            string[] secondString = Console.ReadLine().Split(' ').ToArray();

            int firstLength = firstString.Length;
            int secondLength = secondString.Length;

            int minLength = Math.Min(firstLength, secondLength);
            int maxLength = Math.Max(firstLength, secondLength);

            int counter = 0;
            int maximumMatches = int.MinValue;
            for (int i = 0; i < minLength; i++)
            {
                if (firstString[i] != secondString[i])
                {
                    counter = 0;
                }
                else
                {
                    counter++;
                    if (counter > maximumMatches)
                    {
                        maximumMatches = counter;
                    }
                }
            }
            Console.WriteLine(maximumMatches);
        }
    }
}
