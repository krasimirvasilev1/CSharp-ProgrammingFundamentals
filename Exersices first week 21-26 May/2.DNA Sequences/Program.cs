using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 1; i <=4; i++)
            {
                for (int j = 1; j <= 4;j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        counter++;
                        if(counter > 4)
                        {
                            Console.WriteLine();
                            counter -= 4;
                        }
                        String first = "";
                        String second = "";
                        String third = "";
                        if(i == 1)
                        {
                            first += "A";
                        }
                        else if (i == 2)
                        {
                            first += "C";
                        }
                        else if (i == 3)
                        {
                            first += "G";
                        }
                        else if (i == 4)
                        {
                            first += "T";
                        }
                        if (j == 1)
                        {
                            second += "A";
                        }
                        else if (j == 2)
                        {
                            second += "C";
                        }
                        else if (j == 3)
                        {
                           second += "G";
                        }
                        else if (j == 4)
                        {
                            second += "T";
                        }
                        if (k == 1)
                        {
                            third += "A";
                        }
                        else if (k == 2)
                        {
                            third += "C";
                        }
                        else if (k == 3)
                        {
                            third += "G";
                        }
                        else if (k == 4)
                        {
                            third += "T";
                        }
                        if ((i + j + k) >= number)
                        {
                            Console.Write($"O{first}{second}{third}O ");
                        }
                        else
                        {
                            Console.Write($"X{first}{second}{third}X ");
                        }
                    }
                }
            }
        }
    }
}
