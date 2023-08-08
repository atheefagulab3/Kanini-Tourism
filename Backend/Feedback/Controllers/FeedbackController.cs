using FeedbackProj.Interface;
using FeedbackProj.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FeedbackProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private readonly IFeedback hot;
        public FeedbackController(IFeedback hot)
        {
            this.hot = hot;
        }

        [HttpGet]
        public IEnumerable<Hotel_Rating>? Get()
        {
            return hot.GetHotel_Rating();
        }

        [HttpGet("{rating_id}")]
        public Hotel_Rating? GetById(int rating_id)
        {



            return hot.GetHotel_RatingById(rating_id);


        }

        [HttpPost]
        public Hotel_Rating? PostHotel_Rating(Hotel_Rating Hotel_Rating)
        {
            return hot.PostHotel_Rating(Hotel_Rating);

        }


        [HttpPut("{rating_id}")]
        public Hotel_Rating? PutHotel_Rating(int rating_id, Hotel_Rating Hotel_Rating)
        {

            return hot.PutHotel_Rating(rating_id, Hotel_Rating);


        }

        [HttpDelete("{rating_id}")]
        public Hotel_Rating? DeleteHotel_Rating(int rating_id)
        {
            return hot.DeleteHotel_Rating(rating_id);



        }
    }
}

