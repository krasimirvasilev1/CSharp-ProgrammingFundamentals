using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();

            string[] numbers = values.Split(' ');

            int[] arr = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(arr[i] = int.Parse(numbers[i]));
            }
           
        }
    }
}
