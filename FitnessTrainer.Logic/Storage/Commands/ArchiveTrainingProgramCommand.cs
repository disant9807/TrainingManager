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
    public class ArchiveTrainingProgramCommand : BaseStorageCommand
    {
        private readonly ILogger _logger;
        private readonly long _id;
        private readonly bool _isArchive;

        public ArchiveTrainingProgramCommand(StorageContext context, ILogFactory log, long id, bool isArchive) : base(context)
        {
            _logger = log.CreateModuleLogger(typeof(ArchiveTrainingProgramCommand));
            _id = id;
            _isArchive = isArchive;
        }

        public async override Task ExecuteAsync()
        {
            var trainingProgramm = await context.TrainingProgram.Where(e => e.Id == _id)
                .SingleOrDefaultAsync();

            if (trainingProgramm == null)
                throw new KeyNotFoundException($"Тренировочная программа с id = {_id} не найдена");

            if (trainingProgramm.IsEveryone)
                throw new MethodAccessException();

            trainingProgramm.IsArchived = _isArchive;

            context.TrainingProgram.Update(trainingProgramm);
            await context.SaveChangesAsync();
        }
    }
}
