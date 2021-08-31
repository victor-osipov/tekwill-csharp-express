using System;
using System.Collections.Generic;

namespace lesson5._1.Model
{
    /// <summary>
    /// This class is used to store data
    /// about Student;
    ///     fields:
    ///        first name
    ///        last name
    ///        registered date
    ///     functions:
    ///         get full name
    ///         get registered days
    /// objects of this class should act as data transfer objects
    ///     (store data, transfer data);
    /// </summary>
    public class Student
    {
        public Student()
        {
        }

        public string FirstName;

        public string LastName;

        public DateTime Registered;

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
