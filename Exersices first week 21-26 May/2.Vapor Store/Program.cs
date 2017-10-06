using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            var ballance = double.Parse(Console.ReadLine());
            double startingmoney = 0;
            while (1 > 0)
            {
                String nameofgame = Console.ReadLine();
                if (nameofgame == "OutFall 4")
                {
                    if (ballance >= 39.99)
                    {
                        ballance -= 39.99;
                        startingmoney += 39.99;
                        Console.WriteLine($"Bought {nameofgame}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (nameofgame == "CS: OG")
                {
                    if (ballance >= 15.99)
                    {
                        ballance -= 15.99;
                        startingmoney += 15.99;
                        Console.WriteLine($"Bought {nameofgame}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (nameofgame == "Zplinter Zell")
                {
                    if (ballance >= 19.99)
                    {
                        ballance -= 19.99;
                        startingmoney += 19.99;
                        Console.WriteLine($"Bought {nameofgame}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (nameofgame == "Honored 2")
                {
                    if (ballance >= 59.99)
                    {
                        ballance -= 59.99;
                        startingmoney += 59.99;
                        Console.WriteLine($"Bought {nameofgame}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (nameofgame == "RoverWatch")
                {
                    if (ballance >= 29.99)
                    {
                        startingmoney += 29.99;
                        ballance -= 29.99;
                        Console.WriteLine($"Bought {nameofgame}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (nameofgame == "RoverWatch Origins Edition")
                {
                    if (ballance >= 39.99)
                    {
                        startingmoney += 39.99;
                        ballance -= 39.99;
                        Console.WriteLine($"Bought {nameofgame}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (nameofgame == "Game Time")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
            }
            if (ballance > 0)
            {
                Console.WriteLine($"Total spent: ${startingmoney:F2}. Remaining: ${ballance:F2}");
            }
            else
            {
                Console.WriteLine("Out of money!");
            }
            }   
        }
    }
