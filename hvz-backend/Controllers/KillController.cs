using AutoMapper;
using hvz_backend.Exceptions;
using hvz_backend.Models;
using hvz_backend.Models.DTOs.Game;
using hvz_backend.Models.DTOs.Kill;
using hvz_backend.Services.GameServices;
using hvz_backend.Services.KillServices;
using hvz_backend.Services.PlayerServices;
using hvz_backend.Services.SquadServices;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace hvz_backend.Controllers
{
    [Route("api/v1/game")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class KillsController : ControllerBase
    {
        #region Fields & Constructor
        private readonly IKillService _service;
        private readonly IMapper _mapper;
        private readonly IPlayerService _playerService;
        private readonly ISquadService _squadService;
        private readonly IGameService _gameService;
        // Sets the service and mapper for this controller via constructor.
        public KillsController(IKillService service, IMapper mapper, IPlayerService playerService, ISquadService squadService, IGameService gameService)
        {
            _service = service;
            _mapper = mapper;
            _playerService = playerService;
            _squadService = squadService;
            _gameService = gameService;
        }
        #endregion

        #region HTTP POST
        /// <summary>
        /// Create a kill for the game
        /// </summary>
        /// <param name="killCode"></param>
        /// <param name="createKillDTO"></param>
        /// <returns></returns>

        [HttpPost("{gameId}/kill/")]
        public async Task<ActionResult<Kill>> CreateKill(int gameId, KillCreateDTO createKillDTO)
        {
            try
            {
                //map the kill
                var kill = _mapper.Map<Kill>(createKillDTO);
                kill.GameId= gameId;
                int killId = kill.Id;
                // get the two parter in the kill
                int killerId = kill.KillerId;
                Player killer = await _playerService.GetPlayerByIdInGame(gameId, killerId);
                string biteCode = kill.biteCode;
                Player victim = await _playerService.GetPlayerByBiteCodeInGame(gameId, biteCode);

                if (victim == null) throw new PlayerNotFoundException();
                int victimId = victim.Id;
                var victimSquadId = victim.SquadId;
                kill.VictimId = victimId;
                // Check if both player in same game
                if (victim.GameId != killer.GameId) throw new DifferentGameUsedException();
                await _service.CreateKill(kill);
                Squad squad = await _squadService.GetSquadByIdInGame(gameId, (int)victimSquadId);

                if (victimSquadId != null) squad.TotalDead += 1;
                victim.SquadId = null;
                victim.IsZombie = true;
                await _squadService.UpdateSquad(squad);
                await _playerService.UpdatePlayer(victim);
                return CreatedAtAction(nameof(GetKillByIdInGame), new { gameId, killId }, kill);
            }
            catch (DifferentGameUsedException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
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

        #region HTTP GETs
        /// <summary>
        /// Get all kills in one specific game.
        /// </summary>
        /// <param name="gameId">The identifier of the game.</param>
        /// <returns>List of kills</returns>
        [HttpGet("{gameId}/kill")]
        public async Task<ActionResult<IEnumerable<KillReadDTO>>> GetAllKillsInGame(int gameId)
        {
            try
            {
                return Ok(_mapper.Map<IEnumerable<KillReadDTO>>(await _service.GetAllKillsInGame(gameId)));
            }
            catch (KillNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        /// <summary>
        /// Get one specific kill in a specific game.
        /// </summary>
        /// <param name="gameId">Identifier of the game.</param>
        /// <param name="id">Identifier of the kill.</param>
        /// <returns>One kill.</returns>
        [HttpGet("{gameId}/kill/{id}")]
        public async Task<ActionResult<KillReadDTO>> GetKillByIdInGame(int gameId, int id)
        {
            try
            {
                return Ok(_mapper.Map<KillReadDTO>(await _service.GetKillByIdInGame(gameId, id)));
            }
            catch (KillNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{gameId}/kill/{id}/timedead")]
        public async Task<ActionResult<KillTimeDeadDTO>> GetKillTime(int gameId, int id)
        {
            try
            {
                return Ok(_mapper.Map<KillTimeDeadDTO>(await _service.GetKillByIdInGame(gameId, id)));
            }
            catch (KillNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{gameId}/kill/{id}/killer")]
        public async Task<ActionResult<KillKillerDTO>> GetKillKiller(int gameId, int id)
        {
            try
            {
                return Ok(_mapper.Map<KillKillerDTO>(await _service.GetKillByIdInGame(gameId, id)));
            }
            catch (KillNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{gameId}/kill/{id}/latitude")]
        public async Task<ActionResult<KillLatDTO>> GetKillLatitude(int gameId, int id)
        {
            try
            {
                return Ok(_mapper.Map<KillLatDTO>(await _service.GetKillByIdInGame(gameId, id)));
            }
            catch (KillNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{gameId}/kill/{id}/longitude")]
        public async Task<ActionResult<KillLongDTO>> GetKillLongitude(int gameId, int id)
        {
            try
            {
                return Ok(_mapper.Map<KillLongDTO>(await _service.GetKillByIdInGame(gameId, id)));
            }
            catch (KillNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{gameId}/kill/{id}/story")]
        public async Task<ActionResult<KillStoryDTO>> GetKillStory(int gameId, int id)
        {
            try
            {
                return Ok(_mapper.Map<KillStoryDTO>(await _service.GetKillByIdInGame(gameId, id)));
            }
            catch (KillNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{gameId}/kill/{id}/victim")]
        public async Task<ActionResult<KillVictimDTO>> GetKillVictim(int gameId, int id)
        {
            try
            {
                return Ok(_mapper.Map<KillVictimDTO>(await _service.GetKillByIdInGame(gameId, id)));
            }
            catch (KillNotFoundException e)
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
        /// Possible to update one kill.
        /// </summary>
        /// <param name="id">Identifier of the kill.</param>
        /// <param name="killDTO"></param>
        /// <returns></returns>
        [HttpPut("{gameId}/kill/{id}")]
        public async Task<IActionResult> PutKill(int id, KillUpdateDTO killDTO)
        {
            try
            {
                var kill = _mapper.Map<Kill>(killDTO);
                kill.Id = id;
                await _service.UpdateKill(kill);
            }
            catch (KillNotFoundException e)
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
        [HttpPatch("{gameId}/kill/{id}/story")]
        public async Task<ActionResult> PatchDeadStoryKill(int gameId, int id, [FromBody] KillStoryDTO killStoryDTO)
        {
            try
            {
                await _service.PatchDeadStoryKill(gameId, id, killStoryDTO.DeadStory);
            }
            catch (GameNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
            return NoContent();
        }

        [HttpPatch("{gameId}/kill/{id}/killer")]
        public async Task<ActionResult> PatchKillerKill(int gameId, int id, [FromBody] KillKillerDTO killKillerDTO)
        {
            try
            {
                await _service.PatchKillerKill(gameId, id, killKillerDTO.KillerId);
            }
            catch (GameNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
            return NoContent();
        }

        [HttpPatch("{gameId}/kill/{id}/victim")]
        public async Task<ActionResult> PatchVictimKill(int gameId, int id, [FromBody] KillVictimDTO killVictimDTO)
        {
            try
            {
                await _service.PatchVictimKill(gameId, id, killVictimDTO.VictimId);
            }
            catch (GameNotFoundException e)
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
        /// Delete one kill in a game.
        /// </summary>
        /// <param name="id">Identifier of kill.</param>
        /// <returns></returns>
        [HttpDelete("{gameId}/kill/{id}")]
        public async Task<IActionResult> DeleteKill(int id)
        {
            try
            {
                await _service.DeleteKill(id);
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
