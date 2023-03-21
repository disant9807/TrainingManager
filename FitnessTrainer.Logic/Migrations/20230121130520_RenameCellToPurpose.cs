using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingManager.Logic.Migrations
{
    public partial class RenameCellToPurpose : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubCells");

            migrationBuilder.DropTable(
                name: "Cell");

            migrationBuilder.CreateTable(
                name: "Purpose",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purpose", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubPurpose",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CategoryOfBodyCode = table.Column<string>(type: "TEXT", nullable: true),
                    Value = table.Column<float>(type: "REAL", nullable: false),
                    CodeUnitsOfMeasurement = table.Column<string>(type: "TEXT", nullable: false),
                    PurposeId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubPurpose", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubPurpose_CategoryOfBody_CategoryOfBodyCode",
                        column: x => x.CategoryOfBodyCode,
                        principalTable: "CategoryOfBody",
                        principalColumn: "Code");
                    table.ForeignKey(
                        name: "FK_SubPurpose_Purpose_PurposeId",
                        column: x => x.PurposeId,
                        principalTable: "Purpose",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubPurpose_UnitsOfMeasurement_CodeUnitsOfMeasurement",
                        column: x => x.CodeUnitsOfMeasurement,
                        principalTable: "UnitsOfMeasurement",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubPurpose_CategoryOfBodyCode",
                table: "SubPurpose",
                column: "CategoryOfBodyCode");

            migrationBuilder.CreateIndex(
                name: "IX_SubPurpose_CodeUnitsOfMeasurement",
                table: "SubPurpose",
                column: "CodeUnitsOfMeasurement");

            migrationBuilder.CreateIndex(
                name: "IX_SubPurpose_PurposeId",
                table: "SubPurpose",
                column: "PurposeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubPurpose");

            migrationBuilder.DropTable(
                name: "Purpose");

            migrationBuilder.CreateTable(
                name: "Cell",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cell", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCells",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CategoryOfBodyCode = table.Column<string>(type: "TEXT", nullable: true),
                    CellId = table.Column<long>(type: "INTEGER", nullable: false),
                    CodeUnitsOfMeasurement = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCells", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCells_CategoryOfBody_CategoryOfBodyCode",
                        column: x => x.CategoryOfBodyCode,
                        principalTable: "CategoryOfBody",
                        principalColumn: "Code");
                    table.ForeignKey(
                        name: "FK_SubCells_Cell_CellId",
                        column: x => x.CellId,
                        principalTable: "Cell",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubCells_UnitsOfMeasurement_CodeUnitsOfMeasurement",
                        column: x => x.CodeUnitsOfMeasurement,
                        principalTable: "UnitsOfMeasurement",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubCells_CategoryOfBodyCode",
                table: "SubCells",
                column: "CategoryOfBodyCode");

            migrationBuilder.CreateIndex(
                name: "IX_SubCells_CellId",
                table: "SubCells",
                column: "CellId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCells_CodeUnitsOfMeasurement",
                table: "SubCells",
                column: "CodeUnitsOfMeasurement");
        }
    }
}
