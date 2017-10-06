using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var countryAndCity = new Dictionary<string, List<string>>();
            var cityAndCount = new Dictionary<string, int>();
            var countryAndCount = new Dictionary<string, int>();

            while (true)
            {
                List<string> input = Console.ReadLine().Split('|').ToList();
                if (input[0] == "report")
                {
                    break;
                }
                // Добавяне на елем. към първото dictionary
                if (!countryAndCity.ContainsKey(input[1]))
                {
                    countryAndCity[input[1]] = new List<string>();
                }
                    countryAndCity[input[1]].Add(input[0]);
                

                // Добавяне на елем. към второто dictionary
                var input2ToInt = int.Parse(input[2]);
                cityAndCount[input[0]] = input2ToInt;

                // Добавяне на стойност към трети речник

                if (countryAndCount.ContainsKey(input[1]))
                {
                    var additionalSum = 0;
                    var sumToTheMoment = countryAndCount.TryGetValue(input[1], out additionalSum);
                    countryAndCount[input[1]] = input2ToInt + additionalSum;
                }
                else
                {
                    countryAndCount[input[1]] = input2ToInt;
                }

                countryAndCount = countryAndCount.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                cityAndCount = cityAndCount.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            }
            foreach (var item in countryAndCount)
            {
                Console.WriteLine($"{item.Key} (total population: {item.Value})");
                foreach (var element in countryAndCity)
                {
                    if (item.Key == element.Key)
                    {
 
                        for (int i = element.Value.Count-1; i >= 0; i--)
                        {
                            var value = 0;
                            var valueInCityAndCount = cityAndCount.TryGetValue(element.Value[i], out value);
                            Console.WriteLine($"=>{element.Value[i]}: {value}");
                        }
                    }
                }
            }
        }
    }
}
