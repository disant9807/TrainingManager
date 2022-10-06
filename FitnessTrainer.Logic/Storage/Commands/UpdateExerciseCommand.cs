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

            //exercise.
        }
    }
}
