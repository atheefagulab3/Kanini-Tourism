﻿using System.ComponentModel.DataAnnotations;

namespace FeedbackProj.Models
{
    public class Rating
    {
        [Key]
        [Required(ErrorMessage = "Rating ID is required")]
        public int rating_id { get; set; }

        public string? customer_name { get; set; }

        [Required(ErrorMessage = "Date is required")]
        public DateTime date { get; set; }

        public string? keyword { get; set; }

        public string? description { get; set; }

        [Range(0, 5, ErrorMessage = "Cleanliness rating must be between 0 and 5")]
        public decimal rating { get; set; }
    }
}
