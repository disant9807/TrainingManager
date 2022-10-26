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
    public class UpdateTrainingProgramInfoCommand : BaseStorageCommand
    {
        private readonly Model.TrainingProgram _trainingProgram;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public UpdateTrainingProgramInfoCommand(StorageContext context, Model.TrainingProgram trainingProgram, ILogFactory log, IMapper mapper) : base(context)
        {
            _trainingProgram = trainingProgram;
            _logger = log.CreateModuleLogger(typeof(UpdateTrainingProgramInfoCommand));
            _mapper = mapper;
        }

        public async override Task ExecuteAsync()
        {
            var trainingProgram = await context.TrainingProgram.Where(e => e.Id == _trainingProgram.Id)
                .Include(e => e.Days)
                .ThenInclude(e => e.Exercises)
                .FirstOrDefaultAsync();

            if (trainingProgram == null)
                throw new KeyNotFoundException($"Тренировочная программа с id = {_trainingProgram.Id} не найдена");

            if (!string.IsNullOrWhiteSpace(_trainingProgram.AvatarId))
                trainingProgram.AvatarId = Guid.Parse(_trainingProgram.AvatarId);

            trainingProgram.ShortName = _trainingProgram.ShortName;
            trainingProgram.Name = _trainingProgram.Name;
            trainingProgram.Description = _trainingProgram.Description;

            var deleteDays = trainingProgram.Days.Where(e => !_trainingProgram.Days.Any(z => z.Id == e.Id));
            var addDaysModel = _trainingProgram.Days.Where(e => !trainingProgram.Days.Any(z => z.Id == e.Id));
            var editDaysModel = _trainingProgram.Days.Where(e => trainingProgram.Days.Any(z => z.Id == e.Id));

            foreach (var day in deleteDays)
            {
                trainingProgram.Days.Remove(day);
                context.TrainingProgramDay.Remove(day);
            }
            foreach(var dayModel in addDaysModel)
            {
                var tpDay = _mapper.Map<Model.TrainingProgramDay, Domain.TrainingProgramDay>(dayModel);
                context.TrainingProgramDay.Add(tpDay);
                trainingProgram.Days.Add(tpDay);

            }
            foreach (var dayModel in editDaysModel)
            {
                var day = trainingProgram.Days.FirstOrDefault(e => e.Id == dayModel.Id);

                day.Name = dayModel.Name;
                day.NumberOfTrainingProgram = dayModel.NumberOfTrainingProgram;
                day.DayRelax = dayModel.DayRelax;
                day.Description = dayModel.Description;

                var deleteExercise = day.Exercises.Where(e => !dayModel.Exercises.Any(z => z.Id == e.Id));
                var addExerciseModel = dayModel.Exercises.Where(e => !day.Exercises.Any(z => z.Id == e.Id));

                foreach(var exercise in deleteExercise)
                {
                    day.Exercises.Remove(exercise);
                }
                foreach(var exerciseModel in addExerciseModel)
                {
                    day.Exercises.Add(new Exercise { Id = exerciseModel.Id });
                }

                context.TrainingProgramDay.Update(day);
            }

            context.TrainingProgram.Update(trainingProgram);
            await context.SaveChangesAsync();
        }
    }
}
