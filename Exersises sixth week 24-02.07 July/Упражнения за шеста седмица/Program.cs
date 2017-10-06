using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упражнения_за_шеста_седмица
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var reversedInput = input.Reverse().ToArray();

            Console.WriteLine(reversedInput);
        }
    }
}
