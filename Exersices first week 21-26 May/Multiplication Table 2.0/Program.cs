using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = times; i <= 10; i++)
            {
                sum += num * i;
                Console.WriteLine($"{num} X {i} = {sum}");
                sum -= sum;
            }
            if (times > 10)
            {
                sum += times * num;
                Console.WriteLine($"{num} X {times} = {sum}");
            }

        }
    }
}
