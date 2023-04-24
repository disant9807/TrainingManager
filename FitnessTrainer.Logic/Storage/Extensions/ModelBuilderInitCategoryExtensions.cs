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
    public static class ModelBuilderInitSizeExtensions
    {
        public static void builderInitCategory(this ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
               new Category
               {
                   Code = "Size",
                   Description = "Замеры",
                   Name = "Замеры"
               },
               new Category
               {
                   Code = "Goal",
                   Description = "Цель",
                   Name = "Цель"
               },
               new Category
               {
                   Code = "Training",
                   Description = "Тренировки",
                   Name = "Тренировки"
               }
           );
        }


    }
}
