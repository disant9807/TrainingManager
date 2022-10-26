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
    public class ArchiveTrainingCommand : BaseStorageCommand
    {
        private readonly ILogger _logger;
        private readonly long _id;
        private readonly bool _isArchive;

        public ArchiveTrainingCommand(StorageContext context, ILogFactory log, long id, bool isArchive) : base(context)
        {
            _logger = log.CreateModuleLogger(typeof(ArchiveTrainingCommand));
            _id = id;
            _isArchive = isArchive;
        }

        public async override Task ExecuteAsync()
        {
            var training = await context.Training.Where(e => e.Id == _id)
                .SingleOrDefaultAsync();

            if (training == null)
                throw new KeyNotFoundException($"Тренировка с id = {_id} не найдена");

            training.IsArchived = _isArchive;

            context.Training.Update(training);
            await context.SaveChangesAsync();
        }
    }
}
