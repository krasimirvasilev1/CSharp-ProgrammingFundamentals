using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] text = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var counter = 1;
            var longestCount = 0;
            var element = 0;
            var longestElement = 0;
            var length = text.Length;

            for (int i = length-1; i >= 1 ; i--)
            {
                element = text[i];
                if (text[i] == text [i-1]|| text[i])
                {
                    counter++;
                    if (counter >= longestCount)
                    {
                        longestCount = counter;
                        longestElement = element;
                    }
                }
                else if (text[i] == text[i-1])
                {
                    counter = 1;
                }
            }
            Console.WriteLine(longestElement);

        }
    }
}
