using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.Extract_Sentences_By_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var regex =new Regex(string.Format (@"\b(([^.!?]*) ({0}) ([^.?!]*)([^.?!]))",word));
            string text = Console.ReadLine();
                

            MatchCollection results = regex.Matches(text);

            foreach (Match item in results)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
