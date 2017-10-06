using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            var startLetter = char.Parse(Console.ReadLine());
            
            var endLetter = char.Parse(Console.ReadLine());
            
            var forbiddenLetter = char.Parse(Console.ReadLine());
            
            //String combinations = " ";
            for (char a = startLetter; a <= endLetter; a++)
            {
                for (char b = startLetter; b <= endLetter; b++)
                {
                    for (char c = startLetter; c <= endLetter; c++)
                    {
                        if (a != forbiddenLetter && b != forbiddenLetter && c != forbiddenLetter)
                        {
                            Console.Write($"{a}{b}{c} ");
                        }
                    }
                }
            }
        }
    }
}
