using AutoMapper;
using hvz_backend.Exceptions;
using hvz_backend.Models.DTOs.Game;
using hvz_backend.Services.GameServices;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace hvz_backend.Controllers
{
    [Route("api/v1/games")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class GamesController : ControllerBase
    {
        #region Fields & Constructor
        private readonly IGameService _service;
        private readonly IMapper _mapper;

        // Sets the service and mapper for this controller via constructor.
        public GamesController(IGameService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        #endregion

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GameReadDTO>>> GetAllGames()
        {
            try
            {
                return Ok(_mapper.Map<IEnumerable<GameReadDTO>>(await _service.GetAllGames()));
            }
            catch (GameNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }
    }
}
