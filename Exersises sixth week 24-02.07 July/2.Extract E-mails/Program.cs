using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.Extract_E_mails
{
    class Program
    {
        static void Main(string[] args)
        {
            
           Regex rx = new Regex(@"\b(([\d\w]+)([\w]|\.|\-|_)([\d\w]+))(@)(([\w]+)([\w]|\-)([\w]+)(.)([\w]+)([\w]|\.)([\w]+))\b");

           var input = Console.ReadLine();

            MatchCollection matchCollection = rx.Matches(input);

            foreach (Match item in matchCollection)
            {
                Console.WriteLine(item.Value);
            }
    }
    }
}
