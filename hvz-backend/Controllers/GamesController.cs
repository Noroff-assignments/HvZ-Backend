using AutoMapper;
using hvz_backend.Exceptions;
using hvz_backend.Models;
using hvz_backend.Models.DTOs.Game;
using hvz_backend.Services.GameServices;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace hvz_backend.Controllers
{
    [Route("api/v1/[controller]")]
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


        #region HTTP GETs
        /// <summary>
        /// Get all games from database.
        /// </summary>
        /// <returns>List of games.</returns>
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

        /// <summary>
        /// Get one game information by ID.
        /// </summary>
        /// <param name="id">Unique identifier for a game.</param>
        /// <returns>One specific based on identifier.</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<GameReadDTO>> GetGameById(int id)
        {
            try
            {
                return Ok(_mapper.Map<GameReadDTO>(await _service.GetGameById(id)));
            }
            catch (GameNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }
        #endregion

        #region HTTP POSTs
        /// <summary>
        /// Create a new game in database.
        /// </summary>
        /// <param name="createGameDto"></param>
        /// <returns>Name of the game and Id.</returns>
        [HttpPost]
        public async Task<ActionResult<Game>> CreateGame(GameCreateDTO createGameDto)
        {
            try
            {
                var game = _mapper.Map<Game>(createGameDto);
                await _service.CreateGame(game);
                return CreatedAtAction(nameof(GetGameById), new { id = game.Id }, game);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion

        #region HTTP DELETEs

        #endregion

        #region HTTP PUTs

        #endregion


    }
}
