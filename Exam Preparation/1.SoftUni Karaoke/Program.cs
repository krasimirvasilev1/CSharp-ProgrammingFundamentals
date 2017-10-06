using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var allParticipants = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var allSongs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            while (true)
            {
                var input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var participant = input[0];

                if (participant == "dawn")
                {
                    break;
                }
                var song = input[1];
                var award = input[2];

                var isParticipant = false;
                var isSong = false;
                for (int i = 0; i < allParticipants.Count; i++)
                {
                    if (allParticipants[i] == participant)
                    {
                        isParticipant = true;
                    }
                }

                for (int i = 0; i < allSongs.Count; i++)
                {
                    if (allSongs[i] == song)
                    {
                        isSong = true;
                    }
                }

                if (isParticipant && isSong && dictionary.ContainsKey(participant))
                {
                    dictionary[participant].Add(award);
                }
                else if (isParticipant && isSong)
                {
                    dictionary[participant] = new List<string>();
                    dictionary[participant].Add(award);

                }
            }
            if (dictionary.Count != 0)
            {
                dictionary = dictionary.ToDictionary(a => a.Key, a => a.Value.Distinct().ToList());

                foreach (var singerAwards in dictionary.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    var songs = singerAwards.Value;
                    string singer = singerAwards.Key;

                    Console.WriteLine($"{singer}: {songs.Count} awards");
                    foreach (var values in songs.OrderByDescending(x => x))
                    {
                        Console.WriteLine($"--{values}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
