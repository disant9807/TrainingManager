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
    public class UpdateObjectOfStatisticsCommand : BaseStorageCommand
    {
        private readonly Model.ObjectOfStatistics _objectOfStatistics;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public UpdateObjectOfStatisticsCommand(StorageContext context, Model.ObjectOfStatistics objectOfStatistics, ILogFactory log, IMapper mapper) : base(context)
        {
            _objectOfStatistics = objectOfStatistics;
            _logger = log.CreateModuleLogger(typeof(UpdateObjectOfStatisticsCommand));
            _mapper = mapper;
        }

        public async override Task ExecuteAsync()
        {
            var statistics = await context.ObjectOfStatistics.FirstOrDefaultAsync(e => e.Code == _objectOfStatistics.Code);

            if (statistics == null)
                throw new KeyNotFoundException($"Статистика с id = {_objectOfStatistics.Code} не найдена");

            statistics.CreateOrUpdate = DateTime.Now;

            statistics.CategoryCode = _objectOfStatistics.CategoryCode;
            statistics.Code = _objectOfStatistics.Code;
            statistics.Description = _objectOfStatistics.Description;
            statistics.Name = _objectOfStatistics.Name;

            context.ObjectOfStatistics.Update(statistics);
            await context.SaveChangesAsync();
        }
    }
}
