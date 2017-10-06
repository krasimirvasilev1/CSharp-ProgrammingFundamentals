using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> digits = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List <int> operations = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            

            int indexOfTheBomb = 0;
            int resultSum = 0;
            for (int i = 0; i <= digits.Count - 1; i++)
            {
                if (digits[i] == operations[0])
                {
                    indexOfTheBomb = i;
                    i--;
                    

                    if (operations[1] >= indexOfTheBomb)
                    {
                        for (int j = 1; j <= indexOfTheBomb; j++)
                        {
                            digits.Remove(digits[0]);
                        }

                        if (digits.Count <= operations[1])
                        {
                            digits.Clear();
                        }
                        else if (digits.Count > operations[1])
                        {
                            var whichIndexWeAreGoingToRemove = indexOfTheBomb + operations[1];
                            for (int j = 1; j <= whichIndexWeAreGoingToRemove; j++)
                            {
                                digits.Remove(digits[0]);
                            }
                        }
                    }
                    else if (operations[1] < indexOfTheBomb)
                    {
                        var whichIndexWeAreGoingToRemove = indexOfTheBomb - operations[1];
                        for (int j = whichIndexWeAreGoingToRemove; j < indexOfTheBomb; j++)
                        {
                            digits.Remove(digits[whichIndexWeAreGoingToRemove]);
                        }
                        if (whichIndexWeAreGoingToRemove + operations[1] > digits.Count - 1)
                        {
                            for (int j = 1; j <= digits.Count+1 - whichIndexWeAreGoingToRemove; j++)
                            {
                                digits.Remove(digits[whichIndexWeAreGoingToRemove]);
                            }
                        }
                        else
                        {
                            for (int j = 1; j <= operations[1] + 1; j++)
                            {
                                digits.Remove(digits[whichIndexWeAreGoingToRemove]);
                            }
                        }
                    }
                }
            }

            foreach (var item in digits)
            {
                resultSum += item;
            }
            Console.WriteLine(resultSum);
        }
    }
}
