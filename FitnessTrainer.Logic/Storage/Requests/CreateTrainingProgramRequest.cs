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
    public class CreateTrainingProgramRequest : BaseStorageRequest<long>
    {
        private readonly Model.TrainingProgram _trainingProgram;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public CreateTrainingProgramRequest(StorageContext context, Model.TrainingProgram trainingProgram, ILogFactory log, IMapper mapper) : base(context)
        {
            if (trainingProgram is null) throw new ArgumentNullException();
            _trainingProgram = trainingProgram;
            _logger = log.CreateModuleLogger(typeof(CreateTrainingProgramRequest));
            _mapper = mapper;
        }

        public override async Task<long> ExecuteAsync()
        {
            var trainingProgram = _mapper.Map<Model.TrainingProgram, Domain.TrainingProgram>(_trainingProgram);
            trainingProgram.CreatedDate = DateTime.Now;

            context.TrainingProgram.Add(trainingProgram);
            await context.SaveChangesAsync();
            return trainingProgram.Id;
        }
    }
}
