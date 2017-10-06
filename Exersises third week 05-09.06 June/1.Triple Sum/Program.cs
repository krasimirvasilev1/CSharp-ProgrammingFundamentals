using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] text = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int lenght = text.Length;
            int noCombinations = 0;
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 1; j < text.Length; j++)
                {
                    for (int k = 0; k < text.Length; k++)
                    {
                        if (i < j && text[i] + text[j] == text[k])
                        {
                            noCombinations++;
                            Console.WriteLine("{0} + {1} == {2}", text[i], text[j], text[k]);
                        }
                    }
                }
            }
            if (noCombinations == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
