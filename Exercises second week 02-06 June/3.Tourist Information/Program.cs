using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            String type = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());
            double miles = value * 1.6;
            double inches = value*2.54;
            double feet = value * 30;
            double yards = value * 0.91;
            double gallons = value * 3.8;
            switch (type)
            {
                case "miles":
               Console.WriteLine("{0} miles = {1:F2} kilometers",value,miles);
                    break;
                case "inches":
                    Console.WriteLine("{0} inches = {1:F2} centimeters",value,inches);
                    break;
                case "feet":
                    Console.WriteLine("{0} feet = {1:F2} centimeters",value,feet);
                    break;
                case "yards":
                    Console.WriteLine("{0} yards = {1:F2} meters",value,yards);
                    break;
                case "gallons":
                    Console.WriteLine("{0} gallons = {1:F2} liters",value,gallons);
                    break;
            } 
        }
    }
}
