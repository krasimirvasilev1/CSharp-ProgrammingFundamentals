using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] text = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var counter = 0;
            var longestCount = 0;
            var element = 0;
            var longestElement = 0;
            var length = text.Length; 

            for (int i = length - 1; i >= 1; i--)
            {
                element = text[i];
                if (text[i] - text[i - 1] == 1)
                {
                    counter++;

                    if (counter >= longestCount)
                    {
                        longestElement = element;
                        longestCount = counter;
                    }
                }
                else if (text[i] - text[i - 1] != 1)
                {
                    counter = 0;
                }
            }
            int[] longestArray = new int[longestCount+1];
            longestElement--;
            longestCount++;
            for (int i = 0; i <= longestCount - 1; i++)
            {
                longestArray[i] = longestElement;
                longestElement++;
            }
            Console.Write(string.Join(" ", longestArray));
        }
    }
}
    
