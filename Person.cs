using System;
using System.Collections.Generic;

namespace Lightning {
    public class Person 
    {
        protected string _firstName; // do not need {get; set;} when using protected classes
        protected string _lastName; // do not need {get; set;} when using private classes

        public string Name {get => $"{_firstName} {_lastName}"; } // makes this READ only
    }
}
