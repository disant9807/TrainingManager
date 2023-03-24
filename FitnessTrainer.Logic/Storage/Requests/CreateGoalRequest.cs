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
            var goal = _mapper.Map<Model.Goal, Domain.Goal>(_goal);

            goal.CreatedDate = DateTime.Now;
            context.SubGoal.AttachRange(goal.SubGoals.Select(e => new Domain.SubGoal() { Id = e.Id }));
            context.Goal.Add(goal);
            await context.SaveChangesAsync();
            return goal.Id;
        }
    }
}