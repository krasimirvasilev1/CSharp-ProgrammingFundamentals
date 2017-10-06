using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3._3_Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            var regexForCharsAndDigits = new Regex(("[^0-9]+[0-9]+"));
            var regexForChars = new Regex("([^0-9]+)");
            var regexForDigits = new Regex("[0-9]+");
            var regexRemoveAllDigits = new Regex("[^0-9]");

            var text = Console.ReadLine();

            List<string> allChars = new List<string>();
            List<int> allDigits = new List<int>();

            MatchCollection charsAndDigits = regexForCharsAndDigits.Matches(text);

            var finalResult = "";
            foreach (Match item in charsAndDigits)
            {
                var result = item.Groups[0].Value;

                MatchCollection chars = regexForChars.Matches(result);
                MatchCollection digits = regexForDigits.Matches(result);

                foreach (Match itemChars in chars)
                {
                    var resultchars = itemChars.Groups[0].Value;
                    allChars.Add(resultchars.ToUpper());
                }
                foreach (Match itemDigits in digits)
                {
                    var resultdigits = int.Parse(itemDigits.Groups[0].Value);
                    allDigits.Add(resultdigits);
                }
            }
            string distincedSentence = string.Empty;
            MatchCollection removeDigits = regexRemoveAllDigits.Matches(text);
            foreach (Match item in removeDigits)
            {
                distincedSentence += item.Groups[0].Value;
            }
            
            List <char> distincedList = distincedSentence.ToUpper().Distinct().ToList();
            for (int i = 0; i < allChars.Count; i++)
            {
                for (int j = 1; j <= allDigits[i]; j++)
                {
                    finalResult += allChars[i].ToUpper();
                }
            }
            
            Console.WriteLine($"Unique symbols used: {distincedList.Count}");
            Console.WriteLine(finalResult);
        }

    }
}