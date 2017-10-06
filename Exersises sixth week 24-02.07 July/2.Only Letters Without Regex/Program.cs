using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Only_Letters_Without_Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var newText = text;
            string forRemove = "";
            for (int i = 0; i < text.Length; i++)
            {
                var fromCharToString = text[i].ToString();
                int realnumber = 0;
                bool number = int.TryParse(fromCharToString, out realnumber);

                if (number)
                {
                    var realnumberToString = realnumber.ToString();
                    forRemove += realnumberToString;
                }
                if (i != 0 && forRemove != "" && !number)
                {
                    newText = newText.Replace(forRemove, text[i].ToString());
                    forRemove = "";
                }
            }

            Console.WriteLine(newText);
        }
    }
}
