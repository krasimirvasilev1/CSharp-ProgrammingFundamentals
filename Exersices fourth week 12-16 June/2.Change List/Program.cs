using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> takeAllNumbers = new List<int>();
            numbers.AddRange(takeAllNumbers);
            bool continueInput = true;
            List<int> output = new List<int>();
            while (continueInput)
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();
                if (input[0] == "Delete")
                {
                    int numbersToDelete = 0;
                    Int32.TryParse(input[1], out numbersToDelete);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == numbersToDelete)
                        {
                            numbers.Remove(numbers[i]);
                            i--;
                        }
                    }
                }
                else if (input [0] == "Insert")
                {
                    int digitToInsert = 0;
                    Int32.TryParse(input[1], out digitToInsert);
                    int indexOfTheDigit = 0;
                    Int32.TryParse(input[2], out indexOfTheDigit);

                    numbers.Insert(indexOfTheDigit, digitToInsert);
                }
                else if (input[0] == "Odd")
                {
                    foreach (var item in numbers)
                    {
                        if (item % 2 == 1)
                        {
                            output.Add(item);
                        }
                    }
                    continueInput = false;
                }
                else if (input[0] == "Even")
                {
                    foreach (var item in numbers)
                    {
                        if (item % 2 == 0)
                        {
                            output.Add(item);
                        }
                    }
                    continueInput = false;
                }
            }
            Console.WriteLine(string.Join(" ",output));
        }
    }
}

