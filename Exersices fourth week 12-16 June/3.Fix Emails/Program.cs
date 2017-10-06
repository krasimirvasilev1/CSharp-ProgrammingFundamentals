using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            bool inputContinues = true;
            var counter = 1;
            var nameAndEmail = new Dictionary<string, string>();
            while (inputContinues)
            {
                string name = Console.ReadLine();
                if (name == "stop")
                {
                    inputContinues = false;
                    break;
                }
                List<string> email = Console.ReadLine().Split('.').ToList();
                if (email[1] != "us" || email[1] != "uk")
                {
                    if (email[1] != "us" || email[1] != "uk")
                    {
                        var rightEmail = email[0] + "." + email[1];
                        nameAndEmail[name] = rightEmail;
                    }
                   
                }
            }
            Console.WriteLine();
            foreach (var item in nameAndEmail)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
