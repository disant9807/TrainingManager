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
    public class GetTrainingsByPeriodIncludeRequest : BaseStorageRequest<Model.Training[]>
    {
        private readonly DateTime _dateFrom;
        private readonly DateTime _dateTo;
        private readonly Order? _order;
        private readonly int? start;
        private readonly int? count;
        private readonly IMapper _mapper;

        public GetTrainingsByPeriodIncludeRequest(StorageContext context, IMapper mapper, DateTime dateFrom, DateTime dateTo) : base(context)
        {
            if (start < 0)
                throw new ArgumentOutOfRangeException($"{nameof(start)} start = zero");
            if (count < 0)
                throw new ArgumentOutOfRangeException($"{nameof(count)} count = zero");

            this._dateFrom = dateFrom;
            this._dateTo = dateTo;
            _mapper = mapper;
        }

        public override async Task<Training[]> ExecuteAsync()
        {
            var training = context.Training
                .Where(e => e.TrainingDate >= _dateFrom)
                .Where(e => e.TrainingDate <= _dateTo)
                .Include(e => e.Approachs)
                .ThenInclude(e => e.Exercise)
                .Include(e => e.Approachs)
                .ThenInclude(e => e.ApproachsItems);

            return await training.Select(e => e.AsTraining(_mapper)).ToArrayAsync();
        }

    }
}
