using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _2.Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var inputToString = Console.ReadLine();

            double allSum = 0.0;

            for (int i = 0; i < input.Count; i++)
            {
                var fromListToString = input[i].ToString();

                var firstLetter = char.Parse(string.Join("", fromListToString.Take(1)));
                var numbers = int.Parse(string.Join("", fromListToString.Skip(1).Take(input[i].Length - 2)));
                var secondLetter = char.Parse(string.Join("", fromListToString.Skip(input[i].Length - 1).Take(1)));

                double sumForThisIndex = (double)numbers;

                if (firstLetter >= 'A' && firstLetter <= 'Z')
                {
                    double numberInTheAlphabeth = (int)firstLetter - 64;
                    sumForThisIndex = sumForThisIndex / numberInTheAlphabeth;

                }
                else if (firstLetter >= 'a' && firstLetter <= 'z')
                {
                    double numberInTheAlphabeth = (int)firstLetter - 96;
                    sumForThisIndex = sumForThisIndex * numberInTheAlphabeth;
                }

                if (secondLetter >= 'A' && secondLetter <= 'Z')
                {
                    double numberInTheAlphabeth = (int)secondLetter - 64;
                    sumForThisIndex = sumForThisIndex - numberInTheAlphabeth;
                }
                else if (secondLetter >= 'a' && secondLetter <= 'z')
                {
                    double numberInTheAlphabeth = (int)secondLetter - 96;
                    sumForThisIndex = sumForThisIndex + numberInTheAlphabeth;
                }

                allSum += sumForThisIndex;
            }
            Console.WriteLine("{0:F2}", allSum);
        }
    }
}

