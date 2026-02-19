
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

        //Create GetSingleStudent method here
        //Accept "id" as parameter and return Student

        public Student GetAllStudents(int id) => _repository.GetById(id);


        //Create AddStudent method here
        //Accept Student object as parameter and return void

        public void CreateStudents(Student student) => _repository.Add(student);

        //Create UpdateStudent method here
        //Accept Student object as parameter and return void

        public void UpdateStudents(Student student) => _repository.Update(student);

        //Create DeleteStudent method here
        //Accept "id" as parameter and return void

        public void RemoveStudents(int id) => _repository.Delete(id);

        internal void RemoveStudent(int id)
        {
            throw new NotImplementedException();
        }
    }
}
