using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FortuneTeller.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FortunesController : ControllerBase
    {
        private readonly ILogger<FortunesController> _logger;

        public FortunesController(ILogger<FortunesController> logger)
        {
            _logger = logger;
        }

        // GET: api/fortunes/all
        [HttpGet("all")]
        public async Task<List<Fortune>> AllFortunesAsync()
        {
            _logger?.LogTrace("AllFortunesAsync");
            return await Task.FromResult(new List<Fortune>() { new Fortune() { Id = 1, Text = "Hello from FortuneController Web API!" } });
        }

        // GET api/fortunes/random
        [HttpGet("random")]
        public async Task<Fortune> RandomFortuneAsync()
        {
            _logger?.LogTrace("RandomFortuneAsync");
            return (await AllFortunesAsync())[0];
        }
    }
}
