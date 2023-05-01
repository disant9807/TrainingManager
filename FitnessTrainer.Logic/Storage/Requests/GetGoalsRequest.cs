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
    public class GetGoalsRequest : BaseStorageRequest<Model.Goal[]>
    {
        private readonly GetGoalsFilter filter;
        private readonly Order? _order;
        private readonly int? start;
        private readonly int? count;
        private readonly IMapper _mapper;
        private readonly string _userId;
        private readonly bool? _isEveryone;

        public GetGoalsRequest(StorageContext context, IMapper mapper, GetGoalsFilter filter, string userId, bool? isEveryone, Order? order = null, int? start = null, int? count = null) : base(context)
        {
            if (start < 0)
                throw new ArgumentOutOfRangeException($"{nameof(start)} start = zero");
            if (count < 0)
                throw new ArgumentOutOfRangeException($"{nameof(count)} count = zero");

            this.filter = filter;
            _order = order;
            this.start = start;
            this.count = count;
            _mapper = mapper;
            this._userId = userId;
            this._isEveryone = isEveryone;
        }

        public override async Task<Goal[]> ExecuteAsync()
        {
            var goalRequest = context.GetFiltredGoals(filter)
                .Where(e => (_isEveryone == true && e.IsEveryone == true) || (e.UserId == _userId))
                .Where(e => !e.IsArchived);

            var goal = goalRequest.AsNoTracking();
            goal = Order(goal);
            goal = Take(goal);
            return await goal.Select(e => e.AsGoal(_mapper)).ToArrayAsync();
        }

        private IQueryable<Domain.Goal> Take(IQueryable<Domain.Goal> goals)
        {
            if (count != 0 && count.HasValue && start.HasValue)
            {
                goals = goals.Skip(start.Value).Take(count.Value);
            }

            return goals;
        }

        private IQueryable<Domain.Goal> Order(IQueryable<Domain.Goal> goals)
        {

            if (_order == Model.Order.Asc)
                goals = goals.OrderBy(e => e.CreatedDate);
            else
                goals = goals.OrderByDescending(e => e.CreatedDate);


            return goals;
        }
    }
}
