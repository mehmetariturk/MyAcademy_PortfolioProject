using Microsoft.EntityFrameworkCore;
using MyAcademy_PortfolioProject.Entities;

namespace MyAcademy_PortfolioProject.Context
{
    public class PortfolioContext : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Education> Experience { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
