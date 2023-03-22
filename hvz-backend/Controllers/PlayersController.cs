using AutoMapper;
using hvz_backend.Exceptions;
using hvz_backend.Models;
using hvz_backend.Models.DTOs.Player;
using hvz_backend.Models.DTOs.Player;
using hvz_backend.Services.PlayerServices;
using hvz_backend.Services.PlayerServices;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

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

        // Sets the service and mapper for this controller via constructor.
        public PlayersController(IPlayerService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        #endregion

        /// <summary>
        /// Create a player for the game
        /// </summary>
        /// <param name="createPlayerDTO"></param>
        /// <returns></returns>
        #region HTTP POST
        [HttpPost("{gameId}/player")]
        public async Task<ActionResult<Player>> CreatePlayer(PlayerCreateDTO createPlayerDTO)
        {
            try
            {
                var player = _mapper.Map<Player>(createPlayerDTO);
                await _service.CreatePlayer(player);
                return CreatedAtAction(nameof(GetPlayerByIdInGame), new { gameId = player.GameId, id = player.Id }, player);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
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
                return Ok(_mapper.Map<IEnumerable<PlayerReadDTO>>(await _service.GetAllPlayersInMap(gameId)));
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
                return Ok(_mapper.Map<PlayerReadDTO>(await _service.GetPlayerByIdInMap(gameId, id)));
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
        /// <param name="playerDTO"></param>
        /// <returns></returns>
        [HttpPut("{gameId}/player/{id}")]
        public async Task<IActionResult> PutPlayer(int id, PlayerUpdateDTO playerDTO)
        {
            try
            {
                var player = _mapper.Map<Player>(playerDTO);
                player.Id = id;
                await _service.UpdatePlayer(player);
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
        public async Task<IActionResult> DeletePlayer(int id)
        {
            try
            {
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
