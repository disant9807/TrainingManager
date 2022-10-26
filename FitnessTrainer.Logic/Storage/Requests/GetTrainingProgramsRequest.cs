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
    public class GetTrainingProgramsRequest : BaseStorageRequest<Model.TrainingProgram[]>
    {
        private readonly GetTrainingProgramsFilter filter;
        private readonly Order? _order;
        private readonly int? start;
        private readonly int? count;
        private readonly IMapper _mapper;

        public GetTrainingProgramsRequest(StorageContext context, IMapper mapper, GetTrainingProgramsFilter filter, Order? order = null, int? start = null, int? count = null) : base(context)
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
        }

        public override async Task<TrainingProgram[]> ExecuteAsync()
        {
            var trainingProgramsRequest = context.GetFiltredTrainingPrograms(filter);
            var trainingPrograms = trainingProgramsRequest
                .Include(e => e.Days)
                .AsNoTracking();
            trainingPrograms = Order(trainingPrograms);
            trainingPrograms = Take(trainingPrograms);
            return await trainingPrograms.Select(e => e.AsTrainingProgram(_mapper)).ToArrayAsync();
        }

        private IQueryable<Domain.TrainingProgram> Take(IQueryable<Domain.TrainingProgram> trainingPrograms)
        {
            if (count != 0 && count.HasValue && start.HasValue)
            {
                trainingPrograms = trainingPrograms.Skip(start.Value).Take(count.Value);
            }

            return trainingPrograms;
        }

        private IQueryable<Domain.TrainingProgram> Order(IQueryable<Domain.TrainingProgram> trainingPrograms)
        {

            if (_order == Model.Order.Asc)
                trainingPrograms = trainingPrograms.OrderBy(e => e.CreatedDate);
            else
                trainingPrograms = trainingPrograms.OrderByDescending(e => e.CreatedDate);
            

            return trainingPrograms;
        }
    }
}
