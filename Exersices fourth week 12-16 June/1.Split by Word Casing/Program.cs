using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine()
                .Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\\', '/', '[', ']' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixCase = new List<string>();

            //for (int i = 0; i < text.Count; i++)
            //{
            //    if (text[i] == " " || text[i] == "  ")
            //    {
            //        text.Remove(text[i]);
            //    }
            //}
            for (int i = 0; i < text.Count; i++)
            {
                var counterLower = 0;
                var counterUpper = 0;
                var counterMix = 0;

                char[] word = text[i].ToArray();
                for (int j = 0; j < word.Length; j++)
                {

                    if (word[j] >= 'a' && word[j] <= 'z')
                    {
                        counterLower++;
                    }
                    else if (word[j] >= 'A' && word[j] <= 'Z')
                    {
                        counterUpper++;
                    }
                    else
                    {
                        counterMix++;
                    }
                }
                if ((counterLower > 0 && counterUpper > 0) || counterMix > 0)
                {
                    mixCase.Add(text[i]);
                }
                else if (counterLower > 0)
                {
                    lowerCase.Add(text[i]);
                }
                else if (counterUpper > 0)
                {
                    upperCase.Add(text[i]);
                }

            }
            Console.WriteLine("Lower-case: {0}", String.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", String.Join(", ", mixCase));
            Console.WriteLine("Upper-case: {0}", String.Join(", ", upperCase));
            

        }
    }
}

