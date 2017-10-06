using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            String numberEvenOrOdd = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            String sentence = "";
            for (int i = 1; i <= number; i++)
            {
                String words = Console.ReadLine();
                if (numberEvenOrOdd == "even" && i % 2 == 0)
                {
                    sentence += words;
                    sentence += symbol;
                }
                else if (numberEvenOrOdd == "odd" && i % 2 == 1)
                {
                    sentence += words;
                    sentence += symbol;
                }
            }
            Console.WriteLine($"{sentence.Remove(sentence.Length-1)} ");

            }
        }
    }
