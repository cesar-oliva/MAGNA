using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using MAGNA_CLIENT.Application.Web.DataTransferObject;
using System.Security.Cryptography;
using AutoMapper;
using MAGNA_CLIENT.Abstractions;
using MAGNA_CLIENT.Application.Web.Service;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

namespace MAGNA_CLIENT.Application.Web.Controllers
{
    public class AuthController : Controller
    {
        const string nameService = "https://localhost:5001/";
        const string serviceGetEmployee = "api/Auth/Login";
        private ServiceAuthUser con = new ServiceAuthUser();
        private readonly IMapper _mapper;
        public AuthController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index (UserLoginRequestDTO user)
        {
            user.Password = GenerateKeySHA1(user.Password);
            var userLoginRequestDTO = await con.LoginUser(nameService, serviceGetEmployee, user);
            if (userLoginRequestDTO.Login)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Username),
                    new Claim("token",userLoginRequestDTO.Token)
                };
                
                var claimsIdentity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                TempData["mensaje"] = "welcome : " + user.Username;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["mensaje"] = "wrong username or password";
                return View();
            }
        }

        public async Task<IActionResult> Exit()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Auth");
        }
        private string GenerateKeySHA1(string text)
        {

            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(text);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                // Convert the values ​​to hexadecimal
                // when it has a number, it must be filled with zero
                // so that they always occupy two digits.
                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }
            // We return the string with the hash in uppercase
            return sb.ToString().ToUpper();
        }
    }
}


  //"userName": "cesar",
  //"email": "cesar@gmail.com",
  //"password": "Cesar@1"
