using System.Linq;
using Microsoft.EntityFrameworkCore;
using PlayersAPI.Models;

namespace PlayersAPI.Repository
{
    public class PlayerRepository : IPlayerRepository
    {
        protected readonly PlayersDbContext _context;

        public PlayerRepository(PlayersDbContext context)
        {
            _context = context;
        }

        public IQueryable<Player> Get()
        {
            return _context.Players.Include(p => p.Team);
        }
    }
}
