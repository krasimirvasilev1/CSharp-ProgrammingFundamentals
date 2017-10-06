using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.String_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            String hello = "Hello";
            String world = "World";
            object helloworld = hello + " " + world;
            Console.WriteLine(helloworld);
        }
    }
}
