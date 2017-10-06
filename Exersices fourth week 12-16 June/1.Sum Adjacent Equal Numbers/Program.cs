using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            bool otherMatchExist = true;
            while (otherMatchExist)
            {
                int combinations = 0;
                for (int i = 1; i <= numbers.Count - 1; i++)
                {
                    

                    if (numbers[i] == numbers[i - 1])
                    {
                        numbers[i] += numbers[i - 1];                        
                        numbers.Remove(numbers[i - 1]);
                        combinations++;
                    }
                    if(combinations > 0)
                    {
                        otherMatchExist = true;
                    }
                    else if(combinations == 0)
                    {
                        otherMatchExist = false;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}

