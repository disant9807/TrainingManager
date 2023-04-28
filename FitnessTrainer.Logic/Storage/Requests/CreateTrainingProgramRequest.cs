using System;
using System.Collections;
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
            trainingProgram.UserId = _trainingProgram.UserId;
            trainingProgram.IsEveryone = _trainingProgram.IsEveryone;
            context.TrainingProgram.Add(trainingProgram);
            await context.SaveChangesAsync();

            foreach (var _day in _trainingProgram.Days)
            {
                var day =_mapper.Map<Model.TrainingProgramDay, Domain.TrainingProgramDay>(_day);
                day.TrainingProgramId = trainingProgram.Id;

                context.Exercise.AttachRange(day.Exercises);
                context.TrainingProgramDay.Add(day);
                await context.SaveChangesAsync();
                foreach (var exercise in day.Exercises)
                {
                    context.Entry<Domain.Exercise>(exercise).State = EntityState.Detached;
                }
            }

            return trainingProgram.Id;
        }
    }
}
