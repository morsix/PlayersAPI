using Microsoft.EntityFrameworkCore;
using PlayersAPI.DTO;

namespace PlayersAPI
{
    public class PlayersDbContext : DbContext
    {
        public PlayersDbContext(DbContextOptions<PlayersDbContext> options)
            : base(options)
        {
        }

        public DbSet<PlayerDto> Players { get; set; }

        public DbSet<TeamDto> Teams { get; set; }

    }
}
