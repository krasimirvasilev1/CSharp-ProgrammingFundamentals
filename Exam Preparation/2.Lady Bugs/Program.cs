using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Lady_Bugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizeOfField = int.Parse(Console.ReadLine());
            List<int> indexesOfLadyBugs = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] ladyBugs = new int[sizeOfField];

            for (int i = 0; i < indexesOfLadyBugs.Count; i++)
            {
                if (indexesOfLadyBugs[i] >= 0 && indexesOfLadyBugs[i] <= ladyBugs.Length - 1)
                {
                    ladyBugs[indexesOfLadyBugs[i]] = 1;
                }
            }

            while (true)
            {
                List<string> commands = Console.ReadLine().Split().ToList();

                if (commands[0] == "end")
                {
                    break;
                }

                int indexOfTheArray = int.Parse(commands[0]);
                string command = commands[1];
                int moveTimes = int.Parse(commands[2]);

                var changeIndex = indexOfTheArray;
                while (true)
                {
                    if (indexOfTheArray >= 0 && indexOfTheArray < ladyBugs.Length && ladyBugs[indexOfTheArray] == 1)
                    {
                        if (command == "left")
                        {
                            indexOfTheArray -= moveTimes;
                            if (indexOfTheArray < 0 || indexOfTheArray > ladyBugs.Length - 1)
                            {
                                ladyBugs[changeIndex] = 0;
                                break;
                            }

                            if (ladyBugs[indexOfTheArray] == 0)
                            {
                                ladyBugs[indexOfTheArray] = 1;
                                ladyBugs[changeIndex] = 0;
                                break;
                            }

                        }
                        else if (command == "right")
                        {


                            indexOfTheArray += moveTimes;
                            if (indexOfTheArray < 0 || indexOfTheArray > ladyBugs.Length - 1)
                            {
                                ladyBugs[changeIndex] = 0;
                                break;
                            }

                            if (ladyBugs[indexOfTheArray] == 0)
                            {
                                ladyBugs[indexOfTheArray] = 1;
                                ladyBugs[changeIndex] = 0;
                                break;
                            }

                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", ladyBugs));
        }

    }
}
