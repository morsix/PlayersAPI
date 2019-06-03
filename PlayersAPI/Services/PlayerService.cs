using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PlayersAPI.DTO;
using PlayersAPI.Helpers;
using PlayersAPI.Models;
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
            var query = _playerRepository.Get();

            if (!string.IsNullOrWhiteSpace(paginationInfo.Keyword))
            {
                query = query.Where(p => EF.Functions.Like(p.Name, $"%{paginationInfo.Keyword}%") || EF.Functions.Like(p.Team.Name, $"%{paginationInfo.Keyword}%"));
            }

            if (!string.IsNullOrWhiteSpace(paginationInfo.SortBy))
            {
                query = Sort(paginationInfo.SortBy, paginationInfo.Order, query);
            }

            var paginatedQuery = query.Skip(paginationInfo.PageSize * (paginationInfo.Page - 1)).Take(paginationInfo.PageSize);

            var mappings =  _mapper.Map<IEnumerable<PlayerDto>>(paginatedQuery);

            var totalPages = (int)Math.Ceiling((double)query.Count() / paginationInfo.PageSize);

            return new PlayerPaginationWrapper(totalPages, mappings.ToList());

        }

        private IQueryable<Player> Sort(string sortBy, bool order, IQueryable<Player> query)
        {
            switch (sortBy)
            {
                case "name":
                    if (order)
                    {
                        return query.OrderBy(p => p.Name);
                    }
                    else
                    {
                        return query.OrderByDescending(p => p.Name);
                    }

                case "team":
                    if (order)
                    {
                        return query.OrderBy(p => p.Team);
                    }
                    else
                    {
                        return query.OrderByDescending(p => p.Team);
                    }

                case "gender":
                    if (order)
                    {
                        return query.OrderBy(p => p.Gender);
                    }
                    else
                    {
                        return query.OrderByDescending(p => p.Gender);
                    }
                case "age":
                    if (order)
                    {
                        return query.OrderBy(p => p.Age);
                    }
                    else
                    {
                        return query.OrderByDescending(p => p.Age);
                    }
                case "active":
                    if (order)
                    {
                        return query.OrderBy(p => p.IsActive);
                    }
                    else
                    {
                        return query.OrderByDescending(p => p.IsActive);
                    }
                case "goals":
                    if (order)
                    {
                        return query.OrderBy(p => p.Goals);
                    }
                    else
                    {
                        return query.OrderByDescending(p => p.Goals);
                    }
                case "appearances":
                    if (order)
                    {
                        return query.OrderBy(p => p.Appearances);
                    }
                    else
                    {
                        return query.OrderByDescending(p => p.Appearances);
                    }
                case "redCards":
                    if (order)
                    {
                        return query.OrderBy(p => p.RedCards);
                    }
                    else
                    {
                        return query.OrderByDescending(p => p.RedCards);
                    }
                case "yellowCards":
                    if (order)
                    {
                        return query.OrderBy(p => p.YellowCards);
                    }
                    else
                    {
                        return query.OrderByDescending(p => p.YellowCards);
                    }
                default:
                    return query;
            }
        }
    }
}
