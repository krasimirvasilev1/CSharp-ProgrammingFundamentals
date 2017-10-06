using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Dictionary<string,Dictionary<int, double>> demons = new Dictionary<string, Dictionary<int, double>>();
            var regexForDamage = new Regex(@"(\d+\.\d+|\d+)|[\+\-](\d+\.\d+|\d+)");
            var regexForHealth = new Regex(@"([^0-9\+\-\*\/\.])");
            var regexForAsterix = new Regex(@"(\*)");
            var regexForDivide = new Regex(@"(\/)");
            foreach (var item in names)
            {

                int demonHealth = 0;
                double demonDamage = 0.0;
                int asterixCount = 0;
                int divideCount = 0;

                MatchCollection symbolsForHealth = regexForHealth.Matches(item);
                MatchCollection symbolsForDamage = regexForDamage.Matches(item);
                MatchCollection symbolsAstrix = regexForAsterix.Matches(item);
                MatchCollection symbolsDivide = regexForDivide.Matches(item);

                asterixCount = symbolsAstrix.Count;
                divideCount = symbolsDivide.Count;
                foreach (Match symbol in symbolsForHealth)
                {
                    int health = (int)char.Parse(symbol.Groups[0].Value);
                    demonHealth += health;
                    
                }
                
                foreach (Match symbol in symbolsForDamage)
                {
                    double damage = double.Parse(symbol.Value);
                    demonDamage += damage;
                    
                    
                }
                for (int i = 0; i < asterixCount; i++)
                {
                    demonDamage *= 2;
                }

                for (int i = 0; i < divideCount; i++)
                {
                    demonDamage /= 2;
                }
                if (demons.ContainsKey(item))
                {
                    demons[item][demonHealth] = demonDamage;
                }
                else
                {
                    demons[item] = new Dictionary<int, double>();
                    demons[item][demonHealth] = demonDamage;
                }
            }

            foreach (var item in demons.OrderBy(x => x.Key))
            {
                foreach (var item1 in item.Value)
                {
                    Console.WriteLine($"{item.Key} - {item1.Key} health, {item1.Value:F2} damage");
                }
                
            }
            }
        }
    }

