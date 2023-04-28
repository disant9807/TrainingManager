using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using AutoMapper;
using TrainingManager.Log;
using Microsoft.EntityFrameworkCore;

namespace TrainingManager.Logic.Storage.Requests
{
    public class CreateGoalRequest : BaseStorageRequest<long>
    {
        private readonly Model.Goal _goal;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public CreateGoalRequest(StorageContext context, Model.Goal goal, ILogFactory log, IMapper mapper) : base(context)
        {
            if (goal is null) throw new ArgumentNullException();
            _goal = goal;
            _logger = log.CreateModuleLogger(typeof(CreateSizeRequest));
            _mapper = mapper;
        }

        public override async Task<long> ExecuteAsync()
        {
            var goal = new Domain.Goal();

            goal.Description = _goal.Description;
            goal.CreatedDate = DateTime.Now;
            goal.CompletionDate = _goal.CompletionDate;
            goal.Name = _goal.Name;
            goal.IsArchived = false;
            goal.UserId = _goal.UserId;
            goal.IsEveryone = false;

            _goal.SubGoals.ToList().ForEach(e =>
            {
                var subGoal = new Domain.SubGoal();
                subGoal.Value = e.Value;
                subGoal.BodyCode = e.BodyCode;
                subGoal.CodeUnitsOfMeasurement = e.CodeUnitsOfMeasurement;

                goal.SubGoals.Add(subGoal);
            });

            context.Goal.Add(goal);
            await context.SaveChangesAsync();

            return goal.Id;
        }
    }
}