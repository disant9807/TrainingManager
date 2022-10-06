using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using AutoMapper;
using TrainingManager.Log;

namespace TrainingManager.Logic.Storage.Requests
{
    public class CreateExerciseRequest : BaseStorageRequest<long>
    {
        private readonly Model.Exercise _exercise;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public CreateExerciseRequest(StorageContext context, Model.Exercise exercise, ILogFactory log, IMapper mapper) : base(context)
        {
            _exercise = exercise;
            _logger = log.CreateModuleLogger(typeof(CreateExerciseRequest));
            _mapper = mapper;
        }

        public override async Task<long> ExecuteAsync()
        {
            if (_exercise == null)
                throw new ArgumentNullException($"Ошибка в {_exercise}");

            var exercise = _mapper.Map<Model.Exercise, Domain.Exercise>(_exercise);
            exercise.CreatedDate = DateTimeOffset.Now;

            context.Exercise.Add(exercise);
            await context.SaveChangesAsync();
            return exercise.Id;
        }
    }
}
