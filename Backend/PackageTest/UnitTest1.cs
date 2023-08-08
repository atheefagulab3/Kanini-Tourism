using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moq;
using PackageProj.Controllers;
using PackageProj.Interface;
using PackageProj.Models;
using Xunit;

namespace PackageTest
{
    public class PackageControllerTests
    {
        [Fact]
        public async Task GetLocation_ReturnsListOfLocations()
        {
            // Arrange
            var mockService = new Mock<IPacService>();
            mockService.Setup(service => service.GetLocations()).ReturnsAsync(new List<Location>());

            var controller = new PackageController(mockService.Object);

            // Act
            var result = await controller.GetLocation();

            // Assert
            var okResult = Assert.IsType<List<Location>>(result);
            Assert.Empty(okResult);
        }


        // More tests for other controller methods can be added similarly

        // Sample test for PostBooking
        [Fact]
        public async Task PostBooking_ValidLocation_ReturnsOkResult()
        {
            // Arrange
            var mockService = new Mock<IPacService>();
            mockService.Setup(service => service.PostLocation(It.IsAny<Location>()))
                       .ReturnsAsync(new Location());

            var controller = new PackageController(mockService.Object);
            var locationToPost = new Location();

            // Act
            var result = await controller.PostBooking(locationToPost);

            // Assert
            var actionResult = Assert.IsType<ActionResult<Location>>(result);
            var okObjectResult = Assert.IsType<OkObjectResult>(actionResult.Result);
            var postedLocation = Assert.IsType<Location>(okObjectResult.Value);
            Assert.NotNull(postedLocation);
        }
        // Add more tests for other controller methods

        // Add more test cases as needed for edge cases and error scenarios
    }
}




