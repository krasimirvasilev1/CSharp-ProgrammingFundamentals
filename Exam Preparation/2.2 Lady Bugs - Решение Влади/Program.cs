using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_Lady_Bugs___Решение_Влади
{
    class Program
    {
        static void Main(string[] args)
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var ladyBugIndexex = Console.ReadLine().Split().Select(int.Parse).Where(a => a >= 0 && a < fieldSize).ToArray();

            var ladyBug = new int[fieldSize];

            foreach (var ladyBugIndex in ladyBugIndexex)
            {
                ladyBug[ladyBugIndex] = 1;
            }

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                var tokens = line.Split();
                var ladyBugIndex = int.Parse(tokens[0]);
                var direction = tokens[1];
                var count = int.Parse(tokens[2]);

                var isInsideArray = (ladyBugIndex >= 0 && ladyBugIndex < ladyBug.Length);

                if (!isInsideArray)
                {
                    continue;
                }

                var ladyBugExist = ladyBug[ladyBugIndex] == 1;
                if (!ladyBugExist)
                {
                    continue;
                }
                MoveLadyBug(ladyBug, ladyBugIndex, direction, count);
            }
            Console.WriteLine(string.Join(" ", ladyBug));
        }

        static void MoveLadyBug(int[] ladyBug, int ladyBugIndex, string direction, int count)
        {
            if (direction == "left")
            {
                count = -count;
            }
            var nextIndex = ladyBugIndex + count;

            ladyBug[ladyBugIndex] = 0;
            var hasLeftTheArrayOrFoundPlace = false;

            while (!hasLeftTheArrayOrFoundPlace)
            {
                if (nextIndex < 0 || nextIndex > ladyBug.Length-1)
                {
                    hasLeftTheArrayOrFoundPlace = true;
                    continue;
                }

                var ladyBugAlreadyExistOnIndex = ladyBug[nextIndex] == 1;
                if (ladyBugAlreadyExistOnIndex)
                {
                    nextIndex += count;
                    continue;
                }

                ladyBug[nextIndex] = 1;
                hasLeftTheArrayOrFoundPlace = true;
            }

        }
    }
}
