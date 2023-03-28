using AutoMapper;
using hvz_backend.Exceptions;
using hvz_backend.Models;
using hvz_backend.Models.DTOs.Kill;
using hvz_backend.Models.DTOs.Squad;
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
    public class SquadsController : ControllerBase
    {
        #region Fields & Constructor
        private readonly ISquadService _service;
        private readonly IPlayerService _playerService;
        private readonly IMapper _mapper;

        // Sets the service and mapper for this controller via constructor.
        public SquadsController(ISquadService service, IPlayerService playerService, IMapper mapper)
        {
            _service = service;
            _playerService = playerService;
            _mapper = mapper;
        }
        #endregion

        /// <summary>
        /// Create a squad for the game
        /// </summary>
        /// <param name="createSquadDTO"></param>
        /// <returns></returns>
        #region HTTP POST
        [HttpPost("{gameId}/squad")]
        public async Task<ActionResult<Squad>> CreateSquad(SquadCreateDTO createSquadDTO, int playerId)
        {
            try
            {
                var squad = _mapper.Map<Squad>(createSquadDTO);
                squad.TotalPlayer = 1;
                await _service.CreateSquad(squad);
                var founder = await _playerService.GetPlayerByIdInGame(squad.GameId,playerId);
                if (founder == null) throw new PlayerNotFoundException(playerId);
                founder.SquadId = squad.Id;
                await _playerService.UpdatePlayer(founder);
                return CreatedAtAction(nameof(GetSquadByIdInGame), new { gameId = squad.GameId, id = squad.Id }, squad);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion

        #region HTTP GETs
        /// <summary>
        /// Get all squads in one specific game.
        /// </summary>
        /// <param name="gameId">The identifier of the game.</param>
        /// <returns>List of squads</returns>
        [HttpGet("{gameId}/squad")]
        public async Task<ActionResult<IEnumerable<SquadReadDTO>>> GetAllSquadsInGame(int gameId)
        {
            try
            {
                return Ok(_mapper.Map<IEnumerable<SquadReadDTO>>(await _service.GetAllSquadsInGame(gameId)));
            }
            catch (SquadNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        /// <summary>
        /// Get one specific squad in a specific game.
        /// </summary>
        /// <param name="gameId">Identifier of the game.</param>
        /// <param name="id">Identifier of the squad.</param>
        /// <returns>One squad.</returns>
        [HttpGet("{gameId}/squad/{id}")]
        public async Task<ActionResult<SquadReadDTO>> GetSquadByIdInGame(int gameId, int id)
        {
            try
            {
                return Ok(_mapper.Map<SquadReadDTO>(await _service.GetSquadByIdInGame(gameId, id)));
            }
            catch (SquadNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{gameId}/squad/{id}/name")]
        public async Task<ActionResult<SquadNameDTO>> GetNameSquad(int gameId, int id)
        {
            try
            {
                return Ok(_mapper.Map<SquadNameDTO>(await _service.GetSquadByIdInGame(gameId, id)));
            }
            catch (KillNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{gameId}/squad/{id}/description")]
        public async Task<ActionResult<SquadDescriptionDTO>> GetDescriptionSquad(int gameId, int id)
        {
            try
            {
                return Ok(_mapper.Map<SquadDescriptionDTO>(await _service.GetSquadByIdInGame(gameId, id)));
            }
            catch (KillNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{gameId}/squad/{id}/totalplayer")]
        public async Task<ActionResult<SquadTotalPlayerDTO>> GetTotalPlayerSquad(int gameId, int id)
        {
            try
            {
                return Ok(_mapper.Map<SquadTotalPlayerDTO>(await _service.GetSquadByIdInGame(gameId, id)));
            }
            catch (KillNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{gameId}/squad/{id}/totaldead")]
        public async Task<ActionResult<SquadTotalDeadDTO>> GetTotalDeadSquad(int gameId, int id)
        {
            try
            {
                return Ok(_mapper.Map<SquadTotalDeadDTO>(await _service.GetSquadByIdInGame(gameId, id)));
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

        #region HTTP PATCH
        [HttpPatch("{gameId}/squad/{id}/name")]
        public async Task<ActionResult> PatchNameSquad(int gameId, int id, [FromBody] SquadNameDTO squadNameDTO)
        {
            try
            {
                await _service.PatchNameSquad(gameId, id, squadNameDTO.Name);
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

        [HttpPatch("{gameId}/squad/{id}/description")]
        public async Task<ActionResult> PatchDescriptionSquad(int gameId, int id, [FromBody] SquadDescriptionDTO squadDescriptionDTO)
        {
            try
            {
                await _service.PatchDescriptionSquad(gameId, id, squadDescriptionDTO.Description);
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

        [HttpPatch("{gameId}/squad/{id}/totalplayer")]
        public async Task<ActionResult> PatchTotalPlayerSquad(int gameId, int id, [FromBody] SquadTotalPlayerDTO squadTotalPlayerDTO)
        {
            try
            {
                await _service.PatchTotalPlayerSquad(gameId, id, squadTotalPlayerDTO.TotalPlayer);
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

        [HttpPatch("{gameId}/squad/{id}/totaldead")]
        public async Task<ActionResult> PatchTotalDeadSquad(int gameId, int id, [FromBody] SquadTotalDeadDTO squadTotalDeadDTO)
        {
            try
            {
                await _service.PatchTotalDeadSquad(gameId, id, squadTotalDeadDTO.TotalDead);
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

        #region HTTP PUT
        /// <summary>
        /// Possible to update one squad.
        /// </summary>
        /// <param name="id">Identifier of the squad.</param>
        /// <param name="squadDTO"></param>
        /// <returns></returns>
        [HttpPut("{gameId}/squad/{id}")]
        public async Task<IActionResult> PutSquad(int id, SquadUpdateDTO squadDTO)
        {
            try
            {
                var squad = _mapper.Map<Squad>(squadDTO);
                squad.Id = id;
                await _service.UpdateSquad(squad);
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
        #endregion

        #region HTTP DELETE
        /// <summary>
        /// Delete one squad in a game.
        /// </summary>
        /// <param name="id">Identifier of squad.</param>
        /// <returns></returns>
        [HttpDelete("{gameId}/squad/{id}")]
        public async Task<IActionResult> DeleteSquad(int id)
        {
            try
            {
                await _service.DeleteSquad(id);
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

