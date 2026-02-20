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

        public IEnumerable<Student> GetAllStudents()
        {
            return _repository.GetAll().OrderByDescending(p => p.Id);
        }

        public Student GetSingleStudent(int id) => _repository.GetById(id);
        //Create GetSingleStudent method here
        //Accept "id" as parameter and return Student


        public void AddStudent(Student student) => _repository.Add(student);
        //Create AddStudent method here
        //Accept Student object as parameter and return void


        public void UpdateStudent(Student student) => _repository.Update(student);
        //Create UpdateStudent method here
        //Accept Student object as parameter and return void


        public void DeleteStudent(int id) => _repository.Delete(id);
        //Create DeleteStudent method here
        //Accept "id" as parameter and return void
    }
}
