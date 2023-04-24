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
    public class CreateObjectsOfStatisticsRequest : BaseStorageRequest<string>
    {
        private readonly Model.ObjectOfStatistics _objectOfStatistics;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public CreateObjectsOfStatisticsRequest(StorageContext context, Model.ObjectOfStatistics objectOfStatistics, ILogFactory log, IMapper mapper) : base(context)
        {
            _objectOfStatistics = objectOfStatistics;
            _logger = log.CreateModuleLogger(typeof(CreateExerciseRequest));
            _mapper = mapper;
        }

        public override async Task<string> ExecuteAsync()
        {
            if (_objectOfStatistics == null)
                throw new ArgumentNullException($"Ошибка в {_objectOfStatistics}");

            var objectOfStatistics = new ObjectOfStatistics();

            objectOfStatistics.UnitCode = _objectOfStatistics.UnitCode;
            objectOfStatistics.Code = _objectOfStatistics.Code;
            objectOfStatistics.CategoryCode = _objectOfStatistics.CategoryCode;
            objectOfStatistics.Description = _objectOfStatistics.Description;
            objectOfStatistics.Name = _objectOfStatistics.Name;


            context.ObjectOfStatistics.Add(objectOfStatistics);
            await context.SaveChangesAsync();
            return objectOfStatistics.Code;
        }
    }
}
