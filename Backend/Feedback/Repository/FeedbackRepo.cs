
using FeedbackProj.Interface;
using FeedbackProj.Models;
using Microsoft.EntityFrameworkCore;

namespace FeedbackProj.Repository
{
    public class FeedbackRepo :IFeedback
    {
        private readonly RatingContext _hContext;


        public FeedbackRepo(RatingContext con)
        {
            _hContext = con;

        }
        public IEnumerable<Hotel_Rating> GetHotel_Rating()
        {
            return _hContext.Hotel_Ratings.ToList();
        }
        public Hotel_Rating GetHotel_RatingById(int rating_id)
        {
            try
            {
                return _hContext.Hotel_Ratings.FirstOrDefault(x => x.rating_id == rating_id);

            }
            catch (Exception ex)
            {
                return null;
            }



        }

        public Hotel_Rating PostHotel_Rating(Hotel_Rating Hotel_Rating)
        {
            try
            {
                _hContext.Hotel_Ratings.Add(Hotel_Rating);
                _hContext.SaveChanges();
                return Hotel_Rating;
            }

            catch (Exception ex)
            {
                return null;
            }


        }

        public Hotel_Rating PutHotel_Rating(int rating_id, Hotel_Rating Hotel_Rating)
        {
            try

            {
                Hotel_Rating hot = _hContext.Hotel_Ratings.FirstOrDefault(x => x.rating_id == rating_id);
                _hContext.Entry(Hotel_Rating).State = EntityState.Modified;
                _hContext.SaveChanges();
                return Hotel_Rating;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Hotel_Rating DeleteHotel_Rating(int rating_id)
        {
            try
            {
                Hotel_Rating hot = _hContext.Hotel_Ratings.FirstOrDefault(x => x.rating_id == rating_id);

                _hContext.Hotel_Ratings.Remove(hot);

                _hContext.SaveChanges();

                return hot;
            }

            catch (Exception ex)
            {
                return null;
            }


        }
    }
}

