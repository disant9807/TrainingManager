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

namespace TrainingManager.Logic.Storage.Requests
{
    public class CreateGenStatisticsRequest : BaseStorageRequest<Guid>
    {
        private readonly Model.GenStatistics _genStatistics;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public CreateGenStatisticsRequest(StorageContext context, Model.GenStatistics genStatistics, ILogFactory log, IMapper mapper) : base(context)
        {
            _genStatistics = genStatistics;
            _logger = log.CreateModuleLogger(typeof(CreateExerciseRequest));
            _mapper = mapper;
        }

        public override async Task<Guid> ExecuteAsync()
        {
            if (_genStatistics == null)
                throw new ArgumentNullException($"Ошибка в {_genStatistics}");

            var genStatistics = new GenStatistics();

            var statistis = new List<Domain.ObjectOfStatistics>();

            foreach (var model in _genStatistics.Statistics)
            {
                var objectOfStatistics = new Domain.ObjectOfStatistics();

                objectOfStatistics.UserId = model.UserId;
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

            genStatistics.UserId = _genStatistics.UserId;
            genStatistics.Id = _genStatistics.Id;
            genStatistics.CategoryCode = _genStatistics.CategoryCode;
            genStatistics.CreatedTime = _genStatistics.CreatedTime;
            genStatistics.GeneratedTime = _genStatistics.GeneratedTime;
            
            genStatistics.Statistics = statistis;


            context.GenStatistics.Add(genStatistics);
            await context.SaveChangesAsync();
            return genStatistics.Id;
        }
    }
}
