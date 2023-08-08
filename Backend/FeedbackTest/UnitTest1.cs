using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using FeedbackProj.Controllers;
using FeedbackProj.Interface;
using FeedbackProj.Models;

namespace FeedbackTest
{
    public class FeedbackControllerTests
    {
        


       
        [Fact]
        public void Post_ValidHotelRating_ReturnsPostedHotelRating()
        {
            // Arrange
            var mockService = new Mock<IFeedback>();
            mockService.Setup(service => service.PostHotel_Rating(It.IsAny<Hotel_Rating>())).Returns<Hotel_Rating>(hr => hr);

            var controller = new FeedbackController(mockService.Object);
            var hotelRatingToPost = new Hotel_Rating();

            // Act
            var result = controller.PostHotel_Rating(hotelRatingToPost);

            // Assert
            var postedHotelRating = Assert.IsType<Hotel_Rating>(result);
            Assert.Equal(hotelRatingToPost.rating_id, postedHotelRating.rating_id);
        }



        [Fact]
        public void Put_ValidIdAndHotelRating_ReturnsUpdatedHotelRating()
        {
            // Arrange
            int ratingId = 1;
            var mockService = new Mock<IFeedback>();
            mockService.Setup(service => service.PutHotel_Rating(ratingId, It.IsAny<Hotel_Rating>())).Returns<int, Hotel_Rating>((id, hr) => new Hotel_Rating { rating_id = id });

            var controller = new FeedbackController(mockService.Object);
            var updatedHotelRating = new Hotel_Rating();

            // Act
            var result = controller.PutHotel_Rating(ratingId, updatedHotelRating);

            // Assert
            var updatedHotelRatingResult = Assert.IsType<Hotel_Rating>(result);
            Assert.Equal(ratingId, updatedHotelRatingResult.rating_id);
        }





      
        }
    
}
