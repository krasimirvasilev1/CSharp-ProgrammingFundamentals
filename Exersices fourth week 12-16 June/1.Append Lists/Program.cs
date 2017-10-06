using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] allNumbers = Console.ReadLine().Split('|').ToArray();
            int length = allNumbers.Length;
            
            List<string> reversedNumbers = new List<string>();

            for (int i = length-1; i >= 0; i--)
            {
                string array = allNumbers[i];
                reversedNumbers.Add(array);
            }

            foreach (var item in reversedNumbers)
            {
                List<string> result = item.Split(' ').ToList();
                foreach (var element in result)
                {
                    if (element != "")
                    {

                    }
                }
            }
            Console.WriteLine(string.Join("",reversedNumbers));

        }
    }
}
