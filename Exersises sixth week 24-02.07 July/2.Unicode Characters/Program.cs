using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _2.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split().ToArray();
            var firstString = text[0].ToArray();
            var secondString = text[1].ToArray();

            var MinLength = Math.Min(firstString.Length, secondString.Length);
            int sum = 0;

            for (int i = 0; i < MinLength; i++)
            {
                var charAtFirstString = (int)firstString[i];
                var charAtSecondString = (int)secondString[i];
                sum += charAtFirstString * charAtSecondString;
            }

            if (firstString.Length > secondString.Length)
            {

                for (int i = MinLength; i < firstString.Length; i++)
                {
                    var charAtFirstString = (int)firstString[i];
                    sum += charAtFirstString;
                }
            }
            else if (firstString.Length < secondString.Length)
            {
                for (int i = MinLength; i < secondString.Length; i++)
                {
                    var charAtSecondString = (int)secondString[i];
                    sum += charAtSecondString;
                }
            }
            Console.WriteLine(sum);
        }
    }
}