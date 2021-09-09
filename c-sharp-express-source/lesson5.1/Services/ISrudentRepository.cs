using System;

using Students.Domain.Entity;

namespace lesson5._1.Services
{
    public interface IStudentRepository
    {
        void AddStudent(Student student);

        void RemoveStudentById(int id);
    }

    public class FileStudentRepository : IStudentRepository
    {
        public string FileName { get; set; } = "students.txt";

        public FileStudentRepository()
        {

        }

        public void AddStudent(Student student)
        {
            // add student's name to file
            // ..
        }

        public void RemoveStudentById(int id)
        {
            // get student by id
            // remove student
        }
    }
}
