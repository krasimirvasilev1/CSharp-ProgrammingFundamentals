using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, List<string>>();

            var secondDictionary = new Dictionary<string, int>();

            var result = 0;

            while (true)
            {
                

                List<string> nameAndCards = Console.ReadLine().Split(':').ToList();

                if (nameAndCards[0] == "JOKER")
                {
                    break;
                }
                List<string> cards = nameAndCards[1].Split(' ', ',').ToList();

                string name = nameAndCards[0];

                cards = cards.Distinct().ToList();

                if (!dictionary.ContainsKey(name))
                {

                    dictionary[name] = new List<string>();
                }

                dictionary[name].AddRange(cards);

            }

            foreach (var item in dictionary)
            {
                var dictionaryValueDistinct = item.Value.Distinct().ToList(); 

                result = 0;

                for (int i = 0; i < dictionaryValueDistinct.Count; i++)
                {

                    if (dictionaryValueDistinct[i] != "")
                    {
                        List<char> points = dictionaryValueDistinct[i].ToString().ToList();
                        var firstLetter = 0;
                        var secondLetter = 0;
                        for (int j = 2; j <= 10; j++)
                        {
                            string intToChar = j.ToString();

                            if (points[0] == 'J')
                            {
                                firstLetter += 11;
                                break;
                            }
                            else if (points[0] == 'Q')
                            {
                                firstLetter += 12;
                                break;

                            }
                            else if (points[0] == 'K')
                            {
                                firstLetter += 13;
                                break;
                            }
                            else if (points[0] == 'A')
                            {
                                firstLetter += 14;
                                break;
                            }
                            else if (points[0].ToString() == intToChar)
                            {
                                firstLetter += j;
                                break;
                            }
                        }
                        if (points[1] == 'C')
                        {
                            secondLetter += 1;
                        }
                        else if (points[1] == 'D')
                        {
                            secondLetter += 2;
                        }
                        else if (points[1] == 'H')
                        {
                            secondLetter += 3;
                        }
                        else if (points[1] == 'S')
                        {
                            secondLetter += 4;
                        }
                        result += firstLetter * secondLetter;
                    }
                    secondDictionary[item.Key] = result;
                }

            }

            foreach (var item in secondDictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value }");
            }


        }

    }
}


