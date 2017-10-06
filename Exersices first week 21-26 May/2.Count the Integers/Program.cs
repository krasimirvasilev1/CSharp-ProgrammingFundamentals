using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            try
            {
                for (int i = 1; i <= 100; i++)
                {
                    var num = int.Parse(Console.ReadLine());
                    counter++;
                }

            }
            catch
            {

            }
            Console.WriteLine(counter);
        }
    }
}
