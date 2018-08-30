using System;
using System.Collections.Generic;

namespace Lightning
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create some cohorts, students, and instructors in your `Program.cs` and assign the students and instructors to the cohort
            Cohort Cohort26 = new Cohort();

            Student SathvikReddy = new Student("Sathvik", "Reddy");
            Student SethDana = new Student("Seth", "Dana");

            Instructor JisieDavid = new Instructor("Jisie", "David");
            Instructor SteveBrownlee = new Instructor("Steve", "Brownlee");

            Cohort26.InstructorList.Add(JisieDavid);
            Cohort26.InstructorList.Add(SteveBrownlee);

            Cohort26.StudentList.Add(SathvikReddy);
            Cohort26.StudentList.Add(SethDana);
            
            // 1. Create some exercises
            // 2. Write a method on the `Instructor` class that will allow you to assign an individual exercise to an individual student
            
            Exercise Loops = new Exercise();
            Loops.Name = "For Loops";
            Loops.GitHubUrl = "www.github.com/for-loops";
            Loops.Language = "JavaScript";

            Exercise Conditionals = new Exercise();
            Conditionals.Name = "Conditional Statements";
            Conditionals.GitHubUrl = "www.github.com/conditionals";
            Conditionals.Language = "C#";
            
            SteveBrownlee.AssignExercise(SathvikReddy, Loops);
            JisieDavid.AssignExercise(SathvikReddy, Conditionals);
            JisieDavid.AssignExercise(SethDana, Conditionals);

            // Pick one of the students and write to the Console each exercise that has been assigned to that student
            foreach (Exercise exercise in SathvikReddy.AssignedExercises)
            {
                Console.WriteLine($"{SathvikReddy.Name} has been assigned {exercise.Name} for homework tonight");
            }
        }
    }
}
