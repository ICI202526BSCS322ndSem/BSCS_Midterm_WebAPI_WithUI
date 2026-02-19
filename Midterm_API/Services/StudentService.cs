//Herrera Karylle Ann I. BSCS 3-2
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

        //Create SingleStudent method here
        //Accept "id" as parameter and return void
        public Student GetSingleStudent(int Id) => _repository.GetById(Id);

        //Create CreateStudent method here
        //Accept "id" as parameter and return void
        public void CreateStudent(Student student) => _repository.Add(student);

        //Create UpdateStudent method here
        //Accept "id" as parameter and return void
        public void UpdateStudent(Student student) => _repository.Update(student);


        //Create DeleteStudent method here
        //Accept "id" as parameter and return void
        public void DeleteStudent (int Id) => _repository.Delete(Id);
    }
}
