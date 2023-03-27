using AutoMapper;
using hvz_backend.Exceptions;
using hvz_backend.Models;
using hvz_backend.Models.DTOs.Mission;
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

        [HttpGet("{mapId}/mission/{id}/title")]
        public async Task<ActionResult<MissionTitleDTO>> GetTitleMission(int mapId, int id)
        {
            try
            {
                return Ok(_mapper.Map<MissionTitleDTO>(await _service.GetMissionByIdInMap(mapId, id)));
            }
            catch (KillNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{mapId}/mission/{id}/description")]
        public async Task<ActionResult<MissionDescriptionDTO>> GetDescriptionMission(int mapId, int id)
        {
            try
            {
                return Ok(_mapper.Map<MissionDescriptionDTO>(await _service.GetMissionByIdInMap(mapId, id)));
            }
            catch (KillNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{mapId}/mission/{id}/latitude")]
        public async Task<ActionResult<MissionLatDTO>> GetLatitudeMission(int mapId, int id)
        {
            try
            {
                return Ok(_mapper.Map<MissionLatDTO>(await _service.GetMissionByIdInMap(mapId, id)));
            }
            catch (KillNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{mapId}/mission/{id}/longitude")]
        public async Task<ActionResult<MissionLatDTO>> GetLongitudeMission(int mapId, int id)
        {
            try
            {
                return Ok(_mapper.Map<MissionLatDTO>(await _service.GetMissionByIdInMap(mapId, id)));
            }
            catch (KillNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{mapId}/mission/{id}/visible/zombie")]
        public async Task<ActionResult<MissionZombieDTO>> GetZombieVisibleMission(int mapId, int id)
        {
            try
            {
                return Ok(_mapper.Map<MissionZombieDTO>(await _service.GetMissionByIdInMap(mapId, id)));
            }
            catch (KillNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{mapId}/mission/{id}/visible/human")]
        public async Task<ActionResult<MissionHumanDTO>> GetHumanVisibleMission(int mapId, int id)
        {
            try
            {
                return Ok(_mapper.Map<MissionHumanDTO>(await _service.GetMissionByIdInMap(mapId, id)));
            }
            catch (KillNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{mapId}/mission/{id}/begintime")]
        public async Task<ActionResult<MissionBeginDTO>> GetBeginTimeMission(int mapId, int id)
        {
            try
            {
                return Ok(_mapper.Map<MissionBeginDTO>(await _service.GetMissionByIdInMap(mapId, id)));
            }
            catch (KillNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{mapId}/mission/{id}/endtime")]
        public async Task<ActionResult<MissionEndDTO>> GetEndTimeMission(int mapId, int id)
        {
            try
            {
                return Ok(_mapper.Map<MissionEndDTO>(await _service.GetMissionByIdInMap(mapId, id)));
            }
            catch (KillNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{mapId}/mission/{id}/radius")]
        public async Task<ActionResult<MissionRadiusDTO>> GetRadiusMission(int mapId, int id)
        {
            try
            {
                return Ok(_mapper.Map<MissionRadiusDTO>(await _service.GetMissionByIdInMap(mapId, id)));
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
        [HttpPatch("{mapId}/mission/{id}/title")]
        public async Task<ActionResult> PatchTitleMission(int mapId, int id, [FromBody] MissionTitleDTO missionTitleDTO)
        {
            try
            {
                await _service.PatchTitleMission(mapId, id, missionTitleDTO.Title);
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

        [HttpPatch("{mapId}/mission/{id}/description")]
        public async Task<ActionResult> PatchDescriptionMission(int mapId, int id, [FromBody] MissionDescriptionDTO missionDescriptionDTO)
        {
            try
            {
                await _service.PatchDescriptionMission(mapId, id, missionDescriptionDTO.Description);
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

        [HttpPatch("{mapId}/mission/{id}/latitude")]
        public async Task<ActionResult> PatchLatMission(int mapId, int id, [FromBody] MissionLatDTO missionLatDTO)
        {
            try
            {
                await _service.PatchLatMission(mapId, id, missionLatDTO.Latitude);
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

        [HttpPatch("{mapId}/mission/{id}/longitude")]
        public async Task<ActionResult> PatchLongMission(int mapId, int id, [FromBody] MissionLongDTO missionLongDTO)
        {
            try
            {
                await _service.PatchLongMission(mapId, id, missionLongDTO.Longitude);
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

        [HttpPatch("{mapId}/mission/{id}/visible/human")]
        public async Task<ActionResult> PatchHumanMission(int mapId, int id, [FromBody] MissionHumanDTO missionHumanDTO)
        {
            try
            {
                await _service.PatchHumanMission(mapId, id, missionHumanDTO.HumanVisible);
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

        [HttpPatch("{mapId}/mission/{id}/visible/zombie")]
        public async Task<ActionResult> PatchZombieMission(int mapId, int id, [FromBody] MissionZombieDTO missionZombieDTO)
        {
            try
            {
                await _service.PatchZombieMission(mapId, id, missionZombieDTO.ZombieVisible);
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

        [HttpPatch("{mapId}/mission/{id}/endtime")]
        public async Task<ActionResult> PatchEndMission(int mapId, int id, [FromBody] MissionEndDTO missionEndDTO)
        {
            try
            {
                await _service.PatchEndMission(mapId, id, missionEndDTO.EndTime);
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

        [HttpPatch("{mapId}/mission/{id}/begintime")]
        public async Task<ActionResult> PatchBeginMission(int mapId, int id, [FromBody] MissionBeginDTO missionBeginDTO)
        {
            try
            {
                await _service.PatchBeginMission(mapId, id, missionBeginDTO.BeginTime);
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

        [HttpPatch("{mapId}/mission/{id}/radius")]
        public async Task<ActionResult> PatchRadiusMission(int mapId, int id, [FromBody] MissionRadiusDTO missionRadiusDTO)
        {
            try
            {
                await _service.PatchRadiusMission(mapId, id, missionRadiusDTO.Radius);
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
