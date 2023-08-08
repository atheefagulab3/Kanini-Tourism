using HotelProj.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelProj.Context
{
    public class HotelContext :DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Room> Rooms { get; set; }

        
        public HotelContext(DbContextOptions<HotelContext> options) : base(options) { }
    }
}
