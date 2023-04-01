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
        private readonly string _code;

        public UpdateUnitsOfMeasurementCommand(StorageContext context, Model.UnitsOfMeasurement unitsOfMeasurement, string code, ILogFactory log, IMapper mapper) : base(context)
        {
            _unitsOfMeasurement = unitsOfMeasurement;
            _logger = log.CreateModuleLogger(typeof(UpdateUnitsOfMeasurementCommand));
            _mapper = mapper;
            _code = code;
        }

        public async override Task ExecuteAsync()
        {
            var unitsOfMeasurement = await context.UnitsOfMeasurements.FirstOrDefaultAsync(e => e.Code == _code);

            if (unitsOfMeasurement == null)
                throw new KeyNotFoundException($"Часть тела с code = {_code} не найден");

            if (_code == _unitsOfMeasurement.Code)
            {
                unitsOfMeasurement.Value = _unitsOfMeasurement.Value;
                context.UnitsOfMeasurements.Update(unitsOfMeasurement);
            } else
            {
                context.UnitsOfMeasurements.Remove(unitsOfMeasurement);

                var newUnitsOfMeasurement = _mapper.Map<Model.UnitsOfMeasurement, Domain.UnitsOfMeasurement>(_unitsOfMeasurement);
                context.UnitsOfMeasurements.Add(newUnitsOfMeasurement);
            }

            await context.SaveChangesAsync();
        }
    }
}
