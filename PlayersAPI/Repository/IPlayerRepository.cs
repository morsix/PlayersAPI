using PlayersAPI.Models;
using System.Linq;

namespace PlayersAPI.Repository
{
    public interface IPlayerRepository
    {
        IQueryable<Player> Get(string keyword);
    }
}
