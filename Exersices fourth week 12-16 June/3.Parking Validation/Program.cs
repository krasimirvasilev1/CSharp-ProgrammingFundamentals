using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Parking_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            int commands = int.Parse(Console.ReadLine());

            var dictionary = new Dictionary<string, string>();

            for (int i = 1; i <= commands; i++)
            {
                var input = Console.ReadLine().Split().ToList();

                var enteringOrLeaving = "";
                var name = "";
                var registrationNumber = "";
                char[] firstLetters = new char[2];
                char[] lastLetters = new char[2];
                char[] charMiddle = new char[4];
                string middle = "";
                if (input.Count != 2)
                {

                    enteringOrLeaving = input[0];
                    name = input[1];
                    registrationNumber = input[2];
                    firstLetters = registrationNumber.Take(2).ToArray();
                    lastLetters = registrationNumber.Reverse().Take(2).ToArray();
                    charMiddle = registrationNumber.Skip(2).Take(4).ToArray();
                    middle = new string(charMiddle);

                }
                else
                {
                    enteringOrLeaving = input[0];
                    name = input[1];
                }

                //проверяване дали една променлива е число 
                int n;
                bool isNumeric = int.TryParse(middle, out n);

                if (enteringOrLeaving == "register")
                {
                    if (registrationNumber.Length == 8 && firstLetters[0] <= 'Z' && firstLetters[0] >= 'A' && firstLetters[1] <= 'Z' && firstLetters[1] >= 'A'
                        && lastLetters[0] <= 'Z' && lastLetters[0] >= 'A' && lastLetters[1] <= 'Z' && lastLetters[1] >= 'A' && isNumeric)
                    {
                        var IsBusyDontOutputNothingElse = false;
                        foreach (var item in dictionary)
                        {
                            
                            if (item.Value == registrationNumber)
                            {
                                Console.WriteLine("ERROR: license plate {0} is busy", registrationNumber);
                                IsBusyDontOutputNothingElse = true;
                                break;
                            }
                        }
                        if (!IsBusyDontOutputNothingElse)
                        {
                            dictionary[name] = registrationNumber;
                            Console.WriteLine("{0} registered {1} successfully", name, registrationNumber);
                        }
                    }

                    else
                    {
                        Console.WriteLine("ERROR: invalid license plate {0}", registrationNumber);
                    }

                }
                else if (enteringOrLeaving == "unregister")
                {
                    if (dictionary.ContainsKey(name))
                    {
                        Console.WriteLine("user {0} unregistered successfully", name);
                        dictionary.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine("ERROR: user {0} not found", name);
                    }
                }
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
            
        }

    }
}

