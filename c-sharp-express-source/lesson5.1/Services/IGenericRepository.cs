using System;

using Students.Domain.Entity;

namespace lesson5._1.Services
{
    /// <summary>
    /// a generic class example
    /// </summary>
    /// <typeparam name="T">any type that we want to use</typeparam>
    public interface IGenericRepository<T>
    {
        void AddNew(T entity);

        void RemoveById(int id);
    }

    public class StudentsGenericRepository : IGenericRepository<Student>
    {
        public void AddNew(Student entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveById(int id)
        {
            throw new NotImplementedException();
        }
    }

    public class NotesRepository : IGenericRepository<Note>
    {
        public void AddNew(Note entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
