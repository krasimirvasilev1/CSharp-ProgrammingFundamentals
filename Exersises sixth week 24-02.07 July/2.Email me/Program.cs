using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Email_me
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split('@').ToList();

            var beforeTheSymbol = text[0].ToCharArray();
            var afterTheSymbol = text[1].ToCharArray();

            var valueOfCharactersAfterTheSymbol = 0;
            var valueOfCharactersBeforeTheSymbol = 0;
            for (int i = 0; i < beforeTheSymbol.Length; i++)
            {
                int charToInt = (int)beforeTheSymbol[i];
                valueOfCharactersBeforeTheSymbol += charToInt;
            }

            for (int i = 0; i < afterTheSymbol.Length; i++)
            {
                int charToInt = (int)afterTheSymbol[i];
                valueOfCharactersAfterTheSymbol += charToInt;
            }

            var substractedSum = valueOfCharactersAfterTheSymbol - valueOfCharactersBeforeTheSymbol;

            if (substractedSum <= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}
