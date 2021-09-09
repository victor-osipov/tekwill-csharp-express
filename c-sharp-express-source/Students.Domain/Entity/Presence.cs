using System;
namespace Students.Domain.Entity
{
    public class Presence : IEntity
    {
        public Presence()
        {
        }

        public int Id { get; set; }

        public DateTime Date { get; set; }

        public bool IsPresent { get; set; }

        // link to student
        //public int StudentId { get; set; }
    }
}
