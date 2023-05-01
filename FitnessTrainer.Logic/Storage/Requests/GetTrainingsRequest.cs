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
    public class GetTrainingsRequest : BaseStorageRequest<Model.Training[]>
    {
        private readonly GetTrainingsFilter filter;
        private readonly Order? _order;
        private readonly int? start;
        private readonly int? count;
        private readonly IMapper _mapper;
        private readonly string _userId;
        private readonly bool? _isEveryone;

        public GetTrainingsRequest(StorageContext context, IMapper mapper, GetTrainingsFilter filter, string userId, bool? isEveryone, Order? order = null, int? start = null, int? count = null) : base(context)
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

        public override async Task<Training[]> ExecuteAsync()
        {
            var trainingRequest = context.GetFiltredTrainingPrograms(filter)
                .Where(e => (_isEveryone == true && e.IsEveryone == true) || (e.UserId == _userId));

            var training = trainingRequest.AsNoTracking();
            training = Order(training);
            training = Take(training);
            return await training.Select(e => e.AsTraining(_mapper)).ToArrayAsync();
        }

        private IQueryable<Domain.Training> Take(IQueryable<Domain.Training> trainings)
        {
            if (count != 0 && count.HasValue && start.HasValue)
            {
                trainings = trainings.Skip(start.Value).Take(count.Value);
            }

            return trainings;
        }

        private IQueryable<Domain.Training> Order(IQueryable<Domain.Training> trainings)
        {

            if (_order == Model.Order.Asc)
                trainings = trainings.OrderBy(e => e.TrainingDate);
            else
                trainings = trainings.OrderByDescending(e => e.TrainingDate);
            

            return trainings;
        }
    }
}
