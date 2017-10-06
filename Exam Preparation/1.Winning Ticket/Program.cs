using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> allTickets = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();


            for (int i = 0; i < allTickets.Count; i++)
            {
                if (allTickets[i].Length == 20)
                {
                    var leftHalf = allTickets[i].Substring(0, 10);
                    var rightHalf = allTickets[i].Substring(10, 10);
                    char[] symbols = new char[] { '@', '#', '$', '^' };

                    var isTrue = false;
                    var specialChar = ' ';
                    var maxValue = 0;
                    foreach (var item in symbols)
                    {
                        int countLeft = leftHalf.Split(item).Length - 1;
                        int countRight = rightHalf.Split(item).Length - 1;
                        maxValue = Math.Min(countLeft, countRight);
                        if (countLeft >= 6 && countRight >= 6)
                        {
                            specialChar = item;
                            isTrue = true;
                            break;
                        }

                    }
                    Console.Write("ticket \"{0}\" - ",allTickets[i]);
                    if (!isTrue)
                    {
                        Console.WriteLine("no match");
                    }
                    else
                    {
                        if (maxValue == 10)
                        {
                        Console.WriteLine("{0}{1} Jackpot!", maxValue, specialChar);
                        }
                        else
                        {
                            Console.WriteLine("{0}{1}", maxValue, specialChar);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
