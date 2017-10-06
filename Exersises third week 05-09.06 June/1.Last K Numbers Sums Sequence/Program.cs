using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Last_K_Numbers_Sums_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] text = new int[n];
            text[0] = 1;
            for (int i = 1; i < n; i++)
            {
                var sum = 0;
                for (int j = 1; j <= k; j++)
                {
                    if (i-j >= 0)
                        sum += text[i-j];
                }
                text[i] = sum;
            }
            foreach (var element in text)
                Console.Write(element+" ");
        }
    }
}
