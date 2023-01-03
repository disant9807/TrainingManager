using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingManager.Logic.Migrations
{
    public partial class addNewTableApproachItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hard",
                table: "Approach");

            migrationBuilder.DropColumn(
                name: "Technicality",
                table: "Approach");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Approach");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Approach");

            migrationBuilder.CreateTable(
                name: "ApproachItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    approachId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Time = table.Column<long>(type: "INTEGER", nullable: false),
                    Weight = table.Column<float>(type: "REAL", nullable: false),
                    NumberOfApproach = table.Column<int>(type: "INTEGER", nullable: false),
                    Hard = table.Column<int>(type: "INTEGER", nullable: false),
                    Technicality = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApproachItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApproachItem_Approach_approachId",
                        column: x => x.approachId,
                        principalTable: "Approach",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApproachItem_approachId",
                table: "ApproachItem",
                column: "approachId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApproachItem");

            migrationBuilder.AddColumn<int>(
                name: "Hard",
                table: "Approach",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Technicality",
                table: "Approach",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "Time",
                table: "Approach",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<float>(
                name: "Weight",
                table: "Approach",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
