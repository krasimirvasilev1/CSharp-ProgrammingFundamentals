using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                var commands = line.Split().ToArray();
                var command = commands[0];

                if (command == "exchange")
                {
                    var index = int.Parse(commands[1]);
                    if (index < 0 || index > listOfNumbers.Count-1)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    for (int i = index+1; i < listOfNumbers.Count; i++)
                    {
                        listOfNumbers.Insert(0, listOfNumbers[listOfNumbers.Count - 1]);
                        listOfNumbers.RemoveAt(listOfNumbers.Count - 1);
                    }
                }
                else if (command == "max")
                {
                    var evenOrOdd = commands[1];
                    int maxValue = int.MinValue;
                    int indexOfMaxValue = 0;
                    var counter = 0;
                    if (evenOrOdd == "even")
                    {
                        for (int i = 0; i < listOfNumbers.Count; i++)
                        {
                            if (listOfNumbers[i] % 2 == 0)
                            {
                                if (listOfNumbers[i] >= maxValue)
                                {
                                    maxValue = listOfNumbers[i];
                                    counter++;
                                    indexOfMaxValue = i;
                                }
                            }
                        }
                    }
                    else if (evenOrOdd == "odd")
                    {
                        for (int i = 0; i < listOfNumbers.Count; i++)
                        {
                            if (listOfNumbers[i] % 2 == 1)
                            {
                                if (listOfNumbers[i] >= maxValue)
                                {
                                    maxValue = listOfNumbers[i];
                                    counter++;
                                    indexOfMaxValue = i;
                                }
                            }
                        }
                    }
                    if (counter == 0)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(indexOfMaxValue);

                    }
                    
                }
                else if (command == "min")
                {
                    var evenOrOdd = commands[1];
                    int minValue = int.MaxValue;
                    int indexOfMinValue = 0;
                    var counter = 0;
                    if (evenOrOdd == "even")
                    {
                        for (int i = 0; i < listOfNumbers.Count; i++)
                        {
                            if (listOfNumbers[i] % 2 == 0)
                            {
                                if (listOfNumbers[i] <= minValue)
                                {
                                    minValue = listOfNumbers[i];
                                    counter++;
                                    indexOfMinValue = i;
                                }
                            }
                        }
                    }
                    else if (evenOrOdd == "odd")
                    {
                        for (int i = 0; i < listOfNumbers.Count; i++)
                        {
                            if (listOfNumbers[i] % 2 == 1)
                            {
                                if (listOfNumbers[i] <= minValue)
                                {
                                    minValue = listOfNumbers[i];
                                    counter++;
                                    indexOfMinValue = i;
                                }
                            }
                        }
                    }
                    if (counter == 0)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(indexOfMinValue);

                    }
                }
                else if (command == "first")
                {
                    var index = int.Parse(commands[1]);
                    var evenOrOdd = commands[2];
                    var countOfEvenOrOdd = 0;
                    List<int> evenOrOddNumbers = new List<int>();

                    if (index < 0 || index > listOfNumbers.Count-1)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    if (evenOrOdd == "even")
                    {
                        for (int i = 0; i < listOfNumbers.Count; i++)
                        {
                            if (index == countOfEvenOrOdd)
                            {
                                break;
                            }
                            if (listOfNumbers[i] % 2 == 0)
                            {
                                countOfEvenOrOdd++;
                                evenOrOddNumbers.Add(listOfNumbers[i]);
                            }
                        }
                        if (countOfEvenOrOdd == 0)
                        {
                            Console.WriteLine("["+string.Join("",evenOrOddNumbers)+"]");
                        }
                        else
                        {
                            Console.WriteLine("["+ string.Join(", ",evenOrOddNumbers)+"]");
                        }
                    }
                    else if (evenOrOdd == "odd")
                    {
                        for (int i = 0; i < listOfNumbers.Count; i++)
                        {
                            if (index == countOfEvenOrOdd)
                            {
                                break;
                            }
                            if (listOfNumbers[i] % 2 == 1)
                            {
                                countOfEvenOrOdd++;
                                evenOrOddNumbers.Add(listOfNumbers[i]);
                            }
                        }
                        if (countOfEvenOrOdd == 0)
                        {
                            Console.WriteLine("[" + string.Join("", evenOrOddNumbers) + "]");
                        }
                        else
                        {
                            Console.WriteLine("["+string.Join(", ", evenOrOddNumbers)+"]");
                        }
                    }
                }
                else if (command == "last")
                {
                    var index = int.Parse(commands[1]);
                    var evenOrOdd = commands[2];
                    var countOfEvenOrOdd = 0;
                    List<int> evenOrOddNumbers = new List<int>();

                    if (index < 0 || index > listOfNumbers.Count)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    if (evenOrOdd == "even")
                    {
                        for (int i = listOfNumbers.Count-1; i >= 0; i--)
                        {
                            if (index == countOfEvenOrOdd)
                            {
                                break;
                            }
                            if (listOfNumbers[i] % 2 == 0)
                            {
                                countOfEvenOrOdd++;
                                evenOrOddNumbers.Add(listOfNumbers[i]);
                            }
                        }
                        if (countOfEvenOrOdd == 0)
                        {
                            Console.WriteLine("[" + string.Join("", evenOrOddNumbers) + "]");
                        }
                        else
                        {
                            evenOrOddNumbers.Reverse();
                            Console.WriteLine("[" + string.Join(", ", evenOrOddNumbers)+"]");
                        }
                    }
                    else if (evenOrOdd == "odd")
                    {
                        for (int i = listOfNumbers.Count-1; i >= 0; i--)
                        {
                            if (index == countOfEvenOrOdd)
                            {
                                break;
                            }
                            if (listOfNumbers[i] % 2 == 1)
                            {
                                countOfEvenOrOdd++;
                                evenOrOddNumbers.Add(listOfNumbers[i]);
                            }
                        }
                        if (countOfEvenOrOdd == 0)
                        {
                            Console.WriteLine("[" + string.Join("", evenOrOddNumbers) + "]");
                        }
                        else
                        {
                            evenOrOddNumbers.Reverse();
                            Console.WriteLine("["+string.Join(", ", evenOrOddNumbers)+"]");
                        }
                    }

                }
            }
            Console.WriteLine("["+string.Join(", ",listOfNumbers)+"]");
        }
    }
}
