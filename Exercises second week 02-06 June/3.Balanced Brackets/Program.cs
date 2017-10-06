using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counterOpening = 0;
            int counterClosing = 0;
            for (int i = 1; i <= number; i++)
            {
                String letterOrWord = Console.ReadLine();
                if (letterOrWord == "(")
                {
                    counterOpening++;
                    if (counterOpening - counterClosing == 2)
                    {
                        break;
                    }
                }
                else if (letterOrWord == ")")
                {
                    counterClosing++;
                    if (counterClosing - counterOpening == 2)
                    {
                        break;
                    }
                }
                
            }
            if(counterOpening == counterClosing)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
