using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            Double budget = Double.Parse(Console.ReadLine());
            int numberofitems = int.Parse(Console.ReadLine());
            double spentmoney = 0;
            for (int i = 1; i <= numberofitems; i++) 
            {
                String itemname = Console.ReadLine();
                Double itemprice = double.Parse(Console.ReadLine());
                int itemcount = int.Parse(Console.ReadLine());
                spentmoney += (itemprice * itemcount);
                if (itemcount > 1)
                {
                    Console.WriteLine($"Adding {itemcount} {itemname}s to cart. ");
                }
                else
                {
                    Console.WriteLine($"Adding {itemcount} {itemname} to cart. ");
                }
            }
            double moneyleft = budget - spentmoney;
            if (budget >= spentmoney)
               
            {
                Console.WriteLine($"Subtotal: ${spentmoney:F2}");
                Console.WriteLine($"Money left: ${moneyleft:F2}");
            }
            else
            {
                Console.WriteLine($"Subtotal: ${spentmoney:F2}");
                Console.WriteLine($"Not enough. We need ${(spentmoney-budget):F2} more.");
            }
        }
    }
}
