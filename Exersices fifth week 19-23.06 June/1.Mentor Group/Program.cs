using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1.Mentor_Group
{
    class Student
    {
        public List<string> comments { get; set; }
        public List<DateTime> attendanceDates { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            SortedDictionary<string, Student> allStudents = new SortedDictionary<string, Student>();


            var IsTheEndOfDates = true;
            while (IsTheEndOfDates)
            {
                var inputDates = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (inputDates[0] == "end" && inputDates[1] == "of" && inputDates[2] == "dates")
                {
                    IsTheEndOfDates = false;
                    break;

                }

                var nameDate = inputDates[0];
                List<DateTime> allDatesPerName = new List<DateTime>();

                Student newStudent = new Student
                {
                    comments = new List<string>(),
                    attendanceDates = new List<DateTime>()
                };

                var date = DateTime.ParseExact(inputDates[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                for (int i = 1; i < inputDates.Count; i++)
                {
                    
                    allDatesPerName.Add(date);
                }

                if (allStudents.ContainsKey (nameDate))
                {
                    allStudents [nameDate].attendanceDates.AddRange(date)
                }
                newStudent.attendanceDates.AddRange(allDatesPerName);

                allStudents[nameDate] = newStudent;

            }
            var IsTheEndOfComments = true;
            while (IsTheEndOfComments)
            {
                var inputComments = Console.ReadLine();
                if (inputComments == "end of comments")
                {
                    IsTheEndOfComments = false;
                    break;

                }
                var inputCommentsSplited = inputComments.Split('-').ToList();
                var nameComment = inputCommentsSplited[0];
                List<string> allCommentsPerName = inputCommentsSplited.Skip(1).ToList();

                if (allStudents.ContainsKey(nameComment))
                {
                    foreach (var item in allStudents)
                    {
                        if (item.Key == nameComment)
                        {
                            item.Value.comments.AddRange(allCommentsPerName);
                        }
                    }

                }
            }

            foreach (var item in allStudents)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine("Comments:");
                for (int i = 0; i < item.Value.comments.Count; i++)
                {
                    Console.WriteLine($"- {item.Value.comments[i]}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in item.Value.attendanceDates.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {date:dd/MM/yyyy}");
                }
            }
        }
    }
}
