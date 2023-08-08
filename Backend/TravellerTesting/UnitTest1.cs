using Authentication.Controllers;
using Authentication.Interface;
using Authentication.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace TravelTesting
{
    public class AdminControllerTests
    {
        [Fact]
        public async Task GetAll_ReturnsListOfImages()
        {
            // Arrange
            var mockAdminService = new Mock<IAdminService>();
            mockAdminService.Setup(service => service.GetAll()).ReturnsAsync(GetTestImages());

            var controller = new AdminController(mockAdminService.Object);

            // Act
            var result = await controller.GetAll();

            // Assert
            var images = Assert.IsAssignableFrom<ICollection<Image_Gallery>>(result);
            Assert.Equal(2, images.Count); // Change to match your test data count
        }


        [Fact]
        public async Task PostImage_ValidImage_ReturnsOk()
        {
            // Arrange
            var mockAdminService = new Mock<IAdminService>();
            mockAdminService.Setup(service => service.Image(It.IsAny<Image_Gallery>())).ReturnsAsync(new Image_Gallery());

            var controller = new AdminController(mockAdminService.Object);

            // Act
            var result = await controller.PostImage(new Image_Gallery());

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.IsAssignableFrom<Image_Gallery>(okResult.Value);
        }

        [Fact]
        public async Task Authenticate_ValidAdmin_ReturnsToken()
        {
            // Arrange
            var mockAdminService = new Mock<IAdminService>();
            mockAdminService.Setup(service => service.Login(It.IsAny<Admins>())).ReturnsAsync("testToken");

            var controller = new AdminController(mockAdminService.Object);

            // Act
            var result = await controller.Authenticate(new Admins());

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var token = Assert.IsAssignableFrom<string>(okResult.Value);
            Assert.Equal("testToken", token);
        }

        [Fact]
        public async Task Authenticate_InvalidAdmin_ReturnsBadRequest()
        {
            // Arrange
            var mockAdminService = new Mock<IAdminService>();
            mockAdminService.Setup(service => service.Login(It.IsAny<Admins>())).ReturnsAsync(string.Empty);

            var controller = new AdminController(mockAdminService.Object);

            // Act
            var result = await controller.Authenticate(new Admins());

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

        private List<Image_Gallery> GetTestImages()
        {
            // Create and return sample test data
            return new List<Image_Gallery>
            {
                new Image_Gallery { Id = 1, image = "image1.jpg" },
                new Image_Gallery { Id = 2, image = "image2.jpg" }
            };
        }
    }
}
