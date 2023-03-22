using AutoMapper;
using hvz_backend.Exceptions;
using hvz_backend.Models;
using hvz_backend.Models.DTOs.Squad;
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
        private readonly IMapper _mapper;

        // Sets the service and mapper for this controller via constructor.
        public SquadsController(ISquadService service, IMapper mapper)
        {
            _service = service;
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
        public async Task<ActionResult<Squad>> CreateSquad(SquadCreateDTO createSquadDTO)
        {
            try
            {
                var squad = _mapper.Map<Squad>(createSquadDTO);
                await _service.CreateSquad(squad);
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
                return Ok(_mapper.Map<IEnumerable<SquadReadDTO>>(await _service.GetAllSquadsInMap(gameId)));
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
                return Ok(_mapper.Map<SquadReadDTO>(await _service.GetSquadByIdInMap(gameId, id)));
            }
            catch (SquadNotFoundException e)
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

