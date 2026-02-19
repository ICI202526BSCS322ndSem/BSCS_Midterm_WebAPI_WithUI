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
        private readonly object _students;

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
        //Create GetSingle endpoint here with "id" as para meter
        //return OK if found, NotFound if not found
        [HttpGet("{id}")]
        public ActionResult<Student> GetById(int id)
        {
            var student = _studentService.GetById(id);
            if (student is null) return NotFound(new { message = $"Student with id {id} not found." });
            return Ok(student);
        }

        public object Get_students()
        {
            return _students;
        }

        //POST
        //Create AddStudent endpoint here
        //Accept Student object as parameter
        // POST /api/student
        [HttpPost]
        public ActionResult<Student> Create([FromBody] Student student, object _students)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                var created = _students.Create(student);
                return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }


        //PUT
        //Create UpdateStudent endpoint here
        //Accept "id" as parameter and Student object as body
        public ActionResult<Student> Update([FromBody] Student student, object _students)
        {
            
        }


        //DELETE
        //Create DeleteStudent endpoint here
        //Accept "id" as parameter
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = _studentService.Delete(id);
            if (!deleted) return NotFound(new { message = $"Student with id {id} not found." });
            return Ok(new { message = $"Student {id} deleted successfully." });
        }
    }
}