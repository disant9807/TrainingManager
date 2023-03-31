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
    public class RemoveUnitsOfMeasurementCommand : BaseStorageCommand
    {
        private readonly ILogger _logger;
        private readonly string _code;

        public RemoveUnitsOfMeasurementCommand(StorageContext context, ILogFactory log, string code) : base(context)
        {
            _logger = log.CreateModuleLogger(typeof(RemoveUnitsOfMeasurementCommand));
            _code = code;
        }

        public async override Task ExecuteAsync()
        {
            var unitsOfMeasurement = await context.UnitsOfMeasurements.Where(e => e.Code == _code)
                .SingleOrDefaultAsync();

            if (unitsOfMeasurement == null)
                throw new KeyNotFoundException($"Единица измерения с id = {_code} не найдена");

            context.UnitsOfMeasurements.Remove(unitsOfMeasurement);
            await context.SaveChangesAsync();
        }
    }
}
