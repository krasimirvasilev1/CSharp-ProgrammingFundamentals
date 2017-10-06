using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            String proffesion = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            if(proffesion == "Athlete")
            {
                Console.WriteLine("The {0} has to pay {1}",proffesion,(quantity*0.70).ToString("F2"));
            }
            else if(proffesion == "Businessman" || proffesion == "Businesswoman")
            {
                Console.WriteLine("The {0} has to pay {1}", proffesion, (quantity * 1).ToString("F2"));
            }
            else if (proffesion == "SoftUni Student")
            {
                Console.WriteLine("The {0} has to pay {1}", proffesion, (quantity * 1.70).ToString("F2"));
            }
            else
            {   
                Console.WriteLine("The {0} has to pay {1}", proffesion, (quantity * 1.20).ToString("F2"));
            }
        }
    }
}
