using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            bool phonebook = true;
            var dictionary = new SortedDictionary<string, string>();
            while (phonebook)
            {
                List<string> input = Console.ReadLine().Split().ToList();

                if (input[0] == "A")
                {
                    if (dictionary.ContainsKey(input[1]))
                    {
                        dictionary[input[1]] = input[2];
                    }
                    else
                    {
                        dictionary.Add(input[1], input[2]);
                    }
                }
                else if (input[0] == "S")
                {
                    if (dictionary.ContainsKey(input[1]))
                    {
                        foreach (var item in dictionary)
                        {
                            if (item.Key == input[1])
                            {
                                Console.WriteLine($"{item.Key} -> {item.Value}");

                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                }
                else if (input[0] == "END")
                {
                    phonebook = false;
                }
                else if (input[0] == "ListAll")
                {
                    var sortedDictionary = new Dictionary<string, string>();
                    foreach (var item in dictionary)
                    {
                        sortedDictionary = dictionary.OrderBy(p => p.Key).ToDictionary(p => p.Key, p => p.Value);
                    }
                    foreach (var item in sortedDictionary)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }
            }
        }
    }
}

