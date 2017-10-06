using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ExampleDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split().ToArray();

            var dict = new Dictionary<string, int>();
            foreach (var item in words)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++; 
                }
                else
                {
                    dict[item] = 1;
                }
            }
            List<string> output = new List<string>();
            foreach (var item in dict)
            {
                if (item.Value % 2 == 1)
                {
                    output.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ",output));
        }
    }
}
