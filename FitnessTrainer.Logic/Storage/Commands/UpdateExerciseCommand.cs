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
    public class UpdateExerciseCommand : BaseStorageCommand
    {
        private readonly Model.Exercise _exercise;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public UpdateExerciseCommand(StorageContext context, Model.Exercise exercise, ILogFactory log, IMapper mapper) : base(context)
        {
            _exercise = exercise;
            _logger = log.CreateModuleLogger(typeof(UpdateExerciseCommand));
            _mapper = mapper;
        }

        public async override Task ExecuteAsync()
        {
            var exercise = await context.Exercise.Where(e => e.Id == _exercise.Id)
                .Include(e => e.CategoryOfBodies)
                .FirstOrDefaultAsync((e => e.Id == _exercise.Id));

            if (exercise == null)
                throw new KeyNotFoundException($"Упражнение с id = {_exercise.Id} не найден");

            if (exercise.IsEveryone)
                throw new MethodAccessException();

            exercise.ShortName = _exercise.ShortName;
            exercise.Description = _exercise.Description;
            exercise.Name = _exercise.Name;
            exercise.IsBased = _exercise.IsBased;
            exercise.HardSkill = _exercise.HardSkill switch
            {
                Model.HardSkill.easy => Domain.HardSkill.easy,
                Model.HardSkill.normal => Domain.HardSkill.normal,
                Model.HardSkill.hard => Domain.HardSkill.hard
            };

            var addBodies = _exercise.CategoryOfBodies
                .Where(e => !exercise.CategoryOfBodies.Select(u => u.Code)
                    .Contains(e.Code)).ToList();

            var deleteBodies = exercise.CategoryOfBodies
                .Where(e => !_exercise.CategoryOfBodies.Select(u => u.Code)
                    .Contains(e.Code)).ToList();


            addBodies.ForEach(e => {
                var body = new CategoryOfBody { Code = e.Code };
                context.CategoryOfBody.Attach(body);
                exercise.CategoryOfBodies.Add(body);
            });

            deleteBodies.ForEach(e => exercise.CategoryOfBodies
                .Remove(e));

            context.Exercise.Update(exercise);
            await context.SaveChangesAsync();
        }
    }
}
