using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using AutoMapper;
using TrainingManager.Log;
using Microsoft.EntityFrameworkCore;
using TrainingManager.Logic.Storage.Domain;
using TrainingManager.Logic.Model;

namespace TrainingManager.Logic.Storage.Requests
{
    public class CreateObjectsOfStatisticsArrRequest : BaseStorageRequest<Guid[]>
    {
        private readonly Model.ObjectOfStatistics[] _objectOfStatistics;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public CreateObjectsOfStatisticsArrRequest(StorageContext context, Model.ObjectOfStatistics[] objectOfStatistics, ILogFactory log, IMapper mapper) : base(context)
        {
            _objectOfStatistics = objectOfStatistics;
            _logger = log.CreateModuleLogger(typeof(CreateExerciseRequest));
            _mapper = mapper;
        }

        public override async Task<Guid[]> ExecuteAsync()
        {
            if (_objectOfStatistics == null)
                throw new ArgumentNullException($"Ошибка в {_objectOfStatistics}");

            var statistis = new List<Domain.ObjectOfStatistics>();

            foreach(var model in _objectOfStatistics)
            {
                var objectOfStatistics = new Domain.ObjectOfStatistics();

                objectOfStatistics.Code = model.Code;
                objectOfStatistics.CategoryCode = model.CategoryCode;
                objectOfStatistics.Description = model.Description;
                objectOfStatistics.Name = model.Name;
                objectOfStatistics.CreateOrUpdate = model.CreateOrUpdate;

                var statisticsindicators = new List<Domain.StatisticsIndicator>();

                foreach (var statisticsIndicator in model.StatisticsIndicators)
                {
                    var statistic = new Domain.StatisticsIndicator();

                    statistic.CreatedOrUpdate = DateTime.Now;
                    statistic.IsArchived = false;
                    statistic.ObjectCode = statisticsIndicator.ObjectCode;
                    statistic.Value = statisticsIndicator.Value;
                    statistic.DateOfMeasurement = statisticsIndicator.DateOfMeasurement;

                    statisticsindicators.Add(statistic);
                }

                objectOfStatistics.StatisticsIndicators = statisticsindicators;

                statistis.Add(objectOfStatistics);
            }


            context.ObjectOfStatistics.AddRange(statistis);
            await context.SaveChangesAsync();
            return statistis.Select(e => e.Id).ToArray();
        }
    }
}
