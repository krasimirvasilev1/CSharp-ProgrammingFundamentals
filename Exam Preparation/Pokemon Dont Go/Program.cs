using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Dont_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> distanceToPokemons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int index = int.Parse(Console.ReadLine());

            decimal result = 0;
            while (true)
            {
                int indexNumber = 0;

                if (index > distanceToPokemons.Count - 1)
                {
                    indexNumber = distanceToPokemons[0];
                    var lastNumber = distanceToPokemons.Last();
                    distanceToPokemons[distanceToPokemons.Count - 1] = indexNumber;
                    
                    result += lastNumber;

                    for (int i = 0; i < distanceToPokemons.Count; i++)
                    {
                        if (distanceToPokemons[i] <= indexNumber)
                        {
                            distanceToPokemons[i] += indexNumber;
                        }
                        else if (distanceToPokemons[i] > indexNumber)
                        {
                            distanceToPokemons[i] -= indexNumber;
                        }
                    }
                }
                else if (index < 0)
                {
                    indexNumber = distanceToPokemons[distanceToPokemons.Count - 1];
                    var firstNumber = distanceToPokemons.First();
                    distanceToPokemons[0] = indexNumber;

                    result += firstNumber;

                    for (int i = 0; i < distanceToPokemons.Count; i++)
                    {
                        if (distanceToPokemons[i] <= indexNumber)
                        {
                            distanceToPokemons[i] += indexNumber;
                        }
                        else if (distanceToPokemons[i] > indexNumber)
                        {
                            distanceToPokemons[i] -= indexNumber;
                        }
                    }
                }
                else
                {
                    indexNumber = distanceToPokemons[index];
                    distanceToPokemons.RemoveAt(index);

                    result += indexNumber;

                    for (int i = 0; i < distanceToPokemons.Count; i++)
                    {
                        if (distanceToPokemons[i] <= indexNumber)
                        {
                            distanceToPokemons[i] += indexNumber;
                        }
                        else if (distanceToPokemons[i] > indexNumber)
                        {
                            distanceToPokemons[i] -= indexNumber;
                        }
                    }
                }

                if (distanceToPokemons.Count == 0)
                {
                    break;
                }

               index = int.Parse(Console.ReadLine());

            }
            Console.WriteLine(result);
        }

    }
}

