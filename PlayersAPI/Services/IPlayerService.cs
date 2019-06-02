using PlayersAPI.DTO;
using System.Collections.Generic;

namespace PlayersAPI.Services
{
    public interface IPlayerService
    {
        IEnumerable<PlayerDto> Get();
    }
}
