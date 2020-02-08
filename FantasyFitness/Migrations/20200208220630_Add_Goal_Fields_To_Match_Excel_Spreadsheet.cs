using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FantasyFitness.Migrations
{
    public partial class Add_Goal_Fields_To_Match_Excel_Spreadsheet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Actual",
                table: "Goals",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Goals",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Season",
                table: "Goals",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Target",
                table: "Goals",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "TeamId",
                table: "Goals",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Goals",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "Goals",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Week",
                table: "Goals",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Actual",
                table: "Goals");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Goals");

            migrationBuilder.DropColumn(
                name: "Season",
                table: "Goals");

            migrationBuilder.DropColumn(
                name: "Target",
                table: "Goals");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Goals");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Goals");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "Goals");

            migrationBuilder.DropColumn(
                name: "Week",
                table: "Goals");
        }
    }
}
