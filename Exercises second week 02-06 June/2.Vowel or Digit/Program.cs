using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char word = char.Parse(Console.ReadLine());
            if(word == 'a' || word == 'e' || word == 'o' || word == 'i' || word =='u' || word == 'y')
            {
                Console.WriteLine("vowel");
            }
            else if (char.IsNumber(word))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
