using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.Weather___Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<double, string>> dictionary = new Dictionary<string, SortedDictionary<double, string>>();

            var regex = new Regex(@"[A-Z]{2}[0-9]{1,}(\.)[0-9]{1,}([a-z]|[A-Z])+[\|]");

            var text = "";
            var stringOfMatches = "";
            while ((text = Console.ReadLine()) != "end")
            {
                MatchCollection matches = regex.Matches(text);

                stringOfMatches += string.Join("", from Match match in matches select match.Value);
            }

            var arrayOfMatches = stringOfMatches.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var regexCity = @"\b[A-Z]{2}";
            var regexTemperature = @"[0-9]{1,}(\.)[0-9]{1,}";
            var regexWeatherCast = @"([a-z]|[A-Z])+\b";

            for (int i = 0; i < arrayOfMatches.Length; i++)
            {
                Match informationAboutCity = Regex.Match(arrayOfMatches[i], regexCity);
                Match informationAboutTemperature = Regex.Match(arrayOfMatches[i], regexTemperature);
                Match informationAboutWeather = Regex.Match(arrayOfMatches[i], regexWeatherCast);
                var city = informationAboutCity.ToString();
                var temperature = double.Parse(informationAboutTemperature.ToString());
                var weather = informationAboutWeather.ToString();

                if (dictionary.ContainsKey(city))
                {
                    dictionary[city] = new SortedDictionary<double, string>();
                    dictionary[city][temperature] = weather;
                }
                else
                {

                    dictionary[city] = new SortedDictionary<double, string>();
                    dictionary[city][temperature] = weather;
                }
            }
            
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} => {string.Join("",item.Value.Keys)} => {string.Join("",item.Value.Values)}");
            }
        }
    }
}
