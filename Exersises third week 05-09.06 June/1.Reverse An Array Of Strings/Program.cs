using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Reverse_An_Array_Of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] symbols = Console.ReadLine().Split(' ').ToArray();
            int symbolsLenght = symbols.Length;
            string[] reversedSymbols = new string[symbolsLenght];

            for (int i = 0; i < symbolsLenght / 2; i++)
            {
                SwapElements(symbols, i, symbolsLenght - 1 - i);
            }
            Console.WriteLine(string.Join(" ", symbols));

        }

        public static void SwapElements(string[] symbols, int i, int j)
        {
            var element = symbols[i];
            symbols[i] = symbols[j];
            symbols[j] = element;

        }
    }
}
