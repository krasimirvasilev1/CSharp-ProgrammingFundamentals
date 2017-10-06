using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Evolution
{
    class Program
    {
        class Pokemon
        {
            public string EvolutionType { get; set; }
            public int EvolutionIndex { get; set; }

        }
        static void Main(string[] args)
        {
            Dictionary<string, List<Pokemon>> pokemonSelection = new Dictionary<string, List<Pokemon>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "wubbalubbadubdub")
                {
                    break;
                }

                var listInput = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                
                var pokemonName = listInput[0];
                if (listInput.Count == 1)
                {
                    if (pokemonSelection.ContainsKey(pokemonName))
                    {
                        foreach (var item in pokemonSelection)
                        {
                            if (item.Key == pokemonName)
                            {
                                Console.WriteLine($"# {pokemonName}");
                                foreach (var element in item.Value)
                                {
                                    Console.WriteLine($"{element.EvolutionType} <-> {element.EvolutionIndex}");
                                }
                            }
                            
                        }
                    }
                }
                else
                {
                    var evolutionType = listInput[1];
                    var evolutionIndex = int.Parse(listInput[2]);
                    if (pokemonSelection.ContainsKey(pokemonName))
                    {

                        Pokemon newPokemon = new Pokemon
                        {
                            EvolutionType = evolutionType,
                            EvolutionIndex = evolutionIndex
                        };
                        pokemonSelection[pokemonName].Add(newPokemon);
                    }
                    else
                    {
                        Pokemon newPokemon = new Pokemon
                        {
                            EvolutionType = evolutionType,
                            EvolutionIndex = evolutionIndex
                        };
                        pokemonSelection[pokemonName] = new List<Pokemon>();
                        pokemonSelection[pokemonName].Add(newPokemon);

                    }
                }
            }

            foreach (var item in pokemonSelection)
            {
                Console.WriteLine($"# {item.Key}");
                foreach (var element in item.Value.OrderByDescending(x => x.EvolutionIndex))
                {
                    Console.WriteLine($"{ element.EvolutionType} <-> {element.EvolutionIndex}");
                }
            }


        }
    }
}
