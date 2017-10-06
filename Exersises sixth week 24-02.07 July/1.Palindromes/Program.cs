using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(new char[] { ' ', ',', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            List<string> palindromes = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                char [] wordInText= text[i].ToArray();
                List<char> reversedWordInText = new List<char>();
                reversedWordInText.AddRange(wordInText);
                reversedWordInText.Reverse();
                var numberOfMatches = 0;
                for (int j = 0; j < wordInText.Length; j++)
                {
                    
                    if (wordInText[j] == reversedWordInText[j])
                    {
                        numberOfMatches++;
                    }
                    if (numberOfMatches == wordInText.Length)
                    {
                        string thisIsPalindrome = new string(wordInText, 0, wordInText.Length);
                        palindromes.Add(thisIsPalindrome);
                    }
                }
            }
            palindromes = palindromes.Distinct().ToList();
            Console.WriteLine(string.Join(", ",palindromes.OrderBy(x => x)));
        }
    }
}
