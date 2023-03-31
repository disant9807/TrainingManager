using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingManager.Logic.Model;
using TrainingManager.Logic.Storage.Extensions;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace TrainingManager.Logic.Storage.Requests
{
    public class GetUnitsOfMeasurementRequest : BaseStorageRequest<Model.UnitsOfMeasurement[]>
    {
        private readonly string _queryString;
        private readonly Order? _order;
        private readonly int? start;
        private readonly int? count;
        private readonly IMapper _mapper;

        public GetUnitsOfMeasurementRequest(StorageContext context, IMapper mapper, string queryString, Order? order = null, int? start = null, int? count = null) : base(context)
        {
            if (start < 0)
                throw new ArgumentOutOfRangeException($"{nameof(start)} start = zero");
            if (count < 0)
                throw new ArgumentOutOfRangeException($"{nameof(count)} count = zero");

            _queryString = queryString;
            _order = order;
            this.start = start;
            this.count = count;
            _mapper = mapper;
        }

        public override async Task<UnitsOfMeasurement[]> ExecuteAsync()
        {
            var unitsOfMeasurementRequest = context.UnitsOfMeasurements
                .Where(e => string.IsNullOrEmpty(_queryString) || e.Value.ToLower().Contains(_queryString))
                .Where(e => string.IsNullOrEmpty(_queryString) || e.Code.ToLower().Contains(_queryString));

            var unitsOfMeasurement = unitsOfMeasurementRequest.AsNoTracking();
            unitsOfMeasurement = Order(unitsOfMeasurement);
            unitsOfMeasurement = Take(unitsOfMeasurement);
            return await unitsOfMeasurement.Select(e => AsUnitsOfMeasurement(e, _mapper)).ToArrayAsync();
        }

        private IQueryable<Domain.UnitsOfMeasurement> Take(IQueryable<Domain.UnitsOfMeasurement> categoryOfBody)
        {
            if (count != 0 && count.HasValue && start.HasValue)
            {
                categoryOfBody = categoryOfBody.Skip(start.Value).Take(count.Value);
            }

            return categoryOfBody;
        }

        private IQueryable<Domain.UnitsOfMeasurement> Order(IQueryable<Domain.UnitsOfMeasurement> categoryOfBody)
        {

            if (_order == Model.Order.Asc)
                categoryOfBody = categoryOfBody.OrderBy(e => e.Code);
            else
                categoryOfBody = categoryOfBody.OrderByDescending(e => e.Code);


            return categoryOfBody;
        }

        public Model.UnitsOfMeasurement AsUnitsOfMeasurement(Domain.UnitsOfMeasurement categoryOfBody, IMapper mapper)
        {
            var result = mapper.Map<Domain.UnitsOfMeasurement, Model.UnitsOfMeasurement>(categoryOfBody);
            return result;
        }
    }
}
