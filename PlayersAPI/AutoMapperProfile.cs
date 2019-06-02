using AutoMapper;
using PlayersAPI.DTO;
using PlayersAPI.Models;

namespace PlayersAPI
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Player, PlayerDto>()
                .ForMember(pDto => pDto.Guid, map => map.MapFrom(p => p.Guid.ToString()));

            CreateMap<Team, TeamDto>();
        }
    }
}
