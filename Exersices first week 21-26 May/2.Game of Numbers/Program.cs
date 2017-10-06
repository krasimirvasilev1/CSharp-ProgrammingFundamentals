using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int magicalnum = int.Parse(Console.ReadLine());
            int lastcomninationI = 0;
            int lastcombinationJ = 0;
            int combinations = 0;
            for (int i = num1; i <= num2; i++)
            {
                for (int j = num1; j <= num2; j++)
                {
                    combinations++;
                    if(i+j == magicalnum)
                    {
                        lastcomninationI -= lastcomninationI;
                        lastcombinationJ -= lastcombinationJ;
                        lastcomninationI += i;
                        lastcombinationJ += j;

                    }
                }
            }
            if (lastcombinationJ + lastcomninationI== magicalnum)
            {
                Console.WriteLine($"Number found! {lastcomninationI} + {lastcombinationJ} = {magicalnum}");
            }
            else
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicalnum}");
            }
        }
    }
}
