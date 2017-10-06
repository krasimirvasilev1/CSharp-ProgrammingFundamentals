using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            var usersIpsCounts = new Dictionary<string, Dictionary<string, int>>();

            var line = Console.ReadLine();

            while (line != "end")
            {
                var tokens = line.Split();

                var ip = tokens[0].Split('=')[1];
                var username = tokens[2].Split('=')[1];

                if (!usersIpsCounts.ContainsKey(username))
                {
                    usersIpsCounts[username] = new Dictionary<string, int>();
                }

                if (!usersIpsCounts[username].ContainsKey(ip))
                {
                    usersIpsCounts[username][ip] = 0;
                }

                usersIpsCounts[username][ip]++;

                line = Console.ReadLine();
            }

            foreach (var item in usersIpsCounts)
            {
                Console.WriteLine($"");
            }

              
            return;

            var userNameAndIP = new SortedDictionary<string, List<string>>();
            var ipAndCount = new Dictionary<string, int>();

            while (true)
            {
                List<string> input = Console.ReadLine().Split().ToList();

                if (input[0] == "end")
                {
                    break;
                }

                string ip = input[0].Substring(3);
                string user = input[2].Substring(5);
                var count = 1;
                if (!userNameAndIP.ContainsKey(user))
                {
                    userNameAndIP[user] = new List<string>();
                }
                if (!userNameAndIP[user].Contains(ip))
                {
                    userNameAndIP[user].Add(ip);
                }
               
                if (ipAndCount.ContainsKey(ip))
                {
                    var grade = 0;
                    ipAndCount.TryGetValue(ip,out grade);
                    ipAndCount[ip] = count + grade;
                }
                else
                {
                    ipAndCount[ip] = count;
                }     
            }
            foreach (var item in userNameAndIP)
            {
                var user = item.Key;
                var ips = item.Value;
                Console.WriteLine($"{user}: ");
                List<string> output = new List<string>();
                foreach (var ip in ips)
                {
                    var ipCount = ipAndCount[ip];
                   output.Add($"{ip} => {ipCount}");
                }
                Console.WriteLine(string.Join(", ",output)+".");
            }
        }
    }
}
