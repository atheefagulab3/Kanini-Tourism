using FeedbackProj.Interface;
using FeedbackProj.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FeedbackProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly IRating hot;
        public RatingController(IRating hot)
        {
            this.hot = hot;
        }

        [HttpGet]
        public IEnumerable<Rating>? Get()
        {
            return hot.GetRating();
        }

        [HttpGet("{rating_id}")]
        public Rating? GetById(int rating_id)
        {



            return hot.GetRatingById(rating_id);


        }

        [HttpPost]
        public Rating? PostRating(Rating Rating)
        {
            return hot.PostRating(Rating);

        }


        [HttpPut("{rating_id}")]
        public Rating? PutRating(int rating_id, Rating Rating)
        {

            return hot.PutRating(rating_id, Rating);


        }

        [HttpDelete("{rating_id}")]
        public Rating? DeleteRating(int rating_id)
        {
            return hot.DeleteRating(rating_id);



        }
    }
}
