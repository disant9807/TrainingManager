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

namespace TrainingManager.Logic.Storage.Commands
{
    public class UpdateGoalCommand : BaseStorageCommand
    {
        private readonly Model.Goal _goal;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public UpdateGoalCommand(StorageContext context, Model.Goal goal, ILogFactory log, IMapper mapper) : base(context)
        {
            _goal = goal;
            _logger = log.CreateModuleLogger(typeof(UpdateGoalCommand));
            _mapper = mapper;
        }

        public async override Task ExecuteAsync()
        {        
            var goalCount = await context.Goal.CountAsync(e => e.Id == _goal.Id);

            if (goalCount > 1 )
                throw new KeyNotFoundException($"Цель с id = {_goal.Id} не найден");

            var goal = _mapper.Map<Model.Goal, Domain.Goal>(_goal);
            context.Goal.Attach(goal);
            context.SubGoal.AttachRange(goal.SubGoals.Select(e => new SubGoal { Id = e.Id }));

            context.Goal.Update(goal);
            await context.SaveChangesAsync();
        }
    }
}
