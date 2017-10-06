using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Order_By_Age
{
    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        { 
            List<Person> allPeople = new List<Person>();
            var isDifferentThanEnd = true;
            while (isDifferentThanEnd)
            {
                var input = Console.ReadLine().Split().ToArray();
                if (input[0] == "End")
                {
                    isDifferentThanEnd = false;
                    break;
                }

                Person newPerson = new Person
                {
                    Name = input[0],
                    ID = input[1],
                    Age = int.Parse(input[2])
                };
                allPeople.Add(newPerson);
            }

            foreach (var item in allPeople.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{item.Name} with ID: {item.ID} is {item.Age} years old.");
            }
        }
    }
}
