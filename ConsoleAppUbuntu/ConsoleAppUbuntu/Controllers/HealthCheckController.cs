using Microsoft.AspNetCore.Mvc;

namespace ConsoleAppUbuntu.Controllers
{
    [ApiController]
    [Route("/HC")]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet("healthCheck")]
        public ActionResult HealthCheck()
        {
            return Ok();
        }
    }
}
