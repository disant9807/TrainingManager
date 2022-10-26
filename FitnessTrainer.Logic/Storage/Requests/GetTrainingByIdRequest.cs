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
    public class GetTrainingByIdRequest : BaseStorageRequest<Model.Training>
    {
        private readonly ILogger _logger;
        private readonly long _id;
        private readonly IMapper _mapper;

        public GetTrainingByIdRequest(StorageContext context, ILogFactory log, IMapper mapper, long id) : base(context)
        {
            _logger = log.CreateModuleLogger(typeof(GetTrainingByIdRequest));
            _id = id;
            _mapper = mapper;
        }

        public override async Task<Model.Training> ExecuteAsync()
        {
            var data = await context.Training
                .Where(e => e.Id == _id)
                .Include(e => e.Approachs)
                .FirstOrDefaultAsync();

            if (data is null)
                throw new ArgumentNullException(nameof(data), $"Ошибка при получении тренировки по id {_id}");

            var result = _mapper.Map<Domain.Training, Model.Training>(data);
            return result;
        }
    }
}
