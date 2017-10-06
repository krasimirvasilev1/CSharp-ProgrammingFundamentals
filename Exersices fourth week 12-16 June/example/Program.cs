using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstCat = new Cat();
            var secondCat = new Cat();
            var thirdCat = new Cat();

            firstCat.Name = "Pesho";
            secondCat.Name = "Georgi";
            thirdCat.Name = "Marto";

            firstCat.Age = 24;
            secondCat.Age = 13;
            thirdCat.Age = 33;

            Console.WriteLine(firstCat.SayHello());
         }
    }
}
