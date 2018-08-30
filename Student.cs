using System;
using System.Collections.Generic;

// Directions
// Create a `Student` class with the following properties and fields

// 1. private fields for first name and last name
// 2. Public calculated property that returns "Firstname Lastname" of student
// 3. Constructor that accepts first name and last name
// 4. A public list of exercises

namespace Lightning
{
    public class Student : Person
    {
        // private string _firstName; // do not need {get; set;} when using private classes
        // private string _lastName; // do not need {get; set;} when using private classes
        // public string Name { get => $"{_firstName} {_lastName}"; } // makes this READ only

        public Student(string firstName, string lastName) {
            this._firstName = firstName;
            this._lastName = lastName;
        } 

       public List<Exercise> AssignedExercises { get; } = new List<Exercise>();
    }
}
