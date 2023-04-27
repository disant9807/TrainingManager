using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingManager.Logic.Migrations
{
    /// <inheritdoc />
    public partial class AddGenStatistics : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "GenStatisticsId",
                table: "ObjectOfStatistics",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GenStatistics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    GeneratedTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CategoryCode = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenStatistics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenStatistics_Category_CategoryCode",
                        column: x => x.CategoryCode,
                        principalTable: "Category",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ObjectOfStatistics_GenStatisticsId",
                table: "ObjectOfStatistics",
                column: "GenStatisticsId");

            migrationBuilder.CreateIndex(
                name: "IX_GenStatistics_CategoryCode",
                table: "GenStatistics",
                column: "CategoryCode");

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectOfStatistics_GenStatistics_GenStatisticsId",
                table: "ObjectOfStatistics",
                column: "GenStatisticsId",
                principalTable: "GenStatistics",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ObjectOfStatistics_GenStatistics_GenStatisticsId",
                table: "ObjectOfStatistics");

            migrationBuilder.DropTable(
                name: "GenStatistics");

            migrationBuilder.DropIndex(
                name: "IX_ObjectOfStatistics_GenStatisticsId",
                table: "ObjectOfStatistics");

            migrationBuilder.DropColumn(
                name: "GenStatisticsId",
                table: "ObjectOfStatistics");
        }
    }
}
