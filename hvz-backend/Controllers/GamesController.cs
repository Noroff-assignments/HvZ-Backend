using AutoMapper;
using hvz_backend.Exceptions;
using hvz_backend.Models;
using hvz_backend.Models.DTOs.Game;
using hvz_backend.Services.GameServices;
using Microsoft.AspNetCore.Authorization;
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

        /// <summary>
        /// Get the title of a specific game.
        /// </summary>
        /// <param name="id">Identifier of game.</param>
        /// <returns>title as a string</returns>
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
        /// <summary>
        /// Get the state of a game.
        /// </summary>
        /// <param name="id">Identifier of game</param>
        /// <returns>the state of game in int (0=open for registration, 1=running and 2= completed)</returns>
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
        /// <summary>
        /// Ge the time when the game ends.
        /// </summary>
        /// <param name="id">Identifier of game</param>
        /// <returns>The endtime in a DateTime format</returns>
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

        /// <summary>
        /// Get the begining time of a game.
        /// </summary>
        /// <param name="id">Identifier of game.</param>
        /// <returns>The begin time in a DateTime format</returns>
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

        /// <summary>
        /// Get the description of a game
        /// </summary>
        /// <param name="id">Identifier of game</param>
        /// <returns>The description in a string</returns>
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
        /// <summary>
        /// Get the userid of the admin on a game
        /// </summary>
        /// <param name="id">Identifier of game</param>
        /// <returns>User id of the admin in a string</returns>
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

        /// <summary>
        /// Get the total amount of players in a game
        /// </summary>
        /// <param name="id">Identifer of game</param>
        /// <returns>Int value of total amount players</returns>
        [HttpGet("{id}/amountplayers")]
        public async Task<ActionResult<GamePlayersDTO>> GetAmountPlayerGame(int id)
        {
            try
            {
                return Ok(_mapper.Map<GamePlayersDTO>(await _service.GetGameById(id)));
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
        /// <summary>
        /// Update the title of a gmae
        /// </summary>
        /// <param name="id">Identifier of game</param>
        /// <param name="gameTitleDTO">Game object with Title</param>
        /// <returns></returns>
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
        /// <summary>
        /// Update the state of the game
        /// </summary>
        /// <param name="id">Identifier of game</param>
        /// <param name="gameStateDTO">Game object with int field for Status (0=open for registrating, 1=running, 2=completed)</param>
        /// <returns></returns>
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
        /// <summary>
        /// Update the begin time of game
        /// </summary>
        /// <param name="id">Identifier of game</param>
        /// <param name="gameBeginTimeDTO">Game object with BeginTime</param>
        /// <returns></returns>
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
        /// <summary>
        /// Update the end time of game
        /// </summary>
        /// <param name="id">Identifier of game</param>
        /// <param name="gameEndTimeDTO">Game object with EndTime</param>
        /// <returns></returns>
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

        /// <summary>
        /// Update the description of game
        /// </summary>
        /// <param name="id">Identifier of game</param>
        /// <param name="gameDescriptionDTO">Game object with field for Description</param>
        /// <returns></returns>
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
        /// <summary>
        /// Update the admin user in game
        /// </summary>
        /// <param name="id">Identifier of game</param>
        /// <param name="gameAdminDTO">Game object with field Admin</param>
        /// <returns></returns>
        [HttpPatch("{id}/admin")]
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
        /// <summary>
        /// Update the amount of player in game
        /// </summary>
        /// <param name="id">Identifier of game</param>
        /// <param name="gamePlayerDTO">Game object with field AmountPlayers</param>
        /// <returns></returns>
        [HttpPatch("{id}/amountplayers")]
        public async Task<ActionResult> PatchAmountGame(int id, [FromBody] GamePlayersDTO gamePlayerDTO)
        {
            try
            {
                await _service.PatchAmountGame(id, gamePlayerDTO.Amount);
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
        /// <param name="gameDTO">The game object</param>
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
