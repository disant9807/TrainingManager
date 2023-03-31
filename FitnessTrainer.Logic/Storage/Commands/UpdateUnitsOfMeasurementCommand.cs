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
    public class UpdateUnitsOfMeasurementCommand : BaseStorageCommand
    {
        private readonly Model.UnitsOfMeasurement _unitsOfMeasurement;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public UpdateUnitsOfMeasurementCommand(StorageContext context, Model.UnitsOfMeasurement unitsOfMeasurement, ILogFactory log, IMapper mapper) : base(context)
        {
            _unitsOfMeasurement = unitsOfMeasurement;
            _logger = log.CreateModuleLogger(typeof(UpdateUnitsOfMeasurementCommand));
            _mapper = mapper;
        }

        public async override Task ExecuteAsync()
        {
            var unitsOfMeasurementCount = await context.UnitsOfMeasurements.CountAsync(e => e.Code == _unitsOfMeasurement.Code);

            if (unitsOfMeasurementCount < 1)
                throw new KeyNotFoundException($"Часть тела с id = {_unitsOfMeasurement.Code} не найден");

            var unitsOfMeasurement = _mapper.Map<Model.UnitsOfMeasurement, Domain.UnitsOfMeasurement>(_unitsOfMeasurement);

            context.UnitsOfMeasurements.Update(unitsOfMeasurement);
            await context.SaveChangesAsync();
        }
    }
}
