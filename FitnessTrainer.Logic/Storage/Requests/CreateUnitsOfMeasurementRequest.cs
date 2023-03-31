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
    public class CreateUnitsOfMeasurementRequest : BaseStorageRequest<string>
    {
        private readonly Model.UnitsOfMeasurement _unitsOfMeasurement;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public CreateUnitsOfMeasurementRequest(StorageContext context, Model.UnitsOfMeasurement unitsOfMeasurement, ILogFactory log, IMapper mapper) : base(context)
        {
            _unitsOfMeasurement = unitsOfMeasurement;
            _logger = log.CreateModuleLogger(typeof(CreateUnitsOfMeasurementRequest));
            _mapper = mapper;
        }

        public override async Task<string> ExecuteAsync()
        {
            if (_unitsOfMeasurement == null)
                throw new ArgumentNullException($"Ошибка в {_unitsOfMeasurement}");

            var unitsOfMeasurement = _mapper.Map<Model.UnitsOfMeasurement, Domain.UnitsOfMeasurement>(_unitsOfMeasurement);
           
            context.UnitsOfMeasurements.Add(unitsOfMeasurement);
            await context.SaveChangesAsync();
            return unitsOfMeasurement.Code;
        }
    }
}
