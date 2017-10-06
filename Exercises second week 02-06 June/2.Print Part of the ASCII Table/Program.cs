using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingNum = int.Parse(Console.ReadLine());
            int endingNum = int.Parse(Console.ReadLine());
            for (int i = startingNum; i <= endingNum; i++)
            {
                Console.Write("{0} ", Convert.ToChar(i));
            }
        }
    }
}
