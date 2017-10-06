using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Days_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string[] weekend = new string[7] {"Monday","Tuesday",
                "Wednesday","Thursday","Friday","Saturday","Sunday"};
            if (day >= 1 && day <= 7)
            {
                Console.WriteLine(weekend[day - 1]);

            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
