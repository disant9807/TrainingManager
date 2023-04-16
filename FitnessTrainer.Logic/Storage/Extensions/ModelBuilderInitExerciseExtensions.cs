using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrainingManager.Logic.Storage.Domain;

namespace TrainingManager.Logic.Storage.Extensions
{
    public static class ModelBuilderInitExerciseExtensions
    {
        public static void builderInitExercise(this ModelBuilder builder)
        {
            builder.Entity<Exercise>().HasData(
                new Exercise
                {
                    Id = 1,
                    Name = "Попеременные сгибания рук с гантелями",
                    ShortName = "Сгибания рук с гантелями",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 2,
                    Name = "Концетрированное сгибание одной руки с гантелью",
                    ShortName = "Сгибание одной руки с гантелью",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 3,
                    Name = "Сгибание рук с гантелями хватом молоток",
                    ShortName = "Сгибание рук с гантелями хватом молоток",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 4,
                    Name = "Сгибание одной руки с рукояткой нижнего блока",
                    ShortName = "Сгибание одной руки с рукояткой нижнего блока",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 5,
                    Name = "Сгибание рук с рукоятками верхних блоков",
                    ShortName = "Сгибание рук с рукоятками верхних блоков",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 6,
                    Name = "Сгибание рук с грифом штанги",
                    ShortName = "Сгибание рук с грифом штанги",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 7,
                    Name = "Сгибание рук на тренижере",
                    ShortName = "Сгибание рук на тренижере",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 8,
                    Name = "Сгибание рук на скамье",
                    ShortName = "Сгибание рук на скамье",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 9,
                    Name = "Сгибание со штангой хватом сверху",
                    ShortName = "Сгибание со штангой хватом сверхуы",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 10,
                    Name = "Разгибание запястий со штангой хватом сверху",
                    ShortName = "Разгибание запястий со штангой хватом сверху",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 11,
                    Name = "Сгибание запястий со штангой хватом снизу",
                    ShortName = "Сгибание запястий со штангой хватом снизу",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 12,
                    Name = "Разгибание рук с рукояткой верхнего блока хватом сверху",
                    ShortName = "Разгибание рук с рукояткой верхнего блока хватом сверху",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 13,
                    Name = "Разгибание рук с рукояткой верхнего блока хватом снизу",
                    ShortName = "Разгибание рук с рукояткой верхнего блока хватом снизу",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 14,
                    Name = "Разгибание одной руки с верхним блоком хватом снизу",
                    ShortName = "Разгибание одной руки с верхним блоком хватом снизу",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 15,
                    Name = "Разгибание рук со штангой лежа",
                    ShortName = "Разгибание рук со штангой лежа",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 16,
                    Name = "Разгибание рук с гантелями лежа",
                    ShortName = "Разгибание рук с гантелями лежа",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 17,
                    Name = "Разгибание одной руки с гантелью из-за головы",
                    ShortName = "Разгибание одной руки с гантелью из-за головы",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 18,
                    Name = "Разгибание рук с однойц гантелью из-за головы",
                    ShortName = "Разгибание рук с однойц гантелью из-за голов",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 19,
                    Name = "Разгибание рук с изогнутым грифом штанги из-за головы",
                    ShortName = "Разгибание рук с изогнутым грифом штанги из-за головы",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 20,
                    Name = "Разгибание одной руки назад с гантлью в наклоне",
                    ShortName = "Разгибание одной руки назад с гантлью в наклоне",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 21,
                    Name = "Отжимания трицепсами спиной к скамье",
                    ShortName = "Отжимания трицепсами спиной к скамье",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 22,
                    Name = "Жим штанги из-за головы сидя",
                    ShortName = "Жим штанги из-за головы сидя",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 23,
                    Name = "Жим штанги с груди сидя",
                    ShortName = "Жим штанги с груди сидя",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = true
                },
                new Exercise
                {
                    Id = 24,
                    Name = "Жим гантелей лежа",
                    ShortName = "Жим гантелей лежа",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 25,
                    Name = "Жим гантелей сидя",
                    ShortName = "Жим гантелей сидя",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 26,
                    Name = "Попеременный жим гантелей с поворотами запястий",
                    ShortName = "Попеременный жим гантелей с поворотами запястий",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 27,
                    Name = "Подъем гантелей в стороны в наклоне вперед",
                    ShortName = "Подъем гантелей в стороны в наклоне вперед",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 28,
                    Name = "Подъем гантелей в стороны",
                    ShortName = "Подъем гантелей в стороны",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 29,
                    Name = "Подъем гантелей вперед попеременно",
                    ShortName = "Подъем гантелей вперед попеременно",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 30,
                    Name = "Подъем гантели в сторону одной рукой, лежа на боку",
                    ShortName = "Подъем гантели в сторону одной рукой, лежа на боку",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 31,
                    Name = "Подъем одной руки в сторону с нижнего блока",
                    ShortName = "Подъем одной руки в сторону с нижнего блока",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 32,
                    Name = "Подъем одной руки вперед с нижнего блока стоя",
                    ShortName = "Подъем одной руки вперед с нижнего блока стоя",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 33,
                    Name = "Перекрестные махи руками назад с верхних блоков",
                    ShortName = "Перекрестные махи руками назад с верхних блоков",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 34,
                    Name = "Перекрестные махи руками назад с нижних блоков в наклоне",
                    ShortName = "Перекрестные махи руками назад с нижних блоков в наклоне",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 35,
                    Name = "Подъемы рук вперед с одной гантелью",
                    ShortName = "Подъемы рук вперед с одной гантелью",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 36,
                    Name = "Подъемы штанги вперед",
                    ShortName = "Подъемы штанги вперед",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 37,
                    Name = "Плечевая передняя протяжка",
                    ShortName = "Плечевая передняя протяжка",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 38,
                    Name = "Подъемы рук в стороны на тренажере",
                    ShortName = "Подъемы рук в стороны на тренажере",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 39,
                    Name = "Махи руками назад с рукоятками тренажера",
                    ShortName = "Махи руками назад с рукоятками тренажерае",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 40,
                    Name = "Жим штанги, лежа на наклонной скамье",
                    ShortName = "Жим штанги, лежа на наклонной скамье",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 41,
                    Name = "Жим штанги, лежа на горизонтальной скамье",
                    ShortName = "Жим штанги, лежа на горизонтальной скамье",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 42,
                    Name = "Жим штанги, лежа на скамье с уклоном",
                    ShortName = "Жим штанги, лежа на скамье с уклоном",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 43,
                    Name = "Отжимания от пола",
                    ShortName = "Отжимания от пола",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 44,
                    Name = "Отжимания на брусьях",
                    ShortName = "Отжимания на брусьях",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 45,
                    Name = "Жим гантелей лежа",
                    ShortName = "Жим гантелей лежа",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 46,
                    Name = "Разведение гантелей лежа",
                    ShortName = "Разведение гантелей лежа",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 47,
                    Name = "Жим гантелей, лежа на наклонной скамье",
                    ShortName = "Жим гантелей, лежа на наклонной скамье",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 48,
                    Name = "Сведение рук в тренажере",
                    ShortName = "Сведение рук в тренажере",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 49,
                    Name = "Сведение верхних блоков",
                    ShortName = "Сведение верхних блоков",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 50,
                    Name = "Тяга гантели из-за головы лежа",
                    ShortName = "Тяга гантели из-за головы лежа",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 51,
                    Name = "Тяга штанги лежа",
                    ShortName = "Тяга штанги лежа",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 52,
                    Name = "Подтягивания на перекладине хватом снизу",
                    ShortName = "Подтягивания на перекладине хватом снизу",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 53,
                    Name = "Подтягивания на специальной перекладине",
                    ShortName = "Подтягивания на специальной перекладине",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 54,
                    Name = "Тяга верхнего блока перед собой",
                    ShortName = "Тяга верхнего блока перед собой",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 55,
                    Name = "Тяга верхнего блока за шею",
                    ShortName = "Тяга верхнего блока за шею",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 56,
                    Name = "Тяга верхнего блока узим хватом",
                    ShortName = "Тяга верхнего блока узким хватом",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 57,
                    Name = "Тяга верхнего блока прямыми руками",
                    ShortName = "Тяга верхнего блока прямыми рукам",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 58,
                    Name = "Тяга верхнего блока (гребля)",
                    ShortName = "Тяга верхнего блока (гребля)",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 59,
                    Name = "Тяга гантели одной рукой",
                    ShortName = "Тяга гантели одной рукой",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 60,
                    Name = "Тяга штанги, стоя в наклоне",
                    ShortName = "Тяга штанги стоя в наклоне",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 61,
                    Name = "Тяга т-образного грифа",
                    ShortName = "Тяга т-образного грифа",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 62,
                    Name = "Мертвые тяги со штангой, ноги прямые",
                    ShortName = "Мертвые тяги со штангой, ноги прямые",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 63,
                    Name = "Мертвые тяги в стиле сумо",
                    ShortName = "Мертвые тяги в стиле сумо",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 64,
                    Name = "Становые тяги со штангой",
                    ShortName = "Становые тяги со штангой",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 65,
                    Name = "Поясничные прогибания",
                    ShortName = "Поясничные прогибания",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 66,
                    Name = "Разгибания туловища на тренажере",
                    ShortName = "Разгибания туловища на тренажерея",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 67,
                    Name = "Вертикальные тяги",
                    ShortName = "Вертикальные тяги",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 68,
                    Name = "Шраги со штангой",
                    ShortName = "Шраги со штангой",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 69,
                    Name = "Шраги с гантелями",
                    ShortName = "Шраги с гантелями",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 70,
                    Name = "Шраги в тренажере",
                    ShortName = "Шраги в тренажере",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 71,
                    Name = "Приседания с гантелями",
                    ShortName = "Приседания с гантелями",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = true
                },
                new Exercise
                {
                    Id = 72,
                    Name = "Приседания со штангой на груди",
                    ShortName = "Приседания со штангой на груди",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 73,
                    Name = "Приседания со штангой на плечах",
                    ShortName = "Приседания со штангой на плечах",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 74,
                    Name = "Широкие приседания",
                    ShortName = "Широкие приседания",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 75,
                    Name = "Наклонный жим ногами",
                    ShortName = "Наклонный жим ногами",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 76,
                    Name = "Приседания на тренажере",
                    ShortName = "Приседания на тренажере",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 77,
                    Name = "Разгибание ног",
                    ShortName = "Разгибание ног",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 78,
                    Name = "Сгибание ног лежа",
                    ShortName = "Сгибание ног лежа",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 79,
                    Name = "Сгибание одной ноги лежа",
                    ShortName = "Сгибание одной ноги лежаа",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 80,
                    Name = "Сгибание ног сидя",
                    ShortName = "Сгибание ног сидя",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 81,
                    Name = "Подъемы торса",
                    ShortName = "Подъемы торса",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 82,
                    Name = "Приведение одной ноги стоя",
                    ShortName = "Приведение одной ноги стоя",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 83,
                    Name = "Сведение ног сидя",
                    ShortName = "Сведение ног сидя",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 84,
                    Name = "Подъемы на носки стоя",
                    ShortName = "Подъемы на носки стоя",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 85,
                    Name = "Подъем на носок одной ноги стоя",
                    ShortName = "Подъем на носок одной ноги стоя",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 86,
                    Name = "Подъемы на носки в наклоне",
                    ShortName = "Подъемы на носки в наклоне",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 87,
                    Name = "Разгибание голени сидя",
                    ShortName = "Разгибание голени сидя",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 111,
                    Name = "Разгибание голени сидя, со штангой на коленях",
                    ShortName = "Разгибание голени сидя, со штангой на коленях",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 88,
                    Name = "Сворачивание туловища на полу",
                    ShortName = "Сворачивание туловища на пол",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 89,
                    Name = "Подъемы туловища у гимнастической стенки",
                    ShortName = "Подъемы туловища у гимнастической стенки",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 90,
                    Name = "Сворачивание туловища с голенью на скамье",
                    ShortName = "Сворачивание туловища с голенью на скамье",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 91,
                    Name = "Подъемы туловища на наклонной скамье",
                    ShortName = "Подъемы туловища на наклонной скамье",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 92,
                    Name = "Подъем туловища на вертикальной скамье",
                    ShortName = "Подъем туловища на вертикальной скамье",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 93,
                    Name = "Сворачивание туловища с верхним блоком",
                    ShortName = "Сворачивание туловища с верхним блоком",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 94,
                    Name = "Сворачивание тууловища на тренажере",
                    ShortName = "Сворачивание туловища на тренажере",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 95,
                    Name = "Подъемы ног на наклонной скамье",
                    ShortName = "Подъемы ног на наклонной скамье",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 96,
                    Name = "Подъем коленей в упоре",
                    ShortName = "Подъем коленей в упоре",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 97,
                    Name = "Подъем коленей в висе",
                    ShortName = "Подъем коленей в висе",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 98,
                    Name = "Разворот туловища с грифом",
                    ShortName = "Разворот туловища с грифом",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 99,
                    Name = "Боковые наклоны туловища стоя",
                    ShortName = "Боковые наклоны туловища на римском стуле",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 100,
                    Name = "Вращение туловища на тренажере Твист",
                    ShortName = "Вращение туловища на тренажере Твист",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 101,
                    Name = "Выпады со штангой на плечах",
                    ShortName = "Выпады со штангой на плечах",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 102,
                    Name = "Выпады с гантелями",
                    ShortName = "Выпады с гантелями",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 103,
                    Name = "Махи ногой назад с нижнего блока",
                    ShortName = "Махи ногой назад с нижнего блока",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 104,
                    Name = "Махи ногой назад с рычагом тренажера",
                    ShortName = "Махи ногой назад с рычагом тренажера",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 105,
                    Name = "Махи ногой нзад на полу",
                    ShortName = "Махи ногой нзад на полу",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 106,
                    Name = "Мостик лежа",
                    ShortName = "Мостик лежа",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 107,
                    Name = "Махи ногой в сторону с нинего блока",
                    ShortName = "Махи ногой в сторону с нинего блока",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 108,
                    Name = "Махи ногой в сторону с рычагом тренажера",
                    ShortName = "Махи ногой в сторону с рычагом тренажера",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 109,
                    Name = "Махи ногой в сторону, лежа на боку",
                    ShortName = "Махи ногой в сторону, лежа на боку",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                },
                new Exercise
                {
                    Id = 110,
                    Name = "Разведение ног на тренажере",
                    ShortName = "Разведение ног на тренажере",
                    CreatedDate = DateTime.Now,
                    HardSkill = HardSkill.normal,
                    Description = "",
                    IsBased = false
                }
            );

            builder.Entity<Exercise>()
                .HasMany(x => x.CategoryOfBodies)
                .WithMany(x => x.Exercise)
                .UsingEntity<Dictionary<string, object>>(
                    "ExerciseCategoryOfBody",
                    r => r.HasOne<CategoryOfBody>().WithMany().HasForeignKey("CategoryOfBodyId"),
                    l => l.HasOne<Exercise>().WithMany().HasForeignKey("ExerciseId"),
                    je =>
                    {
                        je.HasKey("ExerciseId", "CategoryOfBodyId");
                        je.HasData(
                            new { ExerciseId = (long)1, CategoryOfBodyId = "DeltovidnayaMyshca" },
                            new { ExerciseId = (long)1, CategoryOfBodyId = "PlechevayaMyshca" },
                            new { ExerciseId = (long)1, CategoryOfBodyId = "PlecheluchevayaMyshca" },
                            new { ExerciseId = (long)2, CategoryOfBodyId = "BicepsDvuglavayaMyshcaPlecha" },
                            new { ExerciseId = (long)2, CategoryOfBodyId = "BicepsPlechaDlannayaGolovka" },
                            new { ExerciseId = (long)2, CategoryOfBodyId = "PlechevayaMyshca" },
                            new { ExerciseId = (long)3, CategoryOfBodyId = "BicepsDvuglavayaMyshcaPlecha" },
                            new { ExerciseId = (long)3, CategoryOfBodyId = "BicepsPlechaDlannayaGolovka" },
                            new { ExerciseId = (long)3, CategoryOfBodyId = "PlechevayaMyshca" },
                            new { ExerciseId = (long)3, CategoryOfBodyId = "PlecheluchevayaMyshca" },
                            new { ExerciseId = (long)4, CategoryOfBodyId = "BicepsDvuglavayaMyshcaPlecha" },
                            new { ExerciseId = (long)4, CategoryOfBodyId = "BicepsPlechaDlannayaGolovka" },
                            new { ExerciseId = (long)4, CategoryOfBodyId = "PlechevayaMyshca" },
                            new { ExerciseId = (long)5, CategoryOfBodyId = "PlechevayaMyshca" },
                            new { ExerciseId = (long)5, CategoryOfBodyId = "BicepsDvuglavayaMyshcaPlecha" },
                            new { ExerciseId = (long)5, CategoryOfBodyId = "BicepsPlechaDlannayaGolovka" },
                            new { ExerciseId = (long)6, CategoryOfBodyId = "BicepsDvuglavayaMyshcaPlecha" },
                            new { ExerciseId = (long)6, CategoryOfBodyId = "BicepsPlechaDlannayaGolovka" },
                            new { ExerciseId = (long)6, CategoryOfBodyId = "PlecheluchevayaMyshca" },
                            new { ExerciseId = (long)7, CategoryOfBodyId = "BicepsPlechaDlannayaGolovka" },
                            new { ExerciseId = (long)7, CategoryOfBodyId = "BicepsDvuglavayaMyshcaPlecha" },
                            new { ExerciseId = (long)8, CategoryOfBodyId = "BicepsPlechaDlannayaGolovka" },
                            new { ExerciseId = (long)8, CategoryOfBodyId = "BicepsDvuglavayaMyshcaPlecha" },
                            new { ExerciseId = (long)9, CategoryOfBodyId = "PlecheluchevayaMyshca" },
                            new { ExerciseId = (long)9, CategoryOfBodyId = "PlechevayaMyshca" },
                            new { ExerciseId = (long)9, CategoryOfBodyId = "BicepsDvuglavayaMyshcaPlecha" },
                            new { ExerciseId = (long)9, CategoryOfBodyId = "BicepsPlechaDlannayaGolovka" },
                            new { ExerciseId = (long)9, CategoryOfBodyId = "Dlinnyjluchevojrazgibatelzapyastya" },
                            new { ExerciseId = (long)9, CategoryOfBodyId = "Korotkijluchevojrvzgibatelzapyastya" },
                            new { ExerciseId = (long)9, CategoryOfBodyId = "Razgibatelpalcevkistisuhozhilie" },
                            new { ExerciseId = (long)9, CategoryOfBodyId = "Loktevojrazgibatelzapyastya" },
                            new { ExerciseId = (long)10, CategoryOfBodyId = "Dlinnyjluchevojrazgibatelzapyastya" },
                            new { ExerciseId = (long)10, CategoryOfBodyId = "Korotkijluchevojrvzgibatelzapyastya" },
                            new { ExerciseId = (long)10, CategoryOfBodyId = "Razgibatelpalcevkistisuhozhilie" },
                            new { ExerciseId = (long)10, CategoryOfBodyId = "Loktevojrazgibatelzapyastya" },
                            new { ExerciseId = (long)11, CategoryOfBodyId = "Luchevojsgibatelzapyastya" },
                            new { ExerciseId = (long)11, CategoryOfBodyId = "DlinnayaLadonnayaMyshca" },
                            new { ExerciseId = (long)11, CategoryOfBodyId = "PoverhnostnyjSgibatelPalcevKisti" },
                            new { ExerciseId = (long)11, CategoryOfBodyId = "Loktevojsgibatelzapyastya" },
                            new { ExerciseId = (long)11, CategoryOfBodyId = "Dlinnyjsgibatelbolshogopalcakisti" },
                            new { ExerciseId = (long)12, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka" },
                            new { ExerciseId = (long)12, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaMedialnayaGolovka" },
                            new { ExerciseId = (long)12, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka" },
                            new { ExerciseId = (long)12, CategoryOfBodyId = "LoktevayaMyshca" },
                            new { ExerciseId = (long)13, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka" },
                            new { ExerciseId = (long)13, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka" },
                            new { ExerciseId = (long)13, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaMedialnayaGolovka" },
                            new { ExerciseId = (long)13, CategoryOfBodyId = "LoktevayaMyshca" },
                            new { ExerciseId = (long)13, CategoryOfBodyId = "Korotkijluchevojrvzgibatelzapyastya" },
                            new { ExerciseId = (long)13, CategoryOfBodyId = "Korotkijluchevojrvzgibatelzapyastya" },
                            new { ExerciseId = (long)14, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka" },
                            new { ExerciseId = (long)14, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka" },
                            new { ExerciseId = (long)14, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaMedialnayaGolovka" },
                            new { ExerciseId = (long)14, CategoryOfBodyId = "LoktevayaMyshca" },
                            new { ExerciseId = (long)15, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka" },
                            new { ExerciseId = (long)15, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka" },
                            new { ExerciseId = (long)15, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaMedialnayaGolovka" },
                            new { ExerciseId = (long)15, CategoryOfBodyId = "LoktevayaMyshca" },
                            new { ExerciseId = (long)16, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka" },
                            new { ExerciseId = (long)16, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka" },
                            new { ExerciseId = (long)16, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaMedialnayaGolovka" },
                            new { ExerciseId = (long)16, CategoryOfBodyId = "LoktevayaMyshca" },
                            new { ExerciseId = (long)17, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka" },
                            new { ExerciseId = (long)17, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka" },
                            new { ExerciseId = (long)17, CategoryOfBodyId = "LoktevayaMyshca" },
                            new { ExerciseId = (long)18, CategoryOfBodyId = "LoktevayaMyshca" },
                            new { ExerciseId = (long)18, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka" },
                            new { ExerciseId = (long)18, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka" },
                            new { ExerciseId = (long)18, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaMedialnayaGolovka" },
                            new { ExerciseId = (long)19, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka" },
                            new { ExerciseId = (long)19, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka" },
                            new { ExerciseId = (long)19, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaMedialnayaGolovka" },
                            new { ExerciseId = (long)20, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka" },
                            new { ExerciseId = (long)20, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka" },,
                            new { ExerciseId = (long)20, CategoryOfBodyId = "LoktevayaMyshca" },
                            new { ExerciseId = (long)21, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka" },
                            new { ExerciseId = (long)21, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka" },
                            new { ExerciseId = (long)21, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaMedialnayaGolovka" },
                            new { ExerciseId = (long)21, CategoryOfBodyId = "LoktevayaMyshca" },
                            new { ExerciseId = (long)22, CategoryOfBodyId = "DeltovidnayaMyshcaPered" },
                            new { ExerciseId = (long)22, CategoryOfBodyId = "DeltovidnayaMyshcaSrednya" },
                            new { ExerciseId = (long)22, CategoryOfBodyId = "DeltovidnayaMyshcaZad" },
                            new { ExerciseId = (long)22, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka" },
                            new { ExerciseId = (long)22, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka" },
                            new { ExerciseId = (long)22, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaMedialnayaGolovka" },
                            new { ExerciseId = (long)23, CategoryOfBodyId = "DeltovidnayaMyshcaPered" },
                            new { ExerciseId = (long)23, CategoryOfBodyId = "DeltovidnayaMyshcaSrednya" },
                            new { ExerciseId = (long)23, CategoryOfBodyId = "DeltovidnayaMyshcaZad" },
                            new { ExerciseId = (long)23, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka" },
                            new { ExerciseId = (long)23, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka" },
                            new { ExerciseId = (long)23, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaMedialnayaGolovka" },
                            new { ExerciseId = (long)23, CategoryOfBodyId = "BolshayaGrudnayaMyshcaGrudinoChychicnayaChast" },
                            new { ExerciseId = (long)24, CategoryOfBodyId = "DeltovidnayaMyshcaPered" },
                            new { ExerciseId = (long)24, CategoryOfBodyId = "DeltovidnayaMyshcaSrednya" },
                            new { ExerciseId = (long)24, CategoryOfBodyId = "DeltovidnayaMyshcaZad" },
                            new { ExerciseId = (long)24, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka" },
                            new { ExerciseId = (long)24, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka" },
                            new { ExerciseId = (long)24, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaMedialnayaGolovka" },
                            new { ExerciseId = (long)25, CategoryOfBodyId = "DeltovidnayaMyshcaPered" },
                            new { ExerciseId = (long)25, CategoryOfBodyId = "DeltovidnayaMyshcaSrednya" },
                            new { ExerciseId = (long)25, CategoryOfBodyId = "DeltovidnayaMyshcaZad" },
                            new { ExerciseId = (long)25, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka" },
                            new { ExerciseId = (long)25, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka" },
                            new { ExerciseId = (long)25, CategoryOfBodyId = "TricepsTrekhglavayaMyshcaPlechaMedialnayaGolovka" },
                            new { ExerciseId = (long)25, CategoryOfBodyId = "BolshayaGrudnayaMyshcaGrudinoChychicnayaChast" },
                            new { ExerciseId = (long)26, CategoryOfBodyId = "DeltovidnayaMyshcaPered" },
                            new { ExerciseId = (long)26, CategoryOfBodyId = "DeltovidnayaMyshcaSrednya" },
                            new { ExerciseId = (long)26, CategoryOfBodyId = "DeltovidnayaMyshcaZad" },
                            new { ExerciseId = (long)26, CategoryOfBodyId = "Malayakruglayamyshca" },
                            new { ExerciseId = (long)26, CategoryOfBodyId = "TrapecividnayaMyshca" },
                            new { ExerciseId = (long)26, CategoryOfBodyId = "Podostnayamyshca" },
                            new { ExerciseId = (long)27, CategoryOfBodyId = "DeltovidnayaMyshcaPered" },
                            new { ExerciseId = (long)27, CategoryOfBodyId = "DeltovidnayaMyshcaSrednya" },
                            new { ExerciseId = (long)27, CategoryOfBodyId = "DeltovidnayaMyshcaZad" },
                            new { ExerciseId = (long)27, CategoryOfBodyId = "TrapecividnayaMyshca" },
                            new { ExerciseId = (long)28, CategoryOfBodyId = "DeltovidnayaMyshcaPered" },
                            new { ExerciseId = (long)28, CategoryOfBodyId = "DeltovidnayaMyshcaSrednya" },
                            new { ExerciseId = (long)28, CategoryOfBodyId = "DeltovidnayaMyshcaZad" },
                            new { ExerciseId = (long)29, CategoryOfBodyId = "DeltovidnayaMyshcaPered" },
                            new { ExerciseId = (long)29, CategoryOfBodyId = "DeltovidnayaMyshcaSrednya" },
                            new { ExerciseId = (long)29, CategoryOfBodyId = "DeltovidnayaMyshcaZad" },
                            new { ExerciseId = (long)29, CategoryOfBodyId = "BolshayaGrudnayaMyshcaGrudinoChychicnayaChast" },
                            new { ExerciseId = (long)30, CategoryOfBodyId = "DeltovidnayaMyshcaPered" },
                            new { ExerciseId = (long)30, CategoryOfBodyId = "DeltovidnayaMyshcaSrednya" },
                            new { ExerciseId = (long)31, CategoryOfBodyId = "DeltovidnayaMyshcaZad" },
                            new { ExerciseId = (long)31, CategoryOfBodyId = "DeltovidnayaMyshcaPered" },
                            new { ExerciseId = (long)31, CategoryOfBodyId = "DeltovidnayaMyshcaSrednya" },
                            new { ExerciseId = (long)32, CategoryOfBodyId = "DeltovidnayaMyshcaZad" },
                            new { ExerciseId = (long)32, CategoryOfBodyId = "DeltovidnayaMyshcaPered" },
                            new { ExerciseId = (long)32, CategoryOfBodyId = "DeltovidnayaMyshcaSrednya" },
                            new { ExerciseId = (long)33, CategoryOfBodyId = "DeltovidnayaMyshcaPered" },
                            new { ExerciseId = (long)33, CategoryOfBodyId = "DeltovidnayaMyshcaSrednya" },
                            new { ExerciseId = (long)33, CategoryOfBodyId = "DeltovidnayaMyshcaZad" },
                            new { ExerciseId = (long)33, CategoryOfBodyId = "TrapecividnayaMyshca" },
                            new { ExerciseId = (long)34, CategoryOfBodyId = "TrapecividnayaMyshca" },
                            new { ExerciseId = (long)34, CategoryOfBodyId = "DeltovidnayaMyshcaPered" },
                            new { ExerciseId = (long)34, CategoryOfBodyId = "DeltovidnayaMyshcaSrednya" },
                            new { ExerciseId = (long)34, CategoryOfBodyId = "DeltovidnayaMyshcaZad" },
                            new { ExerciseId = (long)34, CategoryOfBodyId = "Bolshayakruglayamyshca" },
                            new { ExerciseId = (long)34, CategoryOfBodyId = "Podostnayamyshca" },
                            new { ExerciseId = (long)34, CategoryOfBodyId = "Malayakruglayamyshca" },
                            new { ExerciseId = (long)35, CategoryOfBodyId = "Malayakruglayamyshca" }
                            );
                    }
                );
        }
    }
}
