using Booking.Controllers;
using Booking.Interface;
using Booking.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace BookTesting
{
    public class BookingControllerTests
    {
        // Other test methods...

        [Fact]
        public async Task Payment_ValidPayment_ReturnsOk()
        {
            // Arrange
            var mockBookService = new Mock<IBookService>();
            mockBookService.Setup(service => service.PostPayment(It.IsAny<Payment>())).ReturnsAsync(new Payment());

            var controller = new BookingController(mockBookService.Object);
            var payment = new Payment();

            // Act
            var result = await controller.Payment(payment);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.IsAssignableFrom<Payment>(okResult.Value);
        }

        [Fact]
        public async Task Payment_InvalidPayment_ReturnsInternalServerError()
        {
            // Arrange
            var mockBookService = new Mock<IBookService>();
            mockBookService.Setup(service => service.PostPayment(It.IsAny<Payment>())).ThrowsAsync(new Exception("Invalid payment"));

            var controller = new BookingController(mockBookService.Object);
            var payment = new Payment();

            // Act
            var result = await controller.Payment(payment);

            // Assert
            var objectResult = Assert.IsType<ObjectResult>(result);
            Assert.Equal((int)HttpStatusCode.InternalServerError, objectResult.StatusCode);
            Assert.IsAssignableFrom<string>(objectResult.Value);
        }
 

        // Additional tests for other actions...

        private List<Passenger> GetTestPassengers()
        {
            // Create and return sample test data
            return new List<Passenger>
            {
                new Passenger { passenger_id = 1, first_name = "Passenger 1" },
                new Passenger { passenger_id = 2, first_name = "Passenger 2" }
            };
        }

        // Additional tests for other actions...
    }
}
