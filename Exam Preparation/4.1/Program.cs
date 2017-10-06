using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1
{
    class Program
    {
        static void Main(string[] args)
        {
           decimal amountOfMoney = decimal.Parse(Console.ReadLine());
           decimal numberOfGuests = decimal.Parse(Console.ReadLine());
           decimal bananaPrice = decimal.Parse(Console.ReadLine());
           decimal eggPrice = decimal.Parse(Console.ReadLine());
           decimal berryPrice = decimal.Parse(Console.ReadLine());

            var priceForADessert = 2 * bananaPrice + 4 * eggPrice + berryPrice / 5;
            var numberOfDesserts = (Math.Ceiling(numberOfGuests / 6));

            var allDessertPrice = priceForADessert * numberOfDesserts;

            
            if (allDessertPrice<=amountOfMoney)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {allDessertPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {allDessertPrice - amountOfMoney:F2}lv more.");
            }
           
        }
    }
}
