using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                var letter = char.Parse(Console.ReadLine());
                sum += (int)letter;
            }
            Console.WriteLine("The sum equals: {0}",sum);
        }
    }
}
