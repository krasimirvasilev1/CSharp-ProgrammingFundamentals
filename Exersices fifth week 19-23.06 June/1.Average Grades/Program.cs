using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Average_Grades
{
    class Student
    {
        public string student { get; set; }
        public List<double> grades { get; set; }
        public double averageGrades { get; set; }
    }


    class Program
    {

        static void Main(string[] args)
        {
            List<Student> allStudents = new List<Student>();
            int numberOfStudents = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfStudents; i++)
            {

                List<string> input = Console.ReadLine().Split().ToList();
                List<double> gradesStudents = new List<double>();
                double allSum = 0;

                // Средна аритметична оценка на студент , дели се на броя на елементите на input - 1 , заради name //

                for (int j = 1; j < input.Count; j++)
                {

                    gradesStudents.Add(double.Parse(input[j]));
                    allSum += double.Parse(input[j]);
                }

                double averageSumOfASingleStudent = allSum / (input.Count - 1);

                Student informationAboutStudent = new Student
                {
                    student = input[0],
                    grades = gradesStudents,
                    averageGrades = averageSumOfASingleStudent

                };

                allStudents.Add(informationAboutStudent);
                allStudents = new List<Student>(allStudents.Where(p => p.averageGrades >= 5).OrderBy(w => w.student).ThenByDescending(x => x.averageGrades));
            
            }

            foreach (var item in allStudents)
            {
                Console.WriteLine($"{item.student} -> {item.averageGrades:F2}");
            }
        }
    }
}

