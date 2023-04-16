using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingManager.Logic.Migrations
{
    public partial class InitExerciseValueDefault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 1L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6085), "", 1, false, false, "Попеременные сгибания рук с гантелями", "Сгибания рук с гантелями" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 2L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6099), "", 1, false, false, "Концетрированное сгибание одной руки с гантелью", "Сгибание одной руки с гантелью" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 3L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6104), "", 1, false, false, "Сгибание рук с гантелями хватом молоток", "Сгибание рук с гантелями хватом молоток" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 4L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6107), "", 1, false, false, "Сгибание одной руки с рукояткой нижнего блока", "Сгибание одной руки с рукояткой нижнего блока" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 5L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6110), "", 1, false, false, "Сгибание рук с рукоятками верхних блоков", "Сгибание рук с рукоятками верхних блоков" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 6L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6114), "", 1, false, false, "Сгибание рук с грифом штанги", "Сгибание рук с грифом штанги" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 7L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6117), "", 1, false, false, "Сгибание рук на тренижере", "Сгибание рук на тренижере" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 8L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6120), "", 1, false, false, "Сгибание рук на скамье", "Сгибание рук на скамье" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 9L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6124), "", 1, false, false, "Сгибание со штангой хватом сверху", "Сгибание со штангой хватом сверхуы" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 10L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6127), "", 1, false, false, "Разгибание запястий со штангой хватом сверху", "Разгибание запястий со штангой хватом сверху" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 11L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6130), "", 1, false, false, "Сгибание запястий со штангой хватом снизу", "Сгибание запястий со штангой хватом снизу" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 12L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6193), "", 1, false, false, "Разгибание рук с рукояткой верхнего блока хватом сверху", "Разгибание рук с рукояткой верхнего блока хватом сверху" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 13L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6197), "", 1, false, false, "Разгибание рук с рукояткой верхнего блока хватом снизу", "Разгибание рук с рукояткой верхнего блока хватом снизу" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 14L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6201), "", 1, false, false, "Разгибание одной руки с верхним блоком хватом снизу", "Разгибание одной руки с верхним блоком хватом снизу" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 15L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6205), "", 1, false, false, "Разгибание рук со штангой лежа", "Разгибание рук со штангой лежа" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 16L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6208), "", 1, false, false, "Разгибание рук с гантелями лежа", "Разгибание рук с гантелями лежа" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 17L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6212), "", 1, false, false, "Разгибание одной руки с гантелью из-за головы", "Разгибание одной руки с гантелью из-за головы" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 18L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6216), "", 1, false, false, "Разгибание рук с однойц гантелью из-за головы", "Разгибание рук с однойц гантелью из-за голов" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 19L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6220), "", 1, false, false, "Разгибание рук с изогнутым грифом штанги из-за головы", "Разгибание рук с изогнутым грифом штанги из-за головы" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 20L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6223), "", 1, false, false, "Разгибание одной руки назад с гантлью в наклоне", "Разгибание одной руки назад с гантлью в наклоне" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 21L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6226), "", 1, false, false, "Отжимания трицепсами спиной к скамье", "Отжимания трицепсами спиной к скамье" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 22L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6229), "", 1, false, false, "Жим штанги из-за головы сидя", "Жим штанги из-за головы сидя" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 23L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6233), "", 1, false, true, "Жим штанги с груди сидя", "Жим штанги с груди сидя" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 24L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6236), "", 1, false, false, "Жим гантелей лежа", "Жим гантелей лежа" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 25L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6239), "", 1, false, false, "Жим гантелей сидя", "Жим гантелей сидя" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 26L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6243), "", 1, false, false, "Попеременный жим гантелей с поворотами запястий", "Попеременный жим гантелей с поворотами запястий" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 27L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6246), "", 1, false, false, "Подъем гантелей в стороны в наклоне вперед", "Подъем гантелей в стороны в наклоне вперед" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 28L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6249), "", 1, false, false, "Подъем гантелей в стороны", "Подъем гантелей в стороны" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 29L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6253), "", 1, false, false, "Подъем гантелей вперед попеременно", "Подъем гантелей вперед попеременно" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 30L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6256), "", 1, false, false, "Подъем гантели в сторону одной рукой, лежа на боку", "Подъем гантели в сторону одной рукой, лежа на боку" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 31L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6260), "", 1, false, false, "Подъем одной руки в сторону с нижнего блока", "Подъем одной руки в сторону с нижнего блока" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 32L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6264), "", 1, false, false, "Подъем одной руки вперед с нижнего блока стоя", "Подъем одной руки вперед с нижнего блока стоя" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 33L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6268), "", 1, false, false, "Перекрестные махи руками назад с верхних блоков", "Перекрестные махи руками назад с верхних блоков" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 34L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6271), "", 1, false, false, "Перекрестные махи руками назад с нижних блоков в наклоне", "Перекрестные махи руками назад с нижних блоков в наклоне" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 35L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6274), "", 1, false, false, "Подъемы рук вперед с одной гантелью", "Подъемы рук вперед с одной гантелью" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 36L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6277), "", 1, false, false, "Подъемы штанги вперед", "Подъемы штанги вперед" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 37L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6281), "", 1, false, false, "Плечевая передняя протяжка", "Плечевая передняя протяжка" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 38L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6284), "", 1, false, false, "Подъемы рук в стороны на тренажере", "Подъемы рук в стороны на тренажере" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 39L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6287), "", 1, false, false, "Махи руками назад с рукоятками тренажера", "Махи руками назад с рукоятками тренажерае" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 40L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6291), "", 1, false, false, "Жим штанги, лежа на наклонной скамье", "Жим штанги, лежа на наклонной скамье" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 41L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6295), "", 1, false, false, "Жим штанги, лежа на горизонтальной скамье", "Жим штанги, лежа на горизонтальной скамье" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 42L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6298), "", 1, false, false, "Жим штанги, лежа на скамье с уклоном", "Жим штанги, лежа на скамье с уклоном" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 43L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6301), "", 1, false, false, "Отжимания от пола", "Отжимания от пола" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 44L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6305), "", 1, false, false, "Отжимания на брусьях", "Отжимания на брусьях" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 45L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6309), "", 1, false, false, "Жим гантелей лежа", "Жим гантелей лежа" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 46L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6312), "", 1, false, false, "Разведение гантелей лежа", "Разведение гантелей лежа" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 47L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6316), "", 1, false, false, "Жим гантелей, лежа на наклонной скамье", "Жим гантелей, лежа на наклонной скамье" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 48L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6374), "", 1, false, false, "Сведение рук в тренажере", "Сведение рук в тренажере" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 49L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6379), "", 1, false, false, "Сведение верхних блоков", "Сведение верхних блоков" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 50L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6382), "", 1, false, false, "Тяга гантели из-за головы лежа", "Тяга гантели из-за головы лежа" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 51L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6386), "", 1, false, false, "Тяга штанги лежа", "Тяга штанги лежа" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 52L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6390), "", 1, false, false, "Подтягивания на перекладине хватом снизу", "Подтягивания на перекладине хватом снизу" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 53L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6393), "", 1, false, false, "Подтягивания на специальной перекладине", "Подтягивания на специальной перекладине" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 54L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6397), "", 1, false, false, "Тяга верхнего блока перед собой", "Тяга верхнего блока перед собой" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 55L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6400), "", 1, false, false, "Тяга верхнего блока за шею", "Тяга верхнего блока за шею" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 56L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6404), "", 1, false, false, "Тяга верхнего блока узим хватом", "Тяга верхнего блока узким хватом" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 57L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6408), "", 1, false, false, "Тяга верхнего блока прямыми руками", "Тяга верхнего блока прямыми рукам" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 58L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6411), "", 1, false, false, "Тяга верхнего блока (гребля)", "Тяга верхнего блока (гребля)" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 59L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6415), "", 1, false, false, "Тяга гантели одной рукой", "Тяга гантели одной рукой" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 60L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6418), "", 1, false, false, "Тяга штанги, стоя в наклоне", "Тяга штанги стоя в наклоне" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 61L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6421), "", 1, false, false, "Тяга т-образного грифа", "Тяга т-образного грифа" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 62L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6426), "", 1, false, false, "Мертвые тяги со штангой, ноги прямые", "Мертвые тяги со штангой, ноги прямые" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 63L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6429), "", 1, false, false, "Мертвые тяги в стиле сумо", "Мертвые тяги в стиле сумо" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 64L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6433), "", 1, false, false, "Становые тяги со штангой", "Становые тяги со штангой" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 65L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6436), "", 1, false, false, "Поясничные прогибания", "Поясничные прогибания" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 66L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6440), "", 1, false, false, "Разгибания туловища на тренажере", "Разгибания туловища на тренажерея" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 67L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6443), "", 1, false, false, "Вертикальные тяги", "Вертикальные тяги" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 68L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6447), "", 1, false, false, "Шраги со штангой", "Шраги со штангой" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 69L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6450), "", 1, false, false, "Шраги с гантелями", "Шраги с гантелями" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 70L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6454), "", 1, false, false, "Шраги в тренажере", "Шраги в тренажере" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 71L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6457), "", 1, false, true, "Приседания с гантелями", "Приседания с гантелями" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 72L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6460), "", 1, false, false, "Приседания со штангой на груди", "Приседания со штангой на груди" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 73L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6464), "", 1, false, false, "Приседания со штангой на плечах", "Приседания со штангой на плечах" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 74L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6467), "", 1, false, false, "Широкие приседания", "Широкие приседания" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 75L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6471), "", 1, false, false, "Наклонный жим ногами", "Наклонный жим ногами" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 76L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6474), "", 1, false, false, "Приседания на тренажере", "Приседания на тренажере" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 77L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6478), "", 1, false, false, "Разгибание ног", "Разгибание ног" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 78L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6482), "", 1, false, false, "Сгибание ног лежа", "Сгибание ног лежа" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 79L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6485), "", 1, false, false, "Сгибание одной ноги лежа", "Сгибание одной ноги лежаа" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 80L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6489), "", 1, false, false, "Сгибание ног сидя", "Сгибание ног сидя" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 81L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6493), "", 1, false, false, "Подъемы торса", "Подъемы торса" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 82L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6496), "", 1, false, false, "Приведение одной ноги стоя", "Приведение одной ноги стоя" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 83L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6499), "", 1, false, false, "Сведение ног сидя", "Сведение ног сидя" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 84L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6503), "", 1, false, false, "Подъемы на носки стоя", "Подъемы на носки стоя" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 85L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6564), "", 1, false, false, "Подъем на носок одной ноги стоя", "Подъем на носок одной ноги стоя" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 86L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6568), "", 1, false, false, "Подъемы на носки в наклоне", "Подъемы на носки в наклоне" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 87L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6571), "", 1, false, false, "Разгибание голени сидя", "Разгибание голени сидя" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 88L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6579), "", 1, false, false, "Сворачивание туловища на полу", "Сворачивание туловища на пол" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 89L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6582), "", 1, false, false, "Подъемы туловища у гимнастической стенки", "Подъемы туловища у гимнастической стенки" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 90L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6586), "", 1, false, false, "Сворачивание туловища с голенью на скамье", "Сворачивание туловища с голенью на скамье" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 91L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6590), "", 1, false, false, "Подъемы туловища на наклонной скамье", "Подъемы туловища на наклонной скамье" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 92L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6593), "", 1, false, false, "Подъем туловища на вертикальной скамье", "Подъем туловища на вертикальной скамье" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 93L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6596), "", 1, false, false, "Сворачивание туловища с верхним блоком", "Сворачивание туловища с верхним блоком" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 94L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6599), "", 1, false, false, "Сворачивание тууловища на тренажере", "Сворачивание туловища на тренажере" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 95L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6603), "", 1, false, false, "Подъемы ног на наклонной скамье", "Подъемы ног на наклонной скамье" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 96L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6606), "", 1, false, false, "Подъем коленей в упоре", "Подъем коленей в упоре" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 97L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6610), "", 1, false, false, "Подъем коленей в висе", "Подъем коленей в висе" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 98L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6614), "", 1, false, false, "Разворот туловища с грифом", "Разворот туловища с грифом" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 99L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6617), "", 1, false, false, "Боковые наклоны туловища стоя", "Боковые наклоны туловища на римском стуле" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 100L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6620), "", 1, false, false, "Вращение туловища на тренажере Твист", "Вращение туловища на тренажере Твист" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 101L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6623), "", 1, false, false, "Выпады со штангой на плечах", "Выпады со штангой на плечах" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 102L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6627), "", 1, false, false, "Выпады с гантелями", "Выпады с гантелями" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 103L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6630), "", 1, false, false, "Махи ногой назад с нижнего блока", "Махи ногой назад с нижнего блока" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 104L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6634), "", 1, false, false, "Махи ногой назад с рычагом тренажера", "Махи ногой назад с рычагом тренажера" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 105L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6638), "", 1, false, false, "Махи ногой нзад на полу", "Махи ногой нзад на полу" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 106L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6641), "", 1, false, false, "Мостик лежа", "Мостик лежа" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 107L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6645), "", 1, false, false, "Махи ногой в сторону с нинего блока", "Махи ногой в сторону с нинего блока" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 108L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6648), "", 1, false, false, "Махи ногой в сторону с рычагом тренажера", "Махи ногой в сторону с рычагом тренажера" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 109L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6652), "", 1, false, false, "Махи ногой в сторону, лежа на боку", "Махи ногой в сторону, лежа на боку" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 110L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6655), "", 1, false, false, "Разведение ног на тренажере", "Разведение ног на тренажере" });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[] { 111L, null, new DateTime(2023, 4, 15, 22, 26, 22, 380, DateTimeKind.Local).AddTicks(6575), "", 1, false, false, "Разгибание голени сидя, со штангой на коленях", "Разгибание голени сидя, со штангой на коленях" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 111L);
        }
    }
}
