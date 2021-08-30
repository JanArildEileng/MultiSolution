using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Gateway.Core;

namespace Gateway.WebApi.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class CoreTestController : ControllerBase
    {
       
        private readonly ILogger<CoreTestController> _logger;

        public CoreTestController(ILogger<CoreTestController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<CoreTest> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new CoreTest
            {
                
            })
            .ToArray();
        }
    }
}
