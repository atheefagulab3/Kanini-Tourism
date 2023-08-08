
using FeedbackProj.Models;

namespace FeedbackProj.Interface
{
    public interface IRating 
    {
        public IEnumerable<Rating> GetRating();
        public Rating GetRatingById(int rating_id);

        public Rating PostRating(Rating Rating);
        public Rating PutRating(int rating_id, Rating Rating);
        public Rating DeleteRating(int rating_id);
    }
}
