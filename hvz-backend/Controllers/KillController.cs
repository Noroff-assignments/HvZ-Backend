using AutoMapper;
using hvz_backend.Exceptions;
using hvz_backend.Models;
using hvz_backend.Models.DTOs.Kill;
using hvz_backend.Models.DTOs.Kill;
using hvz_backend.Services.KillServices;
using hvz_backend.Services.KillServices;
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

        // Sets the service and mapper for this controller via constructor.
        public KillsController(IKillService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        #endregion

        /// <summary>
        /// Create a kill for the game
        /// </summary>
        /// <param name="createKillDTO"></param>
        /// <returns></returns>
        #region HTTP POST
        [HttpPost("{gameId}/kill")]
        public async Task<ActionResult<Kill>> CreateKill(KillCreateDTO createKillDTO)
        {
            try
            {
                var kill = _mapper.Map<Kill>(createKillDTO);
                await _service.CreateKill(kill);
                return CreatedAtAction(nameof(GetKillByIdInGame), new { gameId = kill.GameId, id = kill.Id }, kill);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
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
                return Ok(_mapper.Map<IEnumerable<KillReadDTO>>(await _service.GetAllKillsInMap(gameId)));
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
                return Ok(_mapper.Map<KillReadDTO>(await _service.GetKillByIdInMap(gameId, id)));
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
