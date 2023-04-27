using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using AutoMapper;
using TrainingManager.Log;
using Microsoft.EntityFrameworkCore;

namespace TrainingManager.Logic.Storage.Requests
{
    public class AddStatisticsIndicatorArrRequest : BaseStorageRequest<Guid[]>
    {
        private readonly Model.StatisticsIndicator[]  _statisticsIndicator;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public AddStatisticsIndicatorArrRequest(StorageContext context, Model.StatisticsIndicator[] statisticsIndicator, ILogFactory log, IMapper mapper) : base(context)
        {
            if (statisticsIndicator is null) throw new ArgumentNullException();
            _statisticsIndicator = statisticsIndicator;
            _logger = log.CreateModuleLogger(typeof(AddStatisticsIndicatorRequest));
            _mapper = mapper;
        }

        public override async Task<Guid[]> ExecuteAsync()
        {
            var statistics = new List<Domain.StatisticsIndicator>();

            foreach (var statisticsIndicator in _statisticsIndicator)
            {
                var statistic = new Domain.StatisticsIndicator();

                statistic.CreatedOrUpdate = DateTime.Now;
                statistic.IsArchived = false;
                statistic.ObjectCode = statisticsIndicator.ObjectCode;
                statistic.Value = statisticsIndicator.Value;
                statistic.DateOfMeasurement = statisticsIndicator.DateOfMeasurement;

                statistics.Add(statistic);
            }


            context.StatisticsIndicators.AddRange(statistics);
            await context.SaveChangesAsync();

            return statistics.Select(e => e.Id).ToArray();
        }
    }
}