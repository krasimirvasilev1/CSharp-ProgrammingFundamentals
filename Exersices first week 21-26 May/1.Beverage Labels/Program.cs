using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var energycontent = double.Parse(Console.ReadLine());
            var sugarcontent = double.Parse(Console.ReadLine());
            double a = (energycontent * volume) / 100;
            Console.WriteLine(("{0}" + "ml " + "{1}" + ":"), volume, name);
            Console.WriteLine(("{0}kcal, {1}g sugars"), (energycontent * volume) / 100, (sugarcontent * volume) / 100);
        }
    }
}
