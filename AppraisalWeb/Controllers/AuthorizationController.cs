using AppraisalWeb.Models;
using AppraisalWeb.Models.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using AppraisalWeb.Services;

namespace AppraisalWeb.Controllers
{
    public class AuthorizationController : Controller
    {
        private readonly AuthorizationService service;

        public AuthorizationController(AuthorizationService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM viewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var ticket = service.CheckLogin(viewModel);
                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        ticket.Principal,
                        ticket.Properties
                        );

                    return RedirectToAction("Index", "Profile");
                }
                catch (Exception e)
                {
                    ViewBag.Message = e.Message;
                    return View();
                }
            }
            return View("login");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
