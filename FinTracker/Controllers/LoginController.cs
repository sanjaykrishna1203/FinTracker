using FincTracker.Lib;
using FincTracker.Lib.Serivces;
using FinTracker.Dal.Entity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FinTracker.Controllers
{
    public class LoginController : Controller
    {
        private readonly LoginService _loginservice;

        public LoginController(LoginService loginService)
        {
            _loginservice = loginService;
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Validator(string username, string password)
        {
            try
            {
                var user = _loginservice.Validator(username, password);
                if (user != null)
                {
                    HttpContext.Session.SetString(ApplicationConstants.UserName , username);
                    HttpContext.Session.SetString(ApplicationConstants.UserRefId, user.Id.ToString());
                    var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, username)
                };
                    var claimsIdentity = new ClaimsIdentity(claims, "Login");

                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception ex)
            {
                return View();
            }

        }
    }
}
