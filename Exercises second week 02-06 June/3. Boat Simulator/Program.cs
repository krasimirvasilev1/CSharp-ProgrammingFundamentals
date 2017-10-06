using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char charFirstBoat = char.Parse(Console.ReadLine());
            char charSecondBoat = char.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            int scoreFirstBoat = 0;
            int scoreSecondBoat = 0;
            int winner = int.MinValue;
            for (int i = 1; i <= number; i++)
            {
                String sentence = Console.ReadLine();
                if (sentence == "UPGRADE")
                {
                    charFirstBoat += (char)3;
                    charSecondBoat += (char)3;
                }
                else if (i % 2 == 1)
                {
                    scoreFirstBoat += sentence.Length;
                }
                else if (i % 2 == 0)
                {
                    scoreSecondBoat += sentence.Length;
                }
                if (scoreFirstBoat >= 50)
                {
                    Console.WriteLine(charFirstBoat);
                    break;
                }
                else if (scoreSecondBoat >= 50)
                {
                    Console.WriteLine(charSecondBoat);
                    break;
                }
            }
            if (scoreFirstBoat > scoreSecondBoat && scoreFirstBoat < 50)
            {
                Console.WriteLine(charFirstBoat);
            }
            else if (scoreSecondBoat > scoreFirstBoat && scoreSecondBoat < 50)
            {
                Console.WriteLine(charSecondBoat);
            }

                    }
                }
            }