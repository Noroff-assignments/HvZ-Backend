using AutoMapper;
using hvz_backend.Exceptions;
using hvz_backend.Models;
using hvz_backend.Models.DTOs.Player;
using hvz_backend.Services.GameServices;
using hvz_backend.Services.PlayerServices;
using hvz_backend.Services.SquadServices;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using System;
using System.Linq;
using System.Data;
using System.Numerics;
using System.Text.Json.Serialization;
using System.Text.Json;



namespace hvz_backend.Controllers
{
    [Route("api/v1/game")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class PlayersController : ControllerBase
    {
        #region Fields & Constructor
        private readonly IPlayerService _service;
        private readonly IMapper _mapper;
        private readonly IGameService _gameService;
        private readonly ISquadService _squadService;


        // Sets the service and mapper for this controller via constructor.
        public PlayersController(IPlayerService service, IGameService gameService, ISquadService squadService, IMapper mapper)
        {
            _service = service;
            _gameService = gameService;
            _squadService = squadService;
            _mapper = mapper;
        }
        #endregion





        #region HTTP POST
        /// <summary>
        /// Make user to a player in game
        /// </summary>
        /// <param name="gameId">Identifer of game</param>
        /// <param name="createPlayerDTO"></param>
        /// <returns></returns>
        [HttpPost("{gameId}/player")]
        public async Task<ActionResult<Player>> CreatePlayer(int gameId, PlayerCreateDTO createPlayerDTO)
        {
            var userId = createPlayerDTO.UserID;
            var userExist = await _service.GetPlayerByUserIdInGame(gameId, userId);
            if (userExist == null)
            {
                var player = _mapper.Map<Player>(createPlayerDTO);
                player.GameId = gameId;
                var ExistingBiteCode = await _service.GetAllBiteCodeInGame(gameId);
                player.BiteCode = BiteCodeGenerator(ExistingBiteCode);
                var createdPlayer = await _service.CreatePlayer(player);
                var game = await _gameService.GetGameById(gameId);
                var amountPlayer = game.AmountPlayers.HasValue ? (int)game.AmountPlayers + 1 : 1;
                await _gameService.PatchAmountGame(gameId, amountPlayer);
            }
            Player playerReturn = await _service.GetPlayerByUserIdInGame(gameId, userId);
            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };
            string json = JsonSerializer.Serialize(playerReturn, options);
            return Ok(json);
        }

        private static string BiteCodeGenerator(List<string> existingBiteCode)
        {
            string charSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string code = "";
            while (!existingBiteCode.Contains(code))
            {
                code = "";
                // Generate a new code
                var random = new Random();
                code = new string(Enumerable.Repeat(charSet, 15)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
                if (!existingBiteCode.Contains(code)) existingBiteCode.Add(code);
            }
            return code;
        }
        #endregion

        #region HTTP GETs
        /// <summary>
        /// Get all players in one specific game.
        /// </summary>
        /// <param name="gameId">The identifier of the game.</param>
        /// <returns>List of players</returns>
        [HttpGet("{gameId}/player")]
        public async Task<ActionResult<IEnumerable<PlayerReadDTO>>> GetAllPlayersInGame(int gameId)
        {
            try
            {
                return Ok(_mapper.Map<IEnumerable<PlayerReadDTO>>(await _service.GetAllPlayersInGame(gameId)));
            }
            catch (PlayerNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }
        /// <summary>
        /// Get all zombies in game
        /// </summary>
        /// <param name="gameId">Identifier of game</param>
        /// <returns>List of players</returns>
        [HttpGet("{gameId}/zombies")]
        public async Task<ActionResult<IEnumerable<PlayerReadDTO>>> GetAllZombiesInGame(int gameId)
        {
            try
            {
                return Ok(_mapper.Map<IEnumerable<PlayerReadDTO>>(await _service.GetAllZombiesInGame(gameId)));
            }
            catch (PlayerNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }
        /// <summary>
        /// Get all humans in game
        /// </summary>
        /// <param name="gameId">Identifier of game</param>
        /// <returns>List of Players</returns>
        [HttpGet("{gameId}/humans")]
        public async Task<ActionResult<IEnumerable<PlayerReadDTO>>> GetAllHumansInGame(int gameId)
        {
            try
            {
                return Ok(_mapper.Map<IEnumerable<PlayerReadDTO>>(await _service.GetAllHumansInGame(gameId)));
            }
            catch (PlayerNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        /// <summary>
        /// Get one specific player in a specific game.
        /// </summary>
        /// <param name="gameId">Identifier of the game.</param>
        /// <param name="id">Identifier of the player.</param>
        /// <returns>One player.</returns>
        [HttpGet("{gameId}/player/{id}")]
        public async Task<ActionResult<PlayerReadDTO>> GetPlayerByIdInGame(int gameId, int id)
        {
            try
            {
                return Ok(_mapper.Map<PlayerReadDTO>(await _service.GetPlayerByIdInGame(gameId, id)));
            }
            catch (PlayerNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }
        /// <summary>
        /// Get player based on user id from keycloak
        /// </summary>
        /// <param name="gameId">Identifier of gmae</param>
        /// <param name="userId">Keycloak Identifier for user</param>
        /// <returns>Player</returns>
        [HttpGet("{gameId}/user/{userId}")]
        public async Task<ActionResult<PlayerReadDTO>> GetPlayerByUserIdInGame(int gameId, string userId)
        {
            try
            {
                return Ok(_mapper.Map<PlayerReadDTO>(await _service.GetPlayerByUserIdInGame(gameId, userId)));
            }
            catch (PlayerNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        /// <summary>
        /// Get the bitecode of a player in game
        /// </summary>
        /// <param name="gameId">Identifier of game</param>
        /// <param name="id">Identifier of player</param>
        /// <returns>String</returns>
        [HttpGet("{gameId}/player/{id}/bitecode")]
        public async Task<ActionResult<PlayerBiteDTO>> GetBitePlayer(int gameId, int id)
        {
            try
            {
                return Ok(_mapper.Map<PlayerBiteDTO>(await _service.GetPlayerByIdInGame(gameId, id)));
            }
            catch (PlayerNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }
        /// <summary>
        /// Get the latitude of player in game
        /// </summary>
        /// <param name="gameId">Identifier of game</param>
        /// <param name="id">Identifier of player</param>
        /// <returns>Double</returns>
        [HttpGet("{gameId}/player/{id}/latitude")]
        public async Task<ActionResult<PlayerBiteDTO>> GetLatPlayer(int gameId, int id)
        {
            try
            {
                return Ok(_mapper.Map<PlayerBiteDTO>(await _service.GetPlayerByIdInGame(gameId, id)));
            }
            catch (PlayerNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }
        /// <summary>
        /// Get longitude of player in game
        /// </summary>
        /// <param name="gameId">Identifier of game</param>
        /// <param name="id">Identifier of player</param>
        /// <returns>Double</returns>
        [HttpGet("{gameId}/player/{id}/longitude")]
        public async Task<ActionResult<PlayerLongDTO>> GetLonPlayer(int gameId, int id)
        {
            try
            {
                return Ok(_mapper.Map<PlayerLongDTO>(await _service.GetPlayerByIdInGame(gameId, id)));
            }
            catch (PlayerNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }
        /// <summary>
        /// Get if the player is patient zero in game
        /// </summary>
        /// <param name="gameId">Identifier of game</param>
        /// <param name="id">Identifier of player</param>
        /// <returns>Boolean</returns>
        [HttpGet("{gameId}/player/{id}/patientzero")]
        public async Task<ActionResult<PlayerPatientDTO>> GetIsPatientZeroPlayer(int gameId, int id)
        {
            try
            {
                return Ok(_mapper.Map<PlayerPatientDTO>(await _service.GetPlayerByIdInGame(gameId, id)));
            }
            catch (PlayerNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }
        /// <summary>
        /// Get the squad id of player in gmae
        /// </summary>
        /// <param name="gameId">Identifier of game</param>
        /// <param name="id">Identifier of player</param>
        /// <returns>Integer</returns>
        [HttpGet("{gameId}/player/{id}/squad")]
        public async Task<ActionResult<PlayerSquadDTO>> GetSquadIdPlayer(int gameId, int id)
        {
            try
            {
                return Ok(_mapper.Map<PlayerSquadDTO>(await _service.GetPlayerByIdInGame(gameId, id)));
            }
            catch (PlayerNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }
        /// <summary>
        /// Get the user of player in game
        /// </summary>
        /// <param name="gameId">Identifier of game</param>
        /// <param name="id">Identifier of player</param>
        /// <returns>User identifier</returns>
        [HttpGet("{gameId}/player/{id}/user")]
        public async Task<ActionResult<PlayerUserDTO>> GetUserPlayer(int gameId, int id)
        {
            try
            {
                return Ok(_mapper.Map<PlayerUserDTO>(await _service.GetPlayerByIdInGame(gameId, id)));
            }
            catch (PlayerNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }
        /// <summary>
        /// Get if the player in game is a zombie
        /// </summary>
        /// <param name="gameId">Identifier of game</param>
        /// <param name="id">Identifier of player</param>
        /// <returns>Boolean</returns>
        [HttpGet("{gameId}/player/{id}/iszombie")]
        public async Task<ActionResult<PlayerZombieDTO>> GetIsZombiePlayer(int gameId, int id)
        {
            try
            {
                return Ok(_mapper.Map<PlayerZombieDTO>(await _service.GetPlayerByIdInGame(gameId, id)));
            }
            catch (PlayerNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        #endregion

        #region HTTP PUT
        /// <summary>
        /// Possible to update one player.
        /// </summary>
        /// <param name="id">Identifier of the player.</param>
        /// <param name="playerUpdateDTO"></param>
        /// <returns></returns>
        [HttpPut("{gameId}/player/{id}")]
        public async Task<IActionResult> PutPlayer(int gameId, int id, PlayerUpdateDTO playerUpdateDTO)
        {
            try
            {
                var player = await _service.GetPlayerByIdInGame(gameId, id);
                if (player == null) throw new PlayerNotFoundException(id);
                var oldSquad = await _squadService.GetSquadByIdInGame(gameId, player.Id);
                if (oldSquad != null)
                {
                    int oldSquadAmount = oldSquad.TotalPlayer - 1;
                    await _squadService.PatchTotalPlayerSquad(gameId, oldSquad.Id, oldSquadAmount);
                }
                var newSquad = await _squadService.GetSquadByIdInGame(gameId, playerUpdateDTO.SquadId);
                if (newSquad == null) throw new SquadNotFoundException(playerUpdateDTO.SquadId);
                int newSquadAmount = newSquad.TotalPlayer + 1;
                await _squadService.PatchTotalPlayerSquad(gameId, newSquad.Id, newSquadAmount);
                var playerUpdated = _mapper.Map<Player>(playerUpdateDTO);
                player.Id = id;
                await _service.UpdatePlayer(playerUpdated);
            }
            catch (PlayerNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
            return NoContent();
        }
        #endregion


        #region HTTP PATCH

        /// <summary>
        /// Update latitude of player in game
        /// </summary>
        /// <param name="gameId">Identifier of game</param>
        /// <param name="id">identfier of player</param>
        /// <param name="playerLatDTO"></param>
        /// <returns></returns>
        [HttpPatch("{gameId}/player/{id}/latitude")]
        public async Task<ActionResult> PatchLatPlayer(int gameId, int id, [FromBody] PlayerLatDTO playerLatDTO)
        {
            try
            {
                await _service.PatchLatPlayer(gameId, id, playerLatDTO.Latitude);
            }
            catch (PlayerNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
            return NoContent();

        }

        /// <summary>
        /// Update longitude of player in game
        /// </summary>
        /// <param name="gameId">Identifier of game</param>
        /// <param name="id">Identifier of player</param>
        /// <param name="playerLongDTO"></param>
        /// <returns></returns>
        [HttpPatch("{gameId}/player/{id}/longitude")]
        public async Task<ActionResult> PatchlongPlayer(int gameId, int id, [FromBody] PlayerLongDTO playerLongDTO)
        {
            try
            {
                await _service.PatchlongPlayer(gameId, id, playerLongDTO.Longitude);
            }
            catch (PlayerNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
            return NoContent();

        }

        /// <summary>
        /// update squad to player in game
        /// </summary>
        /// <param name="gameId">Identifier of game</param>
        /// <param name="id">Identifier of player</param>
        /// <param name="playerSquadDTO"></param>
        /// <returns></returns>
        [HttpPatch("{gameId}/player/{id}/squad")]
        public async Task<ActionResult> PatchSquadPlayer(int gameId, int id, [FromBody] PlayerSquadDTO playerSquadDTO)
        {
            try
            {
                var player = await _service.GetPlayerByIdInGame(gameId, id);
                var oldSquad = await _squadService.GetSquadByIdInGame(gameId, player.Id);
                if (oldSquad != null)
                {
                    int oldSquadAmount = oldSquad.TotalPlayer - 1;
                    await _squadService.PatchTotalPlayerSquad(gameId, oldSquad.Id, oldSquadAmount);
                }
                var newSquad = await _squadService.GetSquadByIdInGame(gameId, playerSquadDTO.SquadId);
                int newSquadAmount = newSquad.TotalPlayer + 1;
                await _squadService.PatchTotalPlayerSquad(gameId, newSquad.Id, newSquadAmount);
                await _service.PatchSquadPlayer(gameId, id, playerSquadDTO.SquadId);
            }
            catch (PlayerNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
            catch (SquadNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
            return NoContent();

        }

        /// <summary>
        /// Update the player state as zombie in game
        /// </summary>
        /// <param name="gameId">Identifier of game</param>
        /// <param name="id">Identifier of player</param>
        /// <param name="playerZombieDTO"></param>
        /// <returns></returns>
        [HttpPatch("{gameId}/player/{id}/iszombie")]
        public async Task<ActionResult> PatchIsZombiePlayer(int gameId, int id, [FromBody] PlayerZombieDTO playerZombieDTO)
        {
            try
            {
                await _service.PatchIsZombiePlayer(gameId, id, playerZombieDTO.IsZombie);
            }
            catch (PlayerNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
            return NoContent();

        }

        #endregion




        #region HTTP DELETE
        /// <summary>
        /// Delete one player in a game.
        /// </summary>
        /// <param name="id">Identifier of player.</param>
        /// <returns></returns>
        [HttpDelete("{gameId}/player/{id}")]
        public async Task<IActionResult> DeletePlayer(int id, int gameId)
        {
            try
            {
                var player = await _service.GetPlayerByIdInGame(gameId, id);
                if (player != null)
                {
                    var oldSquad = await _squadService.GetSquadByIdInGame(gameId, player.Id);
                    if (oldSquad != null)
                    {
                        int oldSquadAmount = oldSquad.TotalPlayer - 1;
                        await _squadService.PatchTotalPlayerSquad(gameId, oldSquad.Id, oldSquadAmount);
                    }
                    var game = await _gameService.GetGameById(gameId);
                    var amountPlayer = (int)game.AmountPlayers - 1;
                    await _gameService.PatchAmountGame(gameId, amountPlayer);
                }
                await _service.DeletePlayer(id);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return NoContent();
        }
        #endregion
    }
}
