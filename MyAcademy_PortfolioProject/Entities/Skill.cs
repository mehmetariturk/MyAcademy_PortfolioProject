namespace MyAcademy_PortfolioProject.Entities
{
    public class Skill
    {
        public int SkillId { get; set; }
        public string SkillTitle { get; set; }
        public string SkillDescription { get; set; }
        public string IconUrl { get; set; }
        public bool IsActive { get; set; }
        public List<TechnicalSkill> TechnicalSkills { get; set; }
    }
}
