using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Hornet_Armada
{
    class Army
    {
        public string SoldierType { get; set; }
        public int SoldierCount { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> legionNameAndActivity = new Dictionary<string, int>();
            Dictionary<string, List<Army>> legionNameAndListArmy = new Dictionary<string, List<Army>>();

            int rotations = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rotations; i++)
            {
                List<string> inputArmy = Console.ReadLine().Split(new char[] { ' ', '=', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                var lastActivity = int.Parse(inputArmy[0]);
                var legionName = inputArmy[1];
                var soldierType = inputArmy[2];
                var soldierCount = int.Parse(inputArmy[3]);

                Army newArmy = new Army
                {
                    SoldierType = soldierType,
                    SoldierCount = soldierCount
                };

                if (!legionNameAndActivity.ContainsKey(legionName))
                {
                    legionNameAndActivity[legionName] = lastActivity;
                    legionNameAndListArmy[legionName] = new List<Army>();
                    legionNameAndListArmy[legionName].Add(newArmy);
                }
                else
                {
                    var occuarance = 0;
                    foreach (var item in legionNameAndListArmy)
                    {
                        if (item.Key == legionName)
                        {
                            foreach (var element in item.Value.OrderByDescending(x => x.SoldierCount))
                            {
                                if (element.SoldierType == soldierType)
                                {

                                    element.SoldierCount += soldierCount;
                                    occuarance++;
                                    break;
                                }
                            }
                        }
                        if (occuarance > 0)
                        {
                            break;
                        }
                    }
                    if (occuarance == 0)
                    {
                        legionNameAndListArmy[legionName].Add(newArmy);
                    }

                    var valueOfLastActivity = legionNameAndActivity[legionName];
                    if (valueOfLastActivity < lastActivity)
                    {
                        legionNameAndActivity[legionName] = lastActivity;
                    }
                }
            }
            

            var finalInput = Console.ReadLine().Split('\\').ToList();
            Dictionary<string,int> legionsWithLowerActivity = new Dictionary<string, int>();
            if (finalInput.Count > 1)
            {
                var activity = int.Parse(finalInput[0]);
                var soldierType = finalInput[1];

                legionsWithLowerActivity = legionNameAndActivity.Where(y => y.Value < activity).ToDictionary(x => x.Key, x => x.Value);
                
                foreach (var item in legionsWithLowerActivity)
                {
                    foreach (var element in legionNameAndListArmy.OrderByDescending(x => x.Value))
                    {
                        if (item.Key == element.Key)
                        {
                            foreach (var elementValue in element.Value.OrderBy(x => x.SoldierCount))
                            {
                                if (elementValue.SoldierType == soldierType)
                                {
                                    Console.WriteLine($"{element.Key} -> {elementValue.SoldierCount}");
                                }
                            }
                        }
                    }
                }

            }
        }
    }
}
