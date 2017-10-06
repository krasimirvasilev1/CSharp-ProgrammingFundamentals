using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemonPower = uint.Parse(Console.ReadLine());
            var distance = uint.Parse(Console.ReadLine());
            var exhaustionFactor = uint.Parse(Console.ReadLine());

            var counter = 0;
            var changablePokemonPower = pokemonPower;
            var exactlyHalfOfPower = (uint)(pokemonPower * 0.50);
            while (changablePokemonPower >= distance)
            {
                if (changablePokemonPower == exactlyHalfOfPower)
                {
                    if (exhaustionFactor != 0 && changablePokemonPower != 0)
                    {
                        changablePokemonPower /= exhaustionFactor;
                        if (changablePokemonPower < distance)
                        {
                            break;
                        }
                    }
                }
                changablePokemonPower -= distance;
                counter++;
            }
            Console.WriteLine(changablePokemonPower);
            Console.WriteLine(counter);
        }
    }
}
