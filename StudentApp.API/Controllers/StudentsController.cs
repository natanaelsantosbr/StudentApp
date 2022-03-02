using Microsoft.AspNetCore.Mvc;
using StudentApp.Core;
using StudentApp.Core.Repository;
using StudentApp.Core.Students.InputModels;
using StudentApp.Core.Students.Services;

namespace StudentApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IServiceStudents _serviceStudents;

        public StudentsController(IServiceStudents serviceStudents)
        {
            _serviceStudents = serviceStudents;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(this._serviceStudents.GetAll());            
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var student = this._serviceStudents.GetById(id);

            if(student == null) 
                return NotFound();

            return Ok(student);
        }


        [HttpPost]
        public IActionResult Post([FromBody] CreateStudentInputModel studentNew)
        {
            var student = this._serviceStudents.Add(studentNew);

            return Created("", student);

        }

        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] UpdateStudentInputModel studentChange)
        {
            var student = this._serviceStudents.Update(id, studentChange);

            if (student == null)
                return NotFound();

            return Ok(student);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var student = this._serviceStudents.Remove(id);

            if (student == null)
                return NotFound();

            return NoContent();

        }
    }
}
