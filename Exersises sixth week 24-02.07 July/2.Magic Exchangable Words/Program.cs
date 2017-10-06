using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Magic_Exchangable_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                var input = Console.ReadLine().Split().ToList();
                var firstWord = string.Join("", input[0].Distinct());
                var secondWord = string.Join("", input[1].Distinct());

                var match = false;

                if (firstWord.Length == secondWord.Length)
                {
                    match = true;
                }

                if (!match)
                {
                    Console.WriteLine("false");
                }
                else
                {
                    Console.WriteLine("true");
                }


            }
        }
    }
}
