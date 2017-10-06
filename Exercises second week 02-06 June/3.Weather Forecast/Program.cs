using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            String weather = Console.ReadLine();
            long n;
            var number = long.TryParse(weather,out n);
            if (number && sbyte.MinValue <= n && sbyte.MaxValue >= n)
            {
                Console.WriteLine("Sunny");
            } 
            else if (number && int.MinValue <= n && int.MaxValue >= n)
            {
                Console.WriteLine("Cloudy");
            }
            else if(number && long.MinValue <= n && long.MaxValue >= n)
            {
                Console.WriteLine("Windy");
            }
            else
            {
                Console.WriteLine("Rainy");
            }
        }
    }
}
