using DriveCalendarBE.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DriveCalendarBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IDashboardService servie;
        public DashboardController(IDashboardService servie)
        {
            this.servie = servie;
        }
        [HttpGet]
        [Route("GetTotalDriveCount")]
        public IActionResult GetTotalDriveCount()
        {
            try
            {
                return new ObjectResult(servie.GetTotalDriveCount());

            }
            catch(Exception ex)
            {
               return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
            
        }
        [HttpGet]
        [Route("GetTotalPlacementCount")]
        public IActionResult GetTotalPlacementCount()
        {
            try
            {
                return new ObjectResult(servie.GetTotalPlacementCount());

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
        [HttpGet]
        [Route("GetTotalStudentApplied")]
        public IActionResult GetTotalStudentApplied()
        {
            try
            {
                return new ObjectResult(servie.GetTotalStudentApplied());

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
        [HttpGet]
        [Route("GetTotalStudentCount")]
        public IActionResult GetTotalStudentCount()
        {
            try
            {
                return new ObjectResult(servie.GetTotalStudentCount());

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
        [HttpGet]
        [Route("GetTotalStudentShortlisted")]
        public IActionResult GetTotalStudentShortlisted()
        {
            try
            {
                return new ObjectResult(servie.GetTotalStudentShortlisted());

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
        [HttpGet]
        [Route("GetTotalRejectedStudents")]
        public IActionResult GetTotalRejectedStudents()
        {
            try
            {
                return new ObjectResult(servie.GetTotalRejectedStudents());

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
    }
}
