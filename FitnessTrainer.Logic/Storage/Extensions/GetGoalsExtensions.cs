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
    public static class GetGoalsExtensions
    {
        public static IQueryable<Domain.Goal> GetFiltredGoals (this StorageContext context, GetGoalsFilter filter)
        {
            DateTime? createdTo = filter.CreatedTo?.AddDays(1);
            DateTime? complectedDateTo = filter.CompletionDateTo?.AddDays(1);

            var data = from e in context.Goal.AsNoTracking()
                       where !e.IsArchived
                       where !filter.CreatedFrom.HasValue || e.CreatedDate >= filter.CreatedFrom
                       where !createdTo.HasValue || e.CreatedDate < createdTo
                       where !filter.CompletionDateFrom.HasValue || e.CompletionDate >= filter.CompletionDateFrom
                       where !complectedDateTo.HasValue || e.CompletionDate < complectedDateTo
                       where filter.CategoryOfBodies == null || !filter.CategoryOfBodies.Any() || e.SubGoals.Select(y => y.Body)
                        .Where(e => filter.CategoryOfBodies.Any(y => e.Code == y)).Count() > 0
                       where filter.CodeUnitsOfMeasurement == null || !filter.CodeUnitsOfMeasurement.Any() || filter.CodeUnitsOfMeasurement
                        .Any(u => e.SubGoals.Select(t => t.CodeUnitsOfMeasurement).Contains(u))
                       where string.IsNullOrWhiteSpace(filter.Name) || e.Name.ToLower().Contains(filter.Name)
                       where string.IsNullOrWhiteSpace(filter.Description) || e.Name.ToLower().Contains(filter.Description)
                       select e;
            return data;
            
        }

        public static Model.Goal AsGoal(this Domain.Goal goal, IMapper mapper)
        {
            var result = mapper.Map<Domain.Goal, Model.Goal>(goal);
            return result;
        }
        
    }
}
