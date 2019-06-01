using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PlayersAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayersAPI
{
    public class DataGenerator
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PlayersDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<PlayersDbContext>>()))
            {
                // Look for any board games.
                if (context.Players.Any())
                {
                    return;   // Data was already seeded
                }

                context.Players.AddRange(
                    new PlayerDto()
                    {
                        Age = 1,
                        Guid = "aaaa",
                        Name = "Cele",
                        Team = new TeamDto()
                        {
                            Id = 1,
                            Name = "Barcelona"
                        }

                    },
                     new PlayerDto()
                     {
                         Age = 2,
                         Guid = "bbb",
                         Name = "Victor",
                         Team = new TeamDto()
                         {
                             Id = 2,
                             Name = "Real"
                         }
                     }
                     );

                context.SaveChanges();
            }
        }
    }
}
