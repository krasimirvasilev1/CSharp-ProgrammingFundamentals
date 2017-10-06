using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            bool miningTask = true;
            int counter = 1;

            List <string> resources = new List<string>();
            List <int> quantity = new List<int>();

            var dictionary = new Dictionary<string, int>();
            while (miningTask)
            {
                var input = Console.ReadLine();
                if (input == "stop")
                {
                    miningTask = false;
                    break;
                }
                else if (counter % 2 == 1)
                {
                    resources.Add(input);
                }
                else if (counter % 2 == 0)
                {
                    var quantityInt = int.Parse(input);
                    quantity.Add(quantityInt);
                }
                counter++;
            }
            for (int i = 0; i < resources.Count; i++)
            {
                if (dictionary.ContainsKey(resources[i]))
                {
                    var grade = 0;
                    dictionary.TryGetValue(resources[i], out grade);
                    dictionary[resources[i]] = quantity[i] + grade;
                }
                else
                {
                    dictionary[resources[i]] = quantity[i];
                }
                
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
