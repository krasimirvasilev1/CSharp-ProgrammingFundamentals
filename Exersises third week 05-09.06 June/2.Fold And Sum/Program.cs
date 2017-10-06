using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Fold_And_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] text = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int length = text.Length;

            int[] leftText = new int[length / 4];
            int[] rightText = new int[length / 4];
            int[] middleText = new int[length / 2];
            int[] finalText = new int[length / 2];

            for (int i = 0; i < length / 4; i++)
            {
                leftText[i] = text[i];

                rightText[i] = text[(length / 4 + length / 2) + i];
            }

            for (int i = 0; i < length / 2; i++)
            {
                middleText[i] = text[length / 4 + i];
            }

            Array.Reverse(leftText);
            Array.Reverse(rightText);

            for (int i = 0; i < length / 4; i++)
            {
                finalText[i] = leftText[i] + middleText[i];
                finalText[i + length / 4] = rightText[i] + middleText[i + length / 4];
            }
            Console.Write(string.Join(" ", finalText));
        }
    }
}
