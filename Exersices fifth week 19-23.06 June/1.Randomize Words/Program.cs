using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ').ToArray();
            Random randomGenerator = new Random();



            for (int i = 0; i < text.Length; i++)
            {
               int random = randomGenerator.Next(0, text.Length);
                string word = text[random];
                text[random] = text[i];
                text[i] = word;
            }
            foreach (var item in text)
            {
                Console.WriteLine(item);
            }
        }
    }
}
