using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace api_2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private HttpClient http;
        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            http = new HttpClient();
            var api1Service = Environment.GetEnvironmentVariable("API1_SERVICENAME");
            http.BaseAddress = new Uri(api1Service);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await http.GetAsync("weatherforecast");
            return Ok(await result.Content.ReadAsStringAsync());
        }
    }
}
