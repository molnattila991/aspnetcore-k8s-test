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
            string api1Service = Environment.GetEnvironmentVariable("API1_SERVICENAME");
            Console.WriteLine(api1Service);
            http.BaseAddress = new Uri(api1Service.Trim());
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            Console.WriteLine("Hello");
            var result = await http.GetAsync("weatherforecast");
            return Ok(await result.Content.ReadAsStringAsync());
        }
    }
}
