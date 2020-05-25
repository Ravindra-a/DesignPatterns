using MediatorPattern.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MediatorPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotifyRController : ControllerBase
    {
        private readonly INotifierMediatrService _notifierMediatorService;

        public NotifyRController(INotifierMediatrService notifierMediatorService)
        {
            _notifierMediatorService = notifierMediatorService;
        }

        [HttpGet("")]
        public ActionResult<string> NotifyAll()
        {
            _notifierMediatorService.Notify("This is a test notification");
            return "Completed";
        }
    }
}
