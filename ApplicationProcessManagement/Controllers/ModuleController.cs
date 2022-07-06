namespace ApplicationProcessManagement.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Model_Layer;

    [ApiController]
    [Route("[controller]")]
    public class ModuleController : ControllerBase
    {
        private readonly ILogger<ModuleController> _logger;

        public ModuleController(ILogger<ModuleController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<Module> Get()
        {
            return new List<Module>();
        }
    }
}