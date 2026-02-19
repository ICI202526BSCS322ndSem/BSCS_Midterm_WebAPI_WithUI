using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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
			var student = _studentService.GetAllStudent(id);
			return student == null ? NotFound() : Ok(student);
		}

		//Create GetSingle endpoint here with "id" as parameter
		//return OK if found, NotFound if not found


		[HttpPost]
		public IActionResult Post([FromBody] Student student)
		{
			_studentService.CreateStudent(student);
			return Ok();
		}
		//Create AddStudent endpoint here
		//Accept Student object as parameter


		[HttpPut("{id}")]
		public IActionResult Put(int id, [FromBody] Student student) 
		{
			student.Id = id;
			_studentService.CreateStudent(student);
			return Ok();
		}

		//PUT
		//Create UpdateStudent endpoint here
		//Accept "id" as parameter and Student object as body


		[HttpDelete("{id}")]
		public IActionResult Delete (int id)
		{
			_studentService.RemoveStudent(id);
			return Ok();
		}
        //DELETE
        //Create DeleteStudent endpoint here
        //Accept "id" as parameter
       
    }
}
