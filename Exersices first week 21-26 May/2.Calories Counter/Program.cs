using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int cheese = 0;
            int tomatosauce = 0;
            int salami = 0;
            int pepper = 0;
            int callories = 0;
            int counter = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                var ingredients = Console.ReadLine().ToLower();
                counter++;
                if (ingredients == "cheese")
                {
                    callories += 500;
                    cheese += 1;
                    if (cheese > 1)
                    {
                        break;
                    }
                }
                else if (ingredients == "tomato sauce")
                {
                    callories += 150;
                    tomatosauce += 1;
                    if (tomatosauce > 1)
                    {
                        break;
                    }
                }
                else if (ingredients == "salami")
                {
                    callories += 600;
                    salami += 1;
                    if (salami > 1)
                    {
                        break;
                    }
                }
                else if (ingredients == "pepper")
                {
                    callories += 50;
                    pepper += 1;
                    if (pepper > 1)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"Total calories: {callories}");
        }
    }
}
