using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.Email_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string,List<string>>();
            var pattern = @"\b([a-zA-Z]{5,})(@)([a-z]{3,})(\.)(com|bg|org)\b";

            int numberOfEmails = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberOfEmails; i++)
            {
                var input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    var newInput = input.Split('@').ToList();
                    if (dictionary.ContainsKey(newInput[1]))
                    {
                        dictionary[newInput[1]].Add(newInput[0]);
                    }
                    else
                    {
                        dictionary[newInput[1]] = new List<string>();
                        dictionary[newInput[1]].Add(newInput[0]);
                    }
                    
                }
            }

            foreach (var itemKey in dictionary.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{itemKey.Key}:");
                foreach (var itemValue in itemKey.Value)
                {
                    Console.WriteLine($"### {itemValue}");
                }
            }
        }
    }
}
