using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int maxCombination = 0;
            var counter = 1;
            int longestElement = 0;

            List<int> maxSequence = new List<int>();
            
            for (int i = 0; i < numbers.Count-1; i++)
            {
                var element = numbers[i];
                if (numbers[i] == numbers[i+1])
                {
                    counter++;
                    if (counter>maxCombination)
                    {
                        maxCombination = counter;
                        longestElement = element;
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            for (int i = 0; i < maxCombination; i++)
            {
                maxSequence.Add(longestElement);
            }

            Console.WriteLine(string.Join(" ",maxSequence));
            
        }
    }
}
