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
        private List<Domain.Exercise> _attachedExercises;

        public CreateTrainingRequest(StorageContext context, Model.Training training, ILogFactory log, IMapper mapper) : base(context)
        {
            if (training is null) throw new ArgumentNullException();
            _training = training;
            _logger = log.CreateModuleLogger(typeof(CreateTrainingRequest));
            _mapper = mapper;
            _attachedExercises = new List<Domain.Exercise>();
        }

        public override async Task<long> ExecuteAsync()
        {
            Domain.Exercise[] exercises = _training.Approachs
                .Select(e => e.Exercise)
                .Select(e => e.Id)
                .Distinct()
                .Select(id => new Domain.Exercise { Id = id })
                .ToArray();

            context.Exercise.AttachRange(exercises);
            _attachedExercises.AddRange(exercises);

            var training = new Domain.Training();

            training.TrainingDate = _training.TrainingDate;
            training.Description = _training.Description;
            training.Name = _training.Name;
            training.Time = _training.Time;
            training.UserId = _training.UserId;
            training.IsEveryone = false;

            _training.Approachs.ToList()
                .ForEach(e =>
                {
                    var approach = new Domain.Approach();
                    approach.NumberOfTraining = e.NumberOfTraining;
                    approach.ApproachsItems = e.ApproachsItems.Select(e =>
                    {
                        return mapApproachItem(e, new Domain.ApproachItem());
                    }).ToArray();
                    approach.Exercise = getAttachedExercise(e.Exercise.Id);

                    training.Approachs.Add(approach);
                });

            context.Training.Add(training);
            await context.SaveChangesAsync();

            return training.Id;
        }

        private Domain.Exercise getAttachedExercise(long id)
        {
            Domain.Exercise exercise = _attachedExercises.FirstOrDefault(e => e.Id == id);
            if (exercise == null)
            {
                exercise = new Domain.Exercise { Id = id };
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
                Model.ApproachLvl.good => Domain.ApproachLvl.good,
                Model.ApproachLvl.bad => Domain.ApproachLvl.bad,
                Model.ApproachLvl.normal => Domain.ApproachLvl.normal,
                _ => Domain.ApproachLvl.normal
            };
            item.Time = itemModel.Time;
            item.Weight = itemModel.Weight;

            return item;
        }
    }
}
