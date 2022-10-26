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
    public class GetTrainingProgramByIdRequest : BaseStorageRequest<Model.TrainingProgram>
    {
        private readonly ILogger _logger;
        private readonly long _id;
        private readonly IMapper _mapper;

        public GetTrainingProgramByIdRequest(StorageContext context, ILogFactory log, IMapper mapper, long id) : base(context)
        {
            _logger = log.CreateModuleLogger(typeof(GetTrainingProgramByIdRequest));
            _id = id;
            _mapper = mapper;
        }

        public override async Task<Model.TrainingProgram> ExecuteAsync()
        {
            var data = await context.TrainingProgram
                .Where(e => e.Id == _id)
                .Include(e => e.Days)
                .FirstOrDefaultAsync();

            if (data is null)
                throw new ArgumentNullException(nameof(data), $"Ошибка при получении тренировочной программы по id {_id}");

            var result = _mapper.Map<Domain.TrainingProgram, Model.TrainingProgram>(data);
            return result;
        }
    }
}
