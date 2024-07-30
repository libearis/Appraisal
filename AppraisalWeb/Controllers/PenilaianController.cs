using AppraisalWeb.Services;
using Microsoft.AspNetCore.Mvc;

namespace AppraisalWeb.Controllers
{
    public class PenilaianController : Controller
    {
        private readonly PenilaianService service;

        public PenilaianController(PenilaianService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            var model = service.GetAllEmployees();
            return View(model);
        }

        public IActionResult FormPenilaian()
        {
            return View();
        }
    }
}
