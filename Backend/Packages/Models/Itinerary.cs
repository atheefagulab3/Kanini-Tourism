using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PackageProj.Models
{
    public class Itinerary
    {
        [Key]
        public int itinerary_id { get; set; }
        public int package_id { get; set; }
        public DayOfWeek day { get; set; }
        public string spots { get; set; }
        public string details { get; set; }
        public DateTime date { get; set; }
        public string image { get; set; }

        [NotMapped]
        public IFormFile file { get; set; }
    }
}
