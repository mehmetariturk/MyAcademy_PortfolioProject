using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAcademy_PortfolioProject.Migrations
{
    /// <inheritdoc />
    public partial class mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Duration",
                table: "Experiences",
                newName: "IconUrl");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Experiences",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Experiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "ExperienceTechnicalSkill",
                columns: table => new
                {
                    ExperiencesExperienceId = table.Column<int>(type: "int", nullable: false),
                    TechnicalSkillsTechnicalSkillId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienceTechnicalSkill", x => new { x.ExperiencesExperienceId, x.TechnicalSkillsTechnicalSkillId });
                    table.ForeignKey(
                        name: "FK_ExperienceTechnicalSkill_Experiences_ExperiencesExperienceId",
                        column: x => x.ExperiencesExperienceId,
                        principalTable: "Experiences",
                        principalColumn: "ExperienceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExperienceTechnicalSkill_TechnicalSkills_TechnicalSkillsTechnicalSkillId",
                        column: x => x.TechnicalSkillsTechnicalSkillId,
                        principalTable: "TechnicalSkills",
                        principalColumn: "TechnicalSkillId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceTechnicalSkill_TechnicalSkillsTechnicalSkillId",
                table: "ExperienceTechnicalSkill",
                column: "TechnicalSkillsTechnicalSkillId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExperienceTechnicalSkill");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Experiences");

            migrationBuilder.RenameColumn(
                name: "IconUrl",
                table: "Experiences",
                newName: "Duration");
        }
    }
}
