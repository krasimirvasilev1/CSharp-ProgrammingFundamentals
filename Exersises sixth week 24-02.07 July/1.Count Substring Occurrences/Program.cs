using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string patter = Console.ReadLine().ToLower();
            var counter = 0;
            var firstIndex = input.IndexOf(patter);

            while (firstIndex != -1)
            {
                counter++;
                firstIndex = input.IndexOf(patter, firstIndex + 1);
            }
            Console.WriteLine(counter);
        }
    }
}
