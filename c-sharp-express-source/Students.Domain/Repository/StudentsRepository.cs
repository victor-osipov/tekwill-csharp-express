using System.Collections.Generic;
using System.IO;

using Newtonsoft.Json;

using Students.Domain.Entity;

namespace Students.Domain.Repository
{
    /// <summary>
    /// this class is used for work with students data:
    ///     add (save) new student's object
    ///     remove student by id
    ///     remove student by name
    /// work should be done via text file on local disk;
    /// </summary>
    public class FileStudentsRepository : IStudentsRepository
    {
        private string fileName;

        public FileStudentsRepository(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new System.Exception("File name is wrong!");
            }

            this.fileName = fileName;
        }

        /// <summary>
        /// add the student to the collection,
        /// in this case to the text file on disk
        /// </summary>
        public void AddStudent(Student stud)
        {
            // serialize Student into JSON text (string)
            var studentJson = JsonConvert.SerializeObject(stud);

            File.AppendAllText(fileName, studentJson + "\n");
        }

        /// <summary>
        /// read all students from file
        /// and return a collection of them
        /// </summary>
        public List<Student> GetAllStudents()
        {
            var lines = File.ReadAllLines(fileName);

            var temp = new List<Student>();

            foreach (var line in lines)
            {
                var studentDeserialized = JsonConvert.DeserializeObject<Student>(line);
                temp.Add(studentDeserialized);
            }

            return temp;
        }

        public void RemoveStudentById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveStudentByName(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
