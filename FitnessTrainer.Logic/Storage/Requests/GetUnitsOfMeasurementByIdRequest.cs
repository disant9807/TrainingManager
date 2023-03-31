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
    public class GetUnitsOfMeasurementByIdRequest : BaseStorageRequest<Model.UnitsOfMeasurement>
    {
        private readonly ILogger _logger;
        private readonly string _code;
        private readonly IMapper _mapper;

        public GetUnitsOfMeasurementByIdRequest(StorageContext context, ILogFactory log, IMapper mapper, string code) : base(context)
        {
            _logger = log.CreateModuleLogger(typeof(GetUnitsOfMeasurementByIdRequest));
            _code = code;
            _mapper = mapper;
        }

        public override async Task<Model.UnitsOfMeasurement> ExecuteAsync()
        {
            var data = await context.UnitsOfMeasurements
                .Where(e => e.Code == _code)
                .FirstOrDefaultAsync();

            if (data is null)
                throw new ArgumentNullException(nameof(data), $"Ошибка при получении части тела по id {_code}");

            var result = _mapper.Map<Domain.UnitsOfMeasurement, Model.UnitsOfMeasurement>(data);
            return result;
        }
    }
}
