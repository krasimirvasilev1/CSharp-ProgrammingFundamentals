using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstString = Console.ReadLine().Split(' ').ToArray();
            string[] secondString = Console.ReadLine().Split(' ').ToArray();

            int lengthFirst = firstString.Length;
            int lengthSecond = firstString.Length;

            int minimumLength = Math.Min(lengthFirst, lengthSecond);

            for (int i = 0; i <= minimumLength-1; i++)
            {
                char charFirstString = char.Parse(firstString[i]);
                char charSecondString = char.Parse(secondString[i]);
                if (charFirstString != charSecondString)
                {
                    int intFirstString = (int)charFirstString;
                    int intSecondString = (int)charSecondString;

                    if (intFirstString > intSecondString)
                    {
                        Console.WriteLine(string.Join("",secondString));
                        Console.WriteLine(string.Join("", firstString));
                        break;
                    }

                    else if (intFirstString < intSecondString)
                    {
                        Console.WriteLine(string.Join("", firstString));
                        Console.WriteLine(string.Join("", secondString));
                        break;
                    }
                }
                if (firstString.Length != secondString.Length)
                {
                    if (firstString.Length > secondString.Length)
                    {
                        Console.WriteLine(string.Join("", secondString));
                        Console.WriteLine(string.Join("", firstString));
                    }
                    else
                    {
                        Console.WriteLine(string.Join("", firstString));
                        Console.WriteLine(string.Join("", secondString));
                    }
                }
                
            }
        }
    }
}
