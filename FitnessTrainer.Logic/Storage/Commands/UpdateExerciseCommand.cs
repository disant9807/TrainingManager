using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using AutoMapper;
using TrainingManager.Log;
using Microsoft.EntityFrameworkCore;

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
                .SingleOrDefaultAsync();

            if (exercise == null)
                throw new KeyNotFoundException($"Упражнение с id = {_exercise.Id} не найдено");

            var newCategoryIds = _exercise.CategoryOfBodiesIds
                .Where(e => !exercise.CategoryOfBodies.Select(z => z.Code).Contains(e))
                .ToList();


            var deleteCategoryObj = exercise.CategoryOfBodies
                .Where(e => !_exercise.CategoryOfBodiesIds
                    .Contains(e.Code))
                .ToList();

            exercise = _mapper.Map<Model.Exercise, Domain.Exercise>(_exercise);
            newCategoryIds
                .ForEach(e => exercise.CategoryOfBodies.Add(new Domain.CategoryOfBody { Code = e }));
            deleteCategoryObj
                .ForEach(e => exercise.CategoryOfBodies.Remove(e));

            context.Exercise.Update(exercise);
            await context.SaveChangesAsync();
        }
    }
}
