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
        private readonly string _userId;

        public GetSizesByPeriodIncludeRequest(StorageContext context, IMapper mapper, DateTime dateFrom, DateTime dateTo, string userId) : base(context)
        {
            _mapper = mapper;
            _dateFrom = dateFrom;
            _dateTo = dateTo;
            _userId = userId;
        }

        public override async Task<Size[]> ExecuteAsync()
        {
            var sizeRequest = context.Size
                .Where(e => e.CreatedDate >= _dateFrom)
                .Where(e => e.CreatedDate <= _dateTo)
                .Where(e => e.UserId == _userId)
                .Include(e => e.SizeItems);

            var size = sizeRequest.AsNoTracking();

            return await size.Select(e => e.AsSize(_mapper)).ToArrayAsync();
        }
    }
}
