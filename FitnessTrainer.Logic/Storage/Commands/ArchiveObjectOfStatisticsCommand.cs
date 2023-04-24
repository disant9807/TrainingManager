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
    public class ArchiveObjectOfStatisticsCommand : BaseStorageCommand
    {
        private readonly string _id;
        private readonly bool _isArchive;
        private readonly ILogger _logger;

        public ArchiveObjectOfStatisticsCommand(StorageContext context, string id, bool isArchive, ILogFactory log) : base(context)
        {
            _logger = log.CreateModuleLogger(typeof(ArchiveObjectOfStatisticsCommand));
            _id = id;
            _isArchive = isArchive;
        }

        public async override Task ExecuteAsync()
        {
            var statistics = await context.ObjectOfStatistics.FirstOrDefaultAsync(e => e.Code == _id);

            if (statistics == null)
                throw new KeyNotFoundException($"Статистика с id = {_id} не найдена");

            statistics.CreateOrUpdate = DateTime.Now;
            statistics.IsArchived = _isArchive;

            context.ObjectOfStatistics.Update(statistics);
            await context.SaveChangesAsync();
        }
    }   
}
