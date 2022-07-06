namespace ApplicationProcessManagement.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Model_Layer;

    [ApiController]
    [Route("[controller]")]
    public class AuthUserController : ControllerBase
    {
        private readonly ILogger<AuthUserController> _logger;

        public AuthUserController(ILogger<AuthUserController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<AuthUser> Get()
        {
            return new List<AuthUser>();
        }
    }
}