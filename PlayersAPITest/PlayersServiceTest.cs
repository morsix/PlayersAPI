using AutoMapper;
using Moq;
using PlayersAPI.Helpers;
using PlayersAPI.Models;
using PlayersAPI.Repository;
using PlayersAPI.Services;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace PlayersAPITest
{
    public class PlayersServiceTest
    {
        [Fact]
        public void Player_Service_Get()
        {
            //Arrange
            var mockRepo = new Mock<IPlayerRepository>();
            var mockMapper = new Mock<IMapper>();

            var query = new List<Player>().AsQueryable();

            var paginationInfo = new PaginationInfo
            {
                Page = 1,
                PageSize = 10,
                SortBy = "",
                Keyword = "",
                Order = true
            };

            mockRepo.Setup(p => p.Get()).Returns(query);

            var playerService = new PlayerService(mockRepo.Object, mockMapper.Object);

            //Act
            var objectResult = playerService.Get(paginationInfo);


            //Assert
            var okResult = Assert.IsType<PlayerPaginationWrapper>(objectResult);
            
        }
    }
}
