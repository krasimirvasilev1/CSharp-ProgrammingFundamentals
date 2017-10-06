using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split(' ').ToArray();
            int maximumLength = int.Parse(Console.ReadLine());
            int numOfUsedIngredients = 0;

            List<string> pizzaIngredients = new List<string>();

            for (int i = 0; i <= ingredients.Length-1; i++)
            {
                if (ingredients[i].Length == maximumLength)
                {
                    
                    Console.WriteLine($"Adding {ingredients[i]}.");
                    numOfUsedIngredients++;
                    pizzaIngredients.Add(ingredients[i]);
                }
                if (numOfUsedIngredients == 10)
                {
                    break;
                }
            }
            Console.WriteLine($"Made pizza with total of {numOfUsedIngredients} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ",pizzaIngredients)}.");
        }
    }
}
