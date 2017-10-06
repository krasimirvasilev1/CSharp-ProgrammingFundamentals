using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(first, 16));
           
        }
    }   
}
