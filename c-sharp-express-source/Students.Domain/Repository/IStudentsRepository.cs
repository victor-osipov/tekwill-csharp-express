
using System.Collections.Generic;

using Students.Domain.Entity;

namespace Students.Domain.Repository
{
    /// <summary>
    /// this interface is one common data contract
    /// for dealing with Students data
    /// </summary>
    public interface IStudentsRepository
    {
        void AddStudent(Student obj);

        void RemoveStudentById(int id);

        void RemoveStudentByName(string name);

        List<Student> GetAllStudents();
    }
}
