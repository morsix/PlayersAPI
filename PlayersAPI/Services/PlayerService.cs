using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using PlayersAPI.DTO;
using PlayersAPI.Helpers;
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

        public PlayerPaginationWrapper Get(PaginationInfo paginationInfo)
        {
            var query = _playerRepository.Get(paginationInfo.Keyword);

            var paginatedQuery = query.Skip(paginationInfo.PageSize * (paginationInfo.Page - 1)).Take(paginationInfo.PageSize);

            var mappings =  _mapper.Map<IEnumerable<PlayerDto>>(paginatedQuery);

            var totalPages = (int)Math.Ceiling((double)query.Count() / paginationInfo.PageSize);

            return new PlayerPaginationWrapper(totalPages, mappings.ToList());

        }
    }
}
