using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упражнения_за_първа_седмица_21_26_Май
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            var num4 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1.ToString("D4")+" "+num2.ToString("D4")+" "+num3.ToString("D4")+" "+num4.ToString("D4"));
        }
    }
}
