using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Rotate_And_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] number = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotate = int.Parse(Console.ReadLine());
            int length = number.Length;
            int[] sum = new int[length];
            while (rotate != 0)
            {
                for (int i = length-1; i > 0  ; i--)
                {
                    var temp = number [i];
                    number[i] = number[i-1];
                    number[i-1] = temp;
                    
                }
                for (int i = 0; i <=length-1; i++)
                {
                    sum[i] += number[i]; 
                }
                rotate--;
            }
            Console.Write(string.Join(" ",sum));
        }
        }
    }
