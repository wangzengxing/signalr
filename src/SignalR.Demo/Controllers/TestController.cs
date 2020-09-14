using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalR.Demo.Hubs;
using SignalR.Demo.Services;

namespace SignalR.Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private IHubContext<HelloHub> _hubContext;

        public TestController(IHubContext<HelloHub> hubContext)
        {
            _hubContext = hubContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            //var client = _hubContext.Clients.User(userId);
            //await client.SendAsync("ReceiveMessage", userId, "hello");

            var client = _hubContext.Clients.All;
            await client.SendNoticeAsync(new TaskCompleteNotice
            {
                TaskId = 1,
                CompleteTime = DateTime.Now
            });

            return Ok();
        }
    }
}
