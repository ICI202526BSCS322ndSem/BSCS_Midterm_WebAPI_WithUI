using Microsoft.AspNetCore.Mvc;
using Midterm_API.Entities;
using Midterm_API.Services;

namespace Midterm_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentService _studentService;

        public StudentController(StudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_studentService.GetAllStudents());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var student = _studentService.GetSingleStudent(id);
            return student == null? NotFound() : Ok(student);
        }
        //GET
        //Create GetSingle endpoint here with "id" as parameter
        //return OK if found, NotFound if not found

        [HttpPost]
        public IActionResult Post(Student student)
        {
            _studentService.AddStudent(student);
            return Ok();
        }
        //POST
        //Create AddStudent endpoint here
        //Accept Student object as parameter

        [HttpPut("{id}")]
        public IActionResult Put(int id, Student student)
        {
            student.Id = id;
            _studentService.AddStudent(student);
            return Ok();
        }
        //PUT
        //Create UpdateStudent endpoint here
        //Accept "id" as parameter and Student object as body

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _studentService.DeleteStudent(id);
            return Ok();
        }
        //DELETE
        //Create DeleteStudent endpoint here
        //Accept "id" as parameter
       
    }
}