using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Imunne_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialHealth = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<string, int>();

            var levelOfHealth = initialHealth;
            var finalHealth = 0;

            while (true)
            {
                char[] input = Console.ReadLine().ToArray();

                string check = new string(input);
                if (check == "end")
                {
                    break;
                }

                var sumForInput = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    int resultForNumber = (int)input[i];
                    sumForInput += resultForNumber;
                }

                var virusStrength = sumForInput / 3;
                var virusTimeToDefeat = virusStrength * input.Length;
                var minutesDefeat = virusTimeToDefeat / 60;
                var secondsDefeat = virusTimeToDefeat % 60;
                
                if (dictionary.ContainsKey(check))
                {
                    var numberOfTimesVirusDetected = 0;
                    var something = dictionary.TryGetValue(check, out numberOfTimesVirusDetected);
                    dictionary[check] = numberOfTimesVirusDetected + 1;
                    if (dictionary[check] == 2)
                    {
                        virusTimeToDefeat = virusTimeToDefeat / 3;
                        minutesDefeat = virusTimeToDefeat / 60;
                        secondsDefeat = virusTimeToDefeat % 60;
                    }
                }
                dictionary[check] = 1;
               
                

                var currentHealth = levelOfHealth - virusTimeToDefeat;

                Console.WriteLine($"Virus {check}: {virusStrength} => {virusTimeToDefeat} seconds");
                if (currentHealth > 0)
                {
                    Console.WriteLine($"{check} defeated in {minutesDefeat}m {secondsDefeat}s.");
                    Console.WriteLine($"Remaining health: {currentHealth}");

                    levelOfHealth = currentHealth + (int)(currentHealth * 0.20);

                    if (levelOfHealth > initialHealth)
                    {
                        levelOfHealth = initialHealth;
                    }
                    finalHealth = currentHealth;
                }
                else
                {
                    finalHealth = currentHealth;
                    Console.WriteLine("Immune System Defeated.");
                    break;
                }
            }
            if (finalHealth > 0)
            {
                Console.WriteLine($"Final Health: {levelOfHealth}");
            }

        }
    }
}