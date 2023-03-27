using hvz_backend.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using PusherServer;
using System.Net.Mime;

namespace hvz_backend.Controllers
{

    [Route("api/v1/chat")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class ChatController : ControllerBase
    {
        private readonly Pusher pusher;

        public ChatController()
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
        // 
        public async Task<ActionResult> Message(ChatCreateDTO createChatDto) 
        {
            return Ok(await pusher.TriggerAsync("HvZApp",createChatDto.EventName,createChatDto.Message));
        }
    }
}
