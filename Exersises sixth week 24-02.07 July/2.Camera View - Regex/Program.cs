using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.Camera_View___Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"\b(\|<)[^<|\s]*\b");

            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var skipNumber = numbers[0];
            var takeNumber = numbers[1];
            var text = Console.ReadLine();

            MatchCollection matches = regex.Matches(text);

            List<string> stringsBeforeTheOperations = new List<string>();

            var newFlatChain = string.Empty;
            var toarray = from Match match in matches select match.Value;
            newFlatChain = string.Join("", toarray);

            stringsBeforeTheOperations = newFlatChain.Split(new char [] {'<','|'} , StringSplitOptions.RemoveEmptyEntries).ToList();
            var stringsAfterTheOperations = new List<string>();

            var count = stringsBeforeTheOperations.Count;
            for (int i = 0; i < stringsBeforeTheOperations.Count; i++)
            {
                var readyStrings = new string(stringsBeforeTheOperations[i].Skip(skipNumber).Take(takeNumber).ToArray());

                if (readyStrings.Length > 0)
                {
                    stringsAfterTheOperations.Add(readyStrings.ToString());
                }
            }

            Console.WriteLine(string.Join(", ",stringsAfterTheOperations));
    }
    }
}
