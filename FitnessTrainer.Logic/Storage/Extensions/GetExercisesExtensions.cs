using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrainingManager.Logic.Model;

namespace TrainingManager.Logic.Storage.Extensions
{
    public static class GetExercisesExtensions
    {
        public static IQueryable<Domain.Exercise> GetFiltredExercises(this StorageContext context, GetExercisesFilter filter)
        {
            DateTime? createdTo = filter.CreatedTo?.AddDays(1);

            var data = from e in context.Exercise.AsNoTracking()
                       where !filter.CreatedFrom.HasValue || e.CreatedDate >= filter.CreatedFrom
                       where !createdTo.HasValue || e.CreatedDate < createdTo
                       where filter.CategoryOfBodies == null || !filter.CategoryOfBodies.Any() || filter.CategoryOfBodies.Any(u => e.CategoryOfBodies.Select(i => i.Code).Contains(u))
                       where filter.HardSkills == null || !filter.HardSkills.Any() || filter.HardSkills.Select(i => i.ToString()).Contains(e.HardSkill.ToString())
                       where filter.HardSkill == null || filter.HardSkill.ToString() == e.HardSkill.ToString()
                       where !filter.IsBased.HasValue || e.IsBased == filter.IsBased
                       where string.IsNullOrWhiteSpace(filter.Name) || e.Name.ToLower().Contains(filter.Name) || e.ShortName.ToLower().Contains(filter.Name)
                       select e;
            return data;
        }

        public static Model.Exercise AsExercise (this Domain.Exercise exercise)
        {
            return new Model.Exercise()
            {
                CategoryOfBodiesIds = exercise.CategoryOfBodies.Select(e => e.Code).ToArray(),
                CreatedDate = exercise.CreatedDate,
                Id = exercise.Id,
                Description = exercise.Description,
                HardSkill = exercise.HardSkill switch
                {
                    Domain.HardSkill.hard => Model.HardSkill.hard,
                    Domain.HardSkill.normal => Model.HardSkill.normal,
                    Domain.HardSkill.easy => Model.HardSkill.easy
                },
                ImagesIds = exercise.Images.Select(e => e.Id).ToArray(),
                IsBased = exercise.IsBased,
                Name = exercise.Name,
                ShortName = exercise.ShortName
            };
        }
    }
}
