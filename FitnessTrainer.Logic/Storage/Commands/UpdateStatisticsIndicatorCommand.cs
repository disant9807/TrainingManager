using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using AutoMapper;
using TrainingManager.Log;
using Microsoft.EntityFrameworkCore;
using TrainingManager.Logic.Storage.Domain;
using TrainingManager.Logic.Model;
using System.Drawing;

namespace TrainingManager.Logic.Storage.Commands
{
    public class UpdateStatisticsIndicatorCommand : BaseStorageCommand
    {
        private readonly Model.StatisticsIndicator _statisticsIndicator;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public UpdateStatisticsIndicatorCommand(StorageContext context, Model.StatisticsIndicator statisticsIndicator, ILogFactory log, IMapper mapper) : base(context)
        {
            _statisticsIndicator = statisticsIndicator;
            _logger = log.CreateModuleLogger(typeof(UpdateStatisticsIndicatorCommand));
            _mapper = mapper;
        }

        public async override Task ExecuteAsync()
        {
            var statistics = await context.StatisticsIndicators.FirstOrDefaultAsync(e => e.Id == _statisticsIndicator.Id);

            if (statistics == null)
                throw new KeyNotFoundException($"Статистика с id = {_statisticsIndicator.Id} не найдена");

            statistics.CreatedOrUpdate = DateTime.Now;

            statistics.DateOfMeasurement = _statisticsIndicator.DateOfMeasurement;
            statistics.ObjectCode = _statisticsIndicator.ObjectCode;
            statistics.Value = _statisticsIndicator.Value;

            context.StatisticsIndicators.Update(statistics);
            await context.SaveChangesAsync();
        }
    }
}
