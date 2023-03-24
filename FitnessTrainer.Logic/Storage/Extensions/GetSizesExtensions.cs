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
    public static class GetSizesExtensions
    {
        public static IQueryable<Domain.Size> GetFiltredSizes (this StorageContext context, GetSizesFilter filter)
        {
            DateTime? createdTo = filter.CreatedTo?.AddDays(1);

            var data = from e in context.Size.AsNoTracking()
                       where !filter.CreatedFrom.HasValue || e.CreatedDate >= filter.CreatedFrom
                       where !createdTo.HasValue || e.CreatedDate < createdTo
                       where filter.CategoryOfBodies == null || !filter.CategoryOfBodies.Any() || filter.CategoryOfBodies
                        .Any(u => e.SizeItems.Select(t => t.BodyCode).Contains(u))
                       where filter.CodeUnitsOfMeasurement == null || !filter.CodeUnitsOfMeasurement.Any() || filter.CodeUnitsOfMeasurement
                        .Any(u => e.SizeItems.Select(t => t.CodeUnitsOfMeasurement).Contains(u))
                       where string.IsNullOrWhiteSpace(filter.Name) || e.Name.ToLower().Contains(filter.Name)
                       where string.IsNullOrWhiteSpace(filter.Name) || e.Name.ToLower().Contains(filter.Name)
                       select e;
            return data;
            
        }

        public static Model.Size AsSize(this Domain.Size size, IMapper mapper)
        {
            var result = mapper.Map<Domain.Size, Model.Size>(size);
            return result;
        }
        
    }
}
