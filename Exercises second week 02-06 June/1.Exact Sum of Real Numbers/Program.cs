using System;

namespace _1.Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 1; i <= number; i++)
            {
                Decimal num = Decimal.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine(sum);
            {

            }
        }
    }
}
