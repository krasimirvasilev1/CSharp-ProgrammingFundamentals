using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Index_Of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alphabet = new string[26];
            alphabet[0] = "a";
            alphabet[1] = "b";
            alphabet[2] = "c";
            alphabet[3] = "d";
            alphabet[4] = "e";
            alphabet[5] = "f";
            alphabet[6] = "g";
            alphabet[7] = "h";
            alphabet[8] = "i";
            alphabet[9] = "j";
            alphabet[10] = "k";
            alphabet[11] = "l";
            alphabet[12] = "m";
            alphabet[13] = "n";
            alphabet[14] = "o";
            alphabet[15] = "p";
            alphabet[16] = "q";
            alphabet[17] = "r";
            alphabet[18] = "s";
            alphabet[19] = "t";
            alphabet[20] = "u";
            alphabet[21] = "v";
            alphabet[22] = "w";
            alphabet[23] = "x";
            alphabet[24] = "y";
            alphabet[25] = "z";
            string randomText = Console.ReadLine();
            char[] text = randomText.ToCharArray();
      
            int length = text.Length;
            for (int i = 0; i <= length-1; i++)
            {
                for (int j = 0; j <= 25; j++)
                {
                    char letterFromAlphabet = char.Parse(alphabet[j]);
                    char letterFromText = text[i];

                    if (letterFromText == letterFromAlphabet)
                    {
                        Console.WriteLine($"{letterFromText} -> {j}");
                    }
                }
            }
        }
    }
}
