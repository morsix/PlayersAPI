using PlayersAPI.DTO;
using System.Collections.Generic;
namespace PlayersAPI.Helpers
{
    public class PlayerPaginationWrapper
    {
        public PlayerPaginationWrapper(int totalPages, List<PlayerDto> players)
        {
            TotalPages = totalPages;
            Players = players;
        }

        public int TotalPages { get; set; }

        public List<PlayerDto> Players { get; set; }
    }
}
