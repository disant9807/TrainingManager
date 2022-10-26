using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrainingManager.Logic.Model;
using AutoMapper;

namespace TrainingManager.Logic.Storage.Extensions
{
    public static class GetTrainingProgramsExtensions
    {
        public static IQueryable<Domain.TrainingProgram> GetFiltredTrainingPrograms(this StorageContext context, GetTrainingProgramsFilter filter)
        {
            DateTime? createdTo = filter.CreatedTo?.AddDays(1);

            var data = from e in context.TrainingProgram.AsNoTracking()
                       where !filter.CreatedFrom.HasValue || e.CreatedDate >= filter.CreatedFrom
                       where !createdTo.HasValue || e.CreatedDate < createdTo
                       where filter.CategoryOfBodies == null || !filter.CategoryOfBodies.Any() || filter.CategoryOfBodies
                        .Any(u => e.Days.SelectMany(z => z.Exercises).SelectMany(t => t.CategoryOfBodies).Select(i => i.Code).Contains(u))
                       where string.IsNullOrWhiteSpace(filter.Name) || e.Name.ToLower().Contains(filter.Name) || e.ShortName.ToLower().Contains(filter.Name)
                       where filter.Exercises == null || !filter.Exercises.Any() || filter.Exercises
                        .Any(u => e.Days.SelectMany(t => t.Exercises).Select(i => i.Id.ToString()).Contains(u))
                       where !filter.MinCountTrainingDays.HasValue || e.Days.Count >= filter.MinCountTrainingDays
                       where !filter.MaxCountTrainingDays.HasValue || e.Days.Count <= filter.MaxCountTrainingDays
                       select e;
            return data;
        }

        public static Model.TrainingProgram AsTrainingProgram(this Domain.TrainingProgram trainingProgram, IMapper mapper)
        {
            var result = mapper.Map<Domain.TrainingProgram, Model.TrainingProgram>(trainingProgram);
            return result;
        }
    }
}
