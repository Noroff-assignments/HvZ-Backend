using Microsoft.AspNetCore.Mvc;
using PusherServer;
using System.Net.Mime;

namespace hvz_backend.Controllers
{

    [Route("api/v1/[controller]")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class PusherController : ControllerBase
    {
        private readonly Pusher pusher;

        public PusherController()
        {
            var options = new PusherOptions
            {
                Cluster = "eu",
                Encrypted = true,
            };

            pusher = new Pusher(
                PusherConfig.ApiId,
                PusherConfig.ApiKey,
                PusherConfig.ApiSecret,
                options);
        }

        [HttpPost]
        public async Task<ActionResult> HelloWorld()
        {
            return Ok(await pusher.TriggerAsync("HvZApp","my-event",new { message = "hello world" }));
        }
    }
}
