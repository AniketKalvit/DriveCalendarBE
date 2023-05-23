using DriveCalendarBE.Entities;
using DriveCalendarBE.Repository;
using DriveCalendarBE.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DriveCalendarBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService usersService;
        private readonly IConfiguration configuration;
        public UsersController(IUsersService usersService, IConfiguration configuration)
        {
            this.usersService = usersService;
            this.configuration = configuration; 
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register([FromBody] Users users)
        {
            try
            {
                int result = usersService.Register(users);
                if (result == 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest,ex);
            }
        }
        [HttpPost]
        [Route("Login")]
        public IActionResult Login([FromBody]Users user)
        {
            try
            {
                LoginOutput u = usersService.Login(user);
                if (u!=null)
                {
                    return Ok(u);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex);
            }
        }
        [HttpGet]
        [Route("GetUserByRolePE")]
       public IActionResult GetUserByRolePE()
        {
            try
            {
                return new ObjectResult(usersService.GetUserOfPE());
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex);
            }

        }
    }
}
