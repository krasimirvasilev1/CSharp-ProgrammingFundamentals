using System;

namespace _1.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberofpeople = int.Parse(Console.ReadLine());
            var capacityofelevator = int.Parse(Console.ReadLine());
            var courseofelevator = Math.Ceiling((double)numberofpeople / capacityofelevator);
           
            Console.WriteLine($"{courseofelevator}");
             
        }
    }
}
