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

// Добавление тренировочной программы
            if (training.TrainingProgram?.Id == 0)
            {
                training.TrainingProgram = null;
            }
            else
            {
                Domain.TrainingProgram trainingProgramLocal = new Domain.TrainingProgram
                {
                    Id = long.Parse(_training.TrainingProgramId)
                };
                context.TrainingProgram.Attach(trainingProgramLocal);

                training.TrainingProgram = trainingProgramLocal;
            }


            training.CreatedDate = DateTime.Now;
            context.Exercise.AttachRange(training.Approachs.Select(e => e.Exercise).Where(e => e != null));
            context.Training.Add(training);
            await context.SaveChangesAsync();
            return training.Id;
        }
    }
}
