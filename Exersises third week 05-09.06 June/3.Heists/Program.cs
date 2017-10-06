using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] priceOfJewelsGold = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool continueLoot = true;

            int earning = 0;
            int expenses = 0;

            while (1 > 0)
            {
                string[] resultRobbery = Console.ReadLine().Split(' ').ToArray();
                
                if (resultRobbery[0] == "Jail" && resultRobbery[1] == "Time")
                {
                    break;
                }

                char[] earningRobbery = resultRobbery[0].ToArray();
                int expensesRobbery = int.Parse(resultRobbery[1]);

                for (int i = 0; i <= earningRobbery.Length-1; i++)
                {
                    if (earningRobbery[i] == '%')
                    {
                        earning += priceOfJewelsGold[0];
                    }
                    else if(earningRobbery[i] == '$')
                    {
                        earning += priceOfJewelsGold[1];
                    }
                }
                expenses += expensesRobbery;
            }
            if (earning >= expenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {earning - expenses}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {expenses - earning}.");
            }
        }
    }
}
