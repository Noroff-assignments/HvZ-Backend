using hvz_backend.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using PusherServer;
using System.Net.Mime;

namespace hvz_backend.Controllers
{

    [Route("api/v1/game")]
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

        [HttpPost("{gameId}/chat/global")]
        // 
        public async Task<ActionResult> PostMessageGlobalInGame(int gameId, ChatCreateDTO createChatDto) 
        {
            string message = createChatDto.Message;
            string eventName = "Game" + gameId + "_global"; 
            return Ok(await pusher.TriggerAsync("HvZApp",eventName, message));
        }

        [HttpPost("{gameId}/chat/humans")]
        // 
        public async Task<ActionResult> PostMessageHumansInGame(int gameId, ChatCreateDTO createChatDto)
        {
            string message = createChatDto.Message;
            string eventName = "Game" + gameId + "_humans";
            return Ok(await pusher.TriggerAsync("HvZApp", eventName, message));
        }

        [HttpPost("{gameId}/chat/zombies")]
        // 
        public async Task<ActionResult> PostMessageZombiesInGame(int gameId, ChatCreateDTO createChatDto)
        {
            string message = createChatDto.Message;
            string eventName = "Game" + gameId + "_zombies";
            return Ok(await pusher.TriggerAsync("HvZApp", eventName, message));
        }

        [HttpPost("{gameId}/chat/squad/{squadId}")]
        // 
        public async Task<ActionResult> PostMessageSquadInGame(int gameId, int squadId, ChatCreateDTO createChatDto)
        {
            string message = createChatDto.Message;
            string eventName = "Game" + gameId + "_squad" + squadId;
            return Ok(await pusher.TriggerAsync("HvZApp", eventName, message));
        }
    }
}
