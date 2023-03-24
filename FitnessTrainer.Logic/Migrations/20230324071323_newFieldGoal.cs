using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingManager.Logic.Migrations
{
    public partial class newFieldGoal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Goal",
                newName: "CreatedDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "CompletionDate",
                table: "Goal",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "Goal",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompletionDate",
                table: "Goal");

            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "Goal");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Goal",
                newName: "Date");
        }
    }
}
