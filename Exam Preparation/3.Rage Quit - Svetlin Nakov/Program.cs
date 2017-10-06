using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3.Rage_Quit___Svetlin_Nakov
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToUpper();
            var matches = Regex.Matches(input, (@"(\D+)(\d+)"));

            var newString = new StringBuilder();
            StringBuilder result = new StringBuilder();
            foreach (Match item in matches)
            {
                for (int i = 1; i <= int.Parse(item.Groups[2].Value); i++)
                {
                    result.Append(item.Groups[1].Value);
                }
            }

            Console.WriteLine("Unique symbols used: {0}",result.ToString().Distinct().Count());
            Console.WriteLine(result);
        }
    }
}
