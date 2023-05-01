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
    public class ArchiveExerciseCommand : BaseStorageCommand
    {
        private readonly ILogger _logger;
        private readonly long _id;
        private readonly bool _isArchive;

        public ArchiveExerciseCommand(StorageContext context, ILogFactory log, long id, bool isArchive) : base(context)
        {
            _logger = log.CreateModuleLogger(typeof(ArchiveExerciseCommand));
            _id = id;
            _isArchive = isArchive;
        }

        public async override Task ExecuteAsync()
        {
            var exercise = await context.Exercise.Where(e => e.Id == _id)
                .SingleOrDefaultAsync();

            if (exercise == null)
                throw new KeyNotFoundException($"Упражнение с id = {_id} не найдено");

            if (exercise.IsEveryone)
                throw new MethodAccessException();

            exercise.IsArchived = _isArchive;

            context.Exercise.Update(exercise);
            await context.SaveChangesAsync();
        }
    }
}
