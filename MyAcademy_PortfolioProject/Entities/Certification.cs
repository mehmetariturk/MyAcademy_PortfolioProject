namespace MyAcademy_PortfolioProject.Entities
{
    public class Certification
    {
        public int CertificationId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        public string IconUrl { get; set; }
        public string? CertificateUrl { get; set; }
    }
}
