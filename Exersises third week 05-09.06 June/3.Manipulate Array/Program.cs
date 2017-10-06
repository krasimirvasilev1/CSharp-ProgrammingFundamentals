using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ').ToArray();
            int length = text.Length;

           
            while (1 > 0)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                if (command[0] == "Reverse")
                {
                    Array.Reverse(text);
                }
                else if (command[0] == "Distinct")
                {

                    text = text.Distinct().ToArray();
                }
                else if (command[0] == "Replace")
                {
                    int index = int.Parse(command[1]);
                    string wordToReplace = command[2];
                    if (index > text.Length-1 || index < 0)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        text[index] = wordToReplace;
                    }
                }
                else if (command[0] == "END")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }

            Console.WriteLine(string.Join(", ", text));
        }
    }
}
