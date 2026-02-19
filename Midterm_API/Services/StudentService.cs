using Midterm_API.DAL;
using Midterm_API.Entities;

namespace Midterm_API.Services
{
    public class StudentService
    {
        private readonly StudentRepository _repository;

        public StudentService(StudentRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Student> GetAllStudents(int id)
        {
            return _repository.GetAll().OrderByDescending(p => p.Id);
        }

        internal object? GetAllStudents()
        {
            throw new NotImplementedException();
        }

        //Create GetSingleStudent method here
        //Accept "id" as parameter and return Student
        public Student GetSingleStudent(Student Id) => (Student)_repository.GetById(Id);
        internal object GetSingleStudent(int id)
        {
            throw new NotImplementedException();
        }

        //Create AddStudent method here
        //Accept Student object as parameter and return void
        public void AddStudent(Student student) => _repository.Add(student);
        internal object AddStudent(int id)
        {
            throw new NotImplementedException();
        }



        //Create UpdateStudent method here
        //Accept Student object as parameter and return void



        //Create DeleteStudent method here
        //Accept "id" as parameter and return void
    }
}
