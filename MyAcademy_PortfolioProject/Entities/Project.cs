using System.ComponentModel.DataAnnotations;

namespace MyAcademy_PortfolioProject.Entities
{
    public class Project
    {
        public int ProjectId { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [StringLength(300)]
        public string? GithubUrl { get; set; }
        public string? CoverImageUrl { get; set; }
        public bool IsActive { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public List<TechnicalSkill>? TechnicalSkills { get; set; }
    }
}
