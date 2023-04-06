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
    public class ArchiveUnitsOfMeasurementCommand : BaseStorageCommand
    {
        private readonly ILogger _logger;
        private readonly string _code;
        private readonly bool _state;

        public ArchiveUnitsOfMeasurementCommand(StorageContext context, ILogFactory log, string code, bool state) : base(context)
        {
            _logger = log.CreateModuleLogger(typeof(ArchiveUnitsOfMeasurementCommand));
            _code = code;
            _state = state;
        }

        public async override Task ExecuteAsync()
        {
            var unitsOfMeasurement = await context.UnitsOfMeasurements.Where(e => e.Code == _code)
                .SingleOrDefaultAsync();

            if (unitsOfMeasurement == null)
                throw new KeyNotFoundException($"Единица измерения с id = {_code} не найдена");

            unitsOfMeasurement.IsArchive = _state;

            context.UnitsOfMeasurements.Update(unitsOfMeasurement);
            await context.SaveChangesAsync();
        }
    }
}
