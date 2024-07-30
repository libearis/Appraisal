using AppraisalAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AppraisalAPI.Controllers
{
    [ApiController]
    [Route("api/v1/KPI")]
    public class KPIController : ControllerBase
    {
        private readonly KPIService kPIService;

        public KPIController(KPIService kPIService)
        {
            this.kPIService = kPIService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(kPIService.GetKPIList());
        }
    }
}
