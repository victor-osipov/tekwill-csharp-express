using System;

namespace lesson5._1.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface IStudentService
    {
        void AddNewStudent();

        void PrintAllStudents();

        void RemoveStudentByName();

        void WriteStudentsToFile();
    }
}
