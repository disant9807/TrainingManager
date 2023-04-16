using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrainingManager.Logic.Migrations
{
    /// <inheritdoc />
    public partial class InitExerciseData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryOfBodyExercise");

            migrationBuilder.CreateTable(
                name: "ExerciseCategoryOfBody",
                columns: table => new
                {
                    ExerciseId = table.Column<long>(type: "bigint", nullable: false),
                    CategoryOfBodyId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseCategoryOfBody", x => new { x.ExerciseId, x.CategoryOfBodyId });
                    table.ForeignKey(
                        name: "FK_ExerciseCategoryOfBody_CategoryOfBody_CategoryOfBodyId",
                        column: x => x.CategoryOfBodyId,
                        principalTable: "CategoryOfBody",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseCategoryOfBody_Exercise_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AvatarId", "CreatedDate", "Description", "HardSkill", "IsArchived", "IsBased", "Name", "ShortName" },
                values: new object[,]
                {
                    { 1L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Попеременные сгибания рук с гантелями", "Сгибания рук с гантелями" },
                    { 2L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Концетрированное сгибание одной руки с гантелью", "Сгибание одной руки с гантелью" },
                    { 3L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Сгибание рук с гантелями хватом молоток", "Сгибание рук с гантелями хватом молоток" },
                    { 4L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Сгибание одной руки с рукояткой нижнего блока", "Сгибание одной руки с рукояткой нижнего блока" },
                    { 5L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Сгибание рук с рукоятками верхних блоков", "Сгибание рук с рукоятками верхних блоков" },
                    { 6L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Сгибание рук с грифом штанги", "Сгибание рук с грифом штанги" },
                    { 7L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Сгибание рук на тренижере", "Сгибание рук на тренижере" },
                    { 8L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Сгибание рук на скамье", "Сгибание рук на скамье" },
                    { 9L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Сгибание со штангой хватом сверху", "Сгибание со штангой хватом сверхуы" },
                    { 10L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Разгибание запястий со штангой хватом сверху", "Разгибание запястий со штангой хватом сверху" },
                    { 11L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Сгибание запястий со штангой хватом снизу", "Сгибание запястий со штангой хватом снизу" },
                    { 12L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Разгибание рук с рукояткой верхнего блока хватом сверху", "Разгибание рук с рукояткой верхнего блока хватом сверху" },
                    { 13L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Разгибание рук с рукояткой верхнего блока хватом снизу", "Разгибание рук с рукояткой верхнего блока хватом снизу" },
                    { 14L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Разгибание одной руки с верхним блоком хватом снизу", "Разгибание одной руки с верхним блоком хватом снизу" },
                    { 15L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Разгибание рук со штангой лежа", "Разгибание рук со штангой лежа" },
                    { 16L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Разгибание рук с гантелями лежа", "Разгибание рук с гантелями лежа" },
                    { 17L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Разгибание одной руки с гантелью из-за головы", "Разгибание одной руки с гантелью из-за головы" },
                    { 18L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Разгибание рук с однойц гантелью из-за головы", "Разгибание рук с однойц гантелью из-за голов" },
                    { 19L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Разгибание рук с изогнутым грифом штанги из-за головы", "Разгибание рук с изогнутым грифом штанги из-за головы" },
                    { 20L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Разгибание одной руки назад с гантлью в наклоне", "Разгибание одной руки назад с гантлью в наклоне" },
                    { 21L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Отжимания трицепсами спиной к скамье", "Отжимания трицепсами спиной к скамье" },
                    { 22L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Жим штанги из-за головы сидя", "Жим штанги из-за головы сидя" },
                    { 23L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, true, "Жим штанги с груди сидя", "Жим штанги с груди сидя" },
                    { 24L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Жим гантелей лежа", "Жим гантелей лежа" },
                    { 25L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Жим гантелей сидя", "Жим гантелей сидя" },
                    { 26L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Попеременный жим гантелей с поворотами запястий", "Попеременный жим гантелей с поворотами запястий" },
                    { 27L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Подъем гантелей в стороны в наклоне вперед", "Подъем гантелей в стороны в наклоне вперед" },
                    { 28L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Подъем гантелей в стороны", "Подъем гантелей в стороны" },
                    { 29L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Подъем гантелей вперед попеременно", "Подъем гантелей вперед попеременно" },
                    { 30L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Подъем гантели в сторону одной рукой, лежа на боку", "Подъем гантели в сторону одной рукой, лежа на боку" },
                    { 31L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Подъем одной руки в сторону с нижнего блока", "Подъем одной руки в сторону с нижнего блока" },
                    { 32L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Подъем одной руки вперед с нижнего блока стоя", "Подъем одной руки вперед с нижнего блока стоя" },
                    { 33L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Перекрестные махи руками назад с верхних блоков", "Перекрестные махи руками назад с верхних блоков" },
                    { 34L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Перекрестные махи руками назад с нижних блоков в наклоне", "Перекрестные махи руками назад с нижних блоков в наклоне" },
                    { 35L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Подъемы рук вперед с одной гантелью", "Подъемы рук вперед с одной гантелью" },
                    { 36L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Подъемы штанги вперед", "Подъемы штанги вперед" },
                    { 37L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Плечевая передняя протяжка", "Плечевая передняя протяжка" },
                    { 38L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Подъемы рук в стороны на тренажере", "Подъемы рук в стороны на тренажере" },
                    { 39L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Махи руками назад с рукоятками тренажера", "Махи руками назад с рукоятками тренажерае" },
                    { 40L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Жим штанги, лежа на наклонной скамье", "Жим штанги, лежа на наклонной скамье" },
                    { 41L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Жим штанги, лежа на горизонтальной скамье", "Жим штанги, лежа на горизонтальной скамье" },
                    { 42L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Жим штанги, лежа на скамье с уклоном", "Жим штанги, лежа на скамье с уклоном" },
                    { 43L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Отжимания от пола", "Отжимания от пола" },
                    { 44L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Отжимания на брусьях", "Отжимания на брусьях" },
                    { 45L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Жим гантелей лежа", "Жим гантелей лежа" },
                    { 46L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Разведение гантелей лежа", "Разведение гантелей лежа" },
                    { 47L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Жим гантелей, лежа на наклонной скамье", "Жим гантелей, лежа на наклонной скамье" },
                    { 48L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Сведение рук в тренажере", "Сведение рук в тренажере" },
                    { 49L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Сведение верхних блоков", "Сведение верхних блоков" },
                    { 50L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Тяга гантели из-за головы лежа", "Тяга гантели из-за головы лежа" },
                    { 51L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Тяга штанги лежа", "Тяга штанги лежа" },
                    { 52L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Подтягивания на перекладине хватом снизу", "Подтягивания на перекладине хватом снизу" },
                    { 53L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Подтягивания на специальной перекладине", "Подтягивания на специальной перекладине" },
                    { 54L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Тяга верхнего блока перед собой", "Тяга верхнего блока перед собой" },
                    { 55L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Тяга верхнего блока за шею", "Тяга верхнего блока за шею" },
                    { 56L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Тяга верхнего блока узим хватом", "Тяга верхнего блока узким хватом" },
                    { 57L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Тяга верхнего блока прямыми руками", "Тяга верхнего блока прямыми рукам" },
                    { 58L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Тяга верхнего блока (гребля)", "Тяга верхнего блока (гребля)" },
                    { 59L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Тяга гантели одной рукой", "Тяга гантели одной рукой" },
                    { 60L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Тяга штанги, стоя в наклоне", "Тяга штанги стоя в наклоне" },
                    { 61L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Тяга т-образного грифа", "Тяга т-образного грифа" },
                    { 62L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Мертвые тяги со штангой, ноги прямые", "Мертвые тяги со штангой, ноги прямые" },
                    { 63L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Мертвые тяги в стиле сумо", "Мертвые тяги в стиле сумо" },
                    { 64L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Становые тяги со штангой", "Становые тяги со штангой" },
                    { 65L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Поясничные прогибания", "Поясничные прогибания" },
                    { 66L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Разгибания туловища на тренажере", "Разгибания туловища на тренажерея" },
                    { 67L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Вертикальные тяги", "Вертикальные тяги" },
                    { 68L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Шраги со штангой", "Шраги со штангой" },
                    { 69L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Шраги с гантелями", "Шраги с гантелями" },
                    { 70L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Шраги в тренажере", "Шраги в тренажере" },
                    { 71L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, true, "Приседания с гантелями", "Приседания с гантелями" },
                    { 72L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Приседания со штангой на груди", "Приседания со штангой на груди" },
                    { 73L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Приседания со штангой на плечах", "Приседания со штангой на плечах" },
                    { 74L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Широкие приседания", "Широкие приседания" },
                    { 75L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Наклонный жим ногами", "Наклонный жим ногами" },
                    { 76L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Приседания на тренажере", "Приседания на тренажере" },
                    { 77L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Разгибание ног", "Разгибание ног" },
                    { 78L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Сгибание ног лежа", "Сгибание ног лежа" },
                    { 79L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Сгибание одной ноги лежа", "Сгибание одной ноги лежаа" },
                    { 80L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Сгибание ног сидя", "Сгибание ног сидя" },
                    { 81L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Подъемы торса", "Подъемы торса" },
                    { 82L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Приведение одной ноги стоя", "Приведение одной ноги стоя" },
                    { 83L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Сведение ног сидя", "Сведение ног сидя" },
                    { 84L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Подъемы на носки стоя", "Подъемы на носки стоя" },
                    { 85L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Подъем на носок одной ноги стоя", "Подъем на носок одной ноги стоя" },
                    { 86L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Подъемы на носки в наклоне", "Подъемы на носки в наклоне" },
                    { 87L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Разгибание голени сидя", "Разгибание голени сидя" },
                    { 88L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Сворачивание туловища на полу", "Сворачивание туловища на пол" },
                    { 89L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Подъемы туловища у гимнастической стенки", "Подъемы туловища у гимнастической стенки" },
                    { 90L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Сворачивание туловища с голенью на скамье", "Сворачивание туловища с голенью на скамье" },
                    { 91L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Подъемы туловища на наклонной скамье", "Подъемы туловища на наклонной скамье" },
                    { 92L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Подъем туловища на вертикальной скамье", "Подъем туловища на вертикальной скамье" },
                    { 93L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Сворачивание туловища с верхним блоком", "Сворачивание туловища с верхним блоком" },
                    { 94L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Сворачивание тууловища на тренажере", "Сворачивание туловища на тренажере" },
                    { 95L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Подъемы ног на наклонной скамье", "Подъемы ног на наклонной скамье" },
                    { 96L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Подъем коленей в упоре", "Подъем коленей в упоре" },
                    { 97L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Подъем коленей в висе", "Подъем коленей в висе" },
                    { 98L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Разворот туловища с грифом", "Разворот туловища с грифом" },
                    { 99L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Боковые наклоны туловища стоя", "Боковые наклоны туловища на римском стуле" },
                    { 100L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Вращение туловища на тренажере Твист", "Вращение туловища на тренажере Твист" },
                    { 101L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Выпады со штангой на плечах", "Выпады со штангой на плечах" },
                    { 102L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Выпады с гантелями", "Выпады с гантелями" },
                    { 103L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Махи ногой назад с нижнего блока", "Махи ногой назад с нижнего блока" },
                    { 104L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Махи ногой назад с рычагом тренажера", "Махи ногой назад с рычагом тренажера" },
                    { 105L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Махи ногой нзад на полу", "Махи ногой нзад на полу" },
                    { 106L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Мостик лежа", "Мостик лежа" },
                    { 107L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Махи ногой в сторону с нинего блока", "Махи ногой в сторону с нинего блока" },
                    { 108L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Махи ногой в сторону с рычагом тренажера", "Махи ногой в сторону с рычагом тренажера" },
                    { 109L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Махи ногой в сторону, лежа на боку", "Махи ногой в сторону, лежа на боку" },
                    { 110L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Разведение ног на тренажере", "Разведение ног на тренажере" },
                    { 111L, null, new DateTime(2023, 4, 16, 15, 57, 3, 473, DateTimeKind.Utc), "", 1, false, false, "Разгибание голени сидя, со штангой на коленях", "Разгибание голени сидя, со штангой на коленях" }
                });

            migrationBuilder.InsertData(
                table: "ExerciseCategoryOfBody",
                columns: new[] { "CategoryOfBodyId", "ExerciseId" },
                values: new object[,]
                {
                    { "DeltovidnayaMyshca", 1L },
                    { "PlecheluchevayaMyshca", 1L },
                    { "PlechevayaMyshca", 1L },
                    { "BicepsDvuglavayaMyshcaPlecha", 2L },
                    { "BicepsPlechaDlannayaGolovka", 2L },
                    { "PlechevayaMyshca", 2L },
                    { "BicepsDvuglavayaMyshcaPlecha", 3L },
                    { "BicepsPlechaDlannayaGolovka", 3L },
                    { "PlecheluchevayaMyshca", 3L },
                    { "PlechevayaMyshca", 3L },
                    { "BicepsDvuglavayaMyshcaPlecha", 4L },
                    { "BicepsPlechaDlannayaGolovka", 4L },
                    { "PlechevayaMyshca", 4L },
                    { "BicepsDvuglavayaMyshcaPlecha", 5L },
                    { "BicepsPlechaDlannayaGolovka", 5L },
                    { "PlechevayaMyshca", 5L },
                    { "BicepsDvuglavayaMyshcaPlecha", 6L },
                    { "BicepsPlechaDlannayaGolovka", 6L },
                    { "PlecheluchevayaMyshca", 6L },
                    { "BicepsDvuglavayaMyshcaPlecha", 7L },
                    { "BicepsPlechaDlannayaGolovka", 7L },
                    { "BicepsDvuglavayaMyshcaPlecha", 8L },
                    { "BicepsPlechaDlannayaGolovka", 8L },
                    { "BicepsDvuglavayaMyshcaPlecha", 9L },
                    { "BicepsPlechaDlannayaGolovka", 9L },
                    { "Dlinnyjluchevojrazgibatelzapyastya", 9L },
                    { "Korotkijluchevojrvzgibatelzapyastya", 9L },
                    { "Loktevojrazgibatelzapyastya", 9L },
                    { "PlecheluchevayaMyshca", 9L },
                    { "PlechevayaMyshca", 9L },
                    { "Razgibatelpalcevkistisuhozhilie", 9L },
                    { "Dlinnyjluchevojrazgibatelzapyastya", 10L },
                    { "Korotkijluchevojrvzgibatelzapyastya", 10L },
                    { "Loktevojrazgibatelzapyastya", 10L },
                    { "Razgibatelpalcevkistisuhozhilie", 10L },
                    { "DlinnayaLadonnayaMyshca", 11L },
                    { "Dlinnyjsgibatelbolshogopalcakisti", 11L },
                    { "Loktevojsgibatelzapyastya", 11L },
                    { "Luchevojsgibatelzapyastya", 11L },
                    { "PoverhnostnyjSgibatelPalcevKisti", 11L },
                    { "LoktevayaMyshca", 12L },
                    { "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka", 12L },
                    { "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka", 12L },
                    { "TricepsTrekhglavayaMyshcaPlechaMedialnayaGolovka", 12L },
                    { "Korotkijluchevojrvzgibatelzapyastya", 13L },
                    { "LoktevayaMyshca", 13L },
                    { "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka", 13L },
                    { "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka", 13L },
                    { "TricepsTrekhglavayaMyshcaPlechaMedialnayaGolovka", 13L },
                    { "LoktevayaMyshca", 14L },
                    { "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka", 14L },
                    { "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka", 14L },
                    { "TricepsTrekhglavayaMyshcaPlechaMedialnayaGolovka", 14L },
                    { "LoktevayaMyshca", 15L },
                    { "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka", 15L },
                    { "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka", 15L },
                    { "TricepsTrekhglavayaMyshcaPlechaMedialnayaGolovka", 15L },
                    { "LoktevayaMyshca", 16L },
                    { "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka", 16L },
                    { "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka", 16L },
                    { "TricepsTrekhglavayaMyshcaPlechaMedialnayaGolovka", 16L },
                    { "LoktevayaMyshca", 17L },
                    { "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka", 17L },
                    { "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka", 17L },
                    { "LoktevayaMyshca", 18L },
                    { "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka", 18L },
                    { "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka", 18L },
                    { "TricepsTrekhglavayaMyshcaPlechaMedialnayaGolovka", 18L },
                    { "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka", 19L },
                    { "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka", 19L },
                    { "TricepsTrekhglavayaMyshcaPlechaMedialnayaGolovka", 19L },
                    { "LoktevayaMyshca", 20L },
                    { "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka", 20L },
                    { "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka", 20L },
                    { "LoktevayaMyshca", 21L },
                    { "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka", 21L },
                    { "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka", 21L },
                    { "TricepsTrekhglavayaMyshcaPlechaMedialnayaGolovka", 21L },
                    { "DeltovidnayaMyshcaPered", 22L },
                    { "DeltovidnayaMyshcaSrednya", 22L },
                    { "DeltovidnayaMyshcaZad", 22L },
                    { "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka", 22L },
                    { "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka", 22L },
                    { "TricepsTrekhglavayaMyshcaPlechaMedialnayaGolovka", 22L },
                    { "BolshayaGrudnayaMyshcaGrudinoChychicnayaChast", 23L },
                    { "DeltovidnayaMyshcaPered", 23L },
                    { "DeltovidnayaMyshcaSrednya", 23L },
                    { "DeltovidnayaMyshcaZad", 23L },
                    { "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka", 23L },
                    { "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka", 23L },
                    { "TricepsTrekhglavayaMyshcaPlechaMedialnayaGolovka", 23L },
                    { "DeltovidnayaMyshcaPered", 24L },
                    { "DeltovidnayaMyshcaSrednya", 24L },
                    { "DeltovidnayaMyshcaZad", 24L },
                    { "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka", 24L },
                    { "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka", 24L },
                    { "TricepsTrekhglavayaMyshcaPlechaMedialnayaGolovka", 24L },
                    { "BolshayaGrudnayaMyshcaGrudinoChychicnayaChast", 25L },
                    { "DeltovidnayaMyshcaPered", 25L },
                    { "DeltovidnayaMyshcaSrednya", 25L },
                    { "DeltovidnayaMyshcaZad", 25L },
                    { "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka", 25L },
                    { "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka", 25L },
                    { "TricepsTrekhglavayaMyshcaPlechaMedialnayaGolovka", 25L },
                    { "DeltovidnayaMyshcaPered", 26L },
                    { "DeltovidnayaMyshcaSrednya", 26L },
                    { "DeltovidnayaMyshcaZad", 26L },
                    { "Malayakruglayamyshca", 26L },
                    { "Podostnayamyshca", 26L },
                    { "TrapecividnayaMyshca", 26L },
                    { "DeltovidnayaMyshcaPered", 27L },
                    { "DeltovidnayaMyshcaSrednya", 27L },
                    { "DeltovidnayaMyshcaZad", 27L },
                    { "TrapecividnayaMyshca", 27L },
                    { "DeltovidnayaMyshcaPered", 28L },
                    { "DeltovidnayaMyshcaSrednya", 28L },
                    { "DeltovidnayaMyshcaZad", 28L },
                    { "BolshayaGrudnayaMyshcaGrudinoChychicnayaChast", 29L },
                    { "DeltovidnayaMyshcaPered", 29L },
                    { "DeltovidnayaMyshcaSrednya", 29L },
                    { "DeltovidnayaMyshcaZad", 29L },
                    { "DeltovidnayaMyshcaPered", 30L },
                    { "DeltovidnayaMyshcaSrednya", 30L },
                    { "DeltovidnayaMyshcaPered", 31L },
                    { "DeltovidnayaMyshcaSrednya", 31L },
                    { "DeltovidnayaMyshcaZad", 31L },
                    { "DeltovidnayaMyshcaPered", 32L },
                    { "DeltovidnayaMyshcaSrednya", 32L },
                    { "DeltovidnayaMyshcaZad", 32L },
                    { "DeltovidnayaMyshcaPered", 33L },
                    { "DeltovidnayaMyshcaSrednya", 33L },
                    { "DeltovidnayaMyshcaZad", 33L },
                    { "TrapecividnayaMyshca", 33L },
                    { "Bolshayakruglayamyshca", 34L },
                    { "DeltovidnayaMyshcaPered", 34L },
                    { "DeltovidnayaMyshcaSrednya", 34L },
                    { "DeltovidnayaMyshcaZad", 34L },
                    { "Malayakruglayamyshca", 34L },
                    { "Podostnayamyshca", 34L },
                    { "TrapecividnayaMyshca", 34L },
                    { "Malayakruglayamyshca", 35L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseCategoryOfBody_CategoryOfBodyId",
                table: "ExerciseCategoryOfBody",
                column: "CategoryOfBodyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseCategoryOfBody");

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

            migrationBuilder.CreateTable(
                name: "CategoryOfBodyExercise",
                columns: table => new
                {
                    CategoryOfBodiesCode = table.Column<string>(type: "text", nullable: false),
                    ExerciseId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryOfBodyExercise", x => new { x.CategoryOfBodiesCode, x.ExerciseId });
                    table.ForeignKey(
                        name: "FK_CategoryOfBodyExercise_CategoryOfBody_CategoryOfBodiesCode",
                        column: x => x.CategoryOfBodiesCode,
                        principalTable: "CategoryOfBody",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryOfBodyExercise_Exercise_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryOfBodyExercise_ExerciseId",
                table: "CategoryOfBodyExercise",
                column: "ExerciseId");
        }
    }
}
