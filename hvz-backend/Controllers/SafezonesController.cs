using AutoMapper;
using hvz_backend.Exceptions;
using hvz_backend.Models;
using hvz_backend.Models.DTOs.Safezone;
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
        /// <summary>
        /// Create a safezone in map
        /// </summary>
        /// <param name="createSafezoneDTO"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Get title of safezone in map
        /// </summary>
        /// <param name="mapId">Identifier of map</param>
        /// <param name="id">Identifer of safezone</param>
        /// <returns>String</returns>
        [HttpGet("{mapId}/safezone/{id}/title")]
        public async Task<ActionResult<SafezoneTitleDTO>> GetTitleSafezone(int mapId, int id)
        {
            try
            {
                return Ok(_mapper.Map<SafezoneTitleDTO>(await _service.GetSafezoneByIdInMap(mapId, id)));
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
        /// Get the description of safezone in map
        /// </summary>
        /// <param name="mapId">Identifier of map</param>
        /// <param name="id">Identifier of safezone</param>
        /// <returns></returns>
        [HttpGet("{mapId}/safezone/{id}/description")]
        public async Task<ActionResult<SafezoneDescriptionDTO>> GetDescriptionSafezone(int mapId, int id)
        {
            try
            {
                return Ok(_mapper.Map<SafezoneDescriptionDTO>(await _service.GetSafezoneByIdInMap(mapId, id)));
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
        /// Get the latitude of safezone in map
        /// </summary>
        /// <param name="mapId">Identifier of map</param>
        /// <param name="id">Identifier of safezone</param>
        /// <returns></returns>
        [HttpGet("{mapId}/safezone/{id}/latitude")]
        public async Task<ActionResult<SafezoneLatDTO>> GetLatitudeSafezone(int mapId, int id)
        {
            try
            {
                return Ok(_mapper.Map<SafezoneLatDTO>(await _service.GetSafezoneByIdInMap(mapId, id)));
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
        /// Get longitude of safezone in map
        /// </summary>
        /// <param name="mapId">Identifier of map</param>
        /// <param name="id">Identifer of safezone</param>
        /// <returns></returns>
        [HttpGet("{mapId}/safezone/{id}/longitude")]
        public async Task<ActionResult<SafezoneLatDTO>> GetLongitudeSafezone(int mapId, int id)
        {
            try
            {
                return Ok(_mapper.Map<SafezoneLatDTO>(await _service.GetSafezoneByIdInMap(mapId, id)));
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
        /// Get the visibility of safezone toward zombies in map
        /// </summary>
        /// <param name="mapId">Identifier of map</param>
        /// <param name="id">Identifier of safezone</param>
        /// <returns>Boolean</returns>
        [HttpGet("{mapId}/safezone/{id}/visible/zombie")]
        public async Task<ActionResult<SafezoneZombieDTO>> GetZombieVisibleSafezone(int mapId, int id)
        {
            try
            {
                return Ok(_mapper.Map<SafezoneZombieDTO>(await _service.GetSafezoneByIdInMap(mapId, id)));
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
        /// Get the visibility of safezone toward humans in map
        /// </summary>
        /// <param name="mapId">Identifier of map</param>
        /// <param name="id">Identifier of safezone </param>
        /// <returns>Boolean</returns>
        [HttpGet("{mapId}/safezone/{id}/visible/human")]
        public async Task<ActionResult<SafezoneHumanDTO>> GetHumanVisibleSafezone(int mapId, int id)
        {
            try
            {
                return Ok(_mapper.Map<SafezoneHumanDTO>(await _service.GetSafezoneByIdInMap(mapId, id)));
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
        /// Get the begin time of the safezone in map
        /// </summary>
        /// <param name="mapId">Identifier of map</param>
        /// <param name="id">Identifier of safezone</param>
        /// <returns>dateTime</returns>
        [HttpGet("{mapId}/safezone/{id}/begintime")]
        public async Task<ActionResult<SafezoneBeginDTO>> GetBeginTimeSafezone(int mapId, int id)
        {
            try
            {
                return Ok(_mapper.Map<SafezoneBeginDTO>(await _service.GetSafezoneByIdInMap(mapId, id)));
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
        /// Get the end time of safezone in map
        /// </summary>
        /// <param name="mapId">Identifier of map</param>
        /// <param name="id">Identifier of safezone</param>
        /// <returns>DateTime</returns>
        [HttpGet("{mapId}/safezone/{id}/endtime")]
        public async Task<ActionResult<SafezoneEndDTO>> GetEndTimeSafezone(int mapId, int id)
        {
            try
            {
                return Ok(_mapper.Map<SafezoneEndDTO>(await _service.GetSafezoneByIdInMap(mapId, id)));
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
        /// Get the radius of safezone in map
        /// </summary>
        /// <param name="mapId">Identifier of map</param>
        /// <param name="id">Identifier of safezone</param>
        /// <returns>DateTime</returns>
        [HttpGet("{mapId}/safezone/{id}/radius")]
        public async Task<ActionResult<SafezoneRadiusDTO>> GetRadiusSafezone(int mapId, int id)
        {
            try
            {
                return Ok(_mapper.Map<SafezoneRadiusDTO>(await _service.GetSafezoneByIdInMap(mapId, id)));
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
        /// <summary>
        /// Update the title of safezone in map
        /// </summary>
        /// <param name="mapId">Identifier of map</param>
        /// <param name="id">Identifier of safezone</param>
        /// <param name="safezoneTitleDTO"></param>
        /// <returns></returns>
        #region HTTP PATCH
        [HttpPatch("{mapId}/safezone/{id}/title")]
        public async Task<ActionResult> PatchTitleSafezone(int mapId, int id, [FromBody] SafezoneTitleDTO safezoneTitleDTO)
        {
            try
            {
                await _service.PatchTitleSafezone(mapId, id, safezoneTitleDTO.Title);
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
        /// <summary>
        /// Update the description of safezone in map
        /// </summary>
        /// <param name="mapId">Identifier of map</param>
        /// <param name="id">Identifier of safezone</param>
        /// <param name="safezoneDescriptionDTO"></param>
        /// <returns></returns>
        [HttpPatch("{mapId}/safezone/{id}/description")]
        public async Task<ActionResult> PatchDescriptionSafezone(int mapId, int id, [FromBody] SafezoneDescriptionDTO safezoneDescriptionDTO)
        {
            try
            {
                await _service.PatchDescriptionSafezone(mapId, id, safezoneDescriptionDTO.Description);
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
        /// <summary>
        /// Update the latitude of safezone in map
        /// </summary>
        /// <param name="mapId">Identifier of map</param>
        /// <param name="id">Identifier of safezone</param>
        /// <param name="safezoneLatDTO"></param>
        /// <returns></returns>
        [HttpPatch("{mapId}/safezone/{id}/latitude")]
        public async Task<ActionResult> PatchLatSafezone(int mapId, int id, [FromBody] SafezoneLatDTO safezoneLatDTO)
        {
            try
            {
                await _service.PatchLatSafezone(mapId, id, safezoneLatDTO.Latitude);
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
        /// <summary>
        /// Update longitude of safezone in map
        /// </summary>
        /// <param name="mapId">Identifier of map</param>
        /// <param name="id">Identifier of safezone</param>
        /// <param name="safezoneLongDTO"></param>
        /// <returns></returns>
        [HttpPatch("{mapId}/safezone/{id}/longitude")]
        public async Task<ActionResult> PatchLongSafezone(int mapId, int id, [FromBody] SafezoneLonDTO safezoneLongDTO)
        {
            try
            {
                await _service.PatchLongSafezone(mapId, id, safezoneLongDTO.Longitude);
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
        /// <summary>
        /// Update the visibility of safezone toward humans in map
        /// </summary>
        /// <param name="mapId">Identifier of map</param>
        /// <param name="id">Identifier of safezone</param>
        /// <param name="safezoneHumanDTO"></param>
        /// <returns></returns>
        [HttpPatch("{mapId}/safezone/{id}/visible/human")]
        public async Task<ActionResult> PatchHumanSafezone(int mapId, int id, [FromBody] SafezoneHumanDTO safezoneHumanDTO)
        {
            try
            {
                await _service.PatchHumanSafezone(mapId, id, safezoneHumanDTO.HumanVisible);
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
        /// <summary>
        /// Update visibility of safezone toward zombies in map
        /// </summary>
        /// <param name="mapId">Identifier of map</param>
        /// <param name="id">Identifier of safezone</param>
        /// <param name="safezoneZombieDTO"></param>
        /// <returns></returns>
        [HttpPatch("{mapId}/safezone/{id}/visible/zombie")]
        public async Task<ActionResult> PatchZombieSafezone(int mapId, int id, [FromBody] SafezoneZombieDTO safezoneZombieDTO)
        {
            try
            {
                await _service.PatchZombieSafezone(mapId, id, safezoneZombieDTO.ZombieVisible);
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
        /// <summary>
        /// Updat the end time of safezone in map
        /// </summary>
        /// <param name="mapId">Identifier of map</param>
        /// <param name="id">Identifier of safezone</param>
        /// <param name="safezoneEndDTO"></param>
        /// <returns></returns>
        [HttpPatch("{mapId}/safezone/{id}/endtime")]
        public async Task<ActionResult> PatchEndSafezone(int mapId, int id, [FromBody] SafezoneEndDTO safezoneEndDTO)
        {
            try
            {
                await _service.PatchEndSafezone(mapId, id, safezoneEndDTO.EndTime);
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
        /// <summary>
        /// Update the begin time of safezone in map
        /// </summary>
        /// <param name="mapId">Identifier of map</param>
        /// <param name="id">Identifier of safezone</param>
        /// <param name="safezoneBeginDTO"></param>
        /// <returns></returns>
        [HttpPatch("{mapId}/safezone/{id}/begintime")]
        public async Task<ActionResult> PatchBeginSafezone(int mapId, int id, [FromBody] SafezoneBeginDTO safezoneBeginDTO)
        {
            try
            {
                await _service.PatchBeginSafezone(mapId, id, safezoneBeginDTO.BeginTime);
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
        /// <summary>
        /// Update the radius of safezone in map
        /// </summary>
        /// <param name="mapId">Identifier of map</param>
        /// <param name="id">Identifier of safezone</param>
        /// <param name="safezoneRadiusDTO"></param>
        /// <returns></returns>
        [HttpPatch("{mapId}/safezone/{id}/radius")]
        public async Task<ActionResult> PatchRadiusSafezone(int mapId, int id, [FromBody] SafezoneRadiusDTO safezoneRadiusDTO)
        {
            try
            {
                await _service.PatchRadiusSafezone(mapId, id, safezoneRadiusDTO.Radius);
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
