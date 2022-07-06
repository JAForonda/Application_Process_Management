namespace ApplicationProcessManagement.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Model_Layer;

    [ApiController]
    [Route("[controller]")]
    public class ApplicationController : ControllerBase
    {
        private readonly ILogger<ApplicationController> _logger;

        public ApplicationController(ILogger<ApplicationController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<Application> Get()
        {
            return new List<Application>();
        }
    }
}