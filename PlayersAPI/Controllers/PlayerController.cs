using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using PlayersAPI.DTO;
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
        [HttpGet]
        public ActionResult<IEnumerable<PlayerDto>> Get()
        {
            var players = _playerService.Get();

            return Ok(players);
        }
    }
}