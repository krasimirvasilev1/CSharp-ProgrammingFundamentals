using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Make_a_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string sentence = "";
            for (int i = 0; i < num; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                sentence += letter;
            }
            Console.Write("The word is: {0}", sentence);

        }
    }
}
