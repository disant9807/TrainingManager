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
    public static class GetTrainingExtensions
    {
        public static IQueryable<Domain.Training> GetFiltredTrainingPrograms(this StorageContext context, GetTrainingsFilter filter)
        {
            DateTime? createdTo = filter.CreatedTo?.AddDays(1);
            DateTime? trainingTo = filter.TrainingTo?.AddDays(1);


            var data = from e in context.Training.AsNoTracking()
                       where !filter.CreatedFrom.HasValue || e.CreatedDate >= filter.CreatedFrom
                       where !createdTo.HasValue || e.CreatedDate < createdTo
                       where !filter.TrainingFrom.HasValue || e.TrainingDate >= filter.TrainingFrom
                       where !trainingTo.HasValue ||  e.TrainingDate < trainingTo
                       where filter.CategoryOfBodies == null || !filter.CategoryOfBodies.Any() || e.Approachs
                        .SelectMany(z => z.Exercise.CategoryOfBodies).Any(y => filter.CategoryOfBodies.ToList().Contains(y.Code))
                       where string.IsNullOrWhiteSpace(filter.Name) || e.Name.ToLower().Contains(filter.Name)
                       where filter.Exercises == null || !filter.Exercises.Any() || e.Approachs
                        .Select(z => z.Exercise.Id).Any(y => filter.Exercises.ToList().Contains(y.ToString()))
                       where filter.TrainingPrograms == null || !filter.TrainingPrograms.Any() || filter.TrainingPrograms
                        .Any(u => e.TrainingProgram.Id.ToString() == u)
                       where !filter.isNoneTrainingProgram.HasValue || !filter.isNoneTrainingProgram.Value || filter.TrainingPrograms == null
                       where !filter.MinCountApproach.HasValue || e.Approachs.Count >= filter.MinCountApproach
                       where !filter.MaxCountApproach.HasValue || e.Approachs.Count <= filter.MaxCountApproach
                       where !filter.MaxTimeSec.HasValue || e.Time <= filter.MaxTimeSec
                       where !filter.MinTimeSec.HasValue || e.Time >= filter.MinTimeSec
                       select e;
            return data;
        }

        public static Model.Training AsTraining(this Domain.Training training, IMapper mapper)
        {
            var result = mapper.Map<Domain.Training, Model.Training>(training);
            return result;
        }
    }
}
