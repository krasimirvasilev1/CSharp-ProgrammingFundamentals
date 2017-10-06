using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            double beatsperminute = Double.Parse(Console.ReadLine());
            double numofbeats = Double.Parse(Console.ReadLine());
            double allseconds = numofbeats / (beatsperminute / 60);
            double bars = numofbeats / 4;
            double minutes = Math.Floor(allseconds / 60);
            double seconds = Math.Floor(allseconds % 60);
            Console.WriteLine("{0} bars - {1}m {2:F0}s",Math.Round(bars,1),minutes,seconds);
        }
    }
}
