using AutoMapper;
using hvz_backend.Exceptions;
using hvz_backend.Models;
using hvz_backend.Models.DTOs.Supply;
using hvz_backend.Models.DTOs.Supply;
using hvz_backend.Services.SupplyServices;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace hvz_backend.Controllers
{
    [Route("api/v1/map")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class SuppliesController : ControllerBase
    {
        #region Fields & Constructor
        private readonly ISupplyService _service;
        private readonly IMapper _mapper;

        // Sets the service and mapper for this controller via constructor.
        public SuppliesController(ISupplyService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        #endregion

        /// <summary>
        /// Create a supply for the map
        /// </summary>
        /// <param name="createSupplyDTO"></param>
        /// <returns></returns>
        #region HTTP POST
        [HttpPost("{mapId}/supply")]
        public async Task<ActionResult<Supply>> CreateSupply(SupplyCreateDTO createSupplyDTO)
        {
            try
            {
                var supply = _mapper.Map<Supply>(createSupplyDTO);
                await _service.CreateSupply(supply);
                return CreatedAtAction(nameof(GetSupplyByIdInMap), new {mapId = supply.MapId, id = supply.Id }, supply);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion

        #region HTTP GETs
        /// <summary>
        /// Get all supplies in one specific map.
        /// </summary>
        /// <param name="mapId">The identifier of the map.</param>
        /// <returns>List of supplies</returns>
        [HttpGet("{mapId}/supply")]
        public async Task<ActionResult<IEnumerable<SupplyReadDTO>>> GetAllSuppliesInMap(int mapId)
        {
            try
            {
                return Ok(_mapper.Map<IEnumerable<SupplyReadDTO>>(await _service.GetAllSuppliesInMap(mapId)));
            }
            catch (SupplyNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        /// <summary>
        /// Get one specific supply in a specific map.
        /// </summary>
        /// <param name="mapId">Identifier of the map.</param>
        /// <param name="id">Identifier of the supply.</param>
        /// <returns>One supply.</returns>
        [HttpGet("{mapId}/supply/{id}")]
        public async Task<ActionResult<SupplyReadDTO>> GetSupplyByIdInMap(int mapId, int id)
        {
            try
            {
                return Ok(_mapper.Map<SupplyReadDTO>(await _service.GetSupplyByIdInMap(mapId, id)));
            }
            catch (SupplyNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }
        [HttpGet("{mapId}/supply/{id}/title")]
        public async Task<ActionResult<SupplyTitleDTO>> GetTitleSupply(int mapId, int id)
        {
            try
            {
                return Ok(_mapper.Map<SupplyTitleDTO>(await _service.GetSupplyByIdInMap(mapId, id)));
            }
            catch (KillNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{mapId}/supply/{id}/description")]
        public async Task<ActionResult<SupplyDescriptionDTO>> GetDescriptionSupply(int mapId, int id)
        {
            try
            {
                return Ok(_mapper.Map<SupplyDescriptionDTO>(await _service.GetSupplyByIdInMap(mapId, id)));
            }
            catch (KillNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{mapId}/supply/{id}/latitude")]
        public async Task<ActionResult<SupplyLatDTO>> GetLatitudeSupply(int mapId, int id)
        {
            try
            {
                return Ok(_mapper.Map<SupplyLatDTO>(await _service.GetSupplyByIdInMap(mapId, id)));
            }
            catch (KillNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{mapId}/supply/{id}/longitude")]
        public async Task<ActionResult<SupplyLatDTO>> GetLongitudeSupply(int mapId, int id)
        {
            try
            {
                return Ok(_mapper.Map<SupplyLatDTO>(await _service.GetSupplyByIdInMap(mapId, id)));
            }
            catch (KillNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{mapId}/supply/{id}/visible/zombie")]
        public async Task<ActionResult<SupplyZombieDTO>> GetZombieVisibleSupply(int mapId, int id)
        {
            try
            {
                return Ok(_mapper.Map<SupplyZombieDTO>(await _service.GetSupplyByIdInMap(mapId, id)));
            }
            catch (KillNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{mapId}/supply/{id}/visible/human")]
        public async Task<ActionResult<SupplyHumanDTO>> GetHumanVisibleSupply(int mapId, int id)
        {
            try
            {
                return Ok(_mapper.Map<SupplyHumanDTO>(await _service.GetSupplyByIdInMap(mapId, id)));
            }
            catch (KillNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{mapId}/supply/{id}/begintime")]
        public async Task<ActionResult<SupplyBeginDTO>> GetBeginTimeSupply(int mapId, int id)
        {
            try
            {
                return Ok(_mapper.Map<SupplyBeginDTO>(await _service.GetSupplyByIdInMap(mapId, id)));
            }
            catch (KillNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{mapId}/supply/{id}/endtime")]
        public async Task<ActionResult<SupplyEndDTO>> GetEndTimeSupply(int mapId, int id)
        {
            try
            {
                return Ok(_mapper.Map<SupplyEndDTO>(await _service.GetSupplyByIdInMap(mapId, id)));
            }
            catch (KillNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{mapId}/supply/{id}/drop")]
        public async Task<ActionResult<SupplyDropDTO>> GetDropSupply(int mapId, int id)
        {
            try
            {
                return Ok(_mapper.Map<SupplyDropDTO>(await _service.GetSupplyByIdInMap(mapId, id)));
            }
            catch (KillNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{mapId}/supply/{id}/drop/amount")]
        public async Task<ActionResult<SupplyAmountDTO>> GetAmountSupply(int mapId, int id)
        {
            try
            {
                return Ok(_mapper.Map<SupplyAmountDTO>(await _service.GetSupplyByIdInMap(mapId, id)));
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
        [HttpPatch("{mapId}/Supply/{id}/title")]
        public async Task<ActionResult> PatchTitleSupply(int mapId, int id, [FromBody] SupplyTitleDTO supplyTitleDTO)
        {
            try
            {
                await _service.PatchTitleSupply(mapId, id, supplyTitleDTO.Title);
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

        [HttpPatch("{mapId}/Supply/{id}/description")]
        public async Task<ActionResult> PatchDescriptionSupply(int mapId, int id, [FromBody] SupplyDescriptionDTO supplyDescriptionDTO)
        {
            try
            {
                await _service.PatchDescriptionSupply(mapId, id, supplyDescriptionDTO.Description);
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

        [HttpPatch("{mapId}/Supply/{id}/latitude")]
        public async Task<ActionResult> PatchLatSupply(int mapId, int id, [FromBody] SupplyLatDTO supplyLatDTO)
        {
            try
            {
                await _service.PatchLatSupply(mapId, id, supplyLatDTO.Latitude);
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

        [HttpPatch("{mapId}/Supply/{id}/longitude")]
        public async Task<ActionResult> PatchLongSupply(int mapId, int id, [FromBody] SupplyLongDTO supplyLongDTO)
        {
            try
            {
                await _service.PatchLongSupply(mapId, id, supplyLongDTO.Longitude);
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

        [HttpPatch("{mapId}/Supply/{id}/visible/human")]
        public async Task<ActionResult> PatchHumanSupply(int mapId, int id, [FromBody] SupplyHumanDTO supplyHumanDTO)
        {
            try
            {
                await _service.PatchHumanSupply(mapId, id, supplyHumanDTO.HumanVisible);
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

        [HttpPatch("{mapId}/Supply/{id}/visible/zombie")]
        public async Task<ActionResult> PatchZombieSupply(int mapId, int id, [FromBody] SupplyZombieDTO supplyZombieDTO)
        {
            try
            {
                await _service.PatchZombieSupply(mapId, id, supplyZombieDTO.ZombieVisible);
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

        [HttpPatch("{mapId}/Supply/{id}/endtime")]
        public async Task<ActionResult> PatchEndSupply(int mapId, int id, [FromBody] SupplyEndDTO supplyEndDTO)
        {
            try
            {
                await _service.PatchEndSupply(mapId, id, supplyEndDTO.EndTime);
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

        [HttpPatch("{mapId}/Supply/{id}/begintime")]
        public async Task<ActionResult> PatchBeginSupply(int mapId, int id, [FromBody] SupplyBeginDTO supplyBeginDTO)
        {
            try
            {
                await _service.PatchBeginSupply(mapId, id, supplyBeginDTO.BeginTime);
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

        [HttpPatch("{mapId}/Supply/{id}/drop")]
        public async Task<ActionResult> PatchDropSupply(int mapId, int id, [FromBody] SupplyDropDTO supplyDropDTO)
        {
            try
            {
                await _service.PatchDropSupply(mapId, id, supplyDropDTO.Drop);
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

        [HttpPatch("{mapId}/Supply/{id}/drop/amount")]
        public async Task<ActionResult> PatchAmountSupply(int mapId, int id, [FromBody] SupplyAmountDTO supplyAmountDTO)
        {
            try
            {
                await _service.PatchAmountSupply(mapId, id, supplyAmountDTO.Amount);
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
        /// Possible to update one supply.
        /// </summary>
        /// <param name="id">Identifier of the supply.</param>
        /// <param name="supplyDTO"></param>
        /// <returns></returns>
        [HttpPut("{mapId}/supply/{id}")]
        public async Task<IActionResult> PutSupply(int id, SupplyUpdateDTO supplyDTO)
        {
            try
            {
                var supply = _mapper.Map<Supply>(supplyDTO);
                supply.Id = id;
                await _service.UpdateSupply(supply);
            }
            catch (SupplyNotFoundException e)
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
        /// Delete one supply in a map.
        /// </summary>
        /// <param name="id">Identifier of supply.</param>
        /// <returns></returns>
        [HttpDelete("{mapId}/supply/{id}")]
        public async Task<IActionResult> DeleteSupply(int id)
        {
            try
            {
                await _service.DeleteSupply(id);
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
