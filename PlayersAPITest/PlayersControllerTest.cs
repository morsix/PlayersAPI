
using Microsoft.AspNetCore.Mvc;
using Moq;
using PlayersAPI.Controllers;
using PlayersAPI.Helpers;
using PlayersAPI.Services;
using Xunit;

namespace PlayersAPITest
{
    public class PlayersControllerTest
    {

        [Fact]
        public void Player_Controller_Get()
        {
            //Arrange
            var mockService = new Mock<IPlayerService>();

            var pagWrapper = new PlayerPaginationWrapper(5, null);
            mockService.Setup(p => p.Get(It.IsAny<PaginationInfo>())).Returns(pagWrapper);

            var playerController = new PlayerController(mockService.Object);

            //Act
            var objectResult = playerController.Get(It.IsAny<PaginationInfo>()).Result as ObjectResult;


            //Assert
            var okResult = Assert.IsType<OkObjectResult>(objectResult);
            var returnValue = Assert.IsType<PlayerPaginationWrapper>(okResult.Value);
            Assert.Equal(5, returnValue.TotalPages);
        }

        [Fact]
        public void Player_Controller_Get_BadRequest()
        {
            // Arrange
            var mockService = new Mock<IPlayerService>();

            var playerController = new PlayerController(mockService.Object);
            playerController.ModelState.AddModelError("Error", "Error");

            //Act
            var badResponse = playerController.Get(It.IsAny<PaginationInfo>()).Result as ObjectResult;

            //Assert
            Assert.IsType<BadRequestObjectResult>(badResponse);
        }
    }
}