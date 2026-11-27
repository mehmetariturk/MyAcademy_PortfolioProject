using System.ComponentModel.DataAnnotations;

namespace MyAcademy_PortfolioProject.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Category name is required")]
        [StringLength(50)]
        public string CategoryName { get; set; }
        public List<Project>? Projects { get; set; }
    }
}
