using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using AutoMapper;
using TrainingManager.Log;
using Microsoft.EntityFrameworkCore;

namespace TrainingManager.Logic.Storage.Commands
{
    public class ArchiveStatisticsCommand : BaseStorageCommand
    {
        private readonly ILogger _logger;
        private readonly Guid _id;
        private readonly bool _isArchive;

        public ArchiveStatisticsCommand(StorageContext context, ILogFactory log, Guid id, bool isArchive) : base(context)
        {
            _logger = log.CreateModuleLogger(typeof(ArchiveStatisticsCommand));
            _id = id;
            _isArchive = isArchive;
        }

        public async override Task ExecuteAsync()
        {
            var statistics = await context.StatisticsIndicators.FirstOrDefaultAsync(e => e.Id == _id);

            if (statistics == null)
                throw new KeyNotFoundException($"Статистика с id = {_id} не найдена");

            statistics.IsArchived = _isArchive;

            context.StatisticsIndicators.Update(statistics);
            await context.SaveChangesAsync();

            _logger.Information($"Статистика с id = {_id} успешно архивирована");
        }
    }
}
