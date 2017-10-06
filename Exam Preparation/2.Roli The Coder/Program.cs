using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.Roli_The_Coder
{
    class EventAndParticipants
    {
        public string Event { get; set; }
        public List<string> Participants { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var eventsRegex = new Regex(@"((?<id>\d+)\s+#(?<eventName>\w+)\s*(?<participants>(?:@[a-zA-Z0-9'-]+\s*)*))");

            Dictionary<int, EventAndParticipants> events = new Dictionary<int, EventAndParticipants>();

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "Time for Code")
                {
                    break;
                }


                var eventMatch = eventsRegex.Match(line);
                var id = int.Parse(eventMatch.Groups["id"].Value);
                var eventName = eventMatch.Groups["eventName"].Value;
                var participantsStr = eventMatch.Groups["participants"].Value;

                if (!eventMatch.Success)
                {
                    continue;
                }

                var participants = new List<string>();

                if (participantsStr.Length > 0)
                {
                    participants.AddRange(participantsStr.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                }

                if (!events.ContainsKey(id))
                {
                    var @event = new EventAndParticipants
                    {
                        Event = eventName,
                        Participants = participants
                    };

                    events[id] = @event;
                }

                if (events[id].Event == eventName)
                {
                    events[id].Participants.AddRange(participants);
                }
            }

            foreach (var @event in events)
            {
                @event.Value.Participants = @event.Value.Participants.Distinct().OrderBy(x => x).ToList();
            }

            var sortedEvents = events.OrderByDescending(x => x.Value.Participants.Count).ThenBy(y => y.Value.Event).
                   Select(x => x.Value).ToArray();

            foreach (var item in sortedEvents)
            {
                Console.WriteLine($"{item.Event} - {item.Participants.Count}");
                foreach (var itemparticipants in item.Participants)
                {
                    Console.WriteLine($"{itemparticipants}");
                }
            }
        }
    }
}


