using AutoMapper;
using hvz_backend.Exceptions;
using hvz_backend.Models;
using hvz_backend.Models.DTOs.Map;
using hvz_backend.Models.DTOs.Supply;
using hvz_backend.Services.MapServices;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace hvz_backend.Controllers
{
    [Route("api/v1/map")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class MapsController : ControllerBase
    {
        #region Fields & Constructor
        private readonly IMapService _service;
        private readonly IMapper _mapper;

        // Sets the service and mapper for this controller via constructor.
        public MapsController(IMapService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        #endregion

        #region HTTP POSTs
        /// <summary>
        /// Create a new map.
        /// </summary>
        /// <param name="createMapDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<Map>> CreateMap(MapCreateDTO createMapDto)
        {
            try
            {
                var map = _mapper.Map<Map>(createMapDto);
                await _service.CreateMap(map);
                return CreatedAtAction(nameof(GetMapById), new { id = map.Id }, map);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion

        #region HTTP GETs
        /// <summary>
        /// Get all the maps of the database.
        /// </summary>
        /// <returns>List of maps.</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MapReadDTO>>> GetAllMaps()
        {
            try
            {
                return Ok(_mapper.Map<IEnumerable<MapReadDTO>>(await _service.GetAllMaps()));
            }
            catch (MapNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        /// <summary>
        /// Get one specific map.
        /// </summary>
        /// <param name="id">Identifier of a map.</param>
        /// <returns>Map object.</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<MapReadDTO>> GetMapById(int id)
        {
            try
            {
                return Ok(_mapper.Map<MapReadDTO>(await _service.GetMapById(id)));
            }
            catch (MapNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }
        #endregion

        #region HTTP PUT

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMap(int id, MapUpdateDTO mapDTO)
        {
            try
            {
                var map = _mapper.Map<Map>(mapDTO);
                map.Id = id;
                await _service.UpdateMap(map);
            }
            catch (MapNotFoundException e)
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMap(int id)
        {
            try
            {
                await _service.DeleteMap(id);
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
