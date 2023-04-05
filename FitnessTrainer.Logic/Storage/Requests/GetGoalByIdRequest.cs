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
    public class GetGoalByIdRequest : BaseStorageRequest<Model.Goal>
    {
        private readonly ILogger _logger;
        private readonly long _id;
        private readonly IMapper _mapper;

        public GetGoalByIdRequest(StorageContext context, ILogFactory log, IMapper mapper, long id) : base(context)
        {
            _logger = log.CreateModuleLogger(typeof(GetTrainingByIdRequest));
            _id = id;
            _mapper = mapper;
        }

        public override async Task<Model.Goal> ExecuteAsync()
        {
            var data = await context.Goal
                .Where(e => e.Id == _id)
                .Include(e => e.SubGoals)
                .ThenInclude(e => e.Body)
                .Include(e => e.SubGoals)
                .ThenInclude(e => e.UnitsOfMeasurement)
                .FirstOrDefaultAsync();

            if (data is null)
                throw new ArgumentNullException(nameof(data), $"Ошибка при получении цели по id {_id}");

            var result = _mapper.Map<Domain.Goal, Model.Goal>(data);
            return result;
        }
    }
}
