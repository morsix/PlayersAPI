using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using PlayersAPI.DTO;
using PlayersAPI.Repository;

namespace PlayersAPI.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;

        private readonly IMapper _mapper;

        public PlayerService(IPlayerRepository playerRepository, IMapper mapper)
        {
            _playerRepository = playerRepository;
            _mapper = mapper;
        }

        public IEnumerable<PlayerDto> Get()
        {
            var entities = _playerRepository.Get();

            return  _mapper.Map<IEnumerable<PlayerDto>>(entities);
        }
    }
}
