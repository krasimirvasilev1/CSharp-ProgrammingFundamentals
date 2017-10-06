using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _2.Match_Full_Name___Lab___RegEx
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string regex = @"\b([A-Z][a-z]+) ([A-Z][a-z]+)\b";
            string names = Console.ReadLine();

            MatchCollection matchedNames = Regex.Matches(names, regex);

            foreach (Match item in matchedNames)
            {
                Console.Write(item.Value+ " ");
            }
            Console.WriteLine();
        }
    }
}
