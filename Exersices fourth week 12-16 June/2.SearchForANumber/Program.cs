using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> allNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int [] numbersForOperations = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            List<int> output = new List<int>();

            bool doWeHaveTheNumber = false;

            for (int i = 0; i < numbersForOperations[0]; i++)
            {
                output.Add(allNumbers[i]);
            }

            int digitsToDelete = 0;
            while (digitsToDelete < numbersForOperations[1])
            {
                digitsToDelete++;
                output.Remove(output[0]);
            }

            for (int i = 0; i < output.Count; i++)
            {
                if (output[i] == numbersForOperations[2])
                {
                    doWeHaveTheNumber = true;
                }
            }
            if (doWeHaveTheNumber)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
            
        }
    }
}
