using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numForOperations = Console.ReadLine().Split().Select(int.Parse).ToList();
            var skipNum = numForOperations[0];
            var takeNum = numForOperations[1];

            var input = Console.ReadLine();

            List<int> indexes = new List<int>();
            var numberOfMatches = 0;

            List<string> matchedWords = new List<string>();
            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i] == '|' && input[i+1] == '<')
                {
                    indexes.Add(i + 1);
                    numberOfMatches++;
                }
            }

            for (int i = 0; i < indexes.Count; i++)
            {
                var wordToAdd = input.Skip(indexes[i] + skipNum).Take(takeNum).ToString();

                matchedWords.Add(wordToAdd);
            }
        }
    }
}
