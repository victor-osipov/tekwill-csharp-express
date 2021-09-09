using System;
namespace Students.Domain.Entity
{
    public class Note : IEntity
    {
        public Note()
        {
        }

        public int Id { get; set; }

        public string Text { get; set; }

        public DateTime Date { get; set; }

        // link to Student for future
        //public Student Student { get; set; }
        public int StudentId { get; set; }
    }
}
