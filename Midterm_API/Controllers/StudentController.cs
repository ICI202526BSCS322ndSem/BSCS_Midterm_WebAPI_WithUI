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

        //GET
        //Create GetSingle endpoint here with "id" as parameter
        //return OK if found, NotFound if not found


        //POST
        //Create AddStudent endpoint here
        //Accept Student object as parameter
        [HttpGet]
        public ActionResult <Student> Create([FromBody] Student student)
        {
            if (student == null)
                return BadRequest();

            _students.Add(student);
            return CreatedAtAction(nameof(GetById), new { id = student.Id }, student);
        }


        //PUT
        //Create UpdateStudent endpoint here
        //Accept "id" as parameter and Student object as body
        [HttpPut("{id}")]
        public ActionResult<Student> Update(int id, [FromBody] Student student)
        {
            var existing = _students.FirstOrDefault(s => s.Id == id);
            if (existing == null)
                return NotFound();

            existing.Name = _student.Name;
            return Ok(existing);
             
        }
        //DELETE
        //Create DeleteStudent endpoint here
        //Accept "id" as parameter
        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            var deleted = _studentService.Delete(id);
            if (!deleted) return NotFound(new { message = $"Student with Id {id} not found" });
            return Ok(new { message = $"Student {id} deleted successfully " });

        }

}