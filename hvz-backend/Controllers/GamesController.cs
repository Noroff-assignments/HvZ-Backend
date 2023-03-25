using AutoMapper;
using hvz_backend.Exceptions;
using hvz_backend.Models;
using hvz_backend.Models.DTOs.Game;
using hvz_backend.Services.GameServices;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace hvz_backend.Controllers
{
    [Route("api/v1/game")]
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


        #region HTTP POSTs
        /// <summary>
        /// Create a game.
        /// </summary>
        /// <param name="createGameDto"></param>
        /// <returns></returns>
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

        #region HTTP GETs
        /// <summary>
        /// Get all games of the database.
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
        /// Get one specific game.
        /// </summary>
        /// <param name="id">Identifier of game.</param>
        /// <returns>A game object.</returns>
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

        [HttpGet("{id}/title")]
        public async Task<ActionResult<GameTitleDTO>> GetTitleGame(int id)
        {
            try
            {
                return Ok(_mapper.Map<GameTitleDTO>(await _service.GetGameById(id)));
            }
            catch (GameNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{id}/state")]
        public async Task<ActionResult<GameStateDTO>> GetStateGame(int id)
        {
            try
            {
                return Ok(_mapper.Map<GameStateDTO>(await _service.GetGameById(id)));
            }
            catch (GameNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{id}/endtime")]
        public async Task<ActionResult<GameEndTimeDTO>> GetEndTimeGame(int id)
        {
            try
            {
                return Ok(_mapper.Map<GameEndTimeDTO>(await _service.GetGameById(id)));
            }
            catch (GameNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{id}/begintime")]
        public async Task<ActionResult<GameBeginTimeDTO>> GetBeginTimeGame(int id)
        {
            try
            {
                return Ok(_mapper.Map<GameBeginTimeDTO>(await _service.GetGameById(id)));
            }
            catch (GameNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{id}/description")]
        public async Task<ActionResult<GameDescriptionDTO>> GetDescriptionGame(int id)
        {
            try
            {
                return Ok(_mapper.Map<GameDescriptionDTO>(await _service.GetGameById(id)));
            }
            catch (GameNotFoundException e)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = e.Message
                });
            }
        }

        [HttpGet("{id}/admin")]
        public async Task<ActionResult<GameAdminDTO>> GetAdminGame(int id)
        {
            try
            {
                return Ok(_mapper.Map<GameAdminDTO>(await _service.GetGameById(id)));
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


        #region HTTP PATCH
        [HttpPatch("{id}/title")]
        public async Task<ActionResult> PatchTitleGame(int id, [FromBody] GameTitleDTO gameTitleDTO)
        {
            try
            {
                await _service.PatchTitleGame(id, gameTitleDTO.Title); 
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

        [HttpPatch("{id}/state")]
        public async Task<ActionResult> PatchStateGame(int id, [FromBody] GameStateDTO gameStateDTO)
        {
            try
            {
                await _service.PatchStateGame(id, gameStateDTO.Status);
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

        [HttpPatch("{id}/begintime")]
        public async Task<ActionResult> PatchPeriodGame(int id, [FromBody] GameBeginTimeDTO gameBeginTimeDTO)
        {
            try
            {
                await _service.PatchBeginTimeGame(id, gameBeginTimeDTO.BeginTime);
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

        [HttpPatch("{id}/endtime")]
        public async Task<ActionResult> PatchEndtimeGame(int id, [FromBody] GameEndTimeDTO gameEndTimeDTO)
        {
            try
            {
                await _service.PatchEndTimeGame(id, gameEndTimeDTO.EndTime);
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

        [HttpPatch("{id}/Description")]
        public async Task<ActionResult> PatchDescriptionGame(int id, [FromBody] GameDescriptionDTO gameDescriptionDTO)
        {
            try
            {
                await _service.PatchDescriptionGame(id, gameDescriptionDTO.Description);
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

        [HttpPatch("{id}/Admin")]
        public async Task<ActionResult> PatchAdminGame(int id, [FromBody] GameAdminDTO gameAdminDTO)
        {
            try
            {
                await _service.PatchAdminGame(id, gameAdminDTO.AdminID);
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
        /// Possible to update one game.
        /// </summary>
        /// <param name="id">Identifier of the game.</param>
        /// <param name="gameDTO"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGame(int id, GameUpdateDTO gameDTO)
        {
            try
            {
                var game = _mapper.Map<Game>(gameDTO);
                game.Id = id;
                await _service.UpdateGame(game);
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

        #region HTTP DELETE
        /// <summary>
        /// Delete one game.
        /// </summary>
        /// <param name="id">Identifier of game.</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGame(int id)
        {
            try
            {
                await _service.DeleteGame(id);
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
