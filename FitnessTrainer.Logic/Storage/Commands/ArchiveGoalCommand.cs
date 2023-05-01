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
    public class ArchiveGoalCommand : BaseStorageCommand
    {
        private readonly ILogger _logger;
        private readonly long _id;
        private readonly bool _isArchive;

        public ArchiveGoalCommand(StorageContext context, ILogFactory log, long id, bool isArchive) : base(context)
        {
            _logger = log.CreateModuleLogger(typeof(ArchiveGoalCommand));
            _id = id;
            _isArchive = isArchive;
        }

        public async override Task ExecuteAsync()
        {
            var goal = await context.Goal.Where(e => e.Id == _id)
                .SingleOrDefaultAsync();

            if (goal == null)
                throw new KeyNotFoundException($"Тренировка с id = {_id} не найдена");

            if (goal.IsEveryone)
                throw new MethodAccessException();

            goal.IsArchived = _isArchive;

            context.Goal.Update(goal);
            await context.SaveChangesAsync();
        }
    }
}
