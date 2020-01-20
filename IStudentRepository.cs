using System.Collections.Generic;

namespace CRUDStudentApp
{
    public interface IStudentRepository
    {
        public Student GetStudentById(int id);
        public Student Create(int id, string firstName, string lastName, string phone);
        public Student Update(Student student);
        public Student Delete(Student student);

        public IEnumerable<Student> GetAllStudents { get; }
    }
}