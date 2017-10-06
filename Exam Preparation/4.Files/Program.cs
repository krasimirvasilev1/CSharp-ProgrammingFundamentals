using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfFiles = int.Parse(Console.ReadLine());
            var regex = @"([^\\]+)\\?(.*)?\\(.*)\.(.*);(\d+)";
            List<string> allFiles = new List<string>();

            Dictionary<string, string> searchedFiles = new Dictionary<string, string>();
            for (int i = 1; i <= numberOfFiles; i++)
            {
                var file = Console.ReadLine();
                allFiles.Add(file);
            }

            var searchEngine = Console.ReadLine().Split().ToArray();
            var extension = searchEngine[0];
            var root = searchEngine[2];

            foreach (var item in allFiles)
            {
                var matches = Regex.Matches(item, regex);

                foreach (Match element in matches)
                {
                    if (element.Groups[4].Value == extension && element.Groups[1].Value == root)
                    {
                        var keyString = element.Groups[3].Value + "." + element.Groups[4].Value;
                        searchedFiles[keyString] = element.Groups[5].Value;
                    }
                }
            }
            if (searchedFiles.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var item in searchedFiles.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
                {
                    Console.WriteLine($"{item.Key} - {item.Value} KB");
                }

            }
        }
    }
}
