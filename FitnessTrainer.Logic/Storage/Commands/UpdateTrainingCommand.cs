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
        private List<Domain.Exercise> _attachedExercises;

        public UpdateTrainingCommand(StorageContext context, Model.Training training, ILogFactory log, IMapper mapper) : base(context)
        {
            _training = training;
            _logger = log.CreateModuleLogger(typeof(UpdateTrainingCommand));
            _mapper = mapper;
            _attachedExercises = new List<Exercise>();
        }

        public async override Task ExecuteAsync()
        {        
            var training = await context.Training.Where(e => e.Id == _training.Id)
                .Include(e => e.Approachs)
                .ThenInclude(e => e.ApproachsItems)
                .Include(e => e.Approachs)
                .ThenInclude(e => e.Exercise)
                .FirstOrDefaultAsync();

            if (training == null )
                throw new KeyNotFoundException($"Тренирока с id = {_training.Id} не найдена");

            _attachedExercises.AddRange(training.Approachs.Select(e => e.Exercise));

            training.TrainingDate = _training.TrainingDate;
            training.Description = _training.Description;
            training.Name = _training.Name;
            training.Time = _training.Time;
            training.TrainingProgramIdFK = _training.TrainingProgramIdFK;
            training.TrainingProgramDayFK = _training.TrainingProgramDayFK;

            var deleteApproachs = training.Approachs.Where(e => !_training.Approachs.Select(z => z.Id).Contains(e.Id)).ToList();
            var addApproachsModel = _training.Approachs.Where(e => !training.Approachs.Select(z => z.Id).Contains(e.Id)).ToList();
            var editApproachs = training.Approachs.Where(e => _training.Approachs.Select(z => z.Id).Contains(e.Id)).ToList();

            foreach (var approach in deleteApproachs)
            {
                context.Approach.Remove(approach);
            }

            foreach (var approachModel in addApproachsModel)
            {
                var approach = new Domain.Approach();
                approach.NumberOfTraining = approachModel.NumberOfTraining;
                approach.ApproachsItems = approachModel.ApproachsItems.Select(e =>
                {
                    return mapApproachItem(e, new Domain.ApproachItem());
                }).ToArray();
                approach.Exercise = getAttachedExercise(approachModel.Exercise.Id);

                training.Approachs.Add(approach);
            }

            foreach (var approach in editApproachs)
            {
                var newApproachModel = _training.Approachs
                    .FirstOrDefault(e => e.Id == approach.Id);

                approach.NumberOfTraining = newApproachModel.NumberOfTraining;
                
                var deleteApproachItems = approach.ApproachsItems
                    .Where(e => !newApproachModel.ApproachsItems.Any(z => z.Id == e.Id));
                var editApproachItems = approach.ApproachsItems
                    .Where(e => newApproachModel.ApproachsItems.Any(z => z.Id == e.Id));
                var addApproachitems = newApproachModel.ApproachsItems
                    .Where(e => !approach.ApproachsItems.Any(z => z.Id == e.Id));


                context.ApproachItem.RemoveRange(deleteApproachItems.ToArray());

                editApproachItems.ToList().ForEach(e =>
                {
                    var newApproachItemModel = newApproachModel.ApproachsItems
                        .FirstOrDefault(u => u.Id == e.Id);

                    context.ApproachItem
                        .Update(mapApproachItem(newApproachItemModel, e));
                });

                addApproachitems.ToList().ForEach(e =>
                {
                    approach.ApproachsItems.Add(mapApproachItem(e, new Domain.ApproachItem()));
                });
            }

            context.Training.Update(training);
            await context.SaveChangesAsync();
        }

        private Domain.Exercise getAttachedExercise(long id)
        {
            Domain.Exercise exercise = _attachedExercises.FirstOrDefault(e => e.Id == id);
            if (exercise == null)
            {
                exercise = new Exercise { Id = id };
                context.Exercise.Attach(exercise);
                _attachedExercises.Add(exercise);
            }

            return exercise;
        }

        private Domain.ApproachItem mapApproachItem(Model.ApproachItem itemModel, Domain.ApproachItem item)
        {
            item.NumberOfApproach = itemModel.NumberOfApproach;
            item.Hard = itemModel.Hard;
            item.Technicality = itemModel.Technicality switch
            {
                Model.ApproachLvl.good => ApproachLvl.good,
                Model.ApproachLvl.bad => ApproachLvl.bad,
                Model.ApproachLvl.normal => ApproachLvl.normal,
                _ => ApproachLvl.normal
            };
            item.Time = itemModel.Time;
            item.Weight = itemModel.Weight;

            return item;
        }
    }
}
