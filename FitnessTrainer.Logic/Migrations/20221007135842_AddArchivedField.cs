using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingManager.Logic.Migrations
{
    public partial class AddArchivedField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "TrainingProgramDay",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "TrainingProgram",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "Training",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "Image",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "Exercise",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "CategoryOfBody",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "Approach",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "TrainingProgramDay");

            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "TrainingProgram");

            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "Exercise");

            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "CategoryOfBody");

            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "Approach");
        }
    }
}
