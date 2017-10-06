using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string> numbers = Console.ReadLine().Split(' ').ToList();

            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                List<int> result = new List<int>();
                result.InsertRange(numbers[i], numbers);
                char.TryParse(numbers[i], out paca);
                result.Add(paca);
                Console.WriteLine(string.Join(" ",result));
            }
            Console.WriteLine(sum);
        }
        
    }
}
