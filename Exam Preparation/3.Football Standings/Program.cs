using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3.Football_Standings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Regex.Escape(Console.ReadLine());
            
            Dictionary<string, BigInteger> teamsRanking = new Dictionary<string, BigInteger>();
            Dictionary<string, BigInteger> mostGoalsScored = new Dictionary<string, BigInteger>();

            var regexTeams = new Regex($@"(({input}*)([^{input}]*)({input}*))");
            var regexScore = new Regex(@"(\d*)(:)(\d*)");

            while (true)
            {
                var text = Console.ReadLine();
                if (text == "final")
                {
                    break;
                }
                MatchCollection matchesTeams = regexTeams.Matches(text);
                MatchCollection results = regexScore.Matches(text);

                List<string> teamsOnEveryLine = new List<string>();

                foreach (Match item in matchesTeams)
                {
                    var team = item.Groups[3].Value;
                    var reversedTeams = team.ToUpper().Reverse().ToArray();
                    var reversedTeamsToString = new string(reversedTeams);
                    teamsOnEveryLine.Add(reversedTeamsToString);
                }

                if (!teamsRanking.ContainsKey(teamsOnEveryLine[0]))
                {
                    teamsRanking[teamsOnEveryLine[0]] = 0;
                }
                if (!teamsRanking.ContainsKey(teamsOnEveryLine[1]))
                {
                    teamsRanking[teamsOnEveryLine[1]] = 0;
                }

                if (!mostGoalsScored.ContainsKey(teamsOnEveryLine[0]))
                {
                    mostGoalsScored[teamsOnEveryLine[0]] = 0;
                }
                if (!mostGoalsScored.ContainsKey(teamsOnEveryLine[1]))
                {
                    mostGoalsScored[teamsOnEveryLine[1]] = 0;
                }

                foreach (Match item in results)
                {
                    var firstTeamResult = ulong.Parse(item.Groups[1].Value);
                    var secondTeamResult = ulong.Parse(item.Groups[3].Value);

                    if (firstTeamResult > secondTeamResult)
                    {
                        teamsRanking[teamsOnEveryLine[0]] += 3;
                    }
                    else if (firstTeamResult == secondTeamResult)
                    {
                        teamsRanking[teamsOnEveryLine[0]] += 1;
                        teamsRanking[teamsOnEveryLine[1]] += 1;
                    }
                    else if (firstTeamResult < secondTeamResult)
                    {
                        teamsRanking[teamsOnEveryLine[1]] += 3;
                    }

                    mostGoalsScored[teamsOnEveryLine[0]] += firstTeamResult;
                    mostGoalsScored[teamsOnEveryLine[1]] += secondTeamResult;
                }

            }
            Console.WriteLine("League standings:");
            var rankings = 1;

            foreach (var item in teamsRanking.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{rankings}. {item.Key} {item.Value}");
                rankings++;
            }

            var counter = 0;
            Console.WriteLine("Top 3 scored goals:");
            foreach (var item in mostGoalsScored.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
            {
                if (counter == 3)
                {
                    break;
                }
                
                Console.WriteLine($"- {item.Key} -> {item.Value}");
                counter++;
            }
        }
    }
}
