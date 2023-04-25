using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrainingManager.Logic.Migrations
{
    /// <inheritdoc />
    public partial class CreateStatistics : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "ObjectOfStatistics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CategoryCode = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    IsArchived = table.Column<bool>(type: "boolean", nullable: false),
                    CreateOrUpdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjectOfStatistics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ObjectOfStatistics_Category_CategoryCode",
                        column: x => x.CategoryCode,
                        principalTable: "Category",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StatisticsIndicators",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    IsArchived = table.Column<bool>(type: "boolean", nullable: false),
                    ObjectCode = table.Column<Guid>(type: "uuid", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false),
                    CreatedOrUpdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateOfMeasurement = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatisticsIndicators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatisticsIndicators_ObjectOfStatistics_ObjectCode",
                        column: x => x.ObjectCode,
                        principalTable: "ObjectOfStatistics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Code", "Description", "Name" },
                values: new object[,]
                {
                    { "Goal", "Цель", "Цель" },
                    { "Size", "Замеры", "Замеры" },
                    { "Training", "Тренировки", "Тренировки" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ObjectOfStatistics_CategoryCode",
                table: "ObjectOfStatistics",
                column: "CategoryCode");

            migrationBuilder.CreateIndex(
                name: "IX_StatisticsIndicators_ObjectCode",
                table: "StatisticsIndicators",
                column: "ObjectCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StatisticsIndicators");

            migrationBuilder.DropTable(
                name: "ObjectOfStatistics");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
