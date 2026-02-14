using System.ComponentModel.DataAnnotations;

namespace Mission06_Zarges.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Category { get; set; } = string.Empty;

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; } = string.Empty;

        // Dropdown: G, PG, PG-13, R
        [Required]
        public string Rating { get; set; } = string.Empty;

        // Not required
        public bool Edited { get; set; } = false;

        // Not required
        public string? LentTo { get; set; }

        // Not required, max 25 chars
        [StringLength(25)]
        public string? Notes { get; set; }
    }
}