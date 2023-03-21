using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingManager.Logic.Migrations
{
    public partial class CreatedSize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SizeItemId",
                table: "Image",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsArchived = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitsOfMeasurement",
                columns: table => new
                {
                    Code = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitsOfMeasurement", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "SizeItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    SizeId = table.Column<long>(type: "INTEGER", nullable: false),
                    BodyCode = table.Column<string>(type: "TEXT", nullable: true),
                    Value = table.Column<string>(type: "TEXT", nullable: false),
                    CodeUnitsOfMeasurement = table.Column<string>(type: "TEXT", nullable: false),
                    AvatarId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SizeItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SizeItem_CategoryOfBody_BodyCode",
                        column: x => x.BodyCode,
                        principalTable: "CategoryOfBody",
                        principalColumn: "Code");
                    table.ForeignKey(
                        name: "FK_SizeItem_Image_AvatarId",
                        column: x => x.AvatarId,
                        principalTable: "Image",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SizeItem_Size_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Size",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SizeItem_UnitsOfMeasurement_CodeUnitsOfMeasurement",
                        column: x => x.CodeUnitsOfMeasurement,
                        principalTable: "UnitsOfMeasurement",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Image_SizeItemId",
                table: "Image",
                column: "SizeItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SizeItem_AvatarId",
                table: "SizeItem",
                column: "AvatarId");

            migrationBuilder.CreateIndex(
                name: "IX_SizeItem_BodyCode",
                table: "SizeItem",
                column: "BodyCode");

            migrationBuilder.CreateIndex(
                name: "IX_SizeItem_CodeUnitsOfMeasurement",
                table: "SizeItem",
                column: "CodeUnitsOfMeasurement");

            migrationBuilder.CreateIndex(
                name: "IX_SizeItem_SizeId",
                table: "SizeItem",
                column: "SizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_SizeItem_SizeItemId",
                table: "Image",
                column: "SizeItemId",
                principalTable: "SizeItem",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_SizeItem_SizeItemId",
                table: "Image");

            migrationBuilder.DropTable(
                name: "SizeItem");

            migrationBuilder.DropTable(
                name: "Size");

            migrationBuilder.DropTable(
                name: "UnitsOfMeasurement");

            migrationBuilder.DropIndex(
                name: "IX_Image_SizeItemId",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "SizeItemId",
                table: "Image");
        }
    }
}
