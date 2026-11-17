namespace MyAcademy_PortfolioProject.Entities
{
    public class Education
    {
        public int EducationId { get; set; }
        public string? Title { get; set; }
        public string? Subtitle { get; set; }
        public string? Description { get; set; }
        public string? FocusAreas { get; set; }
        public string? Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? IconUrl { get; set; }
        public bool IsActive { get; set; }
    }
}
