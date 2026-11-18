using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAcademy_PortfolioProject.Migrations
{
    /// <inheritdoc />
    public partial class mig8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "OpenToWork",
                table: "Abouts",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "AboutHighlights",
                columns: table => new
                {
                    AboutHighlightId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutHighlights", x => x.AboutHighlightId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutHighlights");

            migrationBuilder.AlterColumn<string>(
                name: "OpenToWork",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
