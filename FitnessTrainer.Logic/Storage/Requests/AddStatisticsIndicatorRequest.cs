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
    public class AddStatisticsIndicatorRequest : BaseStorageRequest<Guid>
    {
        private readonly Model.StatisticsIndicator _statisticsIndicator;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public AddStatisticsIndicatorRequest(StorageContext context, Model.StatisticsIndicator statisticsIndicator, ILogFactory log, IMapper mapper) : base(context)
        {
            if (statisticsIndicator is null) throw new ArgumentNullException();
            _statisticsIndicator = statisticsIndicator;
            _logger = log.CreateModuleLogger(typeof(AddStatisticsIndicatorRequest));
            _mapper = mapper;
        }

        public override async Task<Guid> ExecuteAsync()
        {
            var statistics = new Domain.StatisticsIndicator();

            statistics.CreatedOrUpdate = DateTime.Now;
            statistics.IsArchived = false;
            statistics.ObjectCode = _statisticsIndicator.ObjectCode;
            statistics.UserId = _statisticsIndicator.UserId;
            statistics.Value = _statisticsIndicator.Value;
            statistics.DateOfMeasurement = _statisticsIndicator.DateOfMeasurement;

            context.StatisticsIndicators.Add(statistics);
            await context.SaveChangesAsync();

            return statistics.Id;
        }
    }
}