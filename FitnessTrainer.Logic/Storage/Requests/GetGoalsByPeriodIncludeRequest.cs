using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingManager.Logic.Model;
using TrainingManager.Logic.Storage.Extensions;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace TrainingManager.Logic.Storage.Requests
{
    public class GetGoalsByPeriodIncludeRequest : BaseStorageRequest<Model.Goal[]>
    {
        private readonly IMapper _mapper;
        private readonly DateTime _dateFrom;
        private readonly DateTime _dateTo;
        private readonly string _userId;

        public GetGoalsByPeriodIncludeRequest(StorageContext context, IMapper mapper, DateTime dateFrom, DateTime dateTo, string userId) : base(context)
        {
            _mapper = mapper;
            _dateFrom = dateFrom;
            _dateTo = dateTo;
            _userId = userId;
        }

        public override async Task<Goal[]> ExecuteAsync()
        {
            var goalRequest = context.Goal
                .Where(e => e.CompletionDate >= _dateFrom)
                .Where(e => e.CompletionDate <= _dateTo)
                .Where(e => e.UserId == _userId)
                .Include(e => e.SubGoals);
            var goal = goalRequest.AsNoTracking();

            return await goal.Select(e => e.AsGoal(_mapper)).ToArrayAsync();
        }
    }
}
