using Microsoft.EntityFrameworkCore;
using PlayersAPI.Models;

namespace PlayersAPI
{
    public class PlayersDbContext : DbContext
    {
        public PlayersDbContext(DbContextOptions<PlayersDbContext> options)
            : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }

        public DbSet<Team> Teams { get; set; }

    }
}
