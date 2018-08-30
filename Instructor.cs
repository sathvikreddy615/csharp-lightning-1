using System;
using System.Collections.Generic;

// Directions
// Create an `Instructor` class with the following properties and fields

// 1. private fields for first name and last name
// 2. Public calculated property that returns "Firstname Lastname" of instructor
// 3. Constructor that accepts first name and last name

namespace Lightning
{
    public class Instructor : Person
    {
        // private string _firstName; // do not need {get; set;} when using private classes
        // private string _lastName; // do not need {get; set;} when using private classes

        // public string Name {get => $"{_firstName} {_lastName}"; } // makes this READ only

        public Instructor(string firstName, string lastName) 
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }

        public void AssignExercise(Student student, Exercise exercise) {
            student.AssignedExercises.Add(exercise);
        }
    }
}
