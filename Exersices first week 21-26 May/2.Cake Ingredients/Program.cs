using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int numingredients = 0;
            for (int i = 1; i <= 21; i++)
            {
               

                var ingredient = Console.ReadLine();
                var a = ingredient.Substring(0, Math.Min(50, ingredient.Length));

                if (a == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {numingredients} ingredients.");
                    break;
                }
                else
                {
                    numingredients++;
                    Console.WriteLine($"Adding ingredient {a}.");
                }
            }
        }
    }
}
