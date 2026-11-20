using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAcademy_PortfolioProject.Migrations
{
    /// <inheritdoc />
    public partial class mig13_project_technicalskill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectTechnicalSkill",
                columns: table => new
                {
                    ProjectsProjectId = table.Column<int>(type: "int", nullable: false),
                    TechnicalSkillsTechnicalSkillId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTechnicalSkill", x => new { x.ProjectsProjectId, x.TechnicalSkillsTechnicalSkillId });
                    table.ForeignKey(
                        name: "FK_ProjectTechnicalSkill_Projects_ProjectsProjectId",
                        column: x => x.ProjectsProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectTechnicalSkill_TechnicalSkills_TechnicalSkillsTechnicalSkillId",
                        column: x => x.TechnicalSkillsTechnicalSkillId,
                        principalTable: "TechnicalSkills",
                        principalColumn: "TechnicalSkillId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTechnicalSkill_TechnicalSkillsTechnicalSkillId",
                table: "ProjectTechnicalSkill",
                column: "TechnicalSkillsTechnicalSkillId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectTechnicalSkill");
        }
    }
}
