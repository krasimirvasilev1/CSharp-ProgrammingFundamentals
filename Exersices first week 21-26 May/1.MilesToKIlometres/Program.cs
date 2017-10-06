using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.MilesToKIlometres
{
    class Program
    {
        static void Main(string[] args)
        {
            var distance = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}" ,distance*1.60934);
        }
    }
}
