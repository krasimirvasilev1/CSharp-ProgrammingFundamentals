using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Byte_Flip
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().Where(x => x.Length == 2).ToList();

            List<string> allSymbols = new List<string>();

            
            for (int i = 0; i < numbers.Count; i++)
            {
                char [] reversedSymbolsChar = numbers[i].Reverse().ToArray();
                string reversedSymbolsString = new string (reversedSymbolsChar);
                allSymbols.Add(reversedSymbolsString);
                
            }

            allSymbols.Reverse();
            List<int> transformedNumbersInDecimal = new List<int> ();
            for (int i = 0; i < allSymbols.Count; i++)

            {
                int decimalNumber = Convert.ToInt32(allSymbols[i], 16);
                transformedNumbersInDecimal.Add(decimalNumber);
            }

            foreach (var item in transformedNumbersInDecimal)
            {
                char ascii = (char)item;
                Console.Write(ascii);
            }
            Console.WriteLine();
        }
    }
}
