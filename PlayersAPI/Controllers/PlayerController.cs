using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using PlayersAPI.DTO;
using System.Collections.Generic;

namespace PlayersAPI.Controllers
{
    [EnableCors("AllowMyOrigin")]
    [Route("api/players")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        // GET api/players
        [HttpGet]
        public ActionResult<IEnumerable<PlayerDto>> Get()
        {
            var players = new List<PlayerDto>() {
                 new PlayerDto()
                 {
                     Name = "Cele",
                     Team = new TeamDto()
                     {
                         Name = "Barcelona"
                     }

                 },
                 new PlayerDto()
                 {
                     Name = "Victor",
                     Team = new TeamDto()
                     {
                         Name = "Real"
                     }
                 }
            };

            return Ok(players);

        }
    }
}