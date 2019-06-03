using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using PlayersAPI.DTO;
using PlayersAPI.Helpers;
using PlayersAPI.Services;
using System.Collections.Generic;

namespace PlayersAPI.Controllers
{
    [EnableCors("AllowMyOrigin")]
    [Route("api/players")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService _playerService;
        
        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }
        
        // GET api/players
        [HttpPost]
        public ActionResult<PlayerPaginationWrapper> Get(PaginationInfo paginationInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var players = _playerService.Get(paginationInfo);

            return Ok(players);
        }
    }
}