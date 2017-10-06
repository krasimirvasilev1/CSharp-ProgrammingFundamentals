using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Honet_Comm___Practical_Exam_February
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Broadcasts = new List<string>();
            List<string> Messages = new List<string>();

            
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Hornet is Green")
                {
                    break;
                }
                var firstQuerySecondQuery = input.Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var firstQuery = firstQuerySecondQuery[0];
                var secondQuery = firstQuerySecondQuery[1];

                var onlyDigitsFirstQuery = true;
                var onlyLettersFirstQuery = true;

                for (int i = 0; i < firstQuery.Length; i++)
                {

                    if (Char.IsDigit(firstQuery[i]))
                    {
                        onlyLettersFirstQuery = false;
                    }
                    else if (!Char.IsDigit(firstQuery[i]))
                    {
                        onlyDigitsFirstQuery = false;
                    }
                }

                var digitsOrLettersSecondQuery = true;
                for (int i = 0; i < secondQuery.Length; i++)
                {
                    if (!Char.IsDigit(secondQuery[i]) && !Char.IsLetter(secondQuery[i]))
                    {
                        digitsOrLettersSecondQuery = false;
                    }
                }

                if (!digitsOrLettersSecondQuery)
                {
                    continue;
                }

                string addSomewhere = "";
                string frequency = "";

                if (onlyDigitsFirstQuery && digitsOrLettersSecondQuery)
                {
                    char[] charArray = firstQuery.ToCharArray();
                    Array.Reverse(charArray);
                    addSomewhere += string.Join("",charArray) + " -> " + secondQuery;
                    Messages.Add(addSomewhere);
                }
                else if (onlyLettersFirstQuery && digitsOrLettersSecondQuery)
                {
                    for (int i = 0; i < secondQuery.Length; i++)
                    {
                        if (char.IsLower(secondQuery[i]))
                        {
                            frequency += secondQuery[i].ToString().ToUpper();
                        }
                        else if (char.IsUpper(secondQuery[i]))
                        {
                            frequency += secondQuery[i].ToString().ToLower();
                        }
                        else
                        {
                            frequency += secondQuery[i];
                        }
                    }
                    addSomewhere += frequency + " -> " + firstQuery;
                    Broadcasts.Add(addSomewhere);
                }
            }
            Console.WriteLine("Broadcasts:");
            if (Broadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in Broadcasts)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("Messages:");
            if (Messages.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in Messages)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
