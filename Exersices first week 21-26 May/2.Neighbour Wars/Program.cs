using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int RoundHousekick = int.Parse(Console.ReadLine());
            int ThunderousFist = int.Parse(Console.ReadLine());
            int goshohealth = 100;
            int peshohealth = 100;
            int rounds = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (goshohealth <= 0)
                {
                    Console.WriteLine($"Pesho won in {rounds}th round.");
                    break;
                }
                else if(peshohealth <= 0)
                {
                    Console.WriteLine($"Gosho won in {rounds}th round.");
                    break;
                } 
                else if (i % 2 == 1)
                {
                    rounds++;
                    goshohealth -= RoundHousekick;
                    if (goshohealth > 0 && i % 3 == 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshohealth} health.");
                        goshohealth += 10;
                        peshohealth += 10;
                    }
                    else if (goshohealth > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshohealth} health.");
                    }
                    else if (goshohealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {rounds}th round.");
                        break;
                    }
                }
                else if (i % 2 == 0)
                {
                    rounds++;
                    peshohealth -= ThunderousFist;
                    if (peshohealth > 0 && i % 3 == 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshohealth} health.");
                        goshohealth += 10;
                        peshohealth += 10;
                    }
                    else if (peshohealth > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshohealth} health.");
                    }
                    else if (goshohealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {rounds}th round.");
                        break;
                    }
                }
            }
        }
    }
}

