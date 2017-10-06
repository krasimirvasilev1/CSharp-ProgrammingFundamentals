using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var regexBojomon = new Regex(@"([a-zA-Z]+\-[a-zA-Z]+)");
            var regexDidimon = new Regex(@"([^a-zA-Z-]+)");
            var newText = text;
            while (true)
            { 
                Match matchDidimon = regexDidimon.Match(text);
                if (!matchDidimon.Success)
                {
                    break;
                }
                if (matchDidimon.Success)
                {
                    var firstOccurance = matchDidimon.Groups[1].Value;
                    var indexOfOccurance = text.IndexOf(firstOccurance);
                    
                    text = text.Substring(indexOfOccurance + firstOccurance.Length,text.Length - indexOfOccurance - firstOccurance.Length);
                    
                    Console.WriteLine(firstOccurance);
                }

                Match matchBojomon = regexBojomon.Match(text);
                if (!matchBojomon.Success)
                {
                    break;
                }
                else
                {
                    var firstOccurance = matchBojomon.Groups[1].Value;
                    var indexOfOccurance = text.IndexOf(firstOccurance);
                    text = text.Substring(indexOfOccurance + firstOccurance.Length , text.Length - indexOfOccurance - firstOccurance.Length);
                    Console.WriteLine(firstOccurance);

                }
            }
        }
    }
}
