using System;
using System.Collections.Generic;
using System.Linq;


namespace CG_13_2_High_School
{
    class Program
    {
        static void Main(string[] args)
        {
            //This block of code sets up the Students class into a list that will be used for the 
            //program.
            List<Students> school = new List<Students>()
            {
                new Students {FirstName = "Alicia", LastName = "Wilson", GradeLevel = 5, GPA = 3.5},
                new Students {FirstName = "Andrew", LastName = "Sistek", GradeLevel = 9, GPA = 3.7},
                new Students {FirstName = "Austin", LastName = "Brown", GradeLevel = 12, GPA = 1.6},
                new Students {FirstName = "Matt", LastName = "Welker", GradeLevel = 8, GPA = 2.3},
                new Students {FirstName = "Jessica", LastName = "Burgett", GradeLevel = 10, GPA=3.0},
                new Students {FirstName = "Jacob", LastName = "Wilson", GradeLevel = 3, GPA = 4.0},
                new Students {FirstName = "A.J.", LastName = "Steinbring", GradeLevel = 11, GPA=4.0},
                new Students {FirstName = "Erich", LastName = "Borrman", GradeLevel = 10, GPA = 2.7},
                new Students {FirstName = "Abigail", LastName = "Reynolds", GradeLevel = 1, GPA = 4.0},
                new Students {FirstName = "Jeffery", LastName = "Proud", GradeLevel = 7, GPA = 1.5},
                new Students {FirstName = "Anne", LastName = "Royall", GradeLevel = 9, GPA = 3.5},
                new Students {FirstName = "Henry", LastName = "Rollins", GradeLevel = 12, GPA = 2.0},
            };


            //This is the LINQ coding, narrowing down what we are looking for to form a list.
            var highschool = school.Where(s => s.GradeLevel > 8)
            .Where(s => s.GPA >= 3.0)
            .OrderByDescending(s => s.GradeLevel)
            .ThenByDescending(s => s.GPA)
            .ThenByDescending(s => s.LastName)
            .ThenByDescending(s => s.FirstName);
            

           //This is a loop statement to take all the names that came out of out search and plug
           //those names into the Console.WriteLine statement.
            foreach (var student in highschool)
            {
                Console.WriteLine("{0} {1} is in {2} grade with a GPA of {3}.",
                    student.FirstName, student.LastName, student.GradeLevel, student.GPA);
            }

            Console.ReadLine();
        }
    }
}
