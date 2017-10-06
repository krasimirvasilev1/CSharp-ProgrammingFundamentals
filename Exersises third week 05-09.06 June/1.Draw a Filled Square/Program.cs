using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareSize = int.Parse(Console.ReadLine());
            SquareTopAndBottom(squareSize);
            SquareMiddle(squareSize);
            SquareTopAndBottom(squareSize);
        }
        public static void SquareTopAndBottom (int number)
        {
            Console.WriteLine(new String('-',number*2));
        }
        public static void SquareMiddle(int number)
        {
            for (int i = 1; i <= number-2; i++)
            {
                Console.Write("-");
                for (int j = 1; j < number; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }

    }
}
