using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BilgisayarAglarinaGirisProje.Models;
using BilgisayarAglarinaGirisProje.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BilgisayarAglarinaGirisProje.Controllers
{
    public class LoginController : Controller
    {
     
        private readonly UserService userService;
        public LoginController(UserService _userService)
        {
            userService = _userService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View("Login");
        }

        public IActionResult Register()
        {
            return View("SignUp");
        }

        [HttpPost("LoginUser")]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            var result = userService.Login(loginViewModel);
            if(result != null)
            {
                var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, result.Username),
                new Claim("UserId", result.Id.ToString())
            };

                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity));
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost("SignUp")]
        public IActionResult Register(SignUpModel signUpModel)
        {
            var result = userService.SignUp(signUpModel);
            if (result != 0)
            {
                return Ok(1);
            }
            else
            {
                return BadRequest(0);
            }
        }
    }
}
