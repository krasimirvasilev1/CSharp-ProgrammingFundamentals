using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());
            String LineHealthCurrent = new String('|', currentHealth);
            String LineHealthMaximum = new string('.', maximumHealth-currentHealth);
            String LineEnergyCurrent = new String('|', currentEnergy);
            String LineEnergyMaximum = new string('.', maximumEnergy - currentEnergy);
            Console.WriteLine("Name: "+name);
            Console.WriteLine($"Health: |{LineHealthCurrent}{LineHealthMaximum}|");
            Console.WriteLine($"Energy: |{LineEnergyCurrent}{LineEnergyMaximum}|");
        }
    }
}
