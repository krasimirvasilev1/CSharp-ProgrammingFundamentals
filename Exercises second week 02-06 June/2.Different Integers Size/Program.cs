using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _2.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());

            if (number<0 && number >=sbyte.MinValue )
            {
                Console.WriteLine("{0} can fit in:",number);
                Console.WriteLine("* sbyte");
                Console.WriteLine("* short");
                Console.WriteLine("* int");
                Console.WriteLine("* long ");
            }
            else if (number < 0 && number >= short.MinValue)
            {
                Console.WriteLine("{0} can fit in:",number);
                Console.WriteLine("* short");
                Console.WriteLine("* int");
                Console.WriteLine("* long ");
            }
            else if (number < 0 && number >= int.MinValue)
            {
                Console.WriteLine("{0} can fit in:", number);
                Console.WriteLine("* int");
                Console.WriteLine("* long ");
            }
            else if (number < 0 && number >= long.MinValue)
            {
                Console.WriteLine("{0} can fit in:", number);
                Console.WriteLine("* long ");
            }
            else if (number >= 0 && number <= sbyte.MaxValue)
            {
                Console.WriteLine("{0} can fit in:", number);
                Console.WriteLine("* sbyte");
                Console.WriteLine("* byte");
                Console.WriteLine("* short");
                Console.WriteLine("* ushort");
                Console.WriteLine("* int");
                Console.WriteLine("* uint");
                Console.WriteLine("* long ");
            }
            else if (number > sbyte.MaxValue && number<=byte.MaxValue)
            {
                Console.WriteLine("{0} can fit in:", number);
                Console.WriteLine("* byte");
                Console.WriteLine("* short");
                Console.WriteLine("* ushort");
                Console.WriteLine("* int");
                Console.WriteLine("* uint");
                Console.WriteLine("* long ");
            }
            else if (number > byte.MaxValue && number <= short.MaxValue)
            {
                Console.WriteLine("{0} can fit in:", number);
                Console.WriteLine("* short");
                Console.WriteLine("* ushort");
                Console.WriteLine("* int");
                Console.WriteLine("* uint");
                Console.WriteLine("* long ");
            }
            else if (number > short.MaxValue && number <= ushort.MaxValue)
            {
                Console.WriteLine("{0} can fit in:", number);
                Console.WriteLine("* ushort");
                Console.WriteLine("* int");
                Console.WriteLine("* uint");
                Console.WriteLine("* long ");
            }
            else if (number > ushort.MaxValue && number <= int.MaxValue)
            {
                Console.WriteLine("{0} can fit in:", number);
                Console.WriteLine("* int");
                Console.WriteLine("* uint");
                Console.WriteLine("* long ");
            }
            else if (number > int.MaxValue && number <= uint.MaxValue)
            {
                Console.WriteLine("{0} can fit in:", number);
                Console.WriteLine("* uint");
                Console.WriteLine("* long ");
            }
            else if (number > uint.MaxValue && number <= long.MaxValue)
            {
                Console.WriteLine("{0} can fit in:", number);
                Console.WriteLine("* long ");
            }
            else
            {
                Console.WriteLine("{0} can't fit in any type",number);
            }   
        }
    }
}
