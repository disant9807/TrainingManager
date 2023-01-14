using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using AutoMapper;
using TrainingManager.Log;
using Microsoft.EntityFrameworkCore;
using TrainingManager.Logic.Storage.Domain;

namespace TrainingManager.Logic.Storage.Commands
{
    public class UpdateTrainingCommand : BaseStorageCommand
    {
        private readonly Model.Training _training;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public UpdateTrainingCommand(StorageContext context, Model.Training training, ILogFactory log, IMapper mapper) : base(context)
        {
            _training = training;
            _logger = log.CreateModuleLogger(typeof(UpdateTrainingCommand));
            _mapper = mapper;
        }

        public async override Task ExecuteAsync()
        {        
            var training = await context.Training.Where(e => e.Id == _training.Id).FirstOrDefaultAsync();

            if (training == null )
                throw new KeyNotFoundException($"Тренирока с id = {_training.Id} не найдена");
         
            training.TrainingDate = _training.TrainingDate;
            training.Description = _training.Description;
            training.Name = _training.Name;
            training.Time = _training.Time;
            context.Training.Update(training);
            await context.SaveChangesAsync();

            foreach(var exercise in training.Approachs.Select(e => e.Exercise).ToArray())
            {
                context.Entry<Domain.Exercise>(exercise).State = EntityState.Detached;
            }

            var deleteApproachs = training.Approachs.Where(e => !_training.Approachs.Any(z => z.Id == e.Id));
            var addApproachsModel = _training.Approachs.Where(e => !training.Approachs.Any(z => z.Id == e.Id));
            var editApproachsModel = _training.Approachs.Where(e => training.Approachs.Any(z => z.Id == e.Id));

            foreach (var approach in deleteApproachs)
            {
                context.Exercise.Attach(approach.Exercise);
                training.Approachs.Remove(approach);
                context.Approach.Remove(approach);
                await context.SaveChangesAsync();
            }
            foreach(var approachModel in addApproachsModel)
            {
                var approach = _mapper.Map<Model.Approach, Domain.Approach>(approachModel);
                context.Exercise.Attach(approach.Exercise);
                training.Approachs.Add(approach);
                await context.SaveChangesAsync();

                foreach (var approachItem in training.Approachs.ToArray())
                {
                    context.Entry<Domain.Exercise>(approachItem.Exercise).State = EntityState.Detached;
                    context.Entry<Domain.Approach>(approachItem).State = EntityState.Detached;
                }

            }
            foreach (var approachModel in editApproachsModel)
            {
                var approach = _mapper.Map<Model.Approach, Domain.Approach>(approachModel);
                approach.TrainingId = training.Id;

                context.Exercise.Attach(approach.Exercise);
                context.Approach.Attach(approach);
                context.Approach.Update(approach);
                
                
                await context.SaveChangesAsync();

                foreach (var approachItem in training.Approachs.ToArray())
                {
                    context.Entry<Domain.Exercise>(approachItem.Exercise).State = EntityState.Detached;
                    context.Entry<Domain.Approach>(approachItem).State = EntityState.Detached;
                }
            }
        }
    }
}
