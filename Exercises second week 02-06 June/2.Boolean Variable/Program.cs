using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            bool a = Convert.ToBoolean(str);
            if(a){
                Console.WriteLine("Yes");

            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
