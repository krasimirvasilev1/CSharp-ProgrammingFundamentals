using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2_Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] symbols = Console.ReadLine().Split(' ').ToArray();
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                var commands = input.Split(' ').ToArray();

                if (commands[0] == "reverse")
                {
                    int startNumber = int.Parse(commands[2]);
                    int countNumber = int.Parse(commands[4]);
                    List<string> sortedChars = new List<string>();
                    int constantStartNumber = startNumber;
                    if ((startNumber >= 0 && startNumber < symbols.Length) && (countNumber >= 0 && countNumber < symbols.Length))
                    {
                        for (int i = startNumber; i < startNumber + countNumber; i++)
                        {
                            sortedChars.Add(symbols[i]);
                        }
                        sortedChars.Reverse();
                        for (int i = 0; i < sortedChars.Count; i++)
                        {
                            symbols[startNumber] = sortedChars[i];
                            startNumber++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else if (commands[0] == "sort")
                {
                    var startNumber = int.Parse(commands[2]);
                    var countNumber = int.Parse(commands[4]);
                    List<string> sortedNumbers = new List<string>();
                    if ((startNumber >= 0 && startNumber < symbols.Length) && (countNumber >= 0 && countNumber < symbols.Length) && (countNumber + startNumber >= 0 && countNumber + startNumber < symbols.Length))
                    {
                        for (int i = startNumber; i < startNumber + countNumber; i++)
                        {
                            sortedNumbers.Add(symbols[i].ToString());
                        }
                        sortedNumbers.Sort();
                        for (int i = 0; i < sortedNumbers.Count; i++)
                        {
                            symbols[startNumber] = sortedNumbers[i];
                            startNumber++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else if (commands[0] == "rollRight")
                {
                    int countMoving = int.Parse(commands[1]);  
                    for (int i = 1; i <= countMoving; i++)
                    {
                        var lastIndex = symbols[symbols.Length - 1];

                        for (int j = symbols.Length-1; j > 0; j--)
                        {
                            symbols[j] = symbols[j - 1];

                        }
                        symbols[0] = lastIndex;
                        
                    }
                }
                else if (commands[0] == "rollLeft")
                {
                    int countMoving = int.Parse(commands[1]);
                    for (int i = 1; i <= countMoving; i++)
                    {
                        var firstIndex = symbols[0];

                        for (int j = 0; j < symbols.Length-1; j++)
                        {
                            symbols[j] = symbols[j + 1];

                        }
                        symbols[symbols.Length-1] = firstIndex;
                    }
                }
                
            }
            Console.Write("[");
            Console.Write(string.Join(", ",symbols));
            Console.Write("]");
        }
    }
    }

