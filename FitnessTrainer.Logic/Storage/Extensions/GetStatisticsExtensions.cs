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
    public static class GetStatisticsExtensions
    {
        public static IQueryable<Domain.StatisticsIndicator> GetFiltredStatistics (this StorageContext context, GetStatisticsFilter filter)
        {
            DateTime? measurementTo = filter.MeasurementTo?.AddDays(1);

            var data = from e in context.StatisticsIndicators.AsNoTracking()
                       where !filter.MeasurementFrom.HasValue || e.DateOfMeasurement >= filter.MeasurementFrom
                       where !measurementTo.HasValue || e.DateOfMeasurement < measurementTo
                       where e.UserId == filter.UserId
                       where e.ObjectCode == filter.ObjectCode
                       select e;
            return data;
            
        }

        public static Model.StatisticsIndicator AsStatistics(this Domain.StatisticsIndicator statistics, IMapper mapper)
        {
            var result = mapper.Map<Domain.StatisticsIndicator, Model.StatisticsIndicator>(statistics);
            return result;
        }
        
    }
}
