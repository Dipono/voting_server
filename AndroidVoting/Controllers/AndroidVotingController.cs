using Microsoft.AspNetCore.Mvc;

namespace AndroidVoting.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AndroidVotingController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<AndroidVotingController> _logger;

        public AndroidVotingController(ILogger<AndroidVotingController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult  login()
        {
            return Ok("My name is j");
        }
    }
}