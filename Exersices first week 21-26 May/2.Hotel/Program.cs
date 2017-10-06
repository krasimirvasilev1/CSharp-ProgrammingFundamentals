using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            String month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double pricestudio = 0;
            double pricedouble = 0;
            double pricesuite = 0;
            if (month == "May" || month == "October")
            {
                pricestudio += 50 * nights;
                pricedouble += 65 * nights;
                pricesuite += 75 * nights;
                if (nights > 7 && month == "October")
                {
                    pricestudio *= 0.95;
                    pricestudio -= 50;
                }
                else if (nights > 7 )
                {
                    pricestudio *= 0.95;
                    
                }
              
            }
            if (month == "June" || month == "September")
            {
                pricestudio += 60 * nights;
                pricedouble += 72 * nights;
                pricesuite += 82 * nights;
                if (nights > 14)
                {
                    pricedouble *= 0.90;
                }
                if (month == "September" && nights>7)
                {
                    pricestudio -= 60;
                }
            }
            if (month == "August" || month == "July" || month == "December")
            {
                pricestudio += 68 * nights;
                pricedouble += 77 * nights;
                pricesuite += 89 * nights;
                if(nights>14){
                    pricesuite *= 0.85;  
                }
            }
            Console.WriteLine($"Studio: {pricestudio:F2} lv.");
            Console.WriteLine($"Double: {pricedouble:F2} lv.");
            Console.WriteLine($"Suite: {pricesuite:F2} lv.");
        }
    }
}
