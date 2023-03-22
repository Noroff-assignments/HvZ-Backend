using AutoMapper;
using hvz_backend.Exceptions;
using hvz_backend.Models;
using hvz_backend.Models.DTOs.Mission;
using hvz_backend.Models.DTOs.Mission;
using hvz_backend.Services.MissionServices;
using hvz_backend.Services.MissionServices;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace hvz_backend.Controllers
{
    [Route("api/v1/map")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class MissionsController : ControllerBase
    {
        #region Fields & Constructor
        private readonly IMissionService _service;
        private readonly IMapper _mapper;

        // Sets the service and mapper for this controller via constructor.
        public MissionsController(IMissionService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        #endregion

        /// <summary>
        /// Create a mission for the map
        /// </summary>
        /// <param name="createMissionDTO"></param>
        /// <returns></returns>
        #region HTTP POST
        [HttpPost("{mapId}/mission")]
        public async Task<ActionResult<Mission>> CreateMission(MissionCreateDTO createMissionDTO)
        {
            try
            {
                var mission = _mapper.Map<Mission>(createMissionDTO);
                await _service.CreateMission(mission);
                return CreatedAtAction(nameof(GetMissionByIdInGame), new { mapId = mission.MapId, id = mission.Id }, mission);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion

        #region HTTP GETs
        /// <summary>
        /// Get all missions in one specific map.
        /// </summary>
        /// <param name="mapId">The identifier of the map.</param>
        /// <returns>List of missions</returns>
        [HttpGet("{mapId}/mission")]
        public async Task<ActionResult<IEnumerable<MissionReadDTO>>> GetAllMissionsInGame(int mapId)
        {
            try
            {
                return Ok(_mapper.Map<IEnumerable<MissionReadDTO>>(await _service.GetAllMissionsInMap(mapId)));
            }
            catch (MissionNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        /// <summary>
        /// Get one specific mission in a specific map.
        /// </summary>
        /// <param name="mapId">Identifier of the map.</param>
        /// <param name="id">Identifier of the mission.</param>
        /// <returns>One mission.</returns>
        [HttpGet("{mapId}/mission/{id}")]
        public async Task<ActionResult<MissionReadDTO>> GetMissionByIdInGame(int mapId, int id)
        {
            try
            {
                return Ok(_mapper.Map<MissionReadDTO>(await _service.GetMissionByIdInMap(mapId, id)));
            }
            catch (MissionNotFoundException e)
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
        /// Possible to update one mission.
        /// </summary>
        /// <param name="id">Identifier of the mission.</param>
        /// <param name="missionDTO"></param>
        /// <returns></returns>
        [HttpPut("{mapId}/mission/{id}")]
        public async Task<IActionResult> PutMission(int id, MissionUpdateDTO missionDTO)
        {
            try
            {
                var mission = _mapper.Map<Mission>(missionDTO);
                mission.Id = id;
                await _service.UpdateMission(mission);
            }
            catch (MissionNotFoundException e)
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
        /// Delete one mission in a map.
        /// </summary>
        /// <param name="id">Identifier of mission.</param>
        /// <returns></returns>
        [HttpDelete("{mapId}/mission/{id}")]
        public async Task<IActionResult> DeleteMission(int id)
        {
            try
            {
                await _service.DeleteMission(id);
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
