using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupsize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();
            double price = 0;
            double discount = 0;
            String hall = "";
            int pricepackage = 0;
           if (groupsize >= 0 && groupsize <= 50)
            {
                price += 2500;
                hall = "Small Hall";
            }
           else if (groupsize > 50 && groupsize <= 100)
            {
                price += 5000;
                hall = "Terrace";
            }
           else if(groupsize > 100 && groupsize <= 120)
            {
                price += 7500;
                hall = "Great Hall";
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
           if (package == "Normal")
            {
                pricepackage += 500;
                discount = (price + pricepackage) * 0.05;
                
            }
           else if(package == "Gold")
            {
                pricepackage += 750;
                discount = (price + pricepackage) * 0.10;
               
            }
           else if(package == "Platinum")
            {
                pricepackage += 1000;
                discount = (price + pricepackage) * 0.15;
                
            }
            double result = (((price + pricepackage) - discount) / groupsize);
            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {result:F2}$");      
      }
    }
}
