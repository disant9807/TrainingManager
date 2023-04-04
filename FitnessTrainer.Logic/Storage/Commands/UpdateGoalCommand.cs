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

            if (goalCount < 1 )
                throw new KeyNotFoundException($"Цель с id = {_goal.Id} не найден");

            var goal = _mapper.Map<Model.Goal, Domain.Goal>(_goal);

            context.Entry<Domain.Goal>(goal).State = EntityState.Detached;
            foreach (var subGoal in goal.SubGoals)
            {
                context.Entry<Domain.SubGoal>(subGoal).State = EntityState.Detached;
            }          

            context.Goal.Update(goal);
            await context.SaveChangesAsync();
        }
    }
}
