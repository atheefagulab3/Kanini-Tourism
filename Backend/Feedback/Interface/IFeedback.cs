
using FeedbackProj.Models;

namespace FeedbackProj.Interface
{
    public interface IFeedback
    {
        public IEnumerable<Hotel_Rating> GetHotel_Rating();
        public Hotel_Rating GetHotel_RatingById(int rating_id);

        public Hotel_Rating PostHotel_Rating(Hotel_Rating Hotel_Rating);
        public Hotel_Rating PutHotel_Rating(int rating_id, Hotel_Rating Hotel_Rating);
        public Hotel_Rating DeleteHotel_Rating(int rating_id);
    }
}
