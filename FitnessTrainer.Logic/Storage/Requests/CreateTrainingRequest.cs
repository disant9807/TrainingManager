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
    public class CreateTrainingRequest : BaseStorageRequest<long>
    {
        private readonly Model.Training _training;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public CreateTrainingRequest(StorageContext context, Model.Training training, ILogFactory log, IMapper mapper) : base(context)
        {
            if (training is null) throw new ArgumentNullException();
            _training = training;
            _logger = log.CreateModuleLogger(typeof(CreateTrainingRequest));
            _mapper = mapper;
        }

        public override async Task<long> ExecuteAsync()
        {
            var training = _mapper.Map<Model.Training, Domain.Training>(_training);
            training.CreatedDate = DateTime.Now;

            context.Training.Add(training);
            await context.SaveChangesAsync();
            return training.Id;
        }
    }
}
