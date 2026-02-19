using Midterm_API.DAL;
using Midterm_API.Entities;

namespace Midterm_API.Services
{
    public class StudentService
    {
        private readonly StudentRepository _repository;
        private readonly List<Student>
            _student = new List<Student>();
        public class student
        { 
          
        }
        
        public StudentService(StudentRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _repository.GetAll().OrderByDescending(p => p.Id);
        }

        public IEnumerable<Student> GetStudent() => _repository.GetSingleStudent().ToString(p => p.Id);

        internal object? GetSingleStudent()
        {
            throw new NotImplementedException();
        }


        //Create GetSingleStudent method here
        //Accept "id" as parameter and return Student



        //Create AddStudent method here
        //Accept Student object as parameter and return void



        //Create UpdateStudent method here
        //Accept Student object as parameter and return void



        //Create DeleteStudent method here
        //Accept "id" as parameter and return void
    }
}
