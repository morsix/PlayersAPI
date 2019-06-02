using PlayersAPI.DTO;
using PlayersAPI.Helpers;
using System.Collections.Generic;

namespace PlayersAPI.Services
{
    public interface IPlayerService
    {
        PlayerPaginationWrapper Get(PaginationInfo paginationInfo);
    }
}
