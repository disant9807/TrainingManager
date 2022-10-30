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
            var trainingProgramDb = await context.TrainingProgram.Where(e => e.Id == _trainingProgram.Id)
                .FirstOrDefaultAsync();

            if (trainingProgramDb == null)
                throw new KeyNotFoundException($"Тренировочная программа с id = {_trainingProgram.Id} не найдена");

            var trainingProgram = _mapper.Map<Model.TrainingProgram, Domain.TrainingProgram>(_trainingProgram);

            context.Entry<Domain.TrainingProgram>(trainingProgramDb).State = EntityState.Detached;
            context.TrainingProgram.Update(trainingProgram);
            await context.SaveChangesAsync();


            var daysDb = await context.TrainingProgram.Where(e => e.Id == _trainingProgram.Id)
                .SelectMany(e => e.Days).Include(e => e.Exercises).ToListAsync();
            foreach (var day in daysDb)
            { context.Entry<Domain.TrainingProgramDay>(day).State = EntityState.Detached; }
            foreach (var exer in daysDb.SelectMany(e => e.Exercises))
            { context.Entry<Domain.Exercise>(exer).State = EntityState.Detached; }

            var days = _trainingProgram.Days;

            var deleteDays = trainingProgramDb.Days.Where(e => !days.Any(z => z.Id == e.Id));
            var addDaysModel = _trainingProgram.Days.Where(e => !daysDb.Any(z => z.Id == e.Id));
            var editDaysModel = _trainingProgram.Days.Where(e => daysDb.Any(z => z.Id == e.Id));

            foreach (var day in deleteDays)
            {
                trainingProgram.Days.Remove(day);
                context.TrainingProgramDay.Remove(day);
                await context.SaveChangesAsync();
            }
            foreach(var dayModel in addDaysModel)
            {
                var tpDay = _mapper.Map<Model.TrainingProgramDay, Domain.TrainingProgramDay>(dayModel);
                context.TrainingProgramDay.Add(tpDay);
                trainingProgram.Days.Add(tpDay);

                await context.SaveChangesAsync();
                foreach (var exercise in tpDay.Exercises)
                {
                    context.Entry<Domain.Exercise>(exercise).State = EntityState.Detached;
                }

            }
            foreach (var dayModel in editDaysModel)
            {
                var day = _mapper.Map<Model.TrainingProgramDay, Domain.TrainingProgramDay>(dayModel);
                day.TrainingProgramId = _trainingProgram.Id;
                context.TrainingProgramDay.Attach(day);
                context.Exercise.AttachRange(day.Exercises);

                
                var deleteExercise = day.Exercises.Where(e => !dayModel.Exercises.Any(z => z.Id == e.Id));
                var addExerciseModel = dayModel.Exercises.Where(e => !day.Exercises.Any(z => z.Id == e.Id));


                foreach(var exerciseModel in addExerciseModel)
                {
                    day.Exercises.Add(new Exercise { Id = exerciseModel.Id });
                }
                foreach (var delete in deleteExercise)
                {
                    day.Exercises.Remove(delete);
                }


                context.TrainingProgramDay.Update(day);
                await context.SaveChangesAsync();

                foreach (var exer in day.Exercises)
                { context.Entry<Domain.Exercise>(exer).State = EntityState.Detached; }
            }
        }
    }
}
