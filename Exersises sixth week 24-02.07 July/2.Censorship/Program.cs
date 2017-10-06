using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var sentence = Console.ReadLine();
            var newSentence = sentence.Replace(word, new string('*', word.Length));

            Console.WriteLine(newSentence);
        }
    }
}
