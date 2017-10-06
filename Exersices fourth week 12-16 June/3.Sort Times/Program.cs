using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sort_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> times = Console.ReadLine().Split(' ').ToList();
            times = times.OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(", ",times));
         }
    }
}
