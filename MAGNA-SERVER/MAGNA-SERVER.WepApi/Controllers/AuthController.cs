using MAGNA_SERVER.Services;
using MAGNA_SERVER.WebApi.Configurations;
using MAGNA_SERVER.WebApi.DataTransferObject;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAGNA_SERVER.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        ITokenHandlerService _service;

        /// <summary>
        /// builder authController
        /// /// </summary>
        /// <remarks>
        /// We are going to create two endpoints, one to register the user and the other to authenticate the user at login.
        /// the constructor receives the usermanager as a parameter and we can make use of it
        /// </remarks>
        /// <param name="userManager"></param>
        /// <param name="service"></param>
        public AuthController(UserManager<IdentityUser> userManager,ITokenHandlerService service)
        {
            _userManager = userManager;
            _service = service;
        }

        /// <summary>
        /// it is used to throw an exception and will allow us to test the operation
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.Exception"></exception>
        [HttpGet]
        [Route("exception")]
        public async Task<IActionResult> ThrowException()
        {
            throw new System.Exception("tst");
        }

        /// <summary>
        /// register user
        /// </summary>
        /// <remarks>
        /// receive from the request body data; first check if it meets the requirements (it is valid) we ask you to return the 
        /// user if it exists. If so, we return the existence to the client. Otherwise, register a new user.
        /// </remarks>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserRequestDTO user)
        {
            if (ModelState.IsValid)
            {
                var existtingUser = await _userManager.FindByEmailAsync(user.Email);
                if (existtingUser != null)
                {
                    return BadRequest("The indicated email already exists!");
                }
                var isCreated = await _userManager.CreateAsync(new IdentityUser() { Email = user.Email, UserName = user.UserName }, user.Password);
                if (isCreated.Succeeded)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest(isCreated.Errors.Select(x => x.Description).ToList());
                }
            }
            else
            {
                return BadRequest("There was an error registering the user");
            }
        }

        /// <summary>
        /// login user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] UserLoginRequestDTO user)
        {
            if (ModelState.IsValid)
            {
                var existingUser = await _userManager.FindByNameAsync(user.Username);
                if(existingUser == null)
                {
                    return BadRequest(new UserLoginResponseDTO()
                    {
                        Login = false,
                        Errors = new List<string>()
                        {
                            "wrong username or password"
                        }
                    });
                }
                if (existingUser.UserName.Equals(user.Username) && existingUser.PasswordHash.Equals(user.Password))
                {
                    var pars = new TokenParamaters()
                    {
                        Id = existingUser.Id,
                        PasswordHash = existingUser.PasswordHash,
                        UserName = existingUser.UserName,
                    };

                    var jwtToken = _service.GenerateJwtToken(pars);
                    return Ok(new UserLoginResponseDTO()
                    {
                        Login = true,
                        Token = jwtToken,
                    });

                }
                else
                {
                    return BadRequest(new UserLoginResponseDTO()
                    {
                        Login = false,
                        Errors = new List<string>()
                        {
                            "wrong username or password"
                        }
                    });
                }
            }
            else
            {
                return BadRequest(new UserLoginResponseDTO()
                {
                    Login = false,
                    Errors = new List<string>()
                        {
                            "wrong username or password"
                        }
                });
            }
        }
    }   
}
