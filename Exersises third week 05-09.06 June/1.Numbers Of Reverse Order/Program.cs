using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Numbers_Of_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversedText = NumberInReverseOrder(Console.ReadLine());
            Console.WriteLine(reversedText);
        }
        public static string NumberInReverseOrder(string text)
        {
            
            string reverseText = string.Empty;
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reverseText += text[i];

            }
            return reverseText;
        }
    }
}
