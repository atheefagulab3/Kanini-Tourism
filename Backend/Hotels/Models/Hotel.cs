using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelProj.Models
{
    public class Hotel
    {
        [Key]
        public int hotel_id { get; set; }

        [Required(ErrorMessage = "Hotel name is required")]
        public string? hotel_name { get; set; }

        [Required(ErrorMessage = "Hotel location is required")]
        public string? hotel_location { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string? hotel_email { get; set; }

        [Required(ErrorMessage = "Contact number is required.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Invalid contact number.")]
        public long hotel_phone { get; set; }

        public string? hotel_image { get; set; }

        [Required(ErrorMessage = "location is required.")]
        public string? detailed_location { get; set; }

        [Required(ErrorMessage = "Amenities is required.")]

        public string? amenities { get; set; }

        [Required(ErrorMessage = "type is required.")]
        public string? hotel_type { get; set; }

        [Required(ErrorMessage = "this is required.")]
        public string? whats_nearby { get; set; }

        [Required(ErrorMessage = "policies is required.")]
        public string? policies { get; set; }

        [NotMapped]
        public IFormFile file { get; set; }

    }
}
