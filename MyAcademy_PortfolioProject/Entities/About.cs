using System.ComponentModel.DataAnnotations;

namespace MyAcademy_PortfolioProject.Entities
{
    public class About
    {
        public int AboutId { get; set; }

        [Required(ErrorMessage = "Name and Surname is required")]
        [StringLength(100)]
        public string NameSurname { get; set; }

        [Required(ErrorMessage = "Profession is required")]
        [StringLength(100)]
        public string Jobtitle { get; set; }
        public string? Location { get; set; }
        public string? Expert { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        [StringLength(100)]
        public string Email { get; set; }
        public string? Description { get; set; }
        public bool OpenToWork { get; set; }
        public string? CvUrl { get; set; }
    }
}
