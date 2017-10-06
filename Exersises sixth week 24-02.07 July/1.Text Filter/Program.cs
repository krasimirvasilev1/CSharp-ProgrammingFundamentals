using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> banWords = Console.ReadLine().Split(new char[] {',',' '},StringSplitOptions.RemoveEmptyEntries).ToList();
            var text = Console.ReadLine();

            var replacedString = text;
            

            foreach (var item in banWords)
            {
                    string wordToReplace = new string('*', item.Length);
                    replacedString = replacedString.Replace(item, wordToReplace);
                    
               
            }
            Console.WriteLine(replacedString);
        }
    }
}
