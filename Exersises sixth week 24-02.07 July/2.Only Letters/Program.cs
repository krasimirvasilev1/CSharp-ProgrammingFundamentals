using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.Only_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var pattern = "([0-9]+)";
            var patternOfLetter = "(?<=[0 - 9] +)[a - z]";

            MatchCollection Regextext = Regex.Matches(text, patternOfLetter);
            MatchCollection RegextextDigits = Regex.Matches(text , pattern);

                foreach (Match item1 in Regextext)
                {
                Console.WriteLine(item1.Value);
                }
        }
    }
}
