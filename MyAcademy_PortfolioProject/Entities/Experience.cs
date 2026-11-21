using System.ComponentModel.DataAnnotations;

namespace MyAcademy_PortfolioProject.Entities
{
    public class Experience
    {
        public int ExperienceId { get; set; }

        [Required(ErrorMessage = "Position is required")]
        [StringLength(100)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Company is required")]
        [StringLength(100)]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        public string? SideTitle { get; set; }

        [Required(ErrorMessage = "Worktype is required")]
        public string WorkType { get; set; }
        public bool IsActive{ get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? IconUrl { get; set; }
        public List<TechnicalSkill>? TechnicalSkills { get; set; }
    }
}
