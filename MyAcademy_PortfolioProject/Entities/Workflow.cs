namespace MyAcademy_PortfolioProject.Entities
{
    public class Workflow
    {
        public int WorkflowId { get; set; }
        public string Title { get; set; }
        public int StepOrder { get; set; }
        public string IconUrl { get; set; }
        public string Description { get; set; }
    }
}
