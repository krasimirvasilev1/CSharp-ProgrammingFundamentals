using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2._3_Nether_Realms___Решение_Влади
{
    class Demon
    {
        public string Name { get; set; }
        public decimal Health { get; set; }
        public decimal Damage { get; set; }
        public static Demon Parse(string demonStr)
        {
            var name = demonStr;

            var damageRegex = new Regex (@"(-?\d+(?:\.\d+)?)");
            var healthRegex = new Regex(@"[^\d+\-*\/\.]");
            // Поредицата от мачове я кастваме и правим към желаната от нас променлива чрез LINQ;
            var health = healthRegex.Matches(demonStr).Cast<Match>().Select(a => (int)char.Parse(a.Value)).Sum();
            var damage = damageRegex.Matches(demonStr).Cast<Match>().Select(a => decimal.Parse(a.Value)).Sum();

            var multiplyCount = demonStr.Count(a => a == '*');
            var divideCount = demonStr.Count(a => a == '/');
            if (multiplyCount > 0)
            {
                damage *= (int)Math.Pow(2, multiplyCount);
            }
            if (divideCount > 0)
            {
                damage /= (int)Math.Pow(2, divideCount);
            }
            var demon = new Demon()
            {
                Name = name,
                Damage = damage,
                Health = health
            };
            return demon;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            var demons = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Demon.Parse).OrderBy(a => a.Name).ToArray();

            foreach (var demon in demons)
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:F2} damage");
            }


}
    }
}





