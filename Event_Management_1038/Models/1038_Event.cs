using System;
using System.ComponentModel.DataAnnotations;

namespace Event_Management_1038.Models
{
    public class Event1038
    {
        [Key]
        public int Id { get; set; } // Primary Key

        [Required]
        public required string Title { get; set; } // Required

        [Required]
        public DateTime Date { get; set; } // Required

        public bool IsCanceled { get; set; } // Boolean field

        public int VenueId { get; set; }

        public string? Notes { get; set; } // Nullable field
    }
}