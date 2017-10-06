using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упражнения_за_трета_седмица_05_09._06
{
    class Methods
    {
        public static int Sum (int a , int b)
        {
            return Math.Max(a, b);
        }
        public static char Sum (char a , char b)
        {
            return (char)Math.Max((int)a, (int)b);
        }
        public static string Sum (string a , string b)
        {
            if(a.CompareTo(b) < 0)
            {
                return b;
            }
            else
            {
                return a;
            }
        }


        public static int Sum (int number)
        {

            return Math.Abs(GetSumOfEvenDigits(number) * GetSumOfOddDigits(number));
        }

        public static int GetSumOfOddDigits(int number)
        {
            throw new NotImplementedException();
        }

        public static int GetSumOfEvenDigits(int number)
        {
            throw new NotImplementedException();
        }
    }
}
