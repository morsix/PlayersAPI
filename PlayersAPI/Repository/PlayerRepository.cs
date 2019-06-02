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

        public IQueryable<Player> Get(string keyword)
        {
            var query = _context.Players.Include(p => p.Team).Where(p=>p.Guid == p.Guid);

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(p => EF.Functions.Like(p.Name, $"%{keyword}%"));
            }

            return query;
        }
    }
}
