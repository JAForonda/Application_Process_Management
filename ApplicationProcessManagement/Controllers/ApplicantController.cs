namespace ApplicationProcessManagement.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Model_Layer;

    [ApiController]
    [Route("[controller]")]
    public class ApplicantController : ControllerBase
    {
        private readonly ILogger<ApplicantController> _logger;

        public ApplicantController(ILogger<ApplicantController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<Applicant> Get()
        {
            return new List<Applicant>();
        }
    }
}