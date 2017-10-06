using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Super_Market_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, double[]>();
            var grandTotal = 0.00;

            while (true)
            {
                var inputStock = Console.ReadLine().Split().ToList();
                var stockType = inputStock[0];
                if (stockType == "stocked")
                {
                    break;
                }

                var stockPrice = double.Parse(inputStock[1]);
                var stockQuantity = int.Parse(inputStock[2]);

           
                if (!dictionary.ContainsKey(stockType))
                {
                    dictionary[stockType] = new double[2];
                    dictionary[stockType][0] = stockPrice;
                    dictionary[stockType][1] = stockQuantity;
                }
                else
                {
                    dictionary[stockType][0] = stockPrice;
                    dictionary[stockType][1] += stockQuantity;

                }
            }

                foreach (var item in dictionary)
                {
                    var price = dictionary[item.Key][0];
                    var quantity = dictionary[item.Key][1];
                    var priceForTheProduct = price * quantity;
                    grandTotal += priceForTheProduct;
                    Console.WriteLine($"{item.Key}: ${price:F2} * {quantity} = ${priceForTheProduct:F2}");
                }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${grandTotal:F2}");


                 

            }
        }
    }

