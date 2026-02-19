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
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var student = _studentService.GetSingleStudent(id);
            if (student != null)
            {
                return Ok(student);
            }
            else
            {
                return NotFound();
            }
        }


        //POST
        //Create AddStudent endpoint here
        //Accept Student object as parameter
        [HttpPost]
        public IActionResult Add(Student student)
        {

           _studentService.AddStudent(student);
            return Ok(_studentService.AddStudent(student));
        }


        //PUT
        //Create UpdateStudent endpoint here
        //Accept "id" as parameter and Student object as body



        //DELETE
        //Create DeleteStudent endpoint here
        //Accept "id" as parameter

    }
}