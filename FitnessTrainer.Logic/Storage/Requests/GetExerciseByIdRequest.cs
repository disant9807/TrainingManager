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
    public class GetExerciseByIdRequest : BaseStorageRequest<Model.Exercise>
    {
        private readonly ILogger _logger;
        private readonly long _id;
        private readonly IMapper _mapper;

        public GetExerciseByIdRequest(StorageContext context, ILogFactory log, IMapper mapper, long id) : base(context)
        {
            _logger = log.CreateModuleLogger(typeof(GetExerciseByIdRequest));
            _id = id;
            _mapper = mapper;
        }

        public override async Task<Model.Exercise> ExecuteAsync()
        {
            var data = await context.Exercise
                .Where(e => e.Id == _id)
                .Include(e => e.CategoryOfBodies)
                .FirstOrDefaultAsync();

            if (data is null)
                throw new ArgumentNullException(nameof(data), $"Ошибка при получении упражнения по id {_id}");

            var result = _mapper.Map<Domain.Exercise, Model.Exercise>(data);
            result.CategoryOfBodiesIds = data.CategoryOfBodies.Select(e => e.Code).ToArray();

            return result;
        }
    }
}
