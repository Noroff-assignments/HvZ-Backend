using AutoMapper;
using hvz_backend.Exceptions;
using hvz_backend.Models;
using hvz_backend.Models.DTOs.Safezone;
using hvz_backend.Models.DTOs.Safezone;
using hvz_backend.Services.SafezoneServices;
using hvz_backend.Services.SafezoneServices;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace hvz_backend.Controllers
{
    [Route("api/v1/map")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class SafezonesController : ControllerBase
    {
        #region Fields & Constructor
        private readonly ISafezoneService _service;
        private readonly IMapper _mapper;

        // Sets the service and mapper for this controller via constructor.
        public SafezonesController(ISafezoneService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        #endregion

        #region HTTP POST
        [HttpPost("{mapId}/safezone")]
        public async Task<ActionResult<Safezone>> CreateSafezone(SafezoneCreateDTO createSafezoneDTO)
        {
            try
            {
                var safezone = _mapper.Map<Safezone>(createSafezoneDTO);
                await _service.CreateSafezone(safezone);
                return CreatedAtAction(nameof(GetSafezoneByIdInGame), new { mapId = safezone.MapId, id = safezone.Id }, safezone);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion

        #region HTTP GETs
        /// <summary>
        /// Get all safezones in one specific map.
        /// </summary>
        /// <param name="mapId">The identifier of the map.</param>
        /// <returns>List of safezones</returns>
        [HttpGet("{mapId}/safezone")]
        public async Task<ActionResult<IEnumerable<SafezoneReadDTO>>> GetAllSafezonesInGame(int mapId)
        {
            try
            {
                return Ok(_mapper.Map<IEnumerable<SafezoneReadDTO>>(await _service.GetAllSafezonesInMap(mapId)));
            }
            catch (SafezoneNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        /// <summary>
        /// Get one specific safezone in a specific map.
        /// </summary>
        /// <param name="mapId">Identifier of the map.</param>
        /// <param name="id">Identifier of the safezone.</param>
        /// <returns>One safezone.</returns>
        [HttpGet("{mapId}/safezone/{id}")]
        public async Task<ActionResult<SafezoneReadDTO>> GetSafezoneByIdInGame(int mapId, int id)
        {
            try
            {
                return Ok(_mapper.Map<SafezoneReadDTO>(await _service.GetSafezoneByIdInMap(mapId, id)));
            }
            catch (SafezoneNotFoundException e)
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
        /// Possible to update one safezone.
        /// </summary>
        /// <param name="id">Identifier of the safezone.</param>
        /// <param name="safezoneDTO"></param>
        /// <returns></returns>
        [HttpPut("{mapId}/safezone/{id}")]
        public async Task<IActionResult> PutSafezone(int id, SafezoneUpdateDTO safezoneDTO)
        {
            try
            {
                var safezone = _mapper.Map<Safezone>(safezoneDTO);
                safezone.Id = id;
                await _service.UpdateSafezone(safezone);
            }
            catch (SafezoneNotFoundException e)
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
        /// Delete one safezone in a map.
        /// </summary>
        /// <param name="id">Identifier of safezone.</param>
        /// <returns></returns>
        [HttpDelete("{mapId}/safezone/{id}")]
        public async Task<IActionResult> DeleteSafezone(int id)
        {
            try
            {
                await _service.DeleteSafezone(id);
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
