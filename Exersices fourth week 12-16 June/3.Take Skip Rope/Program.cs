using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Take_Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> inputText = Console.ReadLine().ToList();
          

            List<int> numbers = new List<int>();

            List<string> notNumbers = new List<string>();

            List<int> skipNumbers = new List<int>();
            List<int> takeNumbers = new List<int>();

            int skipSum = 0;

            List<string> resultOutput = new List<string>();

            //Добавяне към новия лист от числа
            for (int i = 0; i < inputText.Count; i++)
            {
                string fromCharToString = new string(inputText[i], 1);
                int n;
                var isNumber = int.TryParse(fromCharToString, out n);

                if (isNumber)
                {
                    numbers.Add(n);
                }
                //Добавяне на новия лист съдържащ not numbers
                else
                {
                    notNumbers.Add(inputText[i].ToString());
                }
            }
            // Разделяне на List numbers на два други листа (take , skip)
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeNumbers.Add(numbers[i]);
                }
                else
                {
                    skipNumbers.Add(numbers[i]);
                }
            }

            // Добавяне към лист result данните за output 
            for (int i = 0; i < takeNumbers.Count; i++)
            {

                resultOutput.AddRange(notNumbers.Skip(skipSum).Take(takeNumbers[i]).ToList());

                skipSum += skipNumbers[i];

                skipSum += takeNumbers[i];
            }
            Console.WriteLine(string.Join("", resultOutput));
        }
    }
}
