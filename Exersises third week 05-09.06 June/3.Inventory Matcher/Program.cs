using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] product = Console.ReadLine().Split(' ').ToArray();
            long[] quantity = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            double[] priceOfProduct = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            while (1 > 0)
            {
                
                string input = Console.ReadLine();

                if (input == "done")
                {
                    break;

                }
                for (int i = 0; i <= product.Length-1; i++)
                {
                    
                    if (input == "done")
                    {
                        break;
                        
                    }
                    else if (input == product[i])
                    {
                        Console.WriteLine($"{input} costs {priceOfProduct[i]}; Available quantity: {quantity[i]}");
                    }
                }
            }
        }
    }
}
