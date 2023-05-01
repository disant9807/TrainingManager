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
using TrainingManager.Logic.Model;

namespace TrainingManager.Logic.Storage.Commands
{
    public class UpdateTrainingProgramInfoCommand : BaseStorageCommand
    {
        private readonly Model.TrainingProgram _trainingProgram;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private List<Domain.Exercise> _attachedExercise;

        public UpdateTrainingProgramInfoCommand(StorageContext context, Model.TrainingProgram trainingProgram, ILogFactory log, IMapper mapper) : base(context)
        {
            _trainingProgram = trainingProgram;
            _logger = log.CreateModuleLogger(typeof(UpdateTrainingProgramInfoCommand));
            _mapper = mapper;
            _attachedExercise = new List<Domain.Exercise>();
        }

        public async override Task ExecuteAsync()
        {
            var trainingProgram = await context.TrainingProgram.Where(e => e.Id == _trainingProgram.Id)
                .Include(e => e.Days)
                .ThenInclude(e => e.Exercises)
                .FirstOrDefaultAsync();

            if (trainingProgram == null)
                throw new KeyNotFoundException($"Тренировочная программа с id = {_trainingProgram.Id} не найдена");

            if (trainingProgram.IsEveryone)
                throw new MethodAccessException();

            trainingProgram.Name = _trainingProgram.Name;
            trainingProgram.ShortName = _trainingProgram.ShortName;
            trainingProgram.Description = _trainingProgram.Description;

            trainingProgram.Days.SelectMany(e => e.Exercises)
                .ToList().ForEach(e => _attachedExercise.Add(e));

            var updatedDays = trainingProgram.Days
                .Where(e => _trainingProgram.Days.Select(z => z.Id).Contains(e.Id)).ToList();

            var removedDays = trainingProgram.Days
                .Where(e => !_trainingProgram.Days.Select(z => z.Id).Contains(e.Id)).ToList();

            var addedDays = _trainingProgram.Days
                .Where(e => !trainingProgram.Days.Select(z => z.Id).Contains(e.Id)).ToList();

            updatedDays.ForEach(day =>
            {
                var newDay = _trainingProgram.Days
                    .FirstOrDefault(e => e.Id == day.Id);

                day.Name = newDay.Name;
                day.DayRelax = newDay.DayRelax;
                day.Description = newDay.Description;
                day.DayRelax = newDay.DayRelax;
                day.NumberOfTrainingProgram = newDay.NumberOfTrainingProgram;

                var addedExercise = newDay.Exercises
                    .Where(e => !day.Exercises
                        .Select(z => z.Id).Contains(e.Id)).ToList();

                var removedExercise = day.Exercises
                    .Where(e => !newDay.Exercises
                        .Select(z => z.Id).Contains(e.Id)).ToList();

                addedExercise.ForEach(newExercise =>
                {
                    var attachedExercise = _attachedExercise
                            .FirstOrDefault(z => z.Id == newExercise.Id);

                    if (attachedExercise != null)
                    {
                        day.Exercises.Add(attachedExercise);
                    }
                    else
                    {
                        var exercise = new Domain.Exercise
                        {
                            Id = newExercise.Id
                        };
                        context.Exercise.Attach(exercise);
                        day.Exercises.Add(exercise);
                        _attachedExercise.Add(exercise);
                    }
                });

                removedExercise.ForEach(exercise =>
                {
                    day.Exercises.Remove(exercise);
                });
            });

            addedDays.ForEach(newDay =>
            {
                var day = new Domain.TrainingProgramDay
                {
                    Name = newDay.Name,
                    DayRelax = newDay.DayRelax,
                    Description = newDay.Description,
                    NumberOfTrainingProgram = newDay.NumberOfTrainingProgram
                };

                newDay.Exercises.ToList()
                    .ForEach(e =>
                    {
                        var attachedExercise = _attachedExercise
                            .FirstOrDefault(z => z.Id == e.Id);

                        if(attachedExercise != null)
                        {
                            day.Exercises.Add(attachedExercise);
                        }
                        else
                        {
                            var exercise = new Domain.Exercise
                            {
                                Id = e.Id
                            };
                            context.Exercise.Attach(exercise);
                            day.Exercises.Add(exercise);
                            _attachedExercise.Add(exercise);
                        }
                    });

                trainingProgram.Days.Add(day);
            });

            removedDays.ForEach(e =>
            {
                trainingProgram.Days.Remove(e);
            });

            context.TrainingProgram.Update(trainingProgram);
            await context.SaveChangesAsync();
        }
    }
}
