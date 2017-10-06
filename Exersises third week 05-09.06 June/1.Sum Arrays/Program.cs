using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int [] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            int firstLenght = firstArray.Length;
            int secondLenght = secondArray.Length;
            int maxLenght = Math.Max(firstLenght, secondLenght);
            int [] result = new int [maxLenght];
            for (int i = 0; i < maxLenght; i++)
            {
                result[i] = firstArray[i % firstLenght-1] + secondArray[i % secondLenght-1];

            }
        }
    }
}
