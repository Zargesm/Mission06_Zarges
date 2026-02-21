using System.ComponentModel.DataAnnotations;

namespace Mission06_Zarges.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        // this matches the provided DB (nullable)
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        [Range(1888, 3000, ErrorMessage = "Year must be 1888 or later.")]
        public int Year { get; set; }

        public string? Director { get; set; }
        public string? Rating { get; set; }

        // required fields (bools are non-nullable)
        public bool Edited { get; set; }
        public bool CopiedToPlex { get; set; }

        public string? LentTo { get; set; }

        [StringLength(25)]
        public string? Notes { get; set; }
    }
}