using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Karate_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var result = "";
            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] == '>')
                {
                    result += '>';
                    var strength = int.Parse(text[i+1].ToString());
                    for (int k = 0; k < strength; k++)
                    {
                        i++;
                        if(i < text.Length && text[i] == '>')
                        {
                            result += '>';
                            strength += int.Parse(text[i + 1].ToString()) + 1;
                        }
                    }
                }
                else
                {
                    result += text[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
