using System.Collections.Generic;
using System.Threading.Tasks;
using MediatorPattern.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MediatorPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotifyController : ControllerBase
    {   
        private readonly ILogger<NotifyController> _logger;

        private readonly INotifierMediatorService notifierMediatorService;

        private readonly INotifier notifier;

        public NotifyController(ILogger<NotifyController> logger, INotifierMediatorService notifierMediatorService, INotifier notifier)
        {
            _logger = logger;
            this.notifierMediatorService = notifierMediatorService;
            this.notifier = notifier;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> NotifyAsync()
        {
            var result = await notifierMediatorService.NotifyAsync();
            return Ok(result);
        }

        [HttpGet]
        [Route("{input}")]
        public async Task<ActionResult<IEnumerable<string>>> ConditionalNotifyAsync([FromRoute]bool input)
        {
            var result = await notifierMediatorService.ConditionalNotifyAsync(input);
            return Ok(result);
        }

        
    }
}
