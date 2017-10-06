using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Number_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                long number = long.Parse(Console.ReadLine());
                Console.WriteLine("integer");
            }
            catch
            {
                Console.WriteLine("floating-point");
            }
            
            }
        }
    }
