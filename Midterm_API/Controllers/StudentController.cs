using Microsoft.AspNetCore.Mvc;
using Midterm_API.Entities;
using Midterm_API.Services;
using System.Security.Cryptography.X509Certificates;

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
            var student = _studentService.GetAllStudent(id);
            return (student) == null ? NotFound() : Ok(student);
        }



        //POST
        //Create AddStudent endpoint here
        //Accept Student object as parameter
        [HttpPost]
        public IActionResult Post([FromBody] Student student)
        {
            _studentService.CreateStudent(student);
            return Ok();


            //PUT
            //Create UpdateStudent endpoint here
            //Accept "id" as parameter and Student object as body

        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Student student)
        {
            _studentService.CreateStudent(student);
            return Ok();

            //DELETE
            //Create DeleteStudent endpoint here
            //Accept "id" as parameter
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _studentService.RemoveStudent(id);
            return Ok();

        }
    }
}