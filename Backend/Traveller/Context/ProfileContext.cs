using Microsoft.EntityFrameworkCore;
using Traveller.Models;

namespace Traveller.Context
{
    public class ProfileContext :DbContext
    {
        public DbSet<Profiles> profiles { get; set; }

        public DbSet<Agent> agent { get; set; }

        public ProfileContext(DbContextOptions<ProfileContext> options) : base(options) { }
    }
}
