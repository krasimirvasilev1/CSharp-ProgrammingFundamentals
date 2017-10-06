using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
             int number = int.Parse(Console.ReadLine());

            String hex = Convert.ToString(number, toBase: 2);
            String hex3 = Convert.ToString(number, toBase: 16);
            Console.WriteLine(hex3.ToUpper());
            Console.WriteLine(hex.ToUpper());

        }
    }
}
