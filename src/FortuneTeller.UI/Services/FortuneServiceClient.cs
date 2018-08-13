using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FortuneTeller.UI.Services
{
    public class FortuneServiceClient : IFortuneService
    {
        private readonly ILogger<FortuneServiceClient> _logger;
        private IOptions<FortuneServiceOptions> _config;

        private FortuneServiceOptions Config
        {
            get
            {
                return _config.Value;
            }
        }

        public FortuneServiceClient(
            IOptions<FortuneServiceOptions> config, 
            ILogger<FortuneServiceClient> logger)
        {
            _logger = logger;
            _config = config;
        }

        public async Task<List<Fortune>> AllFortunesAsync()
        {
            return await Task.FromResult(new List<Fortune>() { new Fortune() { Id = 1, Text = "I need to be wired up!" } });
        }

        public async Task<Fortune> RandomFortuneAsync()
        {
            return (await AllFortunesAsync())[0];
        }
    }
}