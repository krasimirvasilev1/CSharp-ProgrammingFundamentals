using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Catch_the_Theif
{
    class Program
    {
        static void Main(string[] args)
        {
            String numeralType = Console.ReadLine();
            int numberOfIds = int.Parse(Console.ReadLine());
            long maximumValue = long.MinValue;
            for (int i = 1; i <= numberOfIds; i++)
            {
                long id = long.Parse(Console.ReadLine());
                if (numeralType == "sbyte" && id >= sbyte.MinValue && id <= sbyte.MaxValue)
                {
                    if (id > maximumValue)
                    {
                        maximumValue = id;
                    }
                }
                else if (numeralType == "int" && id >= int.MinValue && id <= int.MaxValue)
                {
                    if (id > maximumValue)
                    {
                        maximumValue = id;
                    }
                }
                else if (numeralType == "long" && id >= long.MinValue && id <= long.MaxValue)
                {
                    if (id > maximumValue)
                    {
                        maximumValue = id;
                    }
                }
            }
            double prisonerSentence;
            if (maximumValue < 0)
            {
                prisonerSentence = (double)maximumValue / -128;
                prisonerSentence = Math.Ceiling(Math.Abs(prisonerSentence));
            }
            else
            {
                prisonerSentence = (double)maximumValue / 127;
                prisonerSentence = Math.Ceiling(Math.Abs(prisonerSentence));
            }
           if (prisonerSentence <= 1)
            {
                Console.WriteLine("Prisoner with id {0} is sentenced to {1} year",maximumValue,prisonerSentence);
            }
            else
           {
               Console.WriteLine("Prisoner with id {0} is sentenced to {1} years", maximumValue, prisonerSentence);
           }
            
        }
    }
}
