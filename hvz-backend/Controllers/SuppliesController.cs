using AutoMapper;
using hvz_backend.Exceptions;
using hvz_backend.Models;
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
                return CreatedAtAction(nameof(GetSupplyByIdInGame), new {mapId = supply.MapId, id = supply.Id }, supply);
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
        public async Task<ActionResult<IEnumerable<SupplyReadDTO>>> GetAllSuppliesInGame(int mapId)
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
        public async Task<ActionResult<SupplyReadDTO>> GetSupplyByIdInGame(int mapId, int id)
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
