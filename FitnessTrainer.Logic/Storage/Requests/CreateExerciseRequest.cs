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

            var exercise = new Exercise();
            exercise.CreatedDate = DateTime.Now;
            exercise.Name = _exercise.Name;
            exercise.ShortName = _exercise.ShortName;
            exercise.IsBased = _exercise.IsBased;
            exercise.Description = _exercise.Description;
            exercise.IsEveryone = false;
            exercise.UserId = _exercise.UserId;
            exercise.HardSkill = _exercise.HardSkill switch
            {
                Model.HardSkill.easy => Domain.HardSkill.easy,
                Model.HardSkill.normal => Domain.HardSkill.normal,
                Model.HardSkill.hard => Domain.HardSkill.hard
            };


            if (_exercise.CategoryOfBodies?.Length > 0)
            {
                foreach(var code in _exercise.CategoryOfBodies.Select(e => e.Code))
                {
                    var body = new Domain.CategoryOfBody { Code = code };
                    context.CategoryOfBody.Attach(body);

                    exercise.CategoryOfBodies.Add(body);
                }
            }

            context.Exercise.Add(exercise);
            await context.SaveChangesAsync();
            return exercise.Id;
        }
    }
}
