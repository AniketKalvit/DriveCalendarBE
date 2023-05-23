using DriveCalendarBE.Entities;
using DriveCalendarBE.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DriveCalendarBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService studentSerive;
        public StudentController(IStudentService studentSerive)
        {
            this.studentSerive = studentSerive;
        }

        // GET: api/<StudentController>
        [HttpGet]
        [Route("GetAllStudents")]
        public IActionResult GetAllStudents()
        {
            try
            {
                return new ObjectResult(studentSerive.GetAllStudents());
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent, ex);
            }
        }

        // GET api/<StudentController>/5
        [HttpGet]
        [Route("GetStudentById/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return new ObjectResult(studentSerive.GetStudentById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent, ex);
            }
        }

        // POST api/<StudentController>
        [HttpPost]
        [Route("AddStudent")]
        public IActionResult AddStudent([FromBody] Student student)
        {
            try
            {
                int result = studentSerive.AddStudent(student);
                if(result==1)
                    return StatusCode(StatusCodes.Status201Created);
                else
                    return StatusCode(StatusCodes.Status500InternalServerError);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex);
            }

        }

        // PUT api/<StudentController>/5
        [HttpPut]
        [Route("UpdateStudent")]
        public IActionResult UpdateStudent([FromBody] Student student)
        {
            try
            {
                int result = studentSerive.UpdateStudent(student);
                if (result == 1)
                    return StatusCode(StatusCodes.Status200OK);
                else
                    return StatusCode(StatusCodes.Status500InternalServerError);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex);
            }
        }

        // DELETE api/<StudentController>/5
        [HttpDelete]
        [Route("DeleteStudent/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                int result = studentSerive.DeleteStudent(id);
                if (result == 1)
                    return StatusCode(StatusCodes.Status200OK);
                else
                    return StatusCode(StatusCodes.Status500InternalServerError);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex);
            }
        }
    }
}
