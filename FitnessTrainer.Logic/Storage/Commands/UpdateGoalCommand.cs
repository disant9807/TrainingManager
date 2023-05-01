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
            var goal = await context.Goal
                .Where(e => e.Id == _goal.Id)
                .Include(e => e.SubGoals)
                .FirstOrDefaultAsync();

            if (goal == null)
                throw new KeyNotFoundException($"Цель с id = {_goal.Id} не найдена");

            if (goal.IsEveryone)
                throw new MethodAccessException();

            goal.CompletionDate = _goal.CompletionDate;
            goal.Description = _goal.Description;
            goal.Name = _goal.Name;

            var deleteSubGoal = goal.SubGoals.Where(e => !_goal.SubGoals.Any(z => z.Id == e.Id));
            var addSubGoal = _goal.SubGoals.Where(e => !goal.SubGoals.Any(z => z.Id == e.Id));
            var editSubGoal = goal.SubGoals.Where(e => _goal.SubGoals.Any(z => z.Id == e.Id));

            foreach (var subGoal in deleteSubGoal)
            {
                context.SubGoal.Remove(subGoal);
            }

            foreach (var subGoalModel in addSubGoal)
            {
                var subGoal = new Domain.SubGoal();
                subGoal.Value = subGoalModel.Value;
                subGoal.BodyCode = subGoalModel.BodyCode;
                subGoal.CodeUnitsOfMeasurement = subGoalModel.CodeUnitsOfMeasurement;

                goal.SubGoals.Add(subGoal);
            }

            foreach (var subGoal in editSubGoal)
            {
                var updatedSubGoal = _goal.SubGoals
                    .FirstOrDefault(e => e.Id == subGoal.Id);

                subGoal.Value = updatedSubGoal.Value;
                subGoal.CodeUnitsOfMeasurement = updatedSubGoal.CodeUnitsOfMeasurement;
                subGoal.BodyCode = updatedSubGoal.BodyCode;
            }

            context.Goal.Update(goal);
            await context.SaveChangesAsync();
        }
    }
}
