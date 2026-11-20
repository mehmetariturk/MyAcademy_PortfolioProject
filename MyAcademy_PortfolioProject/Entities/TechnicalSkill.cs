namespace MyAcademy_PortfolioProject.Entities
{
    public class TechnicalSkill
    {
        public int TechnicalSkillId { get; set; }
        public string TechnicalSkillName { get; set; }
        public int Percentage { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<Project> Projects { get; set; }
    }
}
