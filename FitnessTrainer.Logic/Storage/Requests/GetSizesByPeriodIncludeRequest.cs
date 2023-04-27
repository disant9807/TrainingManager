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
    public class GetSizesByPeriodIncludeRequest : BaseStorageRequest<Model.Size[]>
    {
        private readonly DateTime _dateFrom;
        private readonly DateTime _dateTo;
        private readonly Order? _order;
        private readonly int? start;
        private readonly int? count;
        private readonly IMapper _mapper;

        public GetSizesByPeriodIncludeRequest(StorageContext context, IMapper mapper, DateTime dateFrom, DateTime dateTo) : base(context)
        {
            _mapper = mapper;
            _dateFrom = dateFrom;
            _dateTo = dateTo;
        }

        public override async Task<Size[]> ExecuteAsync()
        {
            var sizeRequest = context.Size
                .Where(e => e.CreatedDate >= _dateFrom)
                .Where(e => e.CreatedDate <= _dateTo)
                .Include(e => e.SizeItems);

            var size = sizeRequest.AsNoTracking();

            return await size.Select(e => e.AsSize(_mapper)).ToArrayAsync();
        }
    }
}
