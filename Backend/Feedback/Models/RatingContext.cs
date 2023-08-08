using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FeedbackProj.Models
{
    public class RatingContext : DbContext
    {
        public DbSet<Rating> Ratings { get; set; }

        public DbSet<Hotel_Rating> Hotel_Ratings { get; set; }


        public RatingContext(DbContextOptions<RatingContext> options) : base(options) { }
    }
}
