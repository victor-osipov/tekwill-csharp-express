using System;

using Students.Domain.Entity;
using Students.Domain.Repository;

namespace Students.Domain.Service
{
    /// <summary>
    /// this service should wrap all business logic
    /// related to Students;
    /// </summary>
    public class StudentService : IStudentService
    {
        private IStudentsRepository studentsRepository;

        /// <summary>
        /// service constructor accepting repository as a parameter
        /// </summary>
        public StudentService(IStudentsRepository studentsRepository)
        {
            this.studentsRepository = studentsRepository;
        }

        public void CreateStudent()
        {
            Console.WriteLine("please enter first name:");
            var firstName = Console.ReadLine();

            Console.WriteLine("please enter last name:");
            var lastName = Console.ReadLine();

            var student1 = new Student
            {
                FirstName = firstName,
                LastName = lastName,
                BirthDay = DateTime.Now,
                Id = default
            };

            studentsRepository.AddStudent(student1);
        }

        public void PrintAllStudents()
        {
            var all = studentsRepository.GetAllStudents();

            foreach (var stud in all)
            {
                Console.WriteLine(stud.GetFullName());
            }
        }
    }
}
