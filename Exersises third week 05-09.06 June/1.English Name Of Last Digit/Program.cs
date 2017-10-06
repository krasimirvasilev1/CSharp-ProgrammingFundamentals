using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.English_Name_Of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {

            String LetterOfTheLastDigit = LastDigit(long.Parse(Console.ReadLine()));
            Console.WriteLine(LetterOfTheLastDigit);
        }
        public static string LastDigit(long number)
        {
            if (number < 0)
            {
                number = Math.Abs(number);
            }
            long lastDigit = (number % 10);
            string letterOfTheLastDigit = "";

            switch (lastDigit)
            {
                case 1:
                    letterOfTheLastDigit += "one";
                    return letterOfTheLastDigit;
                case 2:
                    letterOfTheLastDigit += "two";
                    return letterOfTheLastDigit;
                case 3:
                    letterOfTheLastDigit += "three";
                    return letterOfTheLastDigit;
                case 4:
                    letterOfTheLastDigit += "four";
                    return letterOfTheLastDigit;
                case 5:
                    letterOfTheLastDigit += "five";
                    return letterOfTheLastDigit;
                case 6:
                    letterOfTheLastDigit += "six";
                    return letterOfTheLastDigit;
                case 7:
                    letterOfTheLastDigit += "seven";
                    return letterOfTheLastDigit;
                case 8:
                    letterOfTheLastDigit += "eight";
                    return letterOfTheLastDigit;
                case 9:
                    letterOfTheLastDigit += "nine";
                    return letterOfTheLastDigit;
                default:
                    letterOfTheLastDigit += "zero";
                    return letterOfTheLastDigit;

            }
        }
    }
    }

