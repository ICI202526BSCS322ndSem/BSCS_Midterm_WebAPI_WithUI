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
            return Ok(_studentService.GetStudents());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var student = _studentService.GetStudent(id);
            return student == null ? NotFound() : Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Student student)
        {
            _studentService.AddStudent(student);
            return Created();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Student student)
        {
            student.Id = id;
            _studentService.UpdateStudent(student);
            return student == null ? NotFound() : Ok();

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var studentExist = _studentService.GetStudent(id);
            if (studentExist == null)
            {
                return NotFound();
            }
            _studentService.DeleteStudent(id);
            return Ok();
        }

        //GET
        //Create GetSingle endpoint here with "id" as parameter
        //return OK if found, NotFound if not found


        //POST
        //Create AddStudent endpoint here
        //Accept Student object as parameter



        //PUT
        //Create UpdateStudent endpoint here
        //Accept "id" as parameter and Student object as body



        //DELETE
        //Create DeleteStudent endpoint here
        //Accept "id" as parameter

    }
}