using FeedbackProj.Interface;
using FeedbackProj.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace FeedbackProj.Repository
{
    public class RatingRepo : IRating
    {
        private readonly RatingContext _hContext;


        public RatingRepo(RatingContext con)
        {
            _hContext = con;

        }
        public IEnumerable<Rating> GetRating()
        {
            return _hContext.Ratings.ToList();
        }
        public Rating GetRatingById(int rating_id)
        {
            try
            {
                return _hContext.Ratings.FirstOrDefault(x => x.rating_id == rating_id);

            }
            catch (Exception ex)
            {
                return null;
            }



        }

        public Rating PostRating(Rating Rating)
        {
            try
            {
                _hContext.Ratings.Add(Rating);
                _hContext.SaveChanges();
                return Rating;
            }

            catch (Exception ex)
            {
                return null;
            }


        }

        public Rating PutRating(int rating_id, Rating Rating)
        {
            try

            {
                Rating hot = _hContext.Ratings.FirstOrDefault(x => x.rating_id == rating_id);
                _hContext.Entry(Rating).State = EntityState.Modified;
                _hContext.SaveChanges();
                return Rating;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Rating DeleteRating(int rating_id)
        {
            try
            {
                Rating hot = _hContext.Ratings.FirstOrDefault(x => x.rating_id == rating_id);

                _hContext.Ratings.Remove(hot);

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
