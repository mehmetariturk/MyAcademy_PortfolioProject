using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAcademy_PortfolioProject.Migrations
{
    /// <inheritdoc />
    public partial class mig7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Duration",
                table: "Educations",
                newName: "Location");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Educations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FocusAreas",
                table: "Educations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IconUrl",
                table: "Educations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Educations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "FocusAreas",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "IconUrl",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Educations");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Educations",
                newName: "Duration");
        }
    }
}
