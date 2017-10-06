using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Morso_Code_Upgraded
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|').ToList();
            var combinations = 0;

            var totalSum = 0;

            List<int> allMorseCodes = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                var cuurentSection = input[i].ToString();

                for (int j = 0; j < cuurentSection.Length; j++)
                {
                    if (cuurentSection[j] == '0')
                    {
                        totalSum += 3;
                        if (j != 0 && cuurentSection[j - 1] == '1')
                        {
                            combinations = 0;
                        }
                        combinations++;
                        if (combinations > 1 && j == cuurentSection.Length-1)
                        {
                            totalSum += combinations;
                            combinations = 0;
                            break;
                        }
                        if (combinations > 1 && cuurentSection[j + 1] == '1')
                        {
                            totalSum += combinations;
                            combinations = 0;
                        }
                    }
                    else if (cuurentSection[j] == '1')
                    {
                        totalSum += 5;
                        if (j != 0 && cuurentSection[j - 1] == '0')
                        {
                            combinations = 0;
                        }
                        combinations++;
                        if (combinations > 1 && j == cuurentSection.Length - 1)
                        {
                            totalSum += combinations;
                            combinations = 0;
                            break;
                        }
                        if (combinations > 1 && cuurentSection[j + 1] == '0')
                        {
                            totalSum += combinations;
                            combinations = 0;
                        }
                    }
                }
                combinations = 0;
                allMorseCodes.Add(totalSum);
                totalSum = 0;
                
            }

            foreach (var item in allMorseCodes)
            {
                char decode = (char)item;
                Console.Write(decode);
            }
            Console.WriteLine();
        }
    }
}
