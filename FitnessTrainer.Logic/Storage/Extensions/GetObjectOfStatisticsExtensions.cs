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
    public static class GetObjectOfStatisticsExtensions
    {
        public static IQueryable<Domain.ObjectOfStatistics> GetFiltredObjectOfStatistics (this StorageContext context, GetObjectsOfStatisticsFilter filter)
        {
            var data = from e in context.StatisticsIndicators.AsNoTracking()
                       where e.UserId == filter.UserId
                       select e;
            return data;
            
        }

        public static Model.ObjectOfStatistics AsStatistics(this Domain.ObjectOfStatistics statistics, IMapper mapper)
        {
            var result = mapper.Map<Domain.ObjectOfStatistics, Model.ObjectOfStatistics>(statistics);
            return result;
        }
        
    }
}
