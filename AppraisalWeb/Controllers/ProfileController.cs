using AppraisalWeb.Models;
using AppraisalWeb.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
namespace AppraisalWeb.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ProfileService service;

        public ProfileController(ProfileService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            string? nik = User.FindFirstValue("NIK");
            var model = service.GetPersonalInfo(nik??"");
            return View(model);
        }
    }
}
