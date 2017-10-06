using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1Softuni_Coffee_Orders
{
    class Program
    {
        public static IFormatProvider Culture { get; private set; }

        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal priceOfTheCoffeeTotal = 0.0m;
            for (int i = 1; i <= n; i++)
            {
                decimal pricePerCapsula = decimal.Parse(Console.ReadLine());
                string date = Console.ReadLine();
                DateTime orderDate = DateTime.ParseExact(date,"d/M/yyyy",CultureInfo.InvariantCulture);
                decimal capsulesCount = decimal.Parse(Console.ReadLine());
                decimal days = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

                decimal priceOfTheCoffee = days * capsulesCount * pricePerCapsula;
                priceOfTheCoffeeTotal += priceOfTheCoffee;

                Console.WriteLine($"The price for the coffee is: ${priceOfTheCoffee:F2}");
            }
            Console.WriteLine($"Total: ${priceOfTheCoffeeTotal:F2}");
        }
    }
}
