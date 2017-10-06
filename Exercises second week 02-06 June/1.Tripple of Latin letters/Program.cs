using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Tripple_of_Latin_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberoflettersafterA = int.Parse(Console.ReadLine());
            for (int i = 97; i < 97+numberoflettersafterA; i++)
            {
                for (int j = 97;j < 97 + numberoflettersafterA; j++)
                {
                    for (int k = 97; k < 97+numberoflettersafterA; k++)
                    {
                        Console.WriteLine("{0}{1}{2}",(char) i,(char) j,(char) k);
                    }
                }
            }
        }
    }
}
