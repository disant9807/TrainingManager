using System;
using System.Collections.Generic;
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
            var training = await context.Training.Where(e => e.Id == _training.Id)
                .Include(e => e.Approachs)
                .ThenInclude(e => e.Exercise)
                .Include(e => e.TrainingProgram)
                .FirstOrDefaultAsync();

            if (training == null)
                throw new KeyNotFoundException($"Тренирока с id = {_training.Id} не найдена");

            training.TrainingDate = _training.TrainingDate;
            training.Description = _training.Description;
            training.Name = _training.Name;
            training.Time = _training.Time;

            long longId;
            if (!string.IsNullOrEmpty(_training.TrainingProgramId) && long.TryParse(_training.TrainingProgramId, out longId))
                training.TrainingProgram = new TrainingProgram { Id = longId };

            var deleteApproachs = training.Approachs.Where(e => !_training.Approachs.Any(z => z.Id == e.Id));
            var addApproachsModel = _training.Approachs.Where(e => !training.Approachs.Any(z => z.Id == e.Id));
            var editApproachsModel = _training.Approachs.Where(e => training.Approachs.Any(z => z.Id == e.Id));

            foreach (var approach in deleteApproachs)
            {
                training.Approachs.Remove(approach);
                context.Approach.Remove(approach);
            }
            foreach(var approachModel in addApproachsModel)
            {
                var approach = _mapper.Map<Model.Approach, Domain.Approach>(approachModel);
                context.Approach.Add(approach);
                training.Approachs.Add(approach);

            }
            foreach (var approachModel in editApproachsModel)
            {
                var approach = training.Approachs.FirstOrDefault(e => e.Id == approachModel.Id);

                context.Approach.Update(approach);
            }

            context.Training.Update(training);
            await context.SaveChangesAsync();
        }
    }
}
