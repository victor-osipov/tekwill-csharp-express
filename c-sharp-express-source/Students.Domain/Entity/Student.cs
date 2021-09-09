using System;
using System.Collections.Generic;

namespace Students.Domain.Entity
{
    public class Student : IEntity
    {
        public Student()
        {
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDay { get; set; }

        // notes
        public List<Note> Notes { get; set; }

        // presences
        public List<Presence> Presences { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

    }
}
