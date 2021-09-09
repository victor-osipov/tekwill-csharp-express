namespace lesson5._1.Services
{
    /// <summary>
    /// our common interface for any student services
    /// </summary>
    public interface IStudentService
    {
        void AddNewStudent();

        void PrintAllStudents();

        void RemoveStudentByName();

        void WriteStudentsToFile();
    }
}
