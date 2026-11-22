using System.ComponentModel.DataAnnotations;

namespace MyAcademy_PortfolioProject.Entities
{
    public class Education
    {
        public int EducationId { get; set; }

        [Required(ErrorMessage = "School is required")]
        [StringLength(100)]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Degree is required")]
        [StringLength(100)]
        public string? Subtitle { get; set; }
        public string? Description { get; set; }

        [StringLength(200)]
        public string? FocusAreas { get; set; }

        [StringLength(100)]
        public string? Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? IconUrl { get; set; }
        public bool IsActive { get; set; }
    }
}
