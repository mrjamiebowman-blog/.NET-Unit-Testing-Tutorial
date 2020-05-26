﻿using System;

namespace UnitTestingTut.Models
{
    public abstract class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Twitter { get; set; }

        public DateTime? Birthdate { get; set; }
    }
}
